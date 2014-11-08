using Npgsql;
using SIMEDVirtual.DA;
using SIMEDVirtual.Entity;
using SIMEDVirtual.IT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //propiedades del label de division
            label3.AutoSize = false;
            label3.Height = 2;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Width = 1366;

            dgClientes.Columns[0].Width = 200;
            dgClientes.Columns[1].Width = 200;
            dgClientes.Columns[2].Width = 200;
            dgClientes.Columns[3].Width = 200;

            dgReconsultas.Columns[0].Width = 100;
            dgReconsultas.Columns[1].Width = 100;
            dgReconsultas.Columns[2].Width = 180;
            dgReconsultas.Columns[3].Width = 200;
            dgReconsultas.Columns[4].Width = 200;
            dgReconsultas.Columns[5].Width = 200;
            dgReconsultas.Columns[6].Width = 200;
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
                    //.ToString("MM/dd/yyyy")

                    dgReconsultas.Rows[j].Cells[3].Value = PersonaIT.getApellidoMedico(pts.ElementAt(j).cedula_medico.ToString());
                    dgReconsultas.Rows[j].Cells[4].Value = pts.ElementAt(j).diagnostico.ToString();
                    dgReconsultas.Rows[j].Cells[5].Value = pts.ElementAt(j).terapeutica.ToString();
                    dgReconsultas.Rows[j].Cells[6].Value = pts.ElementAt(j).observaciones_generales.ToString();
                }
            }
            else
            {
                MessageBox.Show("seleccion no valida");
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

        //editar un paciente
        //private void btnEditarPaciente_Click(object sender, EventArgs e)
        //{

        //    if (dgClientes.SelectedCells.Count > 0)
        //    {
        //        DataGridViewRow selectedRow = dgClientes.Rows[dgClientes.SelectedCells[0].RowIndex];
        //        string ced = Convert.ToString(selectedRow.Cells["Cedula"].Value);


        //        //////////////////////////////
        //        List<ClienteEntity> lista = ClienteIT.selectClienteAnamnesis(ced);

        //        //informacion personal
        //        string nombre = lista.ElementAt(0).nombre.ToString();
        //        string apellido1 = lista.ElementAt(0).ape1.ToString();
        //        string apellido2 = lista.ElementAt(0).ape2.ToString();
        //        string cedula = lista.ElementAt(0).cedula.ToString();
        //        DateTime fecha = lista.ElementAt(0).fecha;
        //        Char sexo = lista.ElementAt(0).sexo;
        //        string estado_Civil = lista.ElementAt(0).estado_civil.ToString();
        //        string grupo = lista.ElementAt(0).grupo_sanguineo.ToString();
        //        string profesion = lista.ElementAt(0).profesion.ToString(); ;
        //        int telefono = Convert.ToInt32(lista.ElementAt(0).telefono_fijo);
        //        int movil = Convert.ToInt32(lista.ElementAt(0).telefono_movil);
        //        string email = lista.ElementAt(0).email.ToString();
        //        string direccion = lista.ElementAt(0).direccion.ToString();

        //        //anamnesis
        //        char tabaquismo = Convert.ToChar(lista.ElementAt(0).tabaquismo);
        //        char ingesta = Convert.ToChar(lista.ElementAt(0).ingesta_medicamentos);
        //        char alcoholismo = Convert.ToChar(lista.ElementAt(0).alcoholismo);
        //        char rehabilitacion = Convert.ToChar(lista.ElementAt(0).rehabilitacion);
        //        char diabetes = Convert.ToChar(lista.ElementAt(0).diabetes);
        //        string diabetes_trat = Convert.ToString(lista.ElementAt(0).diabetes_trat);
        //        char hipertension = Convert.ToChar(lista.ElementAt(0).hipertension);
        //        string hipertension_trat = Convert.ToString(lista.ElementAt(0).hipertension_trat);
        //        char dolor_cabeza = Convert.ToChar(lista.ElementAt(0).dolor_Cabeza);
        //        char epilepsia = Convert.ToChar(lista.ElementAt(0).epilepsia);
        //        char vertigo = Convert.ToChar(lista.ElementAt(0).vertigo);
        //        char depresion = Convert.ToChar(lista.ElementAt(0).depre);
        //        char falta_aire = Convert.ToChar(lista.ElementAt(0).falta_aire);
        //        char enf_ojos_oidos = Convert.ToChar(lista.ElementAt(0).enf_ojos_oidos);
        //        string observaciones = Convert.ToString(lista.ElementAt(0).observaciones);
        //        this.Hide();

        //        //se le envia toda la informacion al form para llenarlo 
        //        frm_ExpedienteMG frm = new frm_ExpedienteMG(nombre, apellido1, apellido2, cedula, fecha, sexo, estado_Civil, grupo,
        //         profesion, telefono, movil, email, direccion, tabaquismo, ingesta, alcoholismo, rehabilitacion, diabetes, diabetes_trat,
        //         hipertension, hipertension_trat, dolor_cabeza, epilepsia, vertigo, depresion, falta_aire, enf_ojos_oidos, observaciones, true);
        //        //se llama el siguiente form con toda la informacion del paciente

        //        //al editar le quito una tab

        //        frm.ShowDialog();
        //    }
        //}

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ExpedienteMG frm = new frm_ExpedienteMG();
            frm.ShowDialog();
        }

        //con el doble click enla tabla reconsulta muestro el expediente completo
        private void dgReconsultas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtngo el id de la row seleccionada
            string cedula_paciente = Convert.ToString(dgReconsultas.Rows[e.RowIndex].Cells[1].Value);
            int id_paciente = Convert.ToInt32(dgReconsultas.Rows[e.RowIndex].Cells[0].Value);
            //ahora debo hacer un select

            //llamar al otro frm
            this.Hide();
            frm_ExpedienteMG frm = new frm_ExpedienteMG(cedula_paciente, false, true, id_paciente);
            frm.ShowDialog();
        }
        
        //veo la info personal del cliente
        private void dgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtngo el id de la row seleccionada
            string cedula_paciente = Convert.ToString(dgClientes.Rows[e.RowIndex].Cells[0].Value);


            //llamar al otro frm
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
    }
}