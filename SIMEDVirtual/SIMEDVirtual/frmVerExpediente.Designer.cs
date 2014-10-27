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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerExpediente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgReconsultas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terapeutica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReconsulta = new System.Windows.Forms.Button();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReconsultas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            resources.ApplyResources(this.dgClientes, "dgClientes");
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.AllowUserToResizeColumns = false;
            this.dgClientes.AllowUserToResizeRows = false;
            this.dgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.ape1,
            this.ape2,
            this.nombre});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClientes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgClientes.MultiSelect = false;
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dgClientes, resources.GetString("dgClientes.ToolTip"));
            this.dgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellClick);
            this.dgClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellDoubleClick);
            // 
            // cedula
            // 
            resources.ApplyResources(this.cedula, "cedula");
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // ape1
            // 
            resources.ApplyResources(this.ape1, "ape1");
            this.ape1.Name = "ape1";
            this.ape1.ReadOnly = true;
            // 
            // ape2
            // 
            resources.ApplyResources(this.ape2, "ape2");
            this.ape2.Name = "ape2";
            this.ape2.ReadOnly = true;
            // 
            // nombre
            // 
            resources.ApplyResources(this.nombre, "nombre");
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // dgReconsultas
            // 
            resources.ApplyResources(this.dgReconsultas, "dgReconsultas");
            this.dgReconsultas.AllowUserToAddRows = false;
            this.dgReconsultas.AllowUserToDeleteRows = false;
            this.dgReconsultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReconsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgReconsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReconsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cedula_paciente,
            this.fecha,
            this.medico,
            this.diagnostico,
            this.terapeutica,
            this.observaciones});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReconsultas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgReconsultas.Name = "dgReconsultas";
            this.dgReconsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dgReconsultas, resources.GetString("dgReconsultas.ToolTip"));
            this.dgReconsultas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReconsultas_CellDoubleClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // cedula_paciente
            // 
            this.cedula_paciente.Frozen = true;
            resources.ApplyResources(this.cedula_paciente, "cedula_paciente");
            this.cedula_paciente.Name = "cedula_paciente";
            this.cedula_paciente.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.Frozen = true;
            resources.ApplyResources(this.fecha, "fecha");
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // medico
            // 
            this.medico.Frozen = true;
            resources.ApplyResources(this.medico, "medico");
            this.medico.Name = "medico";
            this.medico.ReadOnly = true;
            // 
            // diagnostico
            // 
            this.diagnostico.Frozen = true;
            resources.ApplyResources(this.diagnostico, "diagnostico");
            this.diagnostico.Name = "diagnostico";
            this.diagnostico.ReadOnly = true;
            // 
            // terapeutica
            // 
            this.terapeutica.Frozen = true;
            resources.ApplyResources(this.terapeutica, "terapeutica");
            this.terapeutica.Name = "terapeutica";
            this.terapeutica.ReadOnly = true;
            // 
            // observaciones
            // 
            this.observaciones.Frozen = true;
            resources.ApplyResources(this.observaciones, "observaciones");
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnEditarPaciente);
            this.groupBox1.Controls.Add(this.btnCrearPaciente);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // btnReconsulta
            // 
            resources.ApplyResources(this.btnReconsulta, "btnReconsulta");
            this.btnReconsulta.Image = global::SIMEDVirtual.Properties.Resources.reconsulta32;
            this.btnReconsulta.Name = "btnReconsulta";
            this.toolTip1.SetToolTip(this.btnReconsulta, resources.GetString("btnReconsulta.ToolTip"));
            this.btnReconsulta.UseVisualStyleBackColor = true;
            this.btnReconsulta.Click += new System.EventHandler(this.btnReconsulta_Click);
            // 
            // btnEditarPaciente
            // 
            resources.ApplyResources(this.btnEditarPaciente, "btnEditarPaciente");
            this.btnEditarPaciente.Image = global::SIMEDVirtual.Properties.Resources.edit32;
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.toolTip1.SetToolTip(this.btnEditarPaciente, resources.GetString("btnEditarPaciente.ToolTip"));
            this.btnEditarPaciente.UseVisualStyleBackColor = true;
            this.btnEditarPaciente.Click += new System.EventHandler(this.btnEditarPaciente_Click);
            // 
            // btnCrearPaciente
            // 
            resources.ApplyResources(this.btnCrearPaciente, "btnCrearPaciente");
            this.btnCrearPaciente.Image = global::SIMEDVirtual.Properties.Resources.add28;
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.toolTip1.SetToolTip(this.btnCrearPaciente, resources.GetString("btnCrearPaciente.ToolTip"));
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // frmVerExpediente
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReconsulta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgReconsultas);
            this.Controls.Add(this.dgClientes);
            this.Name = "frmVerExpediente";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVerExpediente_FormClosing);
            this.Load += new System.EventHandler(this.frmVerExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReconsultas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}