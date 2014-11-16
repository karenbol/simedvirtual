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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerExpediente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generarPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.rbCedula = new System.Windows.Forms.RadioButton();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.dgReconsultas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInfoPaciente = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnReconsulta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dtFechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReconsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.AllowUserToResizeColumns = false;
            this.dgClientes.AllowUserToResizeRows = false;
            this.dgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(this.dgClientes, "dgClientes");
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.ape1,
            this.ape2,
            this.nombre});
            this.dgClientes.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgClientes.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgClientes.MultiSelect = false;
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarPDFToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // generarPDFToolStripMenuItem
            // 
            this.generarPDFToolStripMenuItem.Name = "generarPDFToolStripMenuItem";
            resources.ApplyResources(this.generarPDFToolStripMenuItem, "generarPDFToolStripMenuItem");
                        // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Name = "label5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditarPaciente);
            this.groupBox1.Controls.Add(this.btnCrearPaciente);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnEditarPaciente
            // 
            resources.ApplyResources(this.btnEditarPaciente, "btnEditarPaciente");
            this.btnEditarPaciente.Image = global::SIMEDVirtual.Properties.Resources.edit32;
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.UseVisualStyleBackColor = true;
            this.btnEditarPaciente.Click += new System.EventHandler(this.btnEditarPaciente_Click);
            // 
            // btnCrearPaciente
            // 
            resources.ApplyResources(this.btnCrearPaciente, "btnCrearPaciente");
            this.btnCrearPaciente.Image = global::SIMEDVirtual.Properties.Resources.add28;
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // txtBusqueda
            // 
            resources.ApplyResources(this.txtBusqueda, "txtBusqueda");
            this.txtBusqueda.Name = "txtBusqueda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFecha);
            this.groupBox2.Controls.Add(this.rbApellido);
            this.groupBox2.Controls.Add(this.rbCedula);
            this.groupBox2.Controls.Add(this.rbEmpresa);
            this.groupBox2.Controls.Add(this.rbNombre);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // rbFecha
            // 
            resources.ApplyResources(this.rbFecha, "rbFecha");
            this.rbFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.TabStop = true;
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.Click += new System.EventHandler(this.rbFecha_Click);
            // 
            // rbApellido
            // 
            resources.ApplyResources(this.rbApellido, "rbApellido");
            this.rbApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.TabStop = true;
            this.rbApellido.UseVisualStyleBackColor = true;
            this.rbApellido.Click += new System.EventHandler(this.rbApellido_Click);
            // 
            // rbCedula
            // 
            resources.ApplyResources(this.rbCedula, "rbCedula");
            this.rbCedula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbCedula.Name = "rbCedula";
            this.rbCedula.TabStop = true;
            this.rbCedula.UseVisualStyleBackColor = true;
            this.rbCedula.Click += new System.EventHandler(this.rbCedula_Click);
            // 
            // rbEmpresa
            // 
            resources.ApplyResources(this.rbEmpresa, "rbEmpresa");
            this.rbEmpresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.UseVisualStyleBackColor = true;
            this.rbEmpresa.Click += new System.EventHandler(this.rbEmpresa_Click);
            // 
            // rbNombre
            // 
            resources.ApplyResources(this.rbNombre, "rbNombre");
            this.rbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.TabStop = true;
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.Click += new System.EventHandler(this.rbNombre_Click);
            // 
            // dgReconsultas
            // 
            this.dgReconsultas.AllowUserToAddRows = false;
            this.dgReconsultas.AllowUserToDeleteRows = false;
            this.dgReconsultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReconsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgReconsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReconsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cedula_paciente,
            this.fecha,
            this.medico});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReconsultas.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.dgReconsultas, "dgReconsultas");
            this.dgReconsultas.MultiSelect = false;
            this.dgReconsultas.Name = "dgReconsultas";
            this.dgReconsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReconsultas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReconsultas_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.Frozen = true;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            // 
            // lblInfoPaciente
            // 
            resources.ApplyResources(this.lblInfoPaciente, "lblInfoPaciente");
            this.lblInfoPaciente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfoPaciente.Name = "lblInfoPaciente";
            // 
            // btnPdf
            // 
            resources.ApplyResources(this.btnPdf, "btnPdf");
            this.btnPdf.Image = global::SIMEDVirtual.Properties.Resources.pdf;
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnReconsulta
            // 
            resources.ApplyResources(this.btnReconsulta, "btnReconsulta");
            this.btnReconsulta.Image = global::SIMEDVirtual.Properties.Resources.reconsulta32;
            this.btnReconsulta.Name = "btnReconsulta";
            this.btnReconsulta.UseVisualStyleBackColor = true;
            this.btnReconsulta.Click += new System.EventHandler(this.btnReconsulta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::SIMEDVirtual.Properties.Resources.search;
            resources.ApplyResources(this.btnBuscar, "btnBuscar");
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtFechaFiltro
            // 
            resources.ApplyResources(this.dtFechaFiltro, "dtFechaFiltro");
            this.dtFechaFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFiltro.Name = "dtFechaFiltro";
            this.dtFechaFiltro.ValueChanged += new System.EventHandler(this.dtFechaFiltro_ValueChanged);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbEmpresa, "cbEmpresa");
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.SelectionChangeCommitted += new System.EventHandler(this.cbEmpresa_SelectionChangeCommitted);
            // 
            // frmVerExpediente
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.cbEmpresa);
            this.Controls.Add(this.dtFechaFiltro);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.lblInfoPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReconsulta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgReconsultas);
            this.Controls.Add(this.dgClientes);
            this.Name = "frmVerExpediente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVerExpediente_FormClosing);
            this.Load += new System.EventHandler(this.frmVerExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbApellido;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgReconsultas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn medico;
        private System.Windows.Forms.Label lblInfoPaciente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generarPDFToolStripMenuItem;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.DateTimePicker dtFechaFiltro;
        private System.Windows.Forms.ComboBox cbEmpresa;
    }
}