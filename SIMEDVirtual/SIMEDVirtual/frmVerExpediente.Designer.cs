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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgReconsultas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnReconsulta = new System.Windows.Forms.Button();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terapeutica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReconsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgClientes.ColumnHeadersHeight = 30;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.ape1,
            this.ape2,
            this.nombre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgClientes.Location = new System.Drawing.Point(184, 49);
            this.dgClientes.MultiSelect = false;
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClientes.Size = new System.Drawing.Size(517, 250);
            this.dgClientes.TabIndex = 0;
            this.dgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellClick);
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cedula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 84;
            // 
            // ape1
            // 
            this.ape1.HeaderText = "Primer Apellido";
            this.ape1.Name = "ape1";
            this.ape1.ReadOnly = true;
            this.ape1.Width = 139;
            // 
            // ape2
            // 
            this.ape2.HeaderText = "Segundo Apellido";
            this.ape2.Name = "ape2";
            this.ape2.ReadOnly = true;
            this.ape2.Width = 159;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(290, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "LISTA DE PACIENTES";
            // 
            // dgReconsultas
            // 
            this.dgReconsultas.AllowUserToAddRows = false;
            this.dgReconsultas.AllowUserToDeleteRows = false;
            this.dgReconsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgReconsultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReconsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgReconsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReconsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cedula_paciente,
            this.fecha,
            this.medico,
            this.diagnostico,
            this.terapeutica,
            this.observaciones});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReconsultas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgReconsultas.Location = new System.Drawing.Point(81, 385);
            this.dgReconsultas.Name = "dgReconsultas";
            this.dgReconsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReconsultas.Size = new System.Drawing.Size(722, 150);
            this.dgReconsultas.TabIndex = 6;
            this.dgReconsultas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReconsultas_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(238, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "RECONSULTAS DEL PACIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "wwww";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(79, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Usuario:";
            // 
            // btnReconsulta
            // 
            this.btnReconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReconsulta.Image = global::SIMEDVirtual.Properties.Resources.reconsulta32;
            this.btnReconsulta.Location = new System.Drawing.Point(753, 12);
            this.btnReconsulta.Name = "btnReconsulta";
            this.btnReconsulta.Size = new System.Drawing.Size(89, 69);
            this.btnReconsulta.TabIndex = 4;
            this.btnReconsulta.Text = "Reconsulta";
            this.btnReconsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReconsulta.UseVisualStyleBackColor = true;
            this.btnReconsulta.Click += new System.EventHandler(this.btnReconsulta_Click);
            // 
            // btnEditarPaciente
            // 
            this.btnEditarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPaciente.Image = global::SIMEDVirtual.Properties.Resources.edit32;
            this.btnEditarPaciente.Location = new System.Drawing.Point(42, 152);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.Size = new System.Drawing.Size(75, 58);
            this.btnEditarPaciente.TabIndex = 2;
            this.btnEditarPaciente.Text = "Editar";
            this.btnEditarPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPaciente.Image = global::SIMEDVirtual.Properties.Resources.add28;
            this.btnCrearPaciente.Location = new System.Drawing.Point(42, 89);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(75, 57);
            this.btnCrearPaciente.TabIndex = 1;
            this.btnCrearPaciente.Text = "Crear";
            this.btnCrearPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 51;
            // 
            // cedula_paciente
            // 
            this.cedula_paciente.Frozen = true;
            this.cedula_paciente.HeaderText = "Cedula";
            this.cedula_paciente.Name = "cedula_paciente";
            this.cedula_paciente.ReadOnly = true;
            this.cedula_paciente.Width = 84;
            // 
            // fecha
            // 
            this.fecha.Frozen = true;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 79;
            // 
            // medico
            // 
            this.medico.Frozen = true;
            this.medico.HeaderText = "Medico";
            this.medico.Name = "medico";
            this.medico.ReadOnly = true;
            this.medico.Width = 85;
            // 
            // diagnostico
            // 
            this.diagnostico.Frozen = true;
            this.diagnostico.HeaderText = "Diagnostico";
            this.diagnostico.Name = "diagnostico";
            this.diagnostico.ReadOnly = true;
            this.diagnostico.Width = 118;
            // 
            // terapeutica
            // 
            this.terapeutica.Frozen = true;
            this.terapeutica.HeaderText = "Terapeutica";
            this.terapeutica.Name = "terapeutica";
            this.terapeutica.ReadOnly = true;
            this.terapeutica.Width = 118;
            // 
            // observaciones
            // 
            this.observaciones.Frozen = true;
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Width = 139;
            // 
            // frmVerExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(888, 578);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgReconsultas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReconsulta);
            this.Controls.Add(this.btnEditarPaciente);
            this.Controls.Add(this.btnCrearPaciente);
            this.Controls.Add(this.dgClientes);
            this.Name = "frmVerExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control del Expedientes";
            
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
        private System.Windows.Forms.Button btnReconsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgReconsultas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn terapeutica;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
    }
}