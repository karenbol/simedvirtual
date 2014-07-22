namespace SIMEDVirtual
{
    partial class frmVerExpediente
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
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgReconsultas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditarEx = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCrearExp = new System.Windows.Forms.Button();
            this.btnReconsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReconsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.ape1,
            this.ape2,
            this.nombre});
            this.dgClientes.Location = new System.Drawing.Point(130, 96);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.Size = new System.Drawing.Size(447, 150);
            this.dgClientes.TabIndex = 0;
            this.dgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellClick);
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cedula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // ape1
            // 
            this.ape1.HeaderText = "Primer Apellido";
            this.ape1.Name = "ape1";
            this.ape1.ReadOnly = true;
            // 
            // ape2
            // 
            this.ape2.HeaderText = "Segundo Apellido";
            this.ape2.Name = "ape2";
            this.ape2.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPaciente.Location = new System.Drawing.Point(42, 49);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(75, 70);
            this.btnCrearPaciente.TabIndex = 1;
            this.btnCrearPaciente.Text = "Crear";
            this.btnCrearPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            // 
            // btnEditarPaciente
            // 
            this.btnEditarPaciente.Location = new System.Drawing.Point(42, 150);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPaciente.TabIndex = 2;
            this.btnEditarPaciente.Text = "Editar";
            this.btnEditarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Location = new System.Drawing.Point(42, 203);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPaciente.TabIndex = 3;
            this.btnEliminarPaciente.Text = "Eliminar";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista de Pacientes";
            // 
            // dgReconsultas
            // 
            this.dgReconsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReconsultas.Location = new System.Drawing.Point(205, 302);
            this.dgReconsultas.Name = "dgReconsultas";
            this.dgReconsultas.Size = new System.Drawing.Size(439, 150);
            this.dgReconsultas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reconsultas del Paciente";
            // 
            // btnEditarEx
            // 
            this.btnEditarEx.Location = new System.Drawing.Point(42, 369);
            this.btnEditarEx.Name = "btnEditarEx";
            this.btnEditarEx.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEx.TabIndex = 9;
            this.btnEditarEx.Text = "Editar";
            this.btnEditarEx.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "wwww";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(683, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 69);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reconsulta";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 69);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reconsulta";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCrearExp
            // 
            this.btnCrearExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearExp.Location = new System.Drawing.Point(698, 12);
            this.btnCrearExp.Name = "btnCrearExp";
            this.btnCrearExp.Size = new System.Drawing.Size(60, 69);
            this.btnCrearExp.TabIndex = 8;
            this.btnCrearExp.Text = "Crear";
            this.btnCrearExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrearExp.UseVisualStyleBackColor = true;
            this.btnCrearExp.Click += new System.EventHandler(this.btnCrearExp_Click);
            // 
            // btnReconsulta
            // 
            this.btnReconsulta.Location = new System.Drawing.Point(764, 12);
            this.btnReconsulta.Name = "btnReconsulta";
            this.btnReconsulta.Size = new System.Drawing.Size(75, 69);
            this.btnReconsulta.TabIndex = 4;
            this.btnReconsulta.Text = "Reconsulta";
            this.btnReconsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReconsulta.UseVisualStyleBackColor = true;
            this.btnReconsulta.Click += new System.EventHandler(this.btnReconsulta_Click);
            // 
            // frmVerExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 476);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditarEx);
            this.Controls.Add(this.btnCrearExp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgReconsultas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReconsulta);
            this.Controls.Add(this.btnEliminarPaciente);
            this.Controls.Add(this.btnEditarPaciente);
            this.Controls.Add(this.btnCrearPaciente);
            this.Controls.Add(this.dgClientes);
            this.Name = "frmVerExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control del Expedientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVerExpediente_FormClosing);
            this.Load += new System.EventHandler(this.frmVerExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReconsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Button btnCrearPaciente;
        private System.Windows.Forms.Button btnEditarPaciente;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.Button btnReconsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgReconsultas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditarEx;
        private System.Windows.Forms.Button btnCrearExp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}