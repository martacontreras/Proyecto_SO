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

namespace cliente
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

//------------------------------------------------------------------------------------------------------------------------------------
//FUNCIÓN BOTÓN CONECTAR
        private void conectar_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.101");
            IPEndPoint ipep = new IPEndPoint(direc, 9992);

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
        }

//-----------------------------------------------------------------------------------------------------------------------------------
//FUNCIÓN BOTÓN DESCONECTAR
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
//FUNCIÓN BOTÓN ENVIAR PETICIONES
        private void enviar_Click(object sender, EventArgs e)
        {

        //Petición partidas ganadas por el usuario seleccionado.
            if (partidas_ganadas.Checked)
            {
                string mensaje = "1/" + usuario_consulta.Text;
                // Enviamos al servidor el nombre del usuario
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(usuario_consulta.Text + " ha ganado " + mensaje + " partidas");
              
            }

        //Petición de tablones jugados por el usuario.
            else if (tablones.Checked)
            {
                string mensaje = "2/" + usuario_consulta.Text;
                // Enviamos al servidor el nombre del usuario
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];

                string[] words = mensaje.Split('/');
                Int32.TryParse(words[0], out int numValue);
                if (numValue==0)
                {
                    MessageBox.Show(words[1]);
                }
                else 
                {
                    MessageBox.Show(usuario_consulta + " ha jugado los tablones: " + words[1]);
                }

            }
        //Petición ID del usuario.
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
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("La ID de " + usuario_consulta.Text + " es: " + mensaje);
            }
        //Aviso petición no seleccionada.
            else
            {
                MessageBox.Show("¡ATENCIÓN! \n¡Recuerda que tienes que escoger petición antes de enviar!");
            }

        }

//-----------------------------------------------------------------------------------------------------------------------------------
//FUNCIÓN CARGAR FORMS
        private void Form1_Load(object sender, EventArgs e)
        {
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
        }

//-----------------------------------------------------------------------------------------------------------------------------------
//FUNCIÓN BOTÓN ENTRAR AL REGISTRO
        private void entrar_reg_Click(object sender, EventArgs e)
        {
            registro.Visible = true;
        }

//-----------------------------------------------------------------------------------------------------------------------------------
//FUNCIÓN BOTÓN REGISTRARSE
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
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                if (mensaje == "SI")
                    MessageBox.Show("¡Enhorabuena, ya estas registrado!");
                else
                    MessageBox.Show("Lo sentimos el nombre de usuario ya se esta utilizando:( \n ¡Porfavor selecciona otro!");


                registro.Visible = false;
                iniciar_sesion.Visible = true;

            }
            else
            {
                MessageBox.Show("El nombre debe tener más de un caracter");
            }

        }

//-----------------------------------------------------------------------------------------------------------------------------------
//FUNCIÓN BOTÓN INICIAR SESIÓN
        private void entrar_Click(object sender, EventArgs e)
        {
            // Enviamos al servidor el nombre del usuario
            string mensaje = "5/" + usuario_ini.Text + "/" + contraseña_ini.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            if (mensaje == "INCORRECTO")
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta.");
                this.BackColor = Color.LightCoral;
            }
            else
            { 
                MessageBox.Show("bienvenid@ " + usuario_ini.Text);
                this.BackColor = Color.Lavender;
            }

        }
//-----------------------------------------------------------------------------------------------------------------------------------

        private void ListaConectadosButton_Click(object sender, EventArgs e)
        {
             
            // Enviamos al servidor el nombre del usuario
            string mensaje = "6/" + usuario_ini.Text + "/" + contraseña_ini.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            //MessageBox.Show(mensaje);
            ListaConectadosDG.Rows.Clear();
            //Del servidor obtenemos un resultado: "jugadoresConectados.socket/listaConectados". Separaremos el resultado segun "." y insertaremos el resultado en words[]
            string[] words = mensaje.Split('.');
            Int32.TryParse(words[0], out int numValue);
            int existeConectado = 0;
            ListaConectadosDG.ColumnCount = 1;
            //this.ListaConectadosDG.Rows.Add();
            int cont =1;
            while(numValue>1 && existeConectado<numValue)
            {
                //string[] S = words[1].Split('/');
                //this.ListaConectadosDG.Rows.Add();
                ListaConectadosDG.Rows.Add(words[cont]);
                
                
                existeConectado++;
                cont++;
            }
            if(numValue==1)
            {
                ListaConectadosDG.Rows.Add(words[1]);
            }
            //if (numValue < 1)
            //{
            //    ListaConectadosDG.Rows.Clear();
            //}

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pedir numero de servicios realizados
            string mensaje = "7/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            contLbl.Text = mensaje;
        }

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
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("Se ha desconectado");
            }

        private void usuario_ini_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
    }

