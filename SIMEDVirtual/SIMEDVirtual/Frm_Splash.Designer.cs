namespace SIMEDVirtual
{
    partial class Frm_Splash
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secretariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expedientesMedicosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesFamiliaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesEmpresarialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicoToolStripMenuItem,
            this.secretariaToolStripMenuItem});
            this.reToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reToolStripMenuItem.Text = "Registro";
            // 
            // medicoToolStripMenuItem
            // 
            this.medicoToolStripMenuItem.Image = global::SIMEDVirtual.Properties.Resources.dr_paq2;
            this.medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            this.medicoToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.medicoToolStripMenuItem.Text = "Médico";
            this.medicoToolStripMenuItem.Click += new System.EventHandler(this.medicoToolStripMenuItem_Click);
            // 
            // secretariaToolStripMenuItem
            // 
            this.secretariaToolStripMenuItem.Image = global::SIMEDVirtual.Properties.Resources.admin;
            this.secretariaToolStripMenuItem.Name = "secretariaToolStripMenuItem";
            this.secretariaToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.secretariaToolStripMenuItem.Text = "Administrativo";
            this.secretariaToolStripMenuItem.Click += new System.EventHandler(this.secretariaToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expedientesMedicosToolStripMenuItem1,
            this.empresasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.medicosToolStripMenuItem1,
            this.administrativosToolStripMenuItem,
            this.planesFamiliaresToolStripMenuItem,
            this.planesEmpresarialesToolStripMenuItem});
            this.verToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // expedientesMedicosToolStripMenuItem1
            // 
            this.expedientesMedicosToolStripMenuItem1.Image = global::SIMEDVirtual.Properties.Resources.files;
            this.expedientesMedicosToolStripMenuItem1.Name = "expedientesMedicosToolStripMenuItem1";
            this.expedientesMedicosToolStripMenuItem1.Size = new System.Drawing.Size(224, 24);
            this.expedientesMedicosToolStripMenuItem1.Text = "Expedientes Médicos";
            this.expedientesMedicosToolStripMenuItem1.Click += new System.EventHandler(this.expedientesMedicosToolStripMenuItem1_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Image = global::SIMEDVirtual.Properties.Resources.company;
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.empresasToolStripMenuItem.Text = "Empresas";
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.empresasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::SIMEDVirtual.Properties.Resources.client;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // medicosToolStripMenuItem1
            // 
            this.medicosToolStripMenuItem1.Image = global::SIMEDVirtual.Properties.Resources.dr_paq1;
            this.medicosToolStripMenuItem1.Name = "medicosToolStripMenuItem1";
            this.medicosToolStripMenuItem1.Size = new System.Drawing.Size(224, 24);
            this.medicosToolStripMenuItem1.Text = "Médicos";
            this.medicosToolStripMenuItem1.Click += new System.EventHandler(this.medicosToolStripMenuItem1_Click);
            // 
            // administrativosToolStripMenuItem
            // 
            this.administrativosToolStripMenuItem.Image = global::SIMEDVirtual.Properties.Resources.admin;
            this.administrativosToolStripMenuItem.Name = "administrativosToolStripMenuItem";
            this.administrativosToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.administrativosToolStripMenuItem.Text = "Administrativos";
            // 
            // planesFamiliaresToolStripMenuItem
            // 
            this.planesFamiliaresToolStripMenuItem.Image = global::SIMEDVirtual.Properties.Resources.family;
            this.planesFamiliaresToolStripMenuItem.Name = "planesFamiliaresToolStripMenuItem";
            this.planesFamiliaresToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.planesFamiliaresToolStripMenuItem.Text = "Planes Familiares";
            // 
            // planesEmpresarialesToolStripMenuItem
            // 
            this.planesEmpresarialesToolStripMenuItem.Image = global::SIMEDVirtual.Properties.Resources.paqEmpresarial;
            this.planesEmpresarialesToolStripMenuItem.Name = "planesEmpresarialesToolStripMenuItem";
            this.planesEmpresarialesToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.planesEmpresarialesToolStripMenuItem.Text = "Planes Empresariales";
            this.planesEmpresarialesToolStripMenuItem.Click += new System.EventHandler(this.planesEmpresarialesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Image = global::SIMEDVirtual.Properties.Resources.help;
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(85, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Image = global::SIMEDVirtual.Properties.Resources.logout;
            this.btnSalir.Location = new System.Drawing.Point(825, 462);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 41);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIMEDVirtual.Properties.Resources.logo_SIMED;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(941, 483);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 515);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frm_Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a SIMED Virtual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Splash_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Splash_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secretariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expedientesMedicosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administrativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesFamiliaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesEmpresarialesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}