using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace cliente
{
    public partial class Parchís : Form
    {
        Socket server;
        Thread Atender;

        delegate void DelegadorParaEscribir(string mensaje);
        delegate void DelegadoGB(GroupBox mensaje);
        delegate void DelegadaDGV(DataGridView mensaje);

        // Puerto Carla : 50015
        // Puerto Marta : 50016
        // Puerto Lucia : 50017
        //int puerto = 50017;
        int puerto = 50015;
        public Parchís()
        {
            InitializeComponent();
            //Es necesario para que los elementos de los formularios puedan ser accedidos desde threads diferentes a los que los crearon.
            CheckForIllegalCrossThreadCalls = false;
        }




        //-----------------------------------------------------------------------------------------------------------------------------------
        //FUNCIÓN CARGAR FORMS
        private void Form1_Load(object sender, EventArgs e)
        {
            //------------------ FUNCIONES OCULTAS ------------------------------------
            //Boton conectar
            conectar.Visible = false;
            //Boton desconectar
            desconectar.Visible = false;
            //-------------------------------------------------------------------------

            registro.Visible = false;
            iniciar_sesion.Visible = true;
            //Hace grande la ventana de forms.
            int lx, ly;
            int sw, sh;

            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iniciar_sesion.Visible = true;
            peticiones.Visible = false;
            //registro.Visible = false;


            //IPAddress direc = IPAddress.Parse("192.168.56.101");
            IPAddress direc = IPAddress.Parse("147.83.117.22");
            IPEndPoint ipep = new IPEndPoint(direc, puerto);

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.LightGreen;
                MessageBox.Show("Se ha conectado con el servidor");

            }
            catch (SocketException)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }
            //pongo en marcha el thread que atendera los mensajes del servidor
            ThreadStart ts = delegate { AtenderServidor(); };
            Atender = new Thread(ts);
            Atender.Start();
        }


        //-----------------------------------------------------------------------------------------------------------------------------------
        //FUNCIÓN TENDER SERVIDOR
        private void AtenderServidor()
        {
            while (true)
            {
                //Recibimos mensaje del servidor
                byte[] msg2 = new byte[200];
                server.Receive(msg2);
                //string a = Encoding.ASCII.GetString(msg2);

                // Limpiamos el mensaje
                string mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                string[] trozos = mensaje.Split('/');
                int codigo = Convert.ToInt32(trozos[0]);

                //string[] trozos = Encoding.ASCII.GetString(msg2).Split('/');
                //int codigo = Convert.ToInt32(trozos[0]);
                //string mensaje = trozos[1].Split('\0')[0];

                switch (codigo)
                {
                    case 1:     //PARTIDAS GANADAS
                        int partidasganadas = Convert.ToInt32(trozos[1]);
                        MessageBox.Show(usuario_consulta.Text + " ha ganado " + partidasganadas + " partidas");
                        break;
                    case 2:     //TABLONES JUGADOS
                        string[] words1 = trozos[1].Split('-');
                        //a = words[1];
                        Int32.TryParse(words1[0], out int numValue);
                        if (numValue == 0)
                        {
                            MessageBox.Show(words1[1]);
                        }
                        else
                        {
                            MessageBox.Show(usuario_consulta.Text + " ha jugado los tablones: " + words1[1]);
                        }
                        break;
                    case 3:     //ID JUGADOR
                        int idjugador = Convert.ToInt32(trozos[1]);
                        MessageBox.Show("La ID de " + usuario_consulta.Text + " es: " + idjugador);
                        break;
                    case 4:     //REGISTRO
                        if (trozos[1] == "SI")
                            MessageBox.Show("¡Enhorabuena, ya estas registrado!");
                        else
                            MessageBox.Show("Lo sentimos el nombre de usuario ya se esta utilizando:( \n ¡Porfavor selecciona otro!");

                        registro.Visible = false;
                        iniciar_sesion.Visible = true;
                        break;
                    case 5:     //INICIO SESION
                        {
                            if (trozos[1] == "INCORRECTO")
                            {
                                MessageBox.Show("Nombre de usuario o contraseña incorrecta.");
                                this.BackColor = Color.LightCoral;
                            }
                            else
                            {
                                MessageBox.Show("bienvenid@ " + usuario_ini.Text);
                                this.BackColor = Color.Lavender;
                                iniciar_sesion.Visible = false;
                                registro.Visible = false;
                                peticiones.Visible = true;
                                title.Visible = false;
                            }
                        }


                        ////Del servidor obtenemos un resultado: "jugadoresConectados.socket/listaConectados". Separaremos el resultado segun "." y insertaremos el resultado en words[]
                        //string[] words6 = words5[1].Split('*');
                        //Int32.TryParse(words6[0], out int numValue6);
                        //int existeConectado = 0;
                        //ListaConectadosDG.ColumnCount = 1;
                        ////this.ListaConectadosDG.Rows.Add();
                        //int cont = 1;
                        //while (numValue6 > 1 && existeConectado < numValue6)
                        //{
                        //    //string[] S = words[1].Split('/');
                        //    //this.ListaConectadosDG.Rows.Add();
                        //    ListaConectadosDG.Rows.Add(words6[cont]);


                        //    existeConectado++;
                        //    cont++;
                        //}
                        //if (numValue6 == 1)
                        //{
                        //    ListaConectadosDG.Rows.Add(words6[1]);
                        //}

                        break;

                    case 6:     //LISTA CONECTADOS

                        ListaConectadosDG.Rows.Clear();
                        int num = Convert.ToInt32(trozos[1]);
                        int i;
                        for (i = 0; i < num; i++)
                        {
                            int n = ListaConectadosDG.Rows.Add();
                            ListaConectadosDG.Rows[n].Cells[0].Value = trozos[i + 2];

                        }


                        break;
                    case 7:     //SERVICIOS
                        contLbl.Text = trozos[1];
                        break;
                    case 8:     //DESCONEXION
                        MessageBox.Show(trozos[1]);
                        iniciar_sesion.Visible = true;
                        registro.Visible = false;
                        peticiones.Visible = false;
                        break;

                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        //FUNCIÓN BOTÓN CONECTAR (Oculto)
        private void conectar_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.101");
            IPEndPoint ipep = new IPEndPoint(direc, puerto);

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.LightGreen;

            }
            catch (SocketException)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

            //pongo en marcha el thread que atendera los mensajes del servidor
            ThreadStart ts = delegate { AtenderServidor(); };
            Atender = new Thread(ts);
            Atender.Start();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------
        //FUNCIÓN BOTÓN DESCONECTAR (0)
        private void desconectar_Click(object sender, EventArgs e)
        {
            //Mensaje de desconexión
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Nos desconectamos
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------
        //FUNCIÓN BOTÓN ENVIAR PETICIONES (1,2,3)
        private void enviar_Click(object sender, EventArgs e)
        {

            //Petición partidas ganadas por el usuario seleccionado (1)
            if (partidas_ganadas.Checked)
            {
                string mensaje = "1/" + usuario_consulta.Text;
                // Enviamos al servidor el nombre del usuario
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                //mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                //MessageBox.Show(usuario_consulta.Text + " ha ganado " + mensaje + " partidas");

            }

            //Petición de tablones jugados por el usuario (2)
            else if (tablones.Checked)
            {
                string mensaje = "2/" + usuario_consulta.Text;
                // Enviamos al servidor el nombre del usuario
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                //mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];

                //string[] words = mensaje.Split('/');
                //Int32.TryParse(words[0], out int numValue);
                //if (numValue == 0)
                //{
                //    MessageBox.Show(words[1]);
                //}
                //else
                //{
                //    MessageBox.Show(usuario_consulta + " ha jugado los tablones: " + words[1]);
                //}

            }
            //Petición ID del usuario (3)
            else if (id_usuario.Checked)
            {
                // Enviamos al servidor el nombre del usuario
                string mensaje = "3/" + usuario_consulta.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                //mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                //MessageBox.Show("La ID de " + usuario_consulta.Text + " es: " + mensaje);
            }
            //Aviso petición no seleccionada.
            else
            {
                MessageBox.Show("¡ATENCIÓN! \n¡Recuerda que tienes que escoger petición antes de enviar!");
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------------------
        //FUNCIÓN BOTÓN ENTRAR AL REGISTRO
        private void entrar_reg_Click(object sender, EventArgs e)
        {
            registro.Visible = true;
            iniciar_sesion.Visible = false;

        }

        //-----------------------------------------------------------------------------------------------------------------------------------
        //FUNCIÓN BOTÓN REGISTRARSE (4)
        private void envia_reg_Click(object sender, EventArgs e)
        {

            if (((usuario_reg.Text.Length > 1) && (contraseña_reg.Text.Length > 1)) && ((usuario_reg.Text != "") && (contraseña_reg.Text != "")))
            {
                string mensaje = "4/" + usuario_reg.Text + "/" + contraseña_reg.Text;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                //mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                //if (mensaje == "SI")
                //    MessageBox.Show("¡Enhorabuena, ya estas registrado!");
                //else
                //    MessageBox.Show("Lo sentimos el nombre de usuario ya se esta utilizando:( \n ¡Porfavor selecciona otro!");


                //registro.Visible = false;
                //iniciar_sesion.Visible = true;

            }
            else
            {
                MessageBox.Show("El nombre debe tener más de un caracter");
            }

        }

        //-----------------------------------------------------------------------------------------------------------------------------------
        //FUNCIÓN BOTÓN INICIAR SESIÓN (5)
        private void entrar_Click(object sender, EventArgs e)
        {
            // Enviamos al servidor el nombre del usuario
            string mensaje = "5/" + usuario_ini.Text + "/" + contraseña_ini.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            ////Recibimos la respuesta del servidor
            //byte[] msg2 = new byte[80];
            //server.Receive(msg2);
            //mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            //if (mensaje == "INCORRECTO")
            //{
            //    MessageBox.Show("Nombre de usuario o contraseña incorrecta.");
            //    this.BackColor = Color.LightCoral;
            //}
            //else
            //{
            //    MessageBox.Show("bienvenid@ " + usuario_ini.Text);
            //    this.BackColor = Color.Lavender;
            //    iniciar_sesion.Visible = false;
            //    registro.Visible = false;
            //    peticiones.Visible = true;
            //    title.Visible = false;
            //}

        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        //BOTON LISTA DE CONECTADOS (6)
        //private void ListaConectadosButton_Click(object sender, EventArgs e)
        //{
        public void ListaConectados()
        {

            // Enviamos al servidor el nombre del usuario
            string mensaje = "6/" + usuario_ini.Text + "/" + contraseña_ini.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            ////Recibimos la respuesta del servidor
            //byte[] msg2 = new byte[80];
            //server.Receive(msg2);
            //mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            ////MessageBox.Show(mensaje);
            //ListaConectadosDG.Rows.Clear();
            ////Del servidor obtenemos un resultado: "jugadoresConectados.socket/listaConectados". Separaremos el resultado segun "." y insertaremos el resultado en words[]
            //string[] words = mensaje.Split('.');
            //Int32.TryParse(words[0], out int numValue);
            //int existeConectado = 0;
            //ListaConectadosDG.ColumnCount = 1;
            ////this.ListaConectadosDG.Rows.Add();
            //int cont = 1;
            //while (numValue > 1 && existeConectado < numValue)
            //{
            //    //string[] S = words[1].Split('/');
            //    //this.ListaConectadosDG.Rows.Add();
            //    ListaConectadosDG.Rows.Add(words[cont]);


            //    existeConectado++;
            //    cont++;
            //}
            //if (numValue == 1)
            //{
            //    ListaConectadosDG.Rows.Add(words[1]);
            //}

        }

        //-----------------------------------------------------------------------------------------------------------------------------------
        //BOTON SERVICIOS (7)

        private void button1_Click(object sender, EventArgs e)
        {
            //Pedir numero de servicios realizados
            string mensaje = "7/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            ////Recibimos la respuesta del servidor
            //byte[] msg2 = new byte[80];
            //server.Receive(msg2);
            //mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            //contLbl.Text = mensaje;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------
        //BOTON SALIR DE LISTA CONECTADOS (8)
        private void SalirButton_Click(object sender, EventArgs e)
        {
            // Enviamos al servidor el nombre del usuario
            string mensaje = "8/" + usuario_ini.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            //mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            //MessageBox.Show("Se ha desconectado");
        }


    }
}

