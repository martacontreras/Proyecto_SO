namespace cliente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entrar = new System.Windows.Forms.Button();
            this.entrar_reg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuario_ini = new System.Windows.Forms.TextBox();
            this.contraseña_ini = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.usuario_consulta = new System.Windows.Forms.TextBox();
            this.partidas_ganadas = new System.Windows.Forms.RadioButton();
            this.tablones = new System.Windows.Forms.RadioButton();
            this.id_usuario = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.conectar = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.iniciar_sesion = new System.Windows.Forms.GroupBox();
            this.registro = new System.Windows.Forms.GroupBox();
            this.envia_reg = new System.Windows.Forms.Button();
            this.usuario_reg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contraseña_reg = new System.Windows.Forms.TextBox();
            this.iniciar_sesion.SuspendLayout();
            this.registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(359, 81);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(144, 45);
            this.entrar.TabIndex = 0;
            this.entrar.Text = "Entra!";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // entrar_reg
            // 
            this.entrar_reg.Location = new System.Drawing.Point(459, 169);
            this.entrar_reg.Name = "entrar_reg";
            this.entrar_reg.Size = new System.Drawing.Size(144, 39);
            this.entrar_reg.TabIndex = 1;
            this.entrar_reg.Text = "Regístrate";
            this.entrar_reg.UseVisualStyleBackColor = true;
            this.entrar_reg.Click += new System.EventHandler(this.entrar_reg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // usuario_ini
            // 
            this.usuario_ini.Location = new System.Drawing.Point(110, 60);
            this.usuario_ini.Name = "usuario_ini";
            this.usuario_ini.Size = new System.Drawing.Size(207, 26);
            this.usuario_ini.TabIndex = 4;
            // 
            // contraseña_ini
            // 
            this.contraseña_ini.Location = new System.Drawing.Point(110, 115);
            this.contraseña_ini.Name = "contraseña_ini";
            this.contraseña_ini.Size = new System.Drawing.Size(207, 26);
            this.contraseña_ini.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "¿No tienes una cuenta en el juego? Únete a nuestra comunidad!";
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(945, 312);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(158, 28);
            this.enviar.TabIndex = 7;
            this.enviar.Text = "Enviar Consulta";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(811, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Indroduce el nombre de usuario del jugador para hacer la consulta:";
            // 
            // usuario_consulta
            // 
            this.usuario_consulta.Location = new System.Drawing.Point(964, 114);
            this.usuario_consulta.Name = "usuario_consulta";
            this.usuario_consulta.Size = new System.Drawing.Size(125, 26);
            this.usuario_consulta.TabIndex = 12;
            // 
            // partidas_ganadas
            // 
            this.partidas_ganadas.AutoSize = true;
            this.partidas_ganadas.Location = new System.Drawing.Point(918, 209);
            this.partidas_ganadas.Name = "partidas_ganadas";
            this.partidas_ganadas.Size = new System.Drawing.Size(204, 23);
            this.partidas_ganadas.TabIndex = 13;
            this.partidas_ganadas.TabStop = true;
            this.partidas_ganadas.Text = "Número de partidas ganadas";
            this.partidas_ganadas.UseVisualStyleBackColor = true;
            // 
            // tablones
            // 
            this.tablones.AutoSize = true;
            this.tablones.Location = new System.Drawing.Point(918, 238);
            this.tablones.Name = "tablones";
            this.tablones.Size = new System.Drawing.Size(211, 23);
            this.tablones.TabIndex = 14;
            this.tablones.TabStop = true;
            this.tablones.Text = "Tablones en los que ha jugado";
            this.tablones.UseVisualStyleBackColor = true;
            // 
            // id_usuario
            // 
            this.id_usuario.AutoSize = true;
            this.id_usuario.Location = new System.Drawing.Point(918, 267);
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.Size = new System.Drawing.Size(114, 23);
            this.id_usuario.TabIndex = 15;
            this.id_usuario.TabStop = true;
            this.id_usuario.Text = "ID del jugador";
            this.id_usuario.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(867, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Escoge una de las opciones y envia tu consulta!";
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(1172, 420);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(101, 28);
            this.conectar.TabIndex = 17;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(1172, 453);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(101, 28);
            this.desconectar.TabIndex = 18;
            this.desconectar.Text = "Desconectar";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(757, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Conectate y desconectate del servidor cuando quieras:";
            // 
            // iniciar_sesion
            // 
            this.iniciar_sesion.Controls.Add(this.usuario_ini);
            this.iniciar_sesion.Controls.Add(this.entrar);
            this.iniciar_sesion.Controls.Add(this.entrar_reg);
            this.iniciar_sesion.Controls.Add(this.label1);
            this.iniciar_sesion.Controls.Add(this.label2);
            this.iniciar_sesion.Controls.Add(this.contraseña_ini);
            this.iniciar_sesion.Controls.Add(this.label3);
            this.iniciar_sesion.Location = new System.Drawing.Point(25, 14);
            this.iniciar_sesion.Name = "iniciar_sesion";
            this.iniciar_sesion.Size = new System.Drawing.Size(695, 214);
            this.iniciar_sesion.TabIndex = 20;
            this.iniciar_sesion.TabStop = false;
            this.iniciar_sesion.Text = "Iniciar sesión";
            // 
            // registro
            // 
            this.registro.Controls.Add(this.envia_reg);
            this.registro.Controls.Add(this.usuario_reg);
            this.registro.Controls.Add(this.label7);
            this.registro.Controls.Add(this.label8);
            this.registro.Controls.Add(this.contraseña_reg);
            this.registro.Location = new System.Drawing.Point(25, 245);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(683, 185);
            this.registro.TabIndex = 21;
            this.registro.TabStop = false;
            this.registro.Text = "Registro";
            // 
            // envia_reg
            // 
            this.envia_reg.Location = new System.Drawing.Point(359, 77);
            this.envia_reg.Name = "envia_reg";
            this.envia_reg.Size = new System.Drawing.Size(144, 39);
            this.envia_reg.TabIndex = 10;
            this.envia_reg.Text = "Regístrate";
            this.envia_reg.UseVisualStyleBackColor = true;
            this.envia_reg.Click += new System.EventHandler(this.envia_reg_Click);
            // 
            // usuario_reg
            // 
            this.usuario_reg.Location = new System.Drawing.Point(110, 54);
            this.usuario_reg.Name = "usuario_reg";
            this.usuario_reg.Size = new System.Drawing.Size(207, 26);
            this.usuario_reg.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Contraseña";
            // 
            // contraseña_reg
            // 
            this.contraseña_reg.Location = new System.Drawing.Point(110, 109);
            this.contraseña_reg.Name = "contraseña_reg";
            this.contraseña_reg.Size = new System.Drawing.Size(207, 26);
            this.contraseña_reg.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 526);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.iniciar_sesion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id_usuario);
            this.Controls.Add(this.tablones);
            this.Controls.Add(this.partidas_ganadas);
            this.Controls.Add(this.usuario_consulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.iniciar_sesion.ResumeLayout(false);
            this.iniciar_sesion.PerformLayout();
            this.registro.ResumeLayout(false);
            this.registro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button entrar;
        private Button entrar_reg;
        private Label label1;
        private Label label2;
        private TextBox usuario_ini;
        private TextBox contraseña_ini;
        private Label label3;
        private Button enviar;
        private Label label4;
        private TextBox usuario_consulta;
        private RadioButton partidas_ganadas;
        private RadioButton tablones;
        private RadioButton id_usuario;
        private Label label5;
        private Button conectar;
        private Button desconectar;
        private Label label6;
        private GroupBox iniciar_sesion;
        private GroupBox registro;
        private TextBox usuario_reg;
        private Label label7;
        private Label label8;
        private TextBox contraseña_reg;
        private Button envia_reg;
    }
}