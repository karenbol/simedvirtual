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
                cbEmpresa.ValueMember = "cedula";
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
            var cell = this.dgClientes.SelectedCells[0];
            var row = this.dgClientes.Rows[cell.RowIndex];
            string cedula = row.Cells[0].Value.ToString();
            /*saveFileDialog1.CheckFileExists = true;
           saveFileDialog1.CheckPathExists = true;
           saveFileDialog1.Filter = "Archivos pdf (*.pdf)|*.pdf";
           saveFileDialog1.FileName = "prueba";
           saveFileDialog1.InitialDirectory = @"C:\";

           if (saveFileDialog1.ShowDialog() == DialogResult.OK)
           {
               saveFileDialog1.
                
                
               string ruta = saveFileDialog1.FileName;

           }
                       if (cedula != string.Empty)
           {*/

            List<PersonaEntity> paciente = PersonaIT.selectClientePorCedula(cedula);
            List<ExpedienteEntity> paciente_expediente = ExpedienteIT.selectExpediente(cedula);
            List<anamnesis> paciente_anamnesis = anamnesisIT.selectAnamnesisPorCedula(cedula);
            string t = Convert.ToString(paciente_expediente[0].cedula_medico);
            //me retorna nombre, y apellidos del dr
            List<PersonaEntity> info_medico = UsuarioIT.getNombreApeDr(Convert.ToString(paciente_expediente[0].cedula_medico));
            string medico = info_medico[0].nombre + " " + info_medico[0].ape1 + " " + info_medico[0].ape2;


            try
            {
                Document document = new Document(PageSize.LETTER);
                PdfWriter.GetInstance(document, new FileStream("Expediente_" + paciente[0].nombre + "_" + paciente[0].ape1 + ".pdf", FileMode.OpenOrCreate));
                document.Open();

                Paragraph paragraph = new Paragraph(@"EXPEDIENTE MÉDICO");
                paragraph.IndentationLeft = 120;
                iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"C:\SIMEDVirtual\SIMEDVirtual\SIMEDVirtual\bin\Debug\logo.jpg");
                jpg.ScaleToFit(100f, 100f);
                jpg.Alignment = iTextSharp.text.Image.TEXTWRAP | iTextSharp.text.Image.ALIGN_LEFT;
                document.Add(jpg);
                document.Add(paragraph);
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph("_________________________INFORMACION PERSONAL_______________________________"));
                document.Add(new Paragraph(" "));

                Chunk chunk1 = new Chunk("MÉDICO: ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                Chunk chunk2 = new Chunk(medico + "                             ");

                Chunk chunk3 = new Chunk("FECHA CONSULTA: ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                Chunk chunk4 = new Chunk(paciente_expediente[0].fecha.ToShortDateString());

                Phrase phr1 = new Phrase();
                phr1.Add(chunk1);
                phr1.Add(chunk2);
                phr1.Add(chunk3);
                phr1.Add(chunk4);
                document.Add(phr1);

                document.Add(new Paragraph(" "));

                Chunk chunk5 = new Chunk("NOMBRE: ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                Chunk chunk6 = new Chunk(paciente[0].nombre + " " + paciente[0].ape1 + " " + paciente[0].ape2 + "                            ");
                Chunk chunk7 = new Chunk("CÉDULA: ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                Chunk chunk8 = new Chunk(paciente[0].cedula);
                Phrase phr2 = new Phrase();
                phr2.Add(chunk5);
                phr2.Add(chunk6);
                phr2.Add(chunk7);
                phr2.Add(chunk8);
                document.Add(phr2);
                document.Add(new Paragraph(" "));

                Chunk chunk9 = new Chunk("FECHA NACIMIENTO: ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                Chunk chunk10 = new Chunk(paciente[0].fecha.ToShortDateString() + "                     ");
                Chunk chunk11 = new Chunk("EDAD: ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                Chunk chunk12 = new Chunk(paciente[0].edad + "              ");
                Chunk chunk13 = new Chunk(" SEXO: ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                Chunk chunk14 = new Chunk(paciente[0].sexo.ToString().ToUpper() + "");

                Phrase phr3 = new Phrase();
                phr3.Add(chunk9);
                phr3.Add(chunk10);
                phr3.Add(chunk11);
                phr3.Add(chunk12);
                phr3.Add(chunk13);
                phr3.Add(chunk14);
                document.Add(phr3);
                document.Add(new Paragraph(" "));

                Chunk chunk15 = new Chunk("ESTADO CIVIL: ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                Chunk chunk16 = new Chunk(paciente[0].estado_civil + "                     ");
                Chunk chunk17 = new Chunk("PROFESIÓN: ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                Chunk chunk18 = new Chunk(paciente[0].profesion + "                     ");
                Phrase phr4 = new Phrase();
                phr4.Add(chunk15);
                phr4.Add(chunk16);
                phr4.Add(chunk17);
                phr4.Add(chunk18);
                document.Add(phr4);
                document.Add(new Paragraph(" "));


                Chunk chunk19 = new Chunk("TELÉFONO: ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                Chunk chunk20 = new Chunk(paciente[0].telefono_fijo + "                     ");
                Chunk chunk21 = new Chunk("MÓVIL: ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                Chunk chunk22 = new Chunk(paciente[0].telefono_movil + "                     ");
                Chunk chunk23 = new Chunk("CORREO: ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                Chunk chunk24 = new Chunk(paciente[0].email);
                Phrase phr5 = new Phrase();
                phr5.Add(chunk19);
                phr5.Add(chunk20);
                phr5.Add(chunk21);
                phr5.Add(chunk22);
                phr5.Add(chunk23);
                phr5.Add(chunk24);
                document.Add(phr5);
                document.Add(new Paragraph(" "));

                Chunk chunk25 = new Chunk("DIRECCIÓN: ", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));
                Chunk chunk26 = new Chunk(paciente[0].direccion);
                Phrase phr6 = new Phrase();
                phr6.Add(chunk25);
                phr6.Add(chunk26);
                document.Add(phr6);
                document.Add(new Paragraph("________________________________________________________________________________"));
                document.Add(new Paragraph(" "));

                ArrayList info = new ArrayList();

                //tabaquismo
                if (paciente_anamnesis[0].tabaquismo == '\0' || paciente_anamnesis[0].tabaquismo == 'n')
                {
                    info.Add("TABAQUISMO: NO ");
                    //document.Add(new Paragraph());
                }
                else
                {
                    info.Add("TABAQUISMO: SI ");
                    //document.Add(new Paragraph("TABAQUISMO: SI "));
                }

                //----------------------------------------------ANAMNESIS----------------------------------------------------------------
                //INGESTA MEDICAMENTOS
                if (paciente_anamnesis[0].ingesta_medicamentos == '\0' || paciente_anamnesis[0].ingesta_medicamentos == 'n')
                {
                    info.Add("INGESTA MEDICAMENTOS: NO ");
                    //document.Add(new Paragraph("INGESTA MEDICAMENTOS: NO "));
                }
                else
                {
                    info.Add("INGESTA MEDICAMENTOS: SI ");
                    //document.Add(new Paragraph("INGESTA MEDICAMENTOS: SI "));
                }

                //ALCOHOLISMO ACTUAL O PREVIO
                if (paciente_anamnesis[0].alcoholismo == '\0' || paciente_anamnesis[0].alcoholismo == 'n')
                {
                    info.Add("ALCOHOLISMO: NO ");
                    // document.Add(new Paragraph("ALCOHOLISMO: NO "));
                }
                else
                {
                    info.Add("ALCOHOLISMO: SI ");
                    //document.Add(new Paragraph("ALCOHOLISMO: SI "));
                }
                //rehabilitacion fisica o mental
                if (paciente_anamnesis[0].rehabilitacion == '\0' || paciente_anamnesis[0].rehabilitacion == 'n')
                {
                    info.Add("REHABILITACION: NO ");
                    //document.Add(new Paragraph("REHABILITACION: NO "));
                }
                else
                {
                    info.Add("REHABILITACION: SI ");
                    // document.Add(new Paragraph("REHABILITACION: SI "));
                }
                //alergia a medicamentos
                if (paciente_anamnesis[0].alergias == 's')
                {
                    info.Add("ALERGICO A MEDICAMENTOS: " + paciente_anamnesis[0].alergias_tratamiento);
                    //document.Add(new Paragraph("ALERGICO A MEDICAMENTOS: " + paciente_anamnesis[0].alergias_tratamiento));
                }

                PdfPTable table = new PdfPTable(2);
                PdfPCell celda = new PdfPCell(new Phrase("ANTECEDENTES PATOLOGICOS Y NO PATOLOGICOS"));
                celda.Colspan = 2;
                celda.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                table.AddCell(celda);
                table.AddCell(info[0].ToString());
                table.AddCell(info[1].ToString());
                table.AddCell(info[2].ToString());
                table.AddCell(info[3].ToString());
                document.Add(table);
                document.Add(new Paragraph(" "));



                ArrayList info2 = new ArrayList();
                ///////////////////////////////////////////////////////////////////////////////////////////////
                //diabetes

                if (paciente_anamnesis[0].diabetes == '\0' || paciente_anamnesis[0].diabetes == 'n')
                {
                    info2.Add("DIABETES: NO ");
                    //document.Add(new Paragraph("DIABETES: NO "));
                }
                else
                {
                    info2.Add("DIABETES: SI   TRATAMIENTO: " + paciente_anamnesis[0].diabetes_trat);
                    //document.Add(new Paragraph("DIABETES: SI   TRATAMIENTO: " + paciente_anamnesis[0].diabetes_trat));
                }

                //hipertension
                if (paciente_anamnesis[0].hipertension == '\0' || paciente_anamnesis[0].hipertension == 'n')
                {
                    info2.Add("HIPERTENSION: NO ");
                    // document.Add(new Paragraph("HIPERTENSION: NO "));
                }
                else
                {
                    info2.Add("HIPERTENSION: SI   TRATAMIENTO: " + paciente_anamnesis[0].hipertension_trat);
                    //document.Add(new Paragraph("HIPERTENSION: SI   TRATAMIENTO: " + paciente_anamnesis[0].hipertension_trat));
                }

                //asma
                if (paciente_anamnesis[0].asma == '\0' || paciente_anamnesis[0].asma == 'n')
                {
                    info2.Add("ASMA: NO ");
                    //document.Add(new Paragraph("ASMA: NO "));
                }
                else
                {
                    info2.Add("ASMA: SI   TRATAMIENTO: " + paciente_anamnesis[0].alergias_tratamiento);
                    //document.Add(new Paragraph("ASMA: SI   TRATAMIENTO: " + paciente_anamnesis[0].alergias_tratamiento));
                }
                //tiroides
                if (paciente_anamnesis[0].tiroides == '\0' || paciente_anamnesis[0].tiroides == 'n')
                {
                    info2.Add("TIROIDES: NO ");
                    //document.Add(new Paragraph("TIROIDES: NO "));
                }
                else
                {
                    info2.Add("TIROIDES: SI   TRATAMIENTO: " + paciente_anamnesis[0].tiroides_tratamiento);
                    //document.Add(new Paragraph("TIROIDES: SI   TRATAMIENTO: " + paciente_anamnesis[0].tiroides_tratamiento));
                }
                //antecedentes heredo familiares
                if (paciente_anamnesis[0].hipertension_heredo == "")
                {
                    info2.Add("HIPERTENSION: NO ");
                    //document.Add(new Paragraph("HIPERTENSION: NO "));
                }
                else
                {
                    info2.Add("HIPERTENSION: " + paciente_anamnesis[0].hipertension_heredo);
                    //document.Add(new Paragraph("HIPERTENSION: " + paciente_anamnesis[0].hipertension_heredo));
                }
                //diabetes
                if (paciente_anamnesis[0].diabetes_heredo == "")
                {
                    info2.Add("DIABETES: NO ");
                    //document.Add(new Paragraph("DIABETES: NO "));
                }
                else
                {
                    info2.Add("DIABETES: " + paciente_anamnesis[0].diabetes_heredo);
                    //document.Add(new Paragraph("DIABETES: " + paciente_anamnesis[0].diabetes_heredo));
                }
                //cancer
                if (paciente_anamnesis[0].cancer_heredo == "")
                {
                    info2.Add("CANCER: NO ");
                    //document.Add(new Paragraph("CANCER: NO "));
                }
                else
                {
                    info2.Add("CANCER: " + paciente_anamnesis[0].cancer_heredo);
                    // document.Add(new Paragraph("CANCER: " + paciente_anamnesis[0].cancer_heredo));
                }
                //tiroides
                if (paciente_anamnesis[0].tiroides_heredo == "")
                {
                    info2.Add("TIROIDES: NO ");
                    // document.Add(new Paragraph("TIROIDES: NO "));
                }
                else
                {
                    info2.Add("TIROIDES: " + paciente_anamnesis[0].tiroides_heredo);
                    //document.Add(new Paragraph("TIROIDES: " + paciente_anamnesis[0].tiroides_heredo));
                }
                //ASMA
                if (paciente_anamnesis[0].asma_heredo == "")
                {
                    info2.Add("ASMA: NO ");
                    // document.Add(new Paragraph("ASMA: NO "));
                }
                else
                {
                    info2.Add("ASMA: " + paciente_anamnesis[0].asma_heredo);
                    // document.Add(new Paragraph("ASMA: " + paciente_anamnesis[0].asma_heredo));
                }
                //OTROS
                if (paciente_anamnesis[0].otros_heredo == "")
                {
                    info2.Add("OTROS: NO ");
                    //document.Add(new Paragraph("OTROS: NO "));
                }
                else
                {
                    info2.Add("OTROS: " + paciente_anamnesis[0].otros_heredo);
                    //document.Add(new Paragraph("OTROS: " + paciente_anamnesis[0].otros_heredo));
                }
                //OBSERVACIONES
                if (paciente_anamnesis[0].observaciones != "")
                {
                    info2.Add("OBSERVACIONES: " + paciente_anamnesis[0].observaciones);
                    //document.Add(new Paragraph("OBSERVACIONES: " + paciente_anamnesis[0].observaciones));
                }


                PdfPTable table2 = new PdfPTable(2);
                PdfPCell celda2 = new PdfPCell(new Phrase(""));
                celda2.Colspan = 2;
                celda2.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                table2.AddCell(celda2);

                for (int i = 0; i < info2.Count; i++)
                {
                    table2.AddCell(info2[i].ToString());
                }

                document.Add(table2);

                document.Add(new Paragraph("MOTIVO CONSULTA: " + paciente_expediente[0].motivo_consulta.ToUpper()));
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph("DIAGNÓSTICO: " + paciente_expediente[0].diagnostico.ToUpper()));
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph("TERAPEUTICA: " + paciente_expediente[0].terapeutica.ToUpper()));
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph("OBSERVACIONES: " + paciente_expediente[0].observaciones_generales.ToUpper()));

                Chunk chunk = new Chunk("Texto subrayado", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));

                document.Close();

                MessageBox.Show("Se ha creado el archivo");
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la Creacion");
            }
            /*}
            else
            {
                MessageBox.Show("SELECCION NO VALIDA");
            }*/
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
        }

        private void rbFecha_Click(object sender, EventArgs e)
        {
            txtBusqueda.Visible = false;
            cbEmpresa.Visible = false;
            dtFechaFiltro.Visible = true;
            dtFechaFiltro.Location = new Point(131, 114);
        }

        //funciona en el caso de apellido, cedula, nombre y cedula medico
        public void ocultarComponentes()
        {
            dtFechaFiltro.Visible = false;
            cbEmpresa.Visible = false;
            txtBusqueda.Visible = true;
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
    }
}