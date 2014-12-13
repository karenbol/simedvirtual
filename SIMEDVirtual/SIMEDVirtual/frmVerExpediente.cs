using iTextSharp.text;
using iTextSharp.text.pdf;
using Npgsql;
using SIMEDVirtual.DA;
using SIMEDVirtual.Entity;
using SIMEDVirtual.IT;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIMEDVirtual
{
    public partial class frmVerExpediente : Form
    {
        string prueba = "";
        string usuarioPublico = "";

        public frmVerExpediente()
        {
            InitializeComponent();
            //usuario
            usuarioPublico = Frm_Ingreso.datosUsuario;
            label4.Text = Frm_Ingreso.datosUsuario;

            dgClientes.Columns[0].Width = 200;
            dgClientes.Columns[1].Width = 150;
            dgClientes.Columns[2].Width = 150;
            dgClientes.Columns[3].Width = 150;

            dgReconsultas.Columns[0].Width = 50;
            dgReconsultas.Columns[1].Width = 100;
            dgReconsultas.Columns[2].Width = 100;
            dgReconsultas.Columns[3].Width = 100;

            groupBox1.Location = new Point(16, 174);
            dgClientes.Location = new Point(131, 164);
            dgReconsultas.Location = new Point(931, 164);
            label3.Location = new Point(950, 140);
            label2.Location = new Point(990, 97);
            lblInfoPaciente.Location = new Point(128, 143);
            btnReconsulta.Location = new Point(722, 94);

            this.cargaComboEmpresas();
        }

        private void frmVerExpediente_Load(object sender, EventArgs e)
        {
            //llena la tabla con los clientes
            this.cargarDataGrid();

            dtFechaFiltro.Visible = false;
            cbEmpresa.Visible = false;
            toolTip1.InitialDelay = 1;

            toolTip1.SetToolTip(btnCrearPaciente, "Crea Nuevo Paciente");
            toolTip1.SetToolTip(btnEditarPaciente, "Edita Informacion del Paciente");
            toolTip1.SetToolTip(btnReconsulta, "Crea una Reconsulta del Paciente");
            toolTip1.SetToolTip(btnEditaExpediente, "Edita el Expediente");
            toolTip1.SetToolTip(btnPdf, "Exporta el Expediente en Formato PDF");

            if (UsuarioIT.TipoUsuario(Frm_Ingreso.cedulaUsuario) == "1")
            {
                this.btnReconsulta.Enabled = false;
                this.btnEditaExpediente.Enabled = false;
            }
        }
        //metodo que carga TODAS LAS EMPRESAS registradas EN EL COMBO BOX
        public void cargaComboEmpresas()
        {
            List<EmpresaEntity> listaEmpresas = EmpresaIT.getAllEmpresas();

            if (listaEmpresas.Count != 0)
            {
                //asigno los datos al combobox
                cbEmpresa.DataSource = listaEmpresas;
                cbEmpresa.SelectedIndex = 0;
                //lo que quiero obtener
                cbEmpresa.ValueMember = "id";
                //lo q voy a mostrar
                cbEmpresa.DisplayMember = "nombre";
            }
        }


        //cargamos los clientes
        private void cargarDataGrid()
        {
            //cargamos todos la info de drs en el datagrid
            var pts = new BindingList<PersonaEntity>(PersonaIT.selectCliente());
            dgClientes.AutoGenerateColumns = false;
            dgClientes.DataSource = pts;
            //agregar el evento 
            dgClientes.CellContentDoubleClick += dgClientes_CellClick;

            //se asignan datos al datagrid
            for (int j = 0; j < pts.Count; j++)
            {
                dgClientes.Rows[j].Cells[0].Value = pts.ElementAt(j).cedula.ToString();
                dgClientes.Rows[j].Cells[1].Value = pts.ElementAt(j).ape1.ToString();
                dgClientes.Rows[j].Cells[2].Value = pts.ElementAt(j).ape2.ToString();
                dgClientes.Rows[j].Cells[3].Value = pts.ElementAt(j).nombre.ToString();
            }
        }

        private void cargarDataGrid(List<PersonaEntity> lista)
        {
            //cargamos todos la info de drs en el datagrid
            var pts = lista;
            dgClientes.AutoGenerateColumns = false;
            dgClientes.DataSource = pts;
            //agregar el evento 
            dgClientes.CellContentDoubleClick += dgClientes_CellClick;

            //se asignan datos al datagrid
            for (int j = 0; j < pts.Count; j++)
            {
                dgClientes.Rows[j].Cells[0].Value = pts.ElementAt(j).cedula.ToString();
                dgClientes.Rows[j].Cells[1].Value = pts.ElementAt(j).ape1.ToString();
                dgClientes.Rows[j].Cells[2].Value = pts.ElementAt(j).ape2.ToString();
                dgClientes.Rows[j].Cells[3].Value = pts.ElementAt(j).nombre.ToString();
            }
        }

        //para crear un nuevo expediente
        private void btnCrearExp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ExpedienteMG splash = new frm_ExpedienteMG();
            splash.ShowDialog();
            
        }

        //con el click de la tabla clientes se muestra las reconsultas
        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //toma el valor de la cedula
                string cedula = Convert.ToString(dgClientes.Rows[e.RowIndex].Cells[0].Value);
                prueba = cedula;

                //cargamos todos la info de drs en el datagrid
                var pts = new BindingList<ExpedienteEntity>(ExpedienteIT.selectExpediente(cedula));
                dgReconsultas.AutoGenerateColumns = false;
                dgReconsultas.DataSource = pts;

                //se asignan datos al datagrid de reconsultas
                for (int j = 0; j < pts.Count; j++)
                {
                    dgReconsultas.Rows[j].Cells[0].Value = pts.ElementAt(j).id_expediente.ToString();
                    dgReconsultas.Rows[j].Cells[1].Value = pts.ElementAt(j).cedula.ToString();
                    dgReconsultas.Rows[j].Cells[2].Value = pts.ElementAt(j).fecha.ToString("dd/MM/yyyy");
                    dgReconsultas.Rows[j].Cells[3].Value = PersonaIT.getApellidoMedico(pts.ElementAt(j).cedula_medico.ToString());
                }
            }
            else
            {
                MessageBox.Show("SELECCION NO VALIDA");
            }
        }

        //llena todos los campos segun la consulta hecha por cedula
        private void btnReconsulta_Click(object sender, EventArgs e)
        {
            if (prueba != "")
            {
                this.Hide();
                frm_ExpedienteMG frm = new frm_ExpedienteMG(prueba, false, false, 0, 1);
                frm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("NO SE HA SELECCIONADO NINGUN PACIENTE\nPOR FAVOR SELECCIONE EL PACIENTE E INTENTELO DE NUEVO", "Seleccion Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ExpedienteMG frm = new frm_ExpedienteMG();
            frm.ShowDialog();
            
        }

        //con el doble click en la tabla reconsulta muestro el expediente completo
        private void dgReconsultas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtengo el id de la row seleccionada
            string cedula_paciente = Convert.ToString(dgReconsultas.Rows[e.RowIndex].Cells[1].Value);
            int id_paciente = Convert.ToInt32(dgReconsultas.Rows[e.RowIndex].Cells[0].Value);

            this.Hide();
            frm_ExpedienteMG frm = new frm_ExpedienteMG(cedula_paciente, false, true, id_paciente, 0);
            frm.ShowDialog();
            
        }

        //veo la info personal del cliente
        private void dgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtngo el id de la row seleccionada
            string cedula_paciente = Convert.ToString(dgClientes.Rows[e.RowIndex].Cells[0].Value);

            this.Hide();
            frm_Cliente frm = new frm_Cliente(cedula_paciente, 1);
            frm.ShowDialog();
            
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgClientes.Rows[dgClientes.SelectedCells[0].RowIndex];
            string cedula_paciente = Convert.ToString(selectedRow.Cells["Cedula"].Value);

            this.Hide();
            frm_Cliente frm = new frm_Cliente(cedula_paciente, 2);
            frm.ShowDialog();
            
        }

        private void frmVerExpediente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            switch (Frm_Ingreso.tipoUsuario)
            {
                case "2":
                    Frm_Ingreso frm = new Frm_Ingreso();
                    frm.ShowDialog();
                                        break;
                case "1":
                    Frm_Splash pantalla = new Frm_Splash();
                    pantalla.ShowDialog();
                                        break;
                default:
                    break;
            }
            NpgsqlConnection.ClearAllPools();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != string.Empty)
            {
                if (rbNombre.Checked)
                {
                    List<PersonaEntity> personas = PersonaIT.selectClienteByBusqueda("nombre", txtBusqueda.Text);
                    if (personas.Count != 0)
                    {
                        this.cargarDataGrid(personas);
                    }
                }
                else if (rbApellido.Checked)
                {
                    List<PersonaEntity> personas = PersonaIT.selectClienteByBusqueda("apellido1", txtBusqueda.Text);
                    if (personas.Count != 0)
                    {
                        this.cargarDataGrid(personas);
                    }
                }
                else if (rbCedula.Checked)
                {
                    List<PersonaEntity> personas = PersonaIT.selectClienteByBusqueda("cedula", txtBusqueda.Text);
                    if (personas.Count != 0)
                    {
                        this.cargarDataGrid(personas);
                    }
                }
            }
            else
            {
                this.cargarDataGrid();
                rbCedula.Checked = false;
                rbNombre.Checked = false;
                rbApellido.Checked = false;
                rbEmpresa.Checked = false;
                rbFecha.Checked = false;
                txtBusqueda.Visible = false;
                cbEmpresa.Visible = false;
                dtFechaFiltro.Visible = false;
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dgReconsultas.SelectedRows.Count > 0 && dgClientes.SelectedRows.Count > 0)
            {
                var cell = this.dgClientes.SelectedCells[0];
                var row = this.dgClientes.Rows[cell.RowIndex];
                string cedula = row.Cells[0].Value.ToString();

                var cell2 = this.dgReconsultas.SelectedCells[0];
                var row2 = this.dgReconsultas.Rows[cell2.RowIndex];
                int id = Convert.ToInt32(row2.Cells[0].Value);

                if (cell.RowIndex != -1 && cell2.RowIndex != -1)
                {
                    List<PersonaEntity> paciente = PersonaIT.selectClientePorCedula(cedula);
                    List<anamnesis> paciente_anamnesis = anamnesisIT.selectAnamnesisPorCedula(cedula);
                    List<ExpedienteEntity> paciente_expediente = ExpedienteIT.selectExpedienteById(cedula, id);

                    string t = Convert.ToString(paciente_expediente[0].cedula_medico);
                    //me retorna nombre, y apellidos del dr
                    List<PersonaEntity> info_medico = UsuarioIT.getNombreApeDr(Convert.ToString(paciente_expediente[0].cedula_medico));
                    string medico = info_medico[0].nombre + " " + info_medico[0].ape1 + " " + info_medico[0].ape2;

                    try
                    {
                        Document document = new Document(PageSize.LETTER);
                        string usuario = Environment.UserName;
                        //MessageBox.Show(usuario);

                        PdfWriter.GetInstance(document, new FileStream(Path.Combine("C:\\Users\\" + usuario + "\\Desktop", "Expediente_" + paciente[0].nombre + "_" + paciente[0].ape1 + ".pdf"), FileMode.OpenOrCreate));
                        document.Open();

                        // iTextSharp.text.Font contentFont = iTextSharp.text.
                        iTextSharp.text.Font contentFont = FontFactory.GetFont("ARIAL", 18, iTextSharp.text.Font.BOLD);
                        Paragraph paragraph = new Paragraph(@"EXPEDIENTE MÉDICO", contentFont);


                        paragraph.IndentationLeft = 120;
                        iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"C:\SIMEDVirtual\SIMEDVirtual\SIMEDVirtual\bin\Debug\logo.jpg");
                        jpg.ScaleToFit(100f, 100f);
                        jpg.Alignment = iTextSharp.text.Image.TEXTWRAP | iTextSharp.text.Image.ALIGN_LEFT;
                        document.Add(jpg);
                        document.Add(paragraph);
                        document.Add(new Paragraph(" "));
                        document.Add(new Paragraph(" "));
                        document.Add(new Paragraph("________________________________________________________________________________"));
                        document.Add(new Paragraph(" "));

                        Chunk chunk1 = new Chunk("MÉDICO:", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                        Chunk chunk2 = new Chunk(medico + "                                ");

                        Chunk chunk3 = new Chunk("FECHA CONSULTA:", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                        Chunk chunk4 = new Chunk(paciente_expediente[0].fecha.ToShortDateString());

                        Phrase phr1 = new Phrase();
                        phr1.Add(chunk1);
                        phr1.Add(chunk2);
                        phr1.Add(chunk3);
                        phr1.Add(chunk4);
                        document.Add(phr1);
                        document.Add(new Paragraph(" "));

                        //------------------------------------INFORMACION PERSONAL------------------------------------
                        ArrayList info_personal = new ArrayList();
                        //info_personal.Add("NOMBRE:" + paciente[0].nombre);
                        info_personal.Add("CÉDULA:" + paciente[0].cedula);
                        info_personal.Add("FECHA NACIMIENTO: " + paciente[0].fecha.ToShortDateString());
                        info_personal.Add("EDAD: " + paciente[0].edad);
                        info_personal.Add("ESTADO CIVIL: " + paciente[0].estado_civil);
                        info_personal.Add("SEXO: " + paciente[0].sexo.ToString().ToUpper());
                        info_personal.Add("PROFESIÓN: " + paciente[0].profesion);
                        //empresa
                        EmpresaEntity empresa = EmpresaIT.getEmpresaByID(paciente[0].empresa.ToString());
                        info_personal.Add("EMPRESA: " + empresa.nombre.ToUpper());
                        info_personal.Add("TELÉFONO: " + paciente[0].telefono_fijo);
                        info_personal.Add("MÓVIL: " + paciente[0].telefono_movil);
                        info_personal.Add("CORREO: " + paciente[0].email);
                        //titulo
                        PdfPTable tabla_info_personal = new PdfPTable(3);
                        tabla_info_personal.TotalWidth = 550f;
                        //fix the absolute width of the table
                        tabla_info_personal.LockedWidth = true;
                        //relative col widths in proportions - 1/3 and 2/3
                        float[] widths = new float[] { 6f, 6f, 6f };
                        tabla_info_personal.SetWidths(widths);

                        PdfPCell celda1 = new PdfPCell(new Phrase("INFORMACIÓN PERSONAL"));
                        celda1.BackgroundColor = BaseColor.LIGHT_GRAY;
                        celda1.Colspan = 3;
                        celda1.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        tabla_info_personal.AddCell(celda1);

                        PdfPCell celda4 = new PdfPCell(new Phrase("NOMBRE:" + paciente[0].nombre + " " + paciente[0].ape1 + " " + paciente[0].ape2));
                        celda4.Colspan = 3;
                        celda4.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        tabla_info_personal.AddCell(celda4);

                        for (int i = 0; i < info_personal.Count; i++)
                        {
                            tabla_info_personal.AddCell(info_personal[i].ToString());
                        }
                        PdfPCell celda5 = new PdfPCell(new Phrase("DIRECCIÓN:" + paciente[0].direccion));
                        celda5.Colspan = 3;
                        celda5.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        tabla_info_personal.AddCell(celda5);

                        document.Add(tabla_info_personal);
                        //document.Add(new Paragraph(" "));
                        //----------------------------------------------ANAMNESIS---------------------------------------------------------------
                        //------------------------------ANTECEDENTES patologicos y no patologicos----------------
                        ArrayList info_antecedentes = new ArrayList();
                        //tabaquismo
                        if ((paciente_anamnesis[0].tabaquismo != ' ' && paciente_anamnesis[0].tabaquismo == 'n') || paciente_anamnesis[0].tabaquismo == ' ')
                        {
                            info_antecedentes.Add("TABAQUISMO: NO ");
                        }
                        else
                        {
                            info_antecedentes.Add("TABAQUISMO: SI ");
                        }

                        //INGESTA MEDICAMENTOS
                        if ((paciente_anamnesis[0].ingesta_medicamentos != ' ' && paciente_anamnesis[0].ingesta_medicamentos == 'n') || paciente_anamnesis[0].ingesta_medicamentos == ' ')
                        {
                            info_antecedentes.Add("INGESTA MEDICAMENTOS: NO ");
                        }
                        else
                        {
                            info_antecedentes.Add("INGESTA MEDICAMENTOS: SI ");
                        }

                        //ALCOHOLISMO ACTUAL O PREVIO
                        if ((paciente_anamnesis[0].alcoholismo != ' ' && paciente_anamnesis[0].alcoholismo == 'n') || paciente_anamnesis[0].alcoholismo == ' ')
                        {
                            info_antecedentes.Add("ALCOHOLISMO: NO ");
                        }
                        else
                        {
                            info_antecedentes.Add("ALCOHOLISMO: SI ");
                        }
                        //rehabilitacion fisica o mental
                        if ((paciente_anamnesis[0].rehabilitacion != ' ' && paciente_anamnesis[0].rehabilitacion == 'n') || paciente_anamnesis[0].rehabilitacion == ' ')
                        {
                            info_antecedentes.Add("REHABILITACIÓN: NO ");
                        }
                        else
                        {
                            info_antecedentes.Add("REHABILITACIÓN: SI ");
                        }

                        PdfPTable tabla_antecedentes = new PdfPTable(2);
                        tabla_antecedentes.TotalWidth = 550f;
                        //fix the absolute width of the table
                        tabla_antecedentes.LockedWidth = true;
                        //relative col widths in proportions - 1/3 and 2/3
                        float[] widths2 = new float[] { 6f, 6f };
                        tabla_antecedentes.SetWidths(widths2);

                        PdfPCell celda2 = new PdfPCell(new Phrase("ANTECEDENTES PATOLÓGICOS Y NO PATOLÓGICOS"));
                        celda2.BackgroundColor = BaseColor.LIGHT_GRAY;
                        celda2.Colspan = 2;
                        celda2.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        tabla_antecedentes.AddCell(celda2);

                        for (int i = 0; i < info_antecedentes.Count; i++)
                        {
                            tabla_antecedentes.AddCell(info_antecedentes[i].ToString());
                        }
                        //alergia a medicamentos
                        if (paciente_anamnesis[0].alergias == 's')
                        {
                            PdfPCell celda3 = new PdfPCell(new Phrase("ALÉRGICO A MEDICAMENTOS: " + paciente_anamnesis[0].alergias_tratamiento));
                            celda3.Colspan = 2;
                            celda3.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                            tabla_antecedentes.AddCell(celda3);
                        }
                        document.Add(tabla_antecedentes);
                        //-----------------------------------------padece o ha padecido de----------------------------
                        ArrayList info_padecimiento = new ArrayList();

                        //diabetes
                        if (paciente_anamnesis[0].diabetes == ' ' || paciente_anamnesis[0].diabetes == 'n')
                        {
                            info_padecimiento.Add("DIABETES: NO ");
                        }
                        else
                        {
                            info_padecimiento.Add("DIABETES: SI   TRATAMIENTO: " + paciente_anamnesis[0].diabetes_trat);
                        }

                        //hipertension
                        if (paciente_anamnesis[0].hipertension == ' ' || paciente_anamnesis[0].hipertension == 'n')
                        {
                            info_padecimiento.Add("HIPERTENSIÓN: NO ");
                        }
                        else
                        {
                            info_padecimiento.Add("HIPERTENSIÓN: SI   TRATAMIENTO: " + paciente_anamnesis[0].hipertension_trat);
                        }

                        //asma
                        if (paciente_anamnesis[0].asma == ' ' || paciente_anamnesis[0].asma == 'n')
                        {
                            info_padecimiento.Add("ASMA: NO ");
                        }
                        else
                        {
                            info_padecimiento.Add("ASMA: SI   TRATAMIENTO: " + paciente_anamnesis[0].asma_tratamiento);
                        }
                        //tiroides
                        if (paciente_anamnesis[0].tiroides == ' ' || paciente_anamnesis[0].tiroides == 'n')
                        {
                            info_padecimiento.Add("TIROIDES: NO ");
                        }
                        else
                        {
                            info_padecimiento.Add("TIROIDES: SI   TRATAMIENTO: " + paciente_anamnesis[0].tiroides_tratamiento);
                        }

                        PdfPTable tabla_padecimieto = new PdfPTable(2);
                        tabla_padecimieto.TotalWidth = 550f;
                        //fix the absolute width of the table
                        tabla_padecimieto.LockedWidth = true;
                        //relative col widths in proportions - 1/3 and 2/3
                        float[] widths3 = new float[] { 6f, 6f };
                        tabla_padecimieto.SetWidths(widths3);

                        PdfPCell celda6 = new PdfPCell(new Phrase("HA RECIBIDO TRATAMIENTO CON"));
                        celda6.BackgroundColor = BaseColor.LIGHT_GRAY;
                        celda6.Colspan = 2;
                        celda6.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        tabla_padecimieto.AddCell(celda6);

                        for (int i = 0; i < info_padecimiento.Count; i++)
                        {
                            tabla_padecimieto.AddCell(info_padecimiento[i].ToString());
                        }
                        document.Add(tabla_padecimieto);
                        document.Add(new Paragraph(" "));

                        //------------------------antecedentes heredo familiares------------------------------

                        ArrayList info_heredo = new ArrayList();

                        //antecedentes heredo familiares
                        if (paciente_anamnesis[0].hipertension_heredo == "")
                        {
                            info_heredo.Add("HIPERTENSIÓN: NO ");
                        }
                        else
                        {
                            info_heredo.Add("HIPERTENSIÓN: " + paciente_anamnesis[0].hipertension_heredo);
                        }
                        //diabetes
                        if (paciente_anamnesis[0].diabetes_heredo == "")
                        {
                            info_heredo.Add("DIABETES: NO ");
                        }
                        else
                        {
                            info_heredo.Add("DIABETES: " + paciente_anamnesis[0].diabetes_heredo);
                        }
                        //cancer
                        if (paciente_anamnesis[0].cancer_heredo == "")
                        {
                            info_heredo.Add("CÁNCER: NO ");
                        }
                        else
                        {
                            info_heredo.Add("CÁNCER: " + paciente_anamnesis[0].cancer_heredo);
                        }
                        //tiroides
                        if (paciente_anamnesis[0].tiroides_heredo == "")
                        {
                            info_heredo.Add("TIROIDES: NO ");
                        }
                        else
                        {
                            info_heredo.Add("TIROIDES: " + paciente_anamnesis[0].tiroides_heredo);
                        }
                        //ASMA
                        if (paciente_anamnesis[0].asma_heredo == "")
                        {
                            info_heredo.Add("ASMA: NO ");
                        }
                        else
                        {
                            info_heredo.Add("ASMA: " + paciente_anamnesis[0].asma_heredo);
                        }
                        //OTROS
                        if (paciente_anamnesis[0].otros_heredo == "")
                        {
                            info_heredo.Add("OTROS: NO ");
                        }
                        else
                        {
                            info_heredo.Add("OTROS: " + paciente_anamnesis[0].otros_heredo);
                        }

                        PdfPTable tabla_heredo = new PdfPTable(2);
                        tabla_heredo.TotalWidth = 550f;
                        //fix the absolute width of the table
                        tabla_heredo.LockedWidth = true;
                        //relative col widths in proportions - 1/3 and 2/3
                        float[] widths4 = new float[] { 6f, 6f };
                        tabla_heredo.SetWidths(widths4);

                        PdfPCell celda7 = new PdfPCell(new Phrase("ANTECEDENTES HEREDOFAMILIARES"));
                        celda7.BackgroundColor = BaseColor.LIGHT_GRAY;
                        celda7.Colspan = 2;
                        celda7.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        tabla_heredo.AddCell(celda7);

                        for (int i = 0; i < info_heredo.Count; i++)
                        {
                            tabla_heredo.AddCell(info_heredo[i].ToString());
                        }
                        //OBSERVACIONES
                        if (paciente_anamnesis[0].observaciones != "")
                        {
                            PdfPCell celda3 = new PdfPCell(new Phrase("OBSERVACIONES: " + paciente_anamnesis[0].observaciones));
                            celda3.Colspan = 2;
                            celda3.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                            tabla_heredo.AddCell(celda3);
                        }

                        document.Add(tabla_heredo);

                        //--------------------examen fisico-----------------------------------
                        ArrayList info_examen_fisico = new ArrayList();

                        //MC
                        if (paciente_expediente[0].motivo_consulta != "")
                        {
                            info_examen_fisico.Add("MOTIVO CONSULTA: " + paciente_expediente[0].motivo_consulta);
                        }
                        //PULSO
                        if (paciente_expediente[0].pulso != "")
                        {
                            info_examen_fisico.Add("PULSO: " + paciente_expediente[0].pulso);
                        }
                        //PRESION ARTERIAL
                        if (paciente_expediente[0].presion_arterial != "")
                        {
                            info_examen_fisico.Add("TENSIÓN ARTERIAL: " + paciente_expediente[0].presion_arterial);
                        }
                        //SOPLOS
                        if ((paciente_expediente[0].soplos != ' ') && (paciente_expediente[0].soplos != 'n'))
                        {
                            if ((paciente_expediente[0].soplos == '\0') && (paciente_expediente[0].soplos != 'n'))
                            {
                                info_examen_fisico.Add("SOPLOS: SI");
                            }
                        }
                        //DOLOR PRECORDIAL
                        if (paciente_expediente[0].dolor_precordial != ' ' && paciente_expediente[0].dolor_precordial != 'n')
                        {
                            info_examen_fisico.Add("DOLOR PRECORDIAL: SI");
                        }
                        //EDEMAS
                        if (paciente_expediente[0].edemas != ' ' && paciente_expediente[0].edemas != 'n')
                        {
                            info_examen_fisico.Add("EDEMAS: SI");
                        }
                        //ARRITMIAS
                        if (paciente_expediente[0].arritmias != ' ' && paciente_expediente[0].arritmias != 'n')
                        {
                            info_examen_fisico.Add("ARRITMIAS: SI");
                        }
                        //DISNEA
                        if (paciente_expediente[0].disnea != ' ' && paciente_expediente[0].disnea != 'n')
                        {
                            info_examen_fisico.Add("DISNEA: SI");
                        }
                        //OBSERVACIONES SC
                        if (paciente_expediente[0].observaciones_sc != "")
                        {
                            info_examen_fisico.Add("OBSERVACIONES: " + paciente_expediente[0].observaciones_sc);
                        }
                        //OBSERVACIONES SC
                        if (paciente_expediente[0].talla != "")
                        {
                            info_examen_fisico.Add("TALLA: " + paciente_expediente[0].talla);
                        }
                        //PESO
                        if (paciente_expediente[0].peso != "")
                        {
                            info_examen_fisico.Add("PESO: " + paciente_expediente[0].peso);
                        }
                        //OBSERVACIONES SM
                        if (paciente_expediente[0].observaciones_sm != "")
                        {
                            info_examen_fisico.Add("OBSERVACIONES: " + paciente_expediente[0].observaciones_sm);
                        }
                        //BRAZO DERECHO
                        if (paciente_expediente[0].brazo_derecho != "")
                        {
                            info_examen_fisico.Add("BRAZO DERECHO: " + paciente_expediente[0].brazo_derecho);
                        }
                        //BRAZO IZQUIERDO
                        if (paciente_expediente[0].brazo_izquierdo != "")
                        {
                            info_examen_fisico.Add("BRAZO IZQUIERDO: " + paciente_expediente[0].brazo_izquierdo);
                        }
                        //PIERNA DERECHA
                        if (paciente_expediente[0].pierna_derecha != "")
                        {
                            info_examen_fisico.Add("PIERNA DERECHA: " + paciente_expediente[0].pierna_derecha);
                        }
                        //PIERNA IZQUIERDA
                        if (paciente_expediente[0].pierna_izquierda != "")
                        {
                            info_examen_fisico.Add("PIERNA DERECHA: " + paciente_expediente[0].pierna_izquierda);
                        }
                        //SATURACION OX
                        if (paciente_expediente[0].saturacion_ox != "")
                        {
                            info_examen_fisico.Add("SATURACIÓN OX: " + paciente_expediente[0].saturacion_ox);
                        }
                        //TEMPERATURA
                        if (paciente_expediente[0].temperatura != "")
                        {
                            info_examen_fisico.Add("TEMPERATURA: " + paciente_expediente[0].temperatura);
                        }
                        //BICIPAL DERECHO
                        if (paciente_expediente[0].bicipal_derecho != ' ' && paciente_expediente[0].bicipal_derecho != 'n')
                        {
                            info_examen_fisico.Add("BICIPAL DERECHO: ANL");
                        }
                        //BICIPAL IZQUIERDO
                        if (paciente_expediente[0].bicipal_izquierdo != ' ' && paciente_expediente[0].bicipal_izquierdo != 'n')
                        {
                            info_examen_fisico.Add("BICIPAL IZQUIERDO: ANL");
                        }
                        //PATELAR DERECHO
                        if (paciente_expediente[0].patelar_derecho != ' ' && paciente_expediente[0].patelar_derecho != 'n')
                        {
                            info_examen_fisico.Add("PATELAR DERECHO: ANL");
                        }
                        //PATELAR IZQUIERDO
                        if (paciente_expediente[0].patelar_izquierdo != ' ' && paciente_expediente[0].patelar_izquierdo != 'n')
                        {
                            info_examen_fisico.Add("PATELAR IZQUIERDO: ANL");
                        }
                        //ALQUILEANO DERECHO
                        if (paciente_expediente[0].alquileano_derecho != ' ' && paciente_expediente[0].alquileano_derecho != 'n')
                        {
                            info_examen_fisico.Add("ALQUILEANO DERECHO: ANL");
                        }
                        //ALQUILEANO IZQ
                        if (paciente_expediente[0].alquileano_izquierdo != ' ' && paciente_expediente[0].alquileano_izquierdo != 'n')
                        {
                            info_examen_fisico.Add("ALQUILEANO IZQUIERDO: ANL");
                        }
                        //FLEXION
                        if (paciente_expediente[0].flexion != ' ' && paciente_expediente[0].flexion != 'n')
                        {
                            info_examen_fisico.Add("FLEXIÓN: ANL");
                        }
                        //ROTACION
                        if (paciente_expediente[0].rotacion != ' ' && paciente_expediente[0].rotacion != 'n')
                        {
                            info_examen_fisico.Add("ROTACIÓN: ANL");
                        }
                        //EXTENSION
                        if (paciente_expediente[0].extensiones != ' ' && paciente_expediente[0].extensiones != 'n')
                        {
                            info_examen_fisico.Add("EXTENSIÓN: ANL");
                        }
                        //INCLINACION LATERAL
                        if (paciente_expediente[0].inclinacion_lateral != ' ' && paciente_expediente[0].inclinacion_lateral != 'n')
                        {
                            info_examen_fisico.Add("INCLINACIÓN LATERAL: ANL");
                        }
                        //OBSERVACIONES CC
                        if (paciente_expediente[0].observaciones_cc != "")
                        {
                            info_examen_fisico.Add("OBSERVACIONES:" + paciente_expediente[0].observaciones_cc);
                        }
                        //MALFORMACIONES
                        if (paciente_expediente[0].malformaciones != "")
                        {
                            info_examen_fisico.Add("MALFORMACIONES:" + paciente_expediente[0].malformaciones);
                        }
                        //OBSERVACIONES ANL
                        if (paciente_expediente[0].observaciones_dl != ' ' && paciente_expediente[0].observaciones_dl != 'n')
                        {
                            info_examen_fisico.Add("OBSERVACIONES: ANL");
                        }

                        //OBSERVACIONES CDL
                        if (paciente_expediente[0].observaciones_dl_txt != "")
                        {
                            info_examen_fisico.Add("OBSERVACIONES:" + paciente_expediente[0].observaciones_dl_txt);
                        }
                        //PETEQUIAS
                        if (paciente_expediente[0].petequias != ' ' && paciente_expediente[0].petequias != 'n')
                        {
                            info_examen_fisico.Add("PETEQUIAS: SI");
                        }
                        //EQUIMOSIS
                        if (paciente_expediente[0].equimosis != ' ' && paciente_expediente[0].equimosis != 'n')
                        {
                            info_examen_fisico.Add("EQUIMOSIS: SI");
                        }
                        //SANGRADO ESPONTANEO
                        if (paciente_expediente[0].sangrado != ' ' && paciente_expediente[0].sangrado != 'n')
                        {
                            info_examen_fisico.Add("SANGRADO: SI");
                        }
                        //OBSERVACIONES
                        if (paciente_expediente[0].observaciones_sh != "")
                        {
                            info_examen_fisico.Add("OBSERVACIONES:" + paciente_expediente[0].observaciones_sh);
                        }
                        //EXAMEN NEUROLOGICO
                        if (paciente_expediente[0].examen_neurologico != "")
                        {
                            info_examen_fisico.Add("EXAMEN NEUROLÓGICO:" + paciente_expediente[0].examen_neurologico);
                        }
                        //ORL
                        if (paciente_expediente[0].orl != "")
                        {
                            info_examen_fisico.Add("ORL:" + paciente_expediente[0].orl);
                        }
                        //ABDOMEN
                        if (paciente_expediente[0].abdomen != "")
                        {
                            info_examen_fisico.Add("ABDOMEN:" + paciente_expediente[0].abdomen);
                        }
                        //AUSCULTACION
                        if (paciente_expediente[0].auscultacion != ' ' && paciente_expediente[0].auscultacion != 'n')
                        {
                            info_examen_fisico.Add("AUSCULTACIÓN: ANL");
                        }
                        //OBSERVACIONES
                        if (paciente_expediente[0].observaciones_sr != "")
                        {
                            info_examen_fisico.Add("OBSERVACIONES:" + paciente_expediente[0].observaciones_sr);
                        }
                        //CONVULCIONES
                        if (paciente_expediente[0].convulciones != ' ' && paciente_expediente[0].convulciones != 'n')
                        {
                            info_examen_fisico.Add("CONVULCIONES: SI");
                        }
                        //ESPASMOS
                        if (paciente_expediente[0].espasmos != ' ' && paciente_expediente[0].espasmos != 'n')
                        {
                            info_examen_fisico.Add("ESPASMOS: SI");
                        }
                        //TEMBLORES
                        if (paciente_expediente[0].temblores != ' ' && paciente_expediente[0].temblores != 'n')
                        {
                            info_examen_fisico.Add("TEMBLORES: SI");
                        }
                        //MOVIMIENTOS ANORMALES
                        if (paciente_expediente[0].movimientos_anormales != ' ' && paciente_expediente[0].movimientos_anormales != 'n')
                        {
                            info_examen_fisico.Add("MOVIMIENTOS ANORMALES: SI");
                        }
                        //MOVIMIENTOS ANORMALES
                        if (paciente_expediente[0].otros_sn != "")
                        {
                            info_examen_fisico.Add("OTROS: " + paciente_expediente[0].otros_sn);
                        }
                        //OBSERVACIONES
                        if (paciente_expediente[0].observaciones_sn != "")
                        {
                            info_examen_fisico.Add("OBSERVACIONES: " + paciente_expediente[0].observaciones_sn);
                        }
                        //OBSERVACIONES
                        if (paciente_expediente[0].otros_examen2 != "")
                        {
                            info_examen_fisico.Add("OTROS: " + paciente_expediente[0].otros_examen2);
                        }

                        if (info_examen_fisico.Count != 0)
                        {
                            PdfPTable tabla_examen_fisico = new PdfPTable(2);
                            tabla_examen_fisico.TotalWidth = 550f;
                            //fix the absolute width of the table
                            tabla_examen_fisico.LockedWidth = true;
                            //relative col widths in proportions - 1/3 and 2/3
                            float[] widths5 = new float[] { 6f, 6f };
                            tabla_examen_fisico.SetWidths(widths5);

                            PdfPCell celda8 = new PdfPCell(new Phrase("EXAMEN FÍSICO"));
                            celda8.BackgroundColor = BaseColor.LIGHT_GRAY;
                            celda8.BackgroundColor = BaseColor.LIGHT_GRAY;
                            celda8.Colspan = 2;
                            celda8.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                            tabla_examen_fisico.AddCell(celda8);

                            if (info_examen_fisico.Count % 2 != 0)
                            {
                                for (int i = 0; i < info_examen_fisico.Count - 1; i++)
                                {
                                    tabla_examen_fisico.AddCell(info_examen_fisico[i].ToString());
                                }
                                PdfPCell celda3 = new PdfPCell(new Phrase(info_examen_fisico[info_examen_fisico.Count - 1].ToString()));
                                celda3.Colspan = 2;
                                celda3.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                tabla_examen_fisico.AddCell(celda3);
                            }
                            else
                            {
                                for (int i = 0; i < info_examen_fisico.Count; i++)
                                {
                                    tabla_examen_fisico.AddCell(info_examen_fisico[i].ToString());
                                }
                            }

                            document.Add(tabla_examen_fisico);
                        }
                        //--------------------------------EPICRISIS-------------------------------------------------
                        PdfPTable tabla_epicrisis = new PdfPTable(1);
                        tabla_epicrisis.TotalWidth = 550f;
                        //fix the absolute width of the table
                        tabla_epicrisis.LockedWidth = true;
                        //relative col widths in proportions - 1/3 and 2/3
                        float[] widths6 = new float[] { 6f };
                        tabla_epicrisis.SetWidths(widths6);

                        PdfPCell celda9 = new PdfPCell(new Phrase("EPICRISIS"));
                        celda9.BackgroundColor = BaseColor.LIGHT_GRAY;
                        celda9.Colspan = 1;
                        celda9.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        tabla_epicrisis.AddCell(celda9);
                        tabla_epicrisis.AddCell("DIAGNÓSTICO: " + paciente_expediente[0].diagnostico.ToUpper());
                        tabla_epicrisis.AddCell("TERAPEUTICA: " + paciente_expediente[0].terapeutica.ToUpper());
                        tabla_epicrisis.AddCell("OBSERVACIONES: " + paciente_expediente[0].observaciones_generales.ToUpper());

                        document.Add(tabla_epicrisis);
                        document.Close();

                        MessageBox.Show("SE HA CREADO EL ARCHIVO\nACCESALO DESDE TU ESCRITORIO", "CREACION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR EN LA CREACION \n COMPRUEBE QUE EL ARCHIVO PDF NO SE ENCUENTRE ABIERTO", "ERROR EN LA CREACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("SELECCIONE UN PACIENTE Y UNA CONSULTA PARA EXPORTAR A PDF", "SELECCION INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UN PACIENTE Y UNA CONSULTA PARA EXPORTAR A PDF", "SELECCION INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void rbCedula_Click(object sender, EventArgs e)
        {
            this.ocultarComponentes();
        }

        private void rbApellido_Click(object sender, EventArgs e)
        {
            this.ocultarComponentes();
        }

        private void rbNombre_Click(object sender, EventArgs e)
        {
            this.ocultarComponentes();
        }


        private void rbEmpresa_Click(object sender, EventArgs e)
        {
            txtBusqueda.Visible = false;
            dtFechaFiltro.Visible = false;
            cbEmpresa.Visible = true;
            cbEmpresa.Location = new Point(131, 114);
            this.dgReconsultas.Rows.Clear();
        }

        private void rbFecha_Click(object sender, EventArgs e)
        {
            txtBusqueda.Visible = false;
            cbEmpresa.Visible = false;
            dtFechaFiltro.Visible = true;
            dtFechaFiltro.Location = new Point(131, 114);
            this.dgReconsultas.Rows.Clear();
        }

        //funciona en el caso de apellido, cedula, nombre y cedula medico
        public void ocultarComponentes()
        {
            dtFechaFiltro.Visible = false;
            cbEmpresa.Visible = false;
            txtBusqueda.Visible = true;
            this.dgReconsultas.Rows.Clear();
        }

        private void cbEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbEmpresa.SelectedValue != null)
            {
                int cedula_empresa = Convert.ToInt32(cbEmpresa.SelectedValue);
                List<PersonaEntity> personas = PersonaIT.selectClienteByIdEmpresa(cedula_empresa);
                if (personas.Count != 0)
                {
                    this.cargarDataGrid(personas);
                }
                else
                {
                    this.cargarDataGrid();
                    MessageBox.Show("NO SE HAN ENCONTRADO RESULTADOS");
                }
            }
        }

        private void dtFechaFiltro_ValueChanged(object sender, EventArgs e)
        {
            List<PersonaEntity> personas = PersonaIT.selectClientePorFecha(dtFechaFiltro.Text);
            if (personas.Count != 0)
            {
                this.cargarDataGrid(personas);
            }
            else
            {
                this.cargarDataGrid();
                MessageBox.Show("NO SE HAN ENCONTRADO RESULTADOS");
            }
        }

        private void btnEditaExpediente_Click(object sender, EventArgs e)
        {
            //nos traemos el id del expediente
            var cell = this.dgReconsultas.SelectedCells[0];
            var row = this.dgReconsultas.Rows[cell.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value);
            string cedula = row.Cells[1].Value.ToString();

            string cedula_medico = ExpedienteDA.getCedulaMedicoByIdCedula(cedula, id);

            if (cedula_medico == Frm_Ingreso.cedulaUsuario)
            {
                //MessageBox.Show("si lo puedes Editar");
                this.Hide();
                frm_ExpedienteMG splash = new frm_ExpedienteMG(cedula, false, false, id, 0);
                //string cedula_paciente, bool editar, bool verExpediente, int id_paciente
                splash.ShowDialog();
                

            }
            else
            {
                MessageBox.Show("NO ERES EL CREADOR DE ESTE EXPEDIENTE PARA PODER EDITARLO", "Seleccion Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}