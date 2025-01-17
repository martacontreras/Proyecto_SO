#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <pthread.h>

//---------------------------------------------------------------------------------------------------------------------------------------------------
//NOTAS:
/*Antes de ejecutar nuestro programa en c tenemos que:
- Entrar en el directorio (desde consola) donde tenemos ubicados los archivos necesarios (num_partidas_ganadas_Juan.sql).
- Introducir el comando "mysql -u root -p" y introducir contrase\ufff1a "mysql".
- Introducir el comando "source num_partidas_ganadas_Juan.sql;".
- Abrir el codigo en c y ejecutarlo.
*NOTA* : si no sigue estos pasos, no se realizara correctamente el programa ni se actualizaran los datos del fichero .sql, por tanto
cada vez que actualize dicho fichero .sql tendra que introducir el comando "source num_partidas_ganadas_Juan.sql" para actualizar
los datos.*/

//---------------------------------------------------------------------------------------------------------------------------------------------------

int contador;
//Estructura necesaria para acceso excluyente
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

//---------------------------------------------------------------------------------------------------------------------------------------------------
//Declaramos la estructuracon un nombre y un Socket
typedef struct {
	char nombre[20];
	int socket;
} Conectado;

typedef struct {
	Conectado conectados [100];
	int num;
} ListaConectados;

ListaConectados miLista;


//---------------------------------------------------------------------------------------------------------------------------------------------------
//Variables SQL

MYSQL * conn;
int err;
MYSQL_RES * resultado;
MYSQL_ROW row;

int i;
int sockets [100];
//---------------------------------------------------------------------------------------------------------------------------------------------------
//Funcion que aￃﾱade un nuevo conectado. Retorna 0 si se ha aￃﾱadido correctamente y -1 si no se ha podido aￃﾱadir debido a que la lista esta llena.
int Pon (ListaConectados *lista, char nombre[20], int socket)
{
	if (lista->num == 100)
	{
		return -1;
	}
	else
	{
		strcpy(lista->conectados[lista->num].nombre, nombre);
		lista->conectados[lista->num].socket = socket;
		lista->num++;
		return 0;
	}
	
}

//---------------------------------------------------------------------------------------------------------------------------------------------------
//Funcion que devuelve la posicion o -1 si no esta en la lista de conectados.
int DameSocket (ListaConectados *lista, char nombre[20])
{
	int i = 0;
	int encontrado = 0;
	while((i < lista->num) && !encontrado)
	{
		if (strcmp(lista->conectados[i].nombre,nombre) == 0)
		{
			encontrado = 1;
		}
		if(!encontrado)
		{
			i = i+1;
		}
	}
	if (encontrado)
	{
		//return lista->conectados[i].socket;
		return i;
	}
	else
	{
		return -1;
	}
}

//---------------------------------------------------------------------------------------------------------------------------------------------------
//Funcion que retorna 0 si elimina a la persona y -1 si ese usuario no esta conectado.
int Desconectar (ListaConectados *lista, char nombre[20], char respuestaDesconectar[512])
{
	int pos = DameSocket (lista,nombre);
	if (pos == -1)
	{
		return -1;
	}
	
	
	else
	{
		int i;
		for (i = pos; i < lista->num-1; i++)
		{
			strcpy(lista->conectados[i].nombre, lista->conectados[i+1].nombre);
			lista->conectados[i].socket = lista->conectados[i+1].socket;
		}
		lista->num--;
		sprintf(respuestaDesconectar,"8/Hasta la proxima!");
		return 0;
	}
}
//---------------------------------------------------------------------------------------------------------------------------------------------------
//Funcion que pone en conectados los nombres de todos los conectados separados por barras. Primero pone el numero de conectados. Por ejemplo: "3/Lucia/Carla/Marta"
void DameConectados (ListaConectados *lista, char conectados[300])
{
	sprintf(conectados, "%d", lista->num);
	int i;
	for(i=0; i<lista->num; i++)
	{
		sprintf(conectados, "%s.%s", conectados, lista->conectados[i].nombre);
	}
}

//---------------------------------------------------------------------------------------------------------------------------------------------------

int PartidasGanadas (char usuario1[20],char p1[50],char consulta1[80],int codigo1,char respuesta1[512])
{
	strcpy(usuario1,p1);
	sprintf(consulta1,"SELECT Jugador.partidas_ganadas FROM Jugador WHERE Jugador.username ='%s' ",usuario1);
	printf("%s",consulta1);
	err=mysql_query(conn, consulta1);
	if (err!=0){
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn),mysql_error(conn));
		exit(1);
	}
	resultado = mysql_store_result(conn);
	row = mysql_fetch_row(resultado);
	if (row == NULL)
	{
		printf("No se ha obtenido la consulta \n"); 
	}
	else
	{
		printf("Codigo: %d, Nombre: %s, Partidas_ganadas: %s \n",codigo1, usuario1, row[0]);
		printf("El usuario ha ganado %s partidas \n",row[0]);
		sprintf(respuesta1,"1/%s",row[0]);
	}
}

//---------------------------------------------------------------------------------------------------------------------------------------------------

int Tableros (char usuario2[20],char p2[50],char consulta2[80],int codigo2,char respuesta2[512])
{
	strcpy (usuario2, p2);
	printf ("Codigo: %d, Nombre: %s \n", codigo2, usuario2);
	sprintf(consulta2,"SELECT Jugador.partidas_jugadas FROM Jugador WHERE Jugador.username = '%s'",usuario2);
	printf("%s",consulta2);
	err=mysql_query(conn, consulta2);
	if (err!=0)
	{
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn),mysql_error(conn));
		exit(1);
	}
	
	//Recogemos el resultado de la consulta 
	resultado = mysql_store_result(conn);
	row = mysql_fetch_row(resultado);
	if (row == NULL)
	{
		printf("No se ha obtenido la consulta \n"); 
	}
	else
	{
		printf("Nombre: %s, Partidas_jugadas: %s \n", usuario2, row[0]);
		
		int pJugadas = atoi(row[0]);
		
		
		if(pJugadas==0)
		{
			printf("No ha jugado ninguna vez \n");
			sprintf(respuesta2,"2/0-No se ha jugado ninguna partida!!");
		}
		if (pJugadas!=0)
		{
			sprintf (consulta2, "SELECT Partida.tablon FROM (Partida,Jugador,Participacion) WHERE Jugador.username = '%s' AND Jugador.id=Participacion.idJ AND Participacion.idP=Partida.id",usuario2); 
			err=mysql_query(conn, consulta2);
			if (err!=0)
			{
				printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn),mysql_error(conn));
				exit(1);
			}
			
			//Recogemos el resultado de la consulta 
			resultado = mysql_store_result(conn);
			row = mysql_fetch_row(resultado);
			char tableros[100] = " ";
			if (row == NULL)
			{
				printf("No se ha obtenido la consulta \n"); 
			}
			else
			{
				while (row!=NULL)
				{
					printf("Tablero: %s \n",row[0]);
					sprintf(tableros,"%s,%s",tableros,row[0]);
					row = mysql_fetch_row(resultado);
				}
				
				sprintf(respuesta2,"2/1-%s",tableros);
			}
		}
	}
}

//---------------------------------------------------------------------------------------------------------------------------------------------------

int IDUsuario(char usuario3[20],char p3[50],char consulta3[80],int codigo3,char respuesta3[512])
{
	strcpy (usuario3, p3);
	printf ("Codigo: %d, Nombre: %s \n", codigo3, usuario3);
	
	sprintf(consulta3, "SELECT Jugador.id FROM Jugador WHERE Jugador.username='%s' ",usuario3);
	err=mysql_query(conn, consulta3);
	if (err!=0){
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn),mysql_error(conn));
		exit(1);
	}	
	//Recogemos el resultado de la consulta 
	resultado = mysql_store_result(conn);
	row = mysql_fetch_row(resultado);
	if (row == NULL)
	{
		printf("No se ha obtenido la consulta \n"); 
	}
	else
	{
		
		printf("El id del usuario es:%s \n",row[0]);
		sprintf(respuesta3,"3/%s",row[0]);
	}
}

//---------------------------------------------------------------------------------------------------------------------------------------------------

int Registro (char usuario4[20],char p4[50],char consulta4[80],int codigo4,char respuesta4[512],char contrasena4[20],char consulta_id4[80])
{
	strcpy (usuario4, p4);
	p4 = strtok( NULL, "/");
	strcpy(contrasena4,p4);
	printf ("Codigo: %d, Nombre: %s, Contrase￱a: %s\n", codigo4, usuario4, contrasena4);
	
	//Creamos la consulta
	sprintf(consulta4, "SELECT Jugador.username FROM Jugador WHERE Jugador.username='%s' ",usuario4); 
	// hacemos la consulta 
	err=mysql_query (conn, consulta4); 
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//Recogemos el resultado
	resultado = mysql_store_result (conn);
	row=mysql_fetch_row(resultado); 
	if (row==NULL){ 
		//Consultamos el numero de usuarios registrados para obtener el ultimo id
		strcpy(consulta_id4,"SELECT MAX(Jugador.id) FROM (Jugador)");
		err=mysql_query (conn, consulta_id4);
		if (err!=0) {
			printf ("Error al consultar datos de la base %u %s\n",
					mysql_errno(conn), mysql_error(conn));
			exit (1);
		}
		//Recogemos el resultado de la consulta de id
		resultado = mysql_store_result (conn); 
		row = mysql_fetch_row (resultado);
		
		int idJugador=atoi(row[0])+1;
		char insert[150];
		sprintf(insert,"INSERT INTO Jugador(id,username,pass,partidas_ganadas,partidas_jugadas) VALUES (%d,'%s','%s',0,0)",idJugador,usuario4,contrasena4);
		
		err=mysql_query (conn, insert);
		if (err!=0) {
			printf ("Error al insertar datos de la base %u %s\n",
					mysql_errno(conn), mysql_error(conn));
			exit (1);
			sprintf(respuesta4,"4/NO INSERTADO");					
		}
		else
			sprintf(respuesta4,"4/SI");
	}
	else{
		sprintf(respuesta4,"4/NO REGISTRADO");
	}			
}
//---------------------------------------------------------------------------------------------------------------------------------------------------

int InicioSesion(char usuario5[20],char p5[50],char consulta5[80],int codigo5,char respuesta5[512], char contrasena5[20],char conectado5[300],int PONER5,int sock_conn5)
{
	strcpy (usuario5, p5);
	p5 = strtok( NULL, "/");
	strcpy(contrasena5,p5);
	printf ("Codigo: %d, Nombre: %s, Contrase￱a: %s\n", codigo5, usuario5, contrasena5);
	
	sprintf(consulta5, "SELECT Jugador.username, Jugador.pass FROM Jugador WHERE (Jugador.username='%s' AND Jugador.pass='%s')",usuario5,contrasena5);
	err=mysql_query(conn, consulta5);
	
	
	if (err!=0){
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn),mysql_error(conn));
		exit(1);
	}
	//Recogemos el resultado de la consulta 
	resultado = mysql_store_result(conn);
	row = mysql_fetch_row(resultado);
	if (row == NULL)
	{
		printf("No se ha obtenido la consulta \n"); 
		sprintf(respuesta5,"5/INCORRECTO");
	}
	else
	{
		
		printf("Inicio de sesion completado \n");
		pthread_mutex_lock( &mutex );
		PONER5 = Pon(&miLista,usuario5,sock_conn5);
		pthread_mutex_unlock( &mutex);
		
		//char respuestaLista[512];
		//DameConectados(&miLista,respuestaLista);
/*		char conectadoLista[300];*/
/*		MostrarListaConectados(respuestaLista,conectadoLista);*/
		sprintf(respuesta5,"5/CORRECTO1");
		
		printf("%s \n",conectado5);
		
		
		
	}
}

//---------------------------------------------------------------------------------------------------------------------------------------------------

int MostrarListaConectados (char respuesta6[512], char conectado6[300])
{
	sprintf(conectado6, "%d", miLista.num);
	int i;
	for(i=0; i<miLista.num; i++)
	{
		if  (miLista.conectados[i].socket == 4 && miLista.conectados[i].socket == 5)
		{
			printf("%s %d", conectado6, miLista.conectados[i].socket);
			sprintf(conectado6, "%s*%d-%s", conectado6, miLista.conectados[i].socket , miLista.conectados[i].nombre);
		}
		//Se mostrara la lista de conectados de la siguiente manera: "numero de personas conectadas.socket-nombre usuario.socket-nombre usuario ..."
		sprintf(conectado6, "%s*%d-%s", conectado6, miLista.conectados[i].socket , miLista.conectados[i].nombre);
		
	}
	printf("%s \n",conectado6);
	sprintf(respuesta6,"%s",conectado6);
}

int Contador(int codigo7, int contador7, char respuesta7[512])
{
	if ((codigo7 ==1)||(codigo7==2)|| (codigo7==3)||(codigo7==4)|| (codigo7==5)|| (codigo7==6))
	{
		
		contador7 = contador7 +1;
		sprintf (respuesta7,"7/%d",contador7);
	}
}


int Notificacion(char respuestaN[512])
{
	char notificacion[20];
	sprintf(notificacion,"%s",respuestaN);
	int j;
	for (j=0;j<i;j++)
	{
		write(sockets[j],notificacion,strlen(notificacion));
	}
}
//---------------------------------------------------------------------------------------------------------------------------------------------------
//Funci￳n atender cliente
void *AtenderCliente (void *socket)
{
	//llamamos a la ListaConectados
	
	miLista.num = 0;
	//Socket ListaConectados
	//int sock_conn;
	int sock_conn;
	int *s;
	s=(int *) socket;
	sock_conn= *s;
	int PONER;
	char conectado[300];
	int contadorSocket=0;
	
	
	char peticion[512];
	char respuesta[512];
	int ret;
	
	
	//Creamos la conexion a MYSQL
	conn = mysql_init(NULL);
	if (conn == NULL)
	{
		printf("Error al crear la connexion: %u %s \n", mysql_errno(conn), mysql_error(conn));
		exit(1);
	}
	
	conn = mysql_real_connect(conn,"shiva2.upc.es","root","mysql","M5_BBDDJuego",0,NULL,0);
	//conn = mysql_real_connect(conn,"localhost","root","mysql","M5_BBDDJuego",0,NULL,0);
	if (conn == NULL)
	{
		printf("Error al inicializar la conexion: %u %s \n", mysql_errno(conn), mysql_error(conn));
		exit(1);
	}
	
	int terminar = 0;
	// Entramos en un bucle para atender todas las peticiones de este cliente
	//hasta que se desconecte
	while (terminar==0)
	{
		char usuario[20];
		char contrasena[20];
		int partidas_ganadas;
		char consulta[80];
		char consulta_id[80];
		
		// Ahora recibimos su peticion
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibida una peticion\n");
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		
		//Recogemos el codigo indicado por cada peticion.
		char *p = strtok( peticion, "/");
		int codigo =  atoi (p);
		p = strtok( NULL, "/");
		
		int cont = 0;
		//---------------------------------------------------------------------------------------------------------------------------------------------------
		//PETICIONES
		//DESCONECTAR
		if (codigo == 0)
		{
			strcpy(respuesta, "0/1");
			//Notificacion a todos los usuarios
			Notificacion(respuesta);
		}
		//PIDEN LAS PARTIDAS GANADAS
		if (codigo ==1)
		{
			PartidasGanadas(usuario,p,consulta,codigo,respuesta);
			Notificacion(respuesta);
		}
		
		//PIDEN LOS TABLEROS
		if (codigo == 2)
		{ 
			Tableros(usuario,p,consulta,codigo,respuesta);
			char notificacion[20];
			sprintf(notificacion,"%s",respuesta);
			int j;
			for (j=0;j<1;j++)
			{
				write(sockets[j],notificacion,strlen(notificacion));
			}
			
		}
		//PIDEN EL ID DEL USUARIO
		if (codigo ==3)
		{ 
			IDUsuario(usuario,p,consulta,codigo,respuesta);
			Notificacion(respuesta);
		}
		//INSERTA USUARIO Y CONTRASE￑A EN LA BASE DE DATOS (REGISTRO)
		if (codigo == 4)
		{
			Registro(usuario,p,consulta,codigo,respuesta,contrasena,consulta_id);
			//Notificacion(respuesta);
		}
		
		//COMPRUEBA EL NOMBRE DE USUARIO Y CONTRASE￑A EN LA BASE DE DATOS (INICIO SESION)
		if (codigo == 5)
		{
			InicioSesion(usuario,p,consulta,codigo,respuesta,contrasena,conectado,PONER,sock_conn);
			char respuesta1[512];
			strcpy(respuesta1,respuesta);
			MostrarListaConectados(respuesta,conectado);
			sprintf(respuesta,"%s.%s",respuesta1,respuesta);
			//Notificamos a todos los clientes
			Notificacion(respuesta);
			
		}
		//PONER LISTA CONECTADOS
		if (codigo == 6)
		{
			MostrarListaConectados(respuesta,conectado);
			Notificacion(respuesta);
		}
		
		
		//ELIMINAR DE LA LISTA DE CONECTADOS
		if (codigo==8)
		{
			pthread_mutex_lock( &mutex );
			Desconectar(&miLista,usuario,respuesta);
			Notificacion(respuesta);
			pthread_mutex_unlock( &mutex);
			//Notificamos a todos los clientes
			//Notificacion(respuesta);
		}
		
		if (codigo != 0)
		{
			printf("Respuesta: %s \n", respuesta);
			// Enviamos la respuesta
			write (sock_conn,respuesta, strlen(respuesta));
			
		}
		
		//CONTADOR DE FUNCIONES
		if (codigo ==7)
		{
			pthread_mutex_lock( &mutex ); //No me interrumpas ahora
			Contador(codigo,contador,respuesta);
			pthread_mutex_unlock( &mutex); //ya puedes interrumpirme
			Notificacion(respuesta);
		}
		
	}
	// Se acabo el servicio para este cliente
	close(sock_conn);
	
}

int main(int argc, char *argv[])
{
	
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;	
	// Puerto Carla : 50015
	// Puerto Marta : 50016
	// Puerto Lucia : 50017
	
	//int puerto = 50017;
	int puerto =50016;
	
	// INICIALIZACION
	// Abrimos el socket.
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Hacemos bind en el puerto.
	memset(&serv_adr, 0, sizeof(serv_adr));// inicializa en zero serv_addr.
	
	serv_adr.sin_family = AF_INET;
	// asocia el socket a cualquiera de las IP de la maquina. 
	//htonl formatea el numero que recibe al formato necesario.
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// escucharemos en el port (X).
	serv_adr.sin_port = htons(puerto);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	//La cola de peticiones pendientes no podra ser superior a 4
	if (listen(sock_listen, 100) < 0)
		printf("Error en el Listen");
	contador=0;
/*	int i;*/
/*	int sockets [100];*/
	pthread_t  thread;
	i=0;
	
	//---------------------------------------------------------------------------------------------------------------------------------------------------
	//Bucle para realizar las peticiones.
	for(;;)
	{
		printf ("Escuchando\n");
		//sock_conn es el socket que usaremos para este cliente
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexi?n\n");
		
		sockets[i]=sock_conn;
		
		// sock_conn es el socket que utilizaremos para este cliente
		
		//Crear thread y decirle lo que tiene que hacer
		
		pthread_create(&thread, NULL, AtenderCliente, &sockets[i]);
		i++;
		
	}
}
