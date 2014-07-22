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
            this.menuStrip1.Size = new System.Drawing.Size(738, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
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
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // expedientesMedicosToolStripMenuItem1
            // 
            this.expedientesMedicosToolStripMenuItem1.Image = global::SIMEDVirtual.Properties.Resources.files;
            this.expedientesMedicosToolStripMenuItem1.Name = "expedientesMedicosToolStripMenuItem1";
            this.expedientesMedicosToolStripMenuItem1.Size = new System.Drawing.Size(224, 24);
            this.expedientesMedicosToolStripMenuItem1.Text = "Expedientes Médicos";
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Image = global::SIMEDVirtual.Properties.Resources.company;
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.empresasToolStripMenuItem.Text = "Empresas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::SIMEDVirtual.Properties.Resources.client;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // medicosToolStripMenuItem1
            // 
            this.medicosToolStripMenuItem1.Image = global::SIMEDVirtual.Properties.Resources.dr_paq1;
            this.medicosToolStripMenuItem1.Name = "medicosToolStripMenuItem1";
            this.medicosToolStripMenuItem1.Size = new System.Drawing.Size(224, 24);
            this.medicosToolStripMenuItem1.Text = "Médicos";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIMEDVirtual.Properties.Resources.logo_SIMED;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Frm_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frm_Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a SIMED Virtual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Splash_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Splash_FormClosed);
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
    }
}