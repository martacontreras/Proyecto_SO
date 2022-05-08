namespace cliente
{
    partial class Parchís
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parchís));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.entrar = new System.Windows.Forms.Button();
            this.entrar_reg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuario_ini = new System.Windows.Forms.TextBox();
            this.contraseña_ini = new System.Windows.Forms.TextBox();
            this.enviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.usuario_consulta = new System.Windows.Forms.TextBox();
            this.partidas_ganadas = new System.Windows.Forms.RadioButton();
            this.tablones = new System.Windows.Forms.RadioButton();
            this.id_usuario = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.conectar = new System.Windows.Forms.Button();
            this.desconectar = new System.Windows.Forms.Button();
            this.iniciar_sesion = new System.Windows.Forms.GroupBox();
            this.peticiones = new System.Windows.Forms.GroupBox();
            this.jugar_button = new System.Windows.Forms.Button();
            this.ConectadosLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ListaConectadosDG = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SalirButton = new System.Windows.Forms.Button();
            this.contLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.servicios = new System.Windows.Forms.Label();
            this.registro = new System.Windows.Forms.GroupBox();
            this.envia_reg = new System.Windows.Forms.Button();
            this.usuario_reg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contraseña_reg = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.PictureBox();
            this.menuStrip_usuario = new System.Windows.Forms.MenuStrip();
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarseDelServidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label9 = new System.Windows.Forms.Label();
            this.iniciar_sesion.SuspendLayout();
            this.peticiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaConectadosDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            this.menuStrip_usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label9.Location = new System.Drawing.Point(483, 215);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(0, 18);
            label9.TabIndex = 26;
            // 
            // entrar
            // 
            this.entrar.Font = new System.Drawing.Font("Courier New", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.entrar.ForeColor = System.Drawing.Color.Black;
            this.entrar.Location = new System.Drawing.Point(189, 154);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(144, 37);
            this.entrar.TabIndex = 0;
            this.entrar.Text = "Entra!";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            this.entrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entrar_KeyDown);
            // 
            // entrar_reg
            // 
            this.entrar_reg.Font = new System.Drawing.Font("Courier New", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.entrar_reg.ForeColor = System.Drawing.Color.Black;
            this.entrar_reg.Location = new System.Drawing.Point(29, 151);
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
            this.label1.Font = new System.Drawing.Font("Courier New", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // usuario_ini
            // 
            this.usuario_ini.Font = new System.Drawing.Font("Courier New", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usuario_ini.ForeColor = System.Drawing.Color.Black;
            this.usuario_ini.Location = new System.Drawing.Point(131, 46);
            this.usuario_ini.Name = "usuario_ini";
            this.usuario_ini.Size = new System.Drawing.Size(207, 24);
            this.usuario_ini.TabIndex = 4;
            // 
            // contraseña_ini
            // 
            this.contraseña_ini.Font = new System.Drawing.Font("Courier New", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contraseña_ini.ForeColor = System.Drawing.Color.Black;
            this.contraseña_ini.Location = new System.Drawing.Point(131, 101);
            this.contraseña_ini.Name = "contraseña_ini";
            this.contraseña_ini.PasswordChar = '*';
            this.contraseña_ini.Size = new System.Drawing.Size(207, 24);
            this.contraseña_ini.TabIndex = 5;
            // 
            // enviar
            // 
            this.enviar.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enviar.Location = new System.Drawing.Point(1112, 315);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(163, 28);
            this.enviar.TabIndex = 7;
            this.enviar.Text = "Enviar Consulta";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(712, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(668, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Introduce el nombre de usuario del jugador para hacer la consulta:";
            // 
            // usuario_consulta
            // 
            this.usuario_consulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usuario_consulta.Location = new System.Drawing.Point(868, 226);
            this.usuario_consulta.Name = "usuario_consulta";
            this.usuario_consulta.Size = new System.Drawing.Size(125, 24);
            this.usuario_consulta.TabIndex = 12;
            // 
            // partidas_ganadas
            // 
            this.partidas_ganadas.AutoSize = true;
            this.partidas_ganadas.BackColor = System.Drawing.Color.Transparent;
            this.partidas_ganadas.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.partidas_ganadas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.partidas_ganadas.Location = new System.Drawing.Point(775, 290);
            this.partidas_ganadas.Name = "partidas_ganadas";
            this.partidas_ganadas.Size = new System.Drawing.Size(286, 22);
            this.partidas_ganadas.TabIndex = 13;
            this.partidas_ganadas.TabStop = true;
            this.partidas_ganadas.Text = "Número de partidas ganadas";
            this.partidas_ganadas.UseVisualStyleBackColor = false;
            // 
            // tablones
            // 
            this.tablones.AutoSize = true;
            this.tablones.BackColor = System.Drawing.Color.Transparent;
            this.tablones.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tablones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablones.Location = new System.Drawing.Point(775, 318);
            this.tablones.Name = "tablones";
            this.tablones.Size = new System.Drawing.Size(316, 22);
            this.tablones.TabIndex = 14;
            this.tablones.TabStop = true;
            this.tablones.Text = "Tablones en los que ha jugado";
            this.tablones.UseVisualStyleBackColor = false;
            // 
            // id_usuario
            // 
            this.id_usuario.AutoSize = true;
            this.id_usuario.BackColor = System.Drawing.Color.Transparent;
            this.id_usuario.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.id_usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id_usuario.Location = new System.Drawing.Point(775, 347);
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.Size = new System.Drawing.Size(166, 22);
            this.id_usuario.TabIndex = 15;
            this.id_usuario.TabStop = true;
            this.id_usuario.Text = "ID del jugador";
            this.id_usuario.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(712, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(478, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Escoge una de las opciones y envia tu consulta!";
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(1604, 11);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(101, 28);
            this.conectar.TabIndex = 17;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(1604, 47);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(101, 28);
            this.desconectar.TabIndex = 18;
            this.desconectar.Text = "Desconectar";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // iniciar_sesion
            // 
            this.iniciar_sesion.BackColor = System.Drawing.Color.LightCyan;
            this.iniciar_sesion.Controls.Add(this.usuario_ini);
            this.iniciar_sesion.Controls.Add(this.entrar);
            this.iniciar_sesion.Controls.Add(this.entrar_reg);
            this.iniciar_sesion.Controls.Add(this.label1);
            this.iniciar_sesion.Controls.Add(this.label2);
            this.iniciar_sesion.Controls.Add(this.contraseña_ini);
            this.iniciar_sesion.Font = new System.Drawing.Font("Courier New", 9.818182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.iniciar_sesion.ForeColor = System.Drawing.Color.Black;
            this.iniciar_sesion.Location = new System.Drawing.Point(756, 353);
            this.iniciar_sesion.Name = "iniciar_sesion";
            this.iniciar_sesion.Size = new System.Drawing.Size(367, 214);
            this.iniciar_sesion.TabIndex = 20;
            this.iniciar_sesion.TabStop = false;
            this.iniciar_sesion.Text = "Iniciar sesión";
            // 
            // peticiones
            // 
            this.peticiones.BackColor = System.Drawing.Color.Lavender;
            this.peticiones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("peticiones.BackgroundImage")));
            this.peticiones.Controls.Add(this.jugar_button);
            this.peticiones.Controls.Add(this.ConectadosLabel);
            this.peticiones.Controls.Add(this.label11);
            this.peticiones.Controls.Add(this.pictureBox4);
            this.peticiones.Controls.Add(this.ListaConectadosDG);
            this.peticiones.Controls.Add(this.pictureBox3);
            this.peticiones.Controls.Add(this.pictureBox2);
            this.peticiones.Controls.Add(this.SalirButton);
            this.peticiones.Controls.Add(this.partidas_ganadas);
            this.peticiones.Controls.Add(this.enviar);
            this.peticiones.Controls.Add(this.contLbl);
            this.peticiones.Controls.Add(this.label4);
            this.peticiones.Controls.Add(this.button1);
            this.peticiones.Controls.Add(label9);
            this.peticiones.Controls.Add(this.usuario_consulta);
            this.peticiones.Controls.Add(this.servicios);
            this.peticiones.Controls.Add(this.tablones);
            this.peticiones.Controls.Add(this.id_usuario);
            this.peticiones.Controls.Add(this.label5);
            this.peticiones.Font = new System.Drawing.Font("Courier New", 9.818182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.peticiones.ForeColor = System.Drawing.Color.Black;
            this.peticiones.Location = new System.Drawing.Point(175, 85);
            this.peticiones.Name = "peticiones";
            this.peticiones.Size = new System.Drawing.Size(1510, 850);
            this.peticiones.TabIndex = 21;
            this.peticiones.TabStop = false;
            // 
            // jugar_button
            // 
            this.jugar_button.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jugar_button.Location = new System.Drawing.Point(355, 501);
            this.jugar_button.Margin = new System.Windows.Forms.Padding(2);
            this.jugar_button.Name = "jugar_button";
            this.jugar_button.Size = new System.Drawing.Size(199, 44);
            this.jugar_button.TabIndex = 35;
            this.jugar_button.Text = "Jugar :)";
            this.jugar_button.UseVisualStyleBackColor = true;
            this.jugar_button.Click += new System.EventHandler(this.jugar_button_Click);
            // 
            // ConectadosLabel
            // 
            this.ConectadosLabel.AutoSize = true;
            this.ConectadosLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConectadosLabel.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConectadosLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConectadosLabel.Location = new System.Drawing.Point(176, 95);
            this.ConectadosLabel.Name = "ConectadosLabel";
            this.ConectadosLabel.Size = new System.Drawing.Size(198, 18);
            this.ConectadosLabel.TabIndex = 22;
            this.ConectadosLabel.Text = "PERSONAS CONECTADAS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(702, 595);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 30);
            this.label11.TabIndex = 34;
            this.label11.Text = "Selecciona la tematica!";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::cliente.Properties.Resources.logo;
            this.pictureBox4.Location = new System.Drawing.Point(917, 669);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(236, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // ListaConectadosDG
            // 
            this.ListaConectadosDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaConectadosDG.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.ListaConectadosDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaConectadosDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9.818182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaConectadosDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaConectadosDG.ColumnHeadersHeight = 26;
            this.ListaConectadosDG.ColumnHeadersVisible = false;
            this.ListaConectadosDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9.818182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaConectadosDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.ListaConectadosDG.EnableHeadersVisualStyles = false;
            this.ListaConectadosDG.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ListaConectadosDG.Location = new System.Drawing.Point(156, 130);
            this.ListaConectadosDG.Name = "ListaConectadosDG";
            this.ListaConectadosDG.RowHeadersWidth = 47;
            this.ListaConectadosDG.RowTemplate.Height = 28;
            this.ListaConectadosDG.Size = new System.Drawing.Size(244, 218);
            this.ListaConectadosDG.TabIndex = 27;
            this.ListaConectadosDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaConectadosDG_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::cliente.Properties.Resources.star_wars_logo_PNG20;
            this.pictureBox3.Location = new System.Drawing.Point(726, 648);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(545, 646);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // SalirButton
            // 
            this.SalirButton.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalirButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SalirButton.Location = new System.Drawing.Point(176, 396);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(86, 26);
            this.SalirButton.TabIndex = 28;
            this.SalirButton.Text = "Salir:(";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // contLbl
            // 
            this.contLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contLbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contLbl.Location = new System.Drawing.Point(1110, 434);
            this.contLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contLbl.Name = "contLbl";
            this.contLbl.Size = new System.Drawing.Size(63, 48);
            this.contLbl.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(868, 438);
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
            this.servicios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.servicios.Location = new System.Drawing.Point(428, 215);
            this.servicios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.servicios.Name = "servicios";
            this.servicios.Size = new System.Drawing.Size(0, 50);
            this.servicios.TabIndex = 25;
            // 
            // registro
            // 
            this.registro.BackColor = System.Drawing.Color.LightCyan;
            this.registro.Controls.Add(this.envia_reg);
            this.registro.Controls.Add(this.usuario_reg);
            this.registro.Controls.Add(this.label7);
            this.registro.Controls.Add(this.label8);
            this.registro.Controls.Add(this.contraseña_reg);
            this.registro.Font = new System.Drawing.Font("Courier New", 9.818182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.registro.ForeColor = System.Drawing.Color.Black;
            this.registro.Location = new System.Drawing.Point(756, 350);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(367, 214);
            this.registro.TabIndex = 21;
            this.registro.TabStop = false;
            this.registro.Text = "Registro";
            // 
            // envia_reg
            // 
            this.envia_reg.Font = new System.Drawing.Font("Courier New", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.envia_reg.ForeColor = System.Drawing.Color.Black;
            this.envia_reg.Location = new System.Drawing.Point(110, 151);
            this.envia_reg.Name = "envia_reg";
            this.envia_reg.Size = new System.Drawing.Size(144, 37);
            this.envia_reg.TabIndex = 10;
            this.envia_reg.Text = "Regístrate";
            this.envia_reg.UseVisualStyleBackColor = true;
            this.envia_reg.Click += new System.EventHandler(this.envia_reg_Click);
            // 
            // usuario_reg
            // 
            this.usuario_reg.Font = new System.Drawing.Font("Courier New", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usuario_reg.Location = new System.Drawing.Point(121, 49);
            this.usuario_reg.Name = "usuario_reg";
            this.usuario_reg.Size = new System.Drawing.Size(207, 24);
            this.usuario_reg.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(37, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Contraseña:";
            // 
            // contraseña_reg
            // 
            this.contraseña_reg.Font = new System.Drawing.Font("Courier New", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contraseña_reg.Location = new System.Drawing.Point(121, 104);
            this.contraseña_reg.Name = "contraseña_reg";
            this.contraseña_reg.Size = new System.Drawing.Size(207, 24);
            this.contraseña_reg.TabIndex = 9;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Image = global::cliente.Properties.Resources.Tosca_Modern_3D_Game_Box_Logo_removebg_preview;
            this.title.Location = new System.Drawing.Point(690, 153);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(504, 177);
            this.title.TabIndex = 30;
            this.title.TabStop = false;
            // 
            // menuStrip_usuario
            // 
            this.menuStrip_usuario.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip_usuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaToolStripMenuItem});
            this.menuStrip_usuario.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_usuario.Name = "menuStrip_usuario";
            this.menuStrip_usuario.Size = new System.Drawing.Size(1705, 26);
            this.menuStrip_usuario.TabIndex = 31;
            this.menuStrip_usuario.Text = "menuStrip1";
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desconectarseDelServidorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            this.holaToolStripMenuItem.Size = new System.Drawing.Size(14, 22);
            this.holaToolStripMenuItem.Click += new System.EventHandler(this.holaToolStripMenuItem_Click);
            // 
            // desconectarseDelServidorToolStripMenuItem
            // 
            this.desconectarseDelServidorToolStripMenuItem.Name = "desconectarseDelServidorToolStripMenuItem";
            this.desconectarseDelServidorToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.desconectarseDelServidorToolStripMenuItem.Text = "Desconectarse del servidor";
            this.desconectarseDelServidorToolStripMenuItem.Click += new System.EventHandler(this.desconectarseDelServidorToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Parchís
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1705, 881);
            this.Controls.Add(this.peticiones);
            this.Controls.Add(this.title);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.iniciar_sesion);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.menuStrip_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_usuario;
            this.Name = "Parchís";
            this.Text = "P A R C H Í S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.iniciar_sesion.ResumeLayout(false);
            this.iniciar_sesion.PerformLayout();
            this.peticiones.ResumeLayout(false);
            this.peticiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaConectadosDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.registro.ResumeLayout(false);
            this.registro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            this.menuStrip_usuario.ResumeLayout(false);
            this.menuStrip_usuario.PerformLayout();
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
        private Button enviar;
        private Label label4;
        private TextBox usuario_consulta;
        private RadioButton partidas_ganadas;
        private RadioButton tablones;
        private RadioButton id_usuario;
        private Label label5;
        private Button conectar;
        private Button desconectar;
        private GroupBox iniciar_sesion;
        private GroupBox registro;
        private TextBox usuario_reg;
        private Label label7;
        private Label label8;
        private TextBox contraseña_reg;
        private Button envia_reg;
        private Label ConectadosLabel;
        //private Button ListaConectadosButton;
        private Button button1;
        private Label servicios;
        private Label contLbl;
        private DataGridView ListaConectadosDG;
        private Button SalirButton;
        private PictureBox title;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label11;
        private GroupBox peticiones;
        private DataGridViewTextBoxColumn Column1;
        private Button jugar_button;
        private MenuStrip menuStrip_usuario;
        private ToolStripMenuItem holaToolStripMenuItem;
        private ToolStripMenuItem desconectarseDelServidorToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}