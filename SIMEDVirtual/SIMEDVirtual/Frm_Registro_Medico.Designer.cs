namespace SIMEDVirtual
{
    partial class Frm_Registro_Medico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.opFile = new System.Windows.Forms.OpenFileDialog();
            this.pbFotoDr = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspacioVacio = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.telefono2 = new System.Windows.Forms.MaskedTextBox();
            this.lblCampoNumerico = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtconfirmacion = new System.Windows.Forms.TextBox();
            this.lblconfirmapass = new System.Windows.Forms.Label();
            this.telefono1 = new System.Windows.Forms.MaskedTextBox();
            this.codigo = new System.Windows.Forms.MaskedTextBox();
            this.fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtU = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoDr)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(477, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 29);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "REGISTRO DE MÉDICOS";
            // 
            // opFile
            // 
            this.opFile.FileName = "openFileDialog1";
            // 
            // pbFotoDr
            // 
            this.pbFotoDr.BackColor = System.Drawing.Color.Transparent;
            this.pbFotoDr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFotoDr.ErrorImage = null;
            this.pbFotoDr.Image = global::SIMEDVirtual.Properties.Resources.camera2;
            this.pbFotoDr.Location = new System.Drawing.Point(1102, 177);
            this.pbFotoDr.Name = "pbFotoDr";
            this.pbFotoDr.Size = new System.Drawing.Size(177, 181);
            this.pbFotoDr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoDr.TabIndex = 28;
            this.pbFotoDr.TabStop = false;
            this.pbFotoDr.Click += new System.EventHandler(this.pbFotoDr_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::SIMEDVirtual.Properties.Resources.saveIcon2;
            this.btnGuardar.Location = new System.Drawing.Point(1178, 590);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 58);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 57);
            this.panel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbEspecialidad);
            this.groupBox1.Controls.Add(this.lblEspacioVacio);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.label60);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.cbSexo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.telefono2);
            this.groupBox1.Controls.Add(this.lblCampoNumerico);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtconfirmacion);
            this.groupBox1.Controls.Add(this.lblconfirmapass);
            this.groupBox1.Controls.Add(this.telefono1);
            this.groupBox1.Controls.Add(this.codigo);
            this.groupBox1.Controls.Add(this.fecha_nacimiento);
            this.groupBox1.Controls.Add(this.txtcontrasena);
            this.groupBox1.Controls.Add(this.lblpass);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtU);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtApellido2);
            this.groupBox1.Controls.Add(this.txtApellido1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(82, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 548);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(592, 319);
            this.cbEspecialidad.MaxDropDownItems = 100;
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(324, 21);
            this.cbEspecialidad.TabIndex = 11;
            // 
            // lblEspacioVacio
            // 
            this.lblEspacioVacio.AutoSize = true;
            this.lblEspacioVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEspacioVacio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEspacioVacio.Location = new System.Drawing.Point(15, 16);
            this.lblEspacioVacio.Name = "lblEspacioVacio";
            this.lblEspacioVacio.Size = new System.Drawing.Size(294, 18);
            this.lblEspacioVacio.TabIndex = 124;
            this.lblEspacioVacio.Text = "* NO DEJE NINGUN ESPACIO VACIO";
            // 
            // txtEdad
            // 
            this.txtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(592, 175);
            this.txtEdad.Multiline = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(153, 22);
            this.txtEdad.TabIndex = 6;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label60.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label60.Location = new System.Drawing.Point(537, 178);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(46, 18);
            this.label60.TabIndex = 123;
            this.label60.Text = "Edad";
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(177, 126);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(200, 22);
            this.txtCedula.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(473, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 18);
            this.label12.TabIndex = 104;
            this.label12.Text = "Especialidad";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Red;
            this.label41.Location = new System.Drawing.Point(385, 173);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(16, 20);
            this.label41.TabIndex = 122;
            this.label41.Text = "*";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.cbSexo.Location = new System.Drawing.Point(177, 169);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(200, 21);
            this.cbSexo.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(116, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 18);
            this.label11.TabIndex = 121;
            this.label11.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(502, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 120;
            this.label3.Text = "Teléfono";
            // 
            // telefono2
            // 
            this.telefono2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono2.Location = new System.Drawing.Point(592, 358);
            this.telefono2.Mask = "99999999999999999999999";
            this.telefono2.Name = "telefono2";
            this.telefono2.Size = new System.Drawing.Size(205, 22);
            this.telefono2.TabIndex = 13;
            // 
            // lblCampoNumerico
            // 
            this.lblCampoNumerico.AutoSize = true;
            this.lblCampoNumerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoNumerico.ForeColor = System.Drawing.Color.Red;
            this.lblCampoNumerico.Location = new System.Drawing.Point(40, 490);
            this.lblCampoNumerico.Name = "lblCampoNumerico";
            this.lblCampoNumerico.Size = new System.Drawing.Size(137, 16);
            this.lblCampoNumerico.TabIndex = 119;
            this.lblCampoNumerico.Text = "* Campo Numérico";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(383, 354);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 24);
            this.label16.TabIndex = 118;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(385, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 24);
            this.label15.TabIndex = 117;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(383, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 24);
            this.label14.TabIndex = 116;
            this.label14.Text = "*";
            // 
            // txtconfirmacion
            // 
            this.txtconfirmacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtconfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmacion.Location = new System.Drawing.Point(592, 407);
            this.txtconfirmacion.Name = "txtconfirmacion";
            this.txtconfirmacion.PasswordChar = '*';
            this.txtconfirmacion.Size = new System.Drawing.Size(205, 22);
            this.txtconfirmacion.TabIndex = 15;
            // 
            // lblconfirmapass
            // 
            this.lblconfirmapass.AutoSize = true;
            this.lblconfirmapass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmapass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblconfirmapass.Location = new System.Drawing.Point(415, 409);
            this.lblconfirmapass.Name = "lblconfirmapass";
            this.lblconfirmapass.Size = new System.Drawing.Size(175, 18);
            this.lblconfirmapass.TabIndex = 111;
            this.lblconfirmapass.Text = "Confirmar Contraseña";
            // 
            // telefono1
            // 
            this.telefono1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono1.Location = new System.Drawing.Point(177, 356);
            this.telefono1.Mask = "99999999999999999999999";
            this.telefono1.Name = "telefono1";
            this.telefono1.Size = new System.Drawing.Size(200, 22);
            this.telefono1.TabIndex = 12;
            // 
            // codigo
            // 
            this.codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(177, 220);
            this.codigo.Mask = "9999999";
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(200, 22);
            this.codigo.TabIndex = 7;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_nacimiento.ImeMode = System.Windows.Forms.ImeMode.On;
            this.fecha_nacimiento.Location = new System.Drawing.Point(592, 127);
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.Size = new System.Drawing.Size(324, 22);
            this.fecha_nacimiento.TabIndex = 4;
            this.fecha_nacimiento.ValueChanged += new System.EventHandler(this.fecha_nacimiento_ValueChanged);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontrasena.Location = new System.Drawing.Point(177, 403);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.PasswordChar = '*';
            this.txtcontrasena.Size = new System.Drawing.Size(200, 22);
            this.txtcontrasena.TabIndex = 14;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpass.Location = new System.Drawing.Point(62, 409);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(95, 18);
            this.lblpass.TabIndex = 109;
            this.lblpass.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(177, 261);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 22);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtU
            // 
            this.txtU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtU.Location = new System.Drawing.Point(177, 309);
            this.txtU.Name = "txtU";
            this.txtU.Size = new System.Drawing.Size(200, 22);
            this.txtU.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(592, 226);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccion.Size = new System.Drawing.Size(324, 70);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtApellido2
            // 
            this.txtApellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(763, 77);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(153, 22);
            this.txtApellido2.TabIndex = 2;
            // 
            // txtApellido1
            // 
            this.txtApellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(592, 77);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(153, 22);
            this.txtApellido1.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(177, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(79, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 107;
            this.label10.Text = "Teléfono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(102, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 106;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(57, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 101;
            this.label8.Text = "Universidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(91, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 100;
            this.label7.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(92, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 95;
            this.label6.Text = "Cédula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(498, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 97;
            this.label5.Text = "Dirección ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(439, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 93;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(498, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 91;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(86, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 88;
            this.label1.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(62, 469);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 125;
            // 
            // Frm_Registro_Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1361, 730);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbFotoDr);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Frm_Registro_Medico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE MÉDICOS";
            this.Load += new System.EventHandler(this.Frm_Registro_Medico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoDr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbFotoDr;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog opFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEspacioVacio;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox telefono2;
        private System.Windows.Forms.Label lblCampoNumerico;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtconfirmacion;
        private System.Windows.Forms.Label lblconfirmapass;
        private System.Windows.Forms.MaskedTextBox telefono1;
        private System.Windows.Forms.MaskedTextBox codigo;
        private System.Windows.Forms.DateTimePicker fecha_nacimiento;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtU;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label label13;
    }
}