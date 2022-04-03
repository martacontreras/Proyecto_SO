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
            System.Windows.Forms.Label label9;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ConectadosLabel = new System.Windows.Forms.Label();
            this.ListaConectadosButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.servicios = new System.Windows.Forms.Label();
            this.contLbl = new System.Windows.Forms.Label();
            this.ListaConectadosDG = new System.Windows.Forms.DataGridView();
            this.SalirButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.iniciar_sesion.SuspendLayout();
            this.registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaConectadosDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(1028, 368);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(0, 19);
            label9.TabIndex = 26;
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
            this.usuario_ini.TextChanged += new System.EventHandler(this.usuario_ini_TextChanged);
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
            this.enviar.Location = new System.Drawing.Point(1170, 154);
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
            this.label4.Location = new System.Drawing.Point(811, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Indroduce el nombre de usuario del jugador para hacer la consulta:";
            // 
            // usuario_consulta
            // 
            this.usuario_consulta.Location = new System.Drawing.Point(967, 65);
            this.usuario_consulta.Name = "usuario_consulta";
            this.usuario_consulta.Size = new System.Drawing.Size(125, 26);
            this.usuario_consulta.TabIndex = 12;
            // 
            // partidas_ganadas
            // 
            this.partidas_ganadas.AutoSize = true;
            this.partidas_ganadas.Location = new System.Drawing.Point(874, 128);
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
            this.tablones.Location = new System.Drawing.Point(874, 157);
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
            this.id_usuario.Location = new System.Drawing.Point(874, 185);
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
            this.label5.Location = new System.Drawing.Point(811, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Escoge una de las opciones y envia tu consulta!";
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(1209, 211);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(101, 28);
            this.conectar.TabIndex = 17;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(1209, 245);
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
            this.label6.Location = new System.Drawing.Point(811, 245);
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
            // ConectadosLabel
            // 
            this.ConectadosLabel.AutoSize = true;
            this.ConectadosLabel.Location = new System.Drawing.Point(30, 485);
            this.ConectadosLabel.Name = "ConectadosLabel";
            this.ConectadosLabel.Size = new System.Drawing.Size(311, 19);
            this.ConectadosLabel.TabIndex = 22;
            this.ConectadosLabel.Text = "Quieres ver quien está conectado? Pulsa aquí -->";
            // 
            // ListaConectadosButton
            // 
            this.ListaConectadosButton.Location = new System.Drawing.Point(358, 481);
            this.ListaConectadosButton.Name = "ListaConectadosButton";
            this.ListaConectadosButton.Size = new System.Drawing.Size(170, 26);
            this.ListaConectadosButton.TabIndex = 23;
            this.ListaConectadosButton.Text = "Lista de conectados";
            this.ListaConectadosButton.UseVisualStyleBackColor = true;
            this.ListaConectadosButton.Click += new System.EventHandler(this.ListaConectadosButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 44);
            this.button1.TabIndex = 24;
            this.button1.Text = "¿Cuántos servicios?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // servicios
            // 
            this.servicios.AutoSize = true;
            this.servicios.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.servicios.Location = new System.Drawing.Point(973, 368);
            this.servicios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.servicios.Name = "servicios";
            this.servicios.Size = new System.Drawing.Size(0, 50);
            this.servicios.TabIndex = 25;
            // 
            // contLbl
            // 
            this.contLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contLbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contLbl.Location = new System.Drawing.Point(1015, 357);
            this.contLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contLbl.Name = "contLbl";
            this.contLbl.Size = new System.Drawing.Size(63, 48);
            this.contLbl.TabIndex = 12;
            // 
            // ListaConectadosDG
            // 
            this.ListaConectadosDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaConectadosDG.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.ListaConectadosDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaConectadosDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaConectadosDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaConectadosDG.ColumnHeadersHeight = 26;
            this.ListaConectadosDG.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaConectadosDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListaConectadosDG.EnableHeadersVisualStyles = false;
            this.ListaConectadosDG.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ListaConectadosDG.Location = new System.Drawing.Point(590, 481);
            this.ListaConectadosDG.Name = "ListaConectadosDG";
            this.ListaConectadosDG.RowHeadersWidth = 47;
            this.ListaConectadosDG.RowTemplate.Height = 28;
            this.ListaConectadosDG.Size = new System.Drawing.Size(221, 172);
            this.ListaConectadosDG.TabIndex = 27;
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(902, 478);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(86, 26);
            this.SalirButton.TabIndex = 28;
            this.SalirButton.Text = "Salir:(";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(902, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(579, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "Si pulsas en el botón de salir, se desconectará el usuario que tiene sesión inici" +
    "ada en el Forms.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 630);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.ListaConectadosDG);
            this.Controls.Add(this.contLbl);
            this.Controls.Add(label9);
            this.Controls.Add(this.servicios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaConectadosButton);
            this.Controls.Add(this.ConectadosLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.ListaConectadosDG)).EndInit();
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
        private Label ConectadosLabel;
        private Button ListaConectadosButton;
        private Button button1;
        private Label servicios;
        private Label contLbl;
        private DataGridView ListaConectadosDG;
        private Button SalirButton;
        private Label label10;
    }
}