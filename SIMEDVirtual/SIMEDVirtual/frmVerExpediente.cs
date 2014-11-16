using iTextSharp.text;
using iTextSharp.text.pdf;
using Npgsql;
using SIMEDVirtual.DA;
using SIMEDVirtual.Entity;
using SIMEDVirtual.IT;
using System;
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
            dgReconsultas.Location = new Point(859, 164);
            label3.Location = new Point(856, 143);
            label2.Location = new Point(908, 97);
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

            if (UsuarioIT.TipoUsuario(Frm_Ingreso.cedulaUsuario) == "1")
            {
                this.btnReconsulta.Enabled = false;
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
                frm_ExpedienteMG frm = new frm_ExpedienteMG(prueba, false, false, 0);
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
            //obtngo el id de la row seleccionada
            string cedula_paciente = Convert.ToString(dgReconsultas.Rows[e.RowIndex].Cells[1].Value);
            int id_paciente = Convert.ToInt32(dgReconsultas.Rows[e.RowIndex].Cells[0].Value);

            this.Hide();
            frm_ExpedienteMG frm = new frm_ExpedienteMG(cedula_paciente, false, true, id_paciente);
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
            /* var cell = this.dgClientes.SelectedCells[0];
             var row = this.dgClientes.Rows[cell.RowIndex];
             string cedula = row.Cells[0].Value.ToString();
             MessageBox.Show(cedula);

             //saveFileDialog1.CheckFileExists = true;
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
             {
                 List<PersonaEntity> paciente = PersonaIT.selectClientePorCedula(cedula);
                 List<ExpedienteEntity> paciente_expediente = ExpedienteIT.selectExpediente(cedula);
                 string t = Convert.ToString(paciente_expediente[0].cedula_medico);
                 //me retorna nombre, y apellidos del dr
                 List<PersonaEntity> info_medico = UsuarioIT.getNombreApeDr(Convert.ToString(paciente_expediente[0].cedula_medico));
                 string medico = info_medico[0].nombre + " " + info_medico[0].ape1 + " " + info_medico[0].ape2;


                 try
                 {
                     Document document = new Document(PageSize.LETTER);
                     PdfWriter.GetInstance(document, new FileStream("Expediente_" + paciente[0].nombre + "_" + paciente[0].ape1 + ".pdf", FileMode.OpenOrCreate));
                     document.Open();

                     Paragraph paragraph = new Paragraph(@"EXPEDIENTE MEDICO");
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
                     document.Add(new Paragraph("MEDICO: " + medico + "        FECHA CONSULTA: " + paciente_expediente[0].fecha.ToShortDateString()));
                     document.Add(new Paragraph(" "));
                     Paragraph paragraph1 = new Paragraph("NOMBRE: " + paciente[0].nombre + "        PRIMER APELLIDO: " + paciente[0].ape1 + "      SEGUNDO APELLIDO: " + paciente[0].ape2);
                     paragraph1.Alignment = Element.ALIGN_JUSTIFIED;
                     document.Add(paragraph1);
                     document.Add(new Paragraph(" "));
                     Paragraph paragraph2 = new Paragraph("CEDULA: " + paciente[0].cedula + "        FECHA NACIMIENTO: " + paciente[0].fecha.ToShortDateString() +
                        "      EDAD: " + paciente[0].edad + "     SEXO: " + paciente[0].sexo.ToString().ToUpper());
                     paragraph2.Alignment = Element.ALIGN_JUSTIFIED;
                     document.Add(paragraph2);
                     document.Add(new Paragraph(" "));

                     document.Add(new Paragraph("ESTADO CIVIL: " + paciente[0].estado_civil + "        GRUPO SANGUINEO: " + paciente[0].grupo_sanguineo + "      PROFESION: " + paciente[0].profesion));
                     document.Add(new Paragraph(" "));
                     document.Add(new Paragraph("TELEFONO: " + paciente[0].telefono_fijo + "        MOVIL: " + paciente[0].telefono_movil + "      CORREO: " + paciente[0].email));
                     document.Add(new Paragraph(" "));
                     document.Add(new Paragraph("DIRECCION: " + paciente[0].direccion));
                     document.Add(new Paragraph(" "));
                     document.Add(new Paragraph("________________________________________________________________________________"));
                     document.Add(new Paragraph(" "));
                     document.Add(new Paragraph("MOTIVO CONSULTA: " + paciente_expediente[0].motivo_consulta.ToUpper()));
                     document.Add(new Paragraph(" "));
                     document.Add(new Paragraph("DIAGNOSTICO: " + paciente_expediente[0].diagnostico.ToUpper()));
                     document.Add(new Paragraph(" "));
                     document.Add(new Paragraph("TERAPEUTICA: " + paciente_expediente[0].terapeutica.ToUpper()));
                     document.Add(new Paragraph(" "));
                     document.Add(new Paragraph("OBSERVACIONES: " + paciente_expediente[0].observaciones_generales.ToUpper()));

                     Chunk chunk = new Chunk("Texto subrayado",

                     FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));

                     document.Add(new Paragraph(chunk));
                     document.Close();

                     MessageBox.Show("Se ha creado el archivo");
                 }
                 catch (Exception)
                 {
                     MessageBox.Show("Error en la Creacion");
                 }
             }
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
    }
}