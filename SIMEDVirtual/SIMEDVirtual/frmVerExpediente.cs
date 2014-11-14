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
        }

        private void frmVerExpediente_Load(object sender, EventArgs e)
        {
            //llena la tabla con los clientes
            this.cargarDataGrid();

            toolTip1.InitialDelay = 1;

            toolTip1.SetToolTip(btnCrearPaciente, "Crea Nuevo Paciente");
            toolTip1.SetToolTip(btnEditarPaciente, "Edita Informacion del Paciente");
            toolTip1.SetToolTip(btnReconsulta, "Crea una Reconsulta del Paciente");

            if (UsuarioIT.TipoUsuario(Frm_Ingreso.cedulaUsuario) == "1")
            {
                this.btnReconsulta.Enabled = false;
                //MessageBox.Show("No eres medico para crear un expediente", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            }
        }

        private void generarPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aqui genero el pdf
            Document document = new Document(PageSize.LETTER);

            PdfWriter.GetInstance(document,

                          new FileStream("karen.pdf",

                                 FileMode.OpenOrCreate));
            document.Open();
            //iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"C:\SIMEDVirtual\SIMEDVirtual\SIMEDVirtual\bin\Debug\logo.jpg");
            //jpg.ScaleAbsolute(50, 50);
            //jpg.Alignment = iTextSharp.text.Image.ALIGN_LEFT;
            //jpg.ScaleToFit(100f, 100f);
            //jpg.Alt = "Simed Logo";

            
            Paragraph paragraph = new Paragraph(@"EXPEDIENTE MEDICO");
            paragraph.Alignment = Element.ALIGN_CENTER;
                       iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"C:\SIMEDVirtual\SIMEDVirtual\SIMEDVirtual\bin\Debug\logo.jpg");
            jpg.ScaleToFit(100f, 100f);
            jpg.Alignment = iTextSharp.text.Image.TEXTWRAP | iTextSharp.text.Image.ALIGN_LEFT;
            //jpg.IndentationLeft = 9f;
            //jpg.SpacingAfter = 9f;
           
            document.Add(jpg);
            document.Add(paragraph);


            //document.Add(jpg);
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph("________________________________________________________________________________"));

            document.Add(new Paragraph("Este es mi primer PDF al vuelo"));
            document.Add(new Paragraph("Este es mi seertgbdsfgdfhgundo PDF al vuelo"));
            //document.NewPage();

            Chunk chunk = new Chunk("Texto subrayado",

             FontFactory.GetFont("ARIAL",

                         12,

                     iTextSharp.text.Font.UNDERLINE));

            document.Add(new Paragraph(chunk));
            document.Close();

            MessageBox.Show("Se ha creado el archivo");
        }
    }
}