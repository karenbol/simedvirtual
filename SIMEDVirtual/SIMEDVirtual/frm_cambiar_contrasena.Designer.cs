namespace SIMEDVirtual
{
    partial class frm_cambiar_contrasena
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
            this.txt_nueva_pass = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtconfirmacion = new System.Windows.Forms.TextBox();
            this.lblconfirmapass = new System.Windows.Forms.Label();
            this.txt_pass_anterior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nueva_pass
            // 
            this.txt_nueva_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nueva_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nueva_pass.Location = new System.Drawing.Point(253, 153);
            this.txt_nueva_pass.Name = "txt_nueva_pass";
            this.txt_nueva_pass.PasswordChar = '*';
            this.txt_nueva_pass.Size = new System.Drawing.Size(205, 22);
            this.txt_nueva_pass.TabIndex = 110;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpass.Location = new System.Drawing.Point(100, 157);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(147, 18);
            this.lblpass.TabIndex = 111;
            this.lblpass.Text = "Nueva Contraseña";
            // 
            // txtconfirmacion
            // 
            this.txtconfirmacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtconfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmacion.Location = new System.Drawing.Point(253, 207);
            this.txtconfirmacion.Name = "txtconfirmacion";
            this.txtconfirmacion.PasswordChar = '*';
            this.txtconfirmacion.Size = new System.Drawing.Size(205, 22);
            this.txtconfirmacion.TabIndex = 112;
            // 
            // lblconfirmapass
            // 
            this.lblconfirmapass.AutoSize = true;
            this.lblconfirmapass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmapass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblconfirmapass.Location = new System.Drawing.Point(72, 207);
            this.lblconfirmapass.Name = "lblconfirmapass";
            this.lblconfirmapass.Size = new System.Drawing.Size(175, 18);
            this.lblconfirmapass.TabIndex = 113;
            this.lblconfirmapass.Text = "Confirmar Contraseña";
            // 
            // txt_pass_anterior
            // 
            this.txt_pass_anterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_anterior.Location = new System.Drawing.Point(253, 102);
            this.txt_pass_anterior.Name = "txt_pass_anterior";
            this.txt_pass_anterior.PasswordChar = '*';
            this.txt_pass_anterior.Size = new System.Drawing.Size(205, 22);
            this.txt_pass_anterior.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(88, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 115;
            this.label1.Text = "Contraseña Anterior";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.lblTitle);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(554, 47);
            this.flowLayoutPanel1.TabIndex = 116;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 25);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "CAMBIAR CONTRASEÑA";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::SIMEDVirtual.Properties.Resources.saveIcon2;
            this.btnGuardar.Location = new System.Drawing.Point(463, 269);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 58);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frm_cambiar_contrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(549, 339);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txt_pass_anterior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtconfirmacion);
            this.Controls.Add(this.lblconfirmapass);
            this.Controls.Add(this.txt_nueva_pass);
            this.Controls.Add(this.lblpass);
            this.Name = "frm_cambiar_contrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIAR CONTRASEÑA";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nueva_pass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtconfirmacion;
        private System.Windows.Forms.Label lblconfirmapass;
        private System.Windows.Forms.TextBox txt_pass_anterior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGuardar;
    }
}