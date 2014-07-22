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
    
        string prueba="";
        public frmVerExpediente()
        {
            InitializeComponent();
            label3.AutoSize = false;
            label3.Height = 2;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Width = 850;
        }

        private void frmVerExpediente_Load(object sender, EventArgs e)
        {
            this.cargarDataGrid();
        }
        //cargamos los clientes
        private void cargarDataGrid()
        {
            //cargamos todos la info de drs en el datagrid
            var pts = new BindingList<ClienteEntity>(ClienteIT.selectCliente());
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
                prueba=cedula;
                dgReconsultas.DataSource = ExpedienteIT.selectExpediente(cedula);
            }
        }

        private void frmVerExpediente_FormClosing(object sender, FormClosingEventArgs e)
        {
        }



        private void btnReconsulta_Click(object sender, EventArgs e)
        {
            

            List<ClienteEntity> lista = ClienteIT.selectClienteAnamnesis(prueba);

            //informacion personal
            string nombre = lista.ElementAt(0).nombre.ToString();
            string apellido1 = lista.ElementAt(0).ape1.ToString();
            string apellido2 = lista.ElementAt(0).ape2.ToString();
            string cedula = lista.ElementAt(0).cedula.ToString();
            DateTime fecha = lista.ElementAt(0).fecha;
            Char sexo = lista.ElementAt(0).sexo;
            string estado_Civil = lista.ElementAt(0).estado_civil.ToString();
            string grupo = lista.ElementAt(0).grupo_sanguineo.ToString();
            string profesion = lista.ElementAt(0).profesion.ToString(); ;
            int telefono = Convert.ToInt32(lista.ElementAt(0).telefono_fijo);
            int movil = Convert.ToInt32(lista.ElementAt(0).telefono_movil);
            string email = lista.ElementAt(0).email.ToString();
            string direccion = lista.ElementAt(0).direccion.ToString();

            //anamnesis
            char tabaquismo= Convert.ToChar(lista.ElementAt(0).tabaquismo);
            char ingesta = Convert.ToChar(lista.ElementAt(0).ingesta_medicamentos);
            char alcoholismo = Convert.ToChar(lista.ElementAt(0).alcoholismo);
            char rehabilitacion = Convert.ToChar(lista.ElementAt(0).rehabilitacion);
            char diabetes = Convert.ToChar(lista.ElementAt(0).diabetes);
            string diabetes_trat = Convert.ToString(lista.ElementAt(0).diabetes_trat);
            char hipertension = Convert.ToChar(lista.ElementAt(0).hipertension);
            string hipertension_trat = Convert.ToString(lista.ElementAt(0).hipertension_trat);
            char dolor_cabeza = Convert.ToChar(lista.ElementAt(0).dolor_cabeza);
            char epilepsia = Convert.ToChar(lista.ElementAt(0).epilepsia);
            char vertigo = Convert.ToChar(lista.ElementAt(0).vertigo);
            char depresion = Convert.ToChar(lista.ElementAt(0).depre);
            char falta_aire = Convert.ToChar(lista.ElementAt(0).falta_aire);
            char enf_ojos_oidos = Convert.ToChar(lista.ElementAt(0).enf_ojos_oidos);
            string observaciones = Convert.ToString(lista.ElementAt(0).observaciones);
            this.Hide();

            frm_ExpedienteMG frm = new frm_ExpedienteMG(nombre,apellido1, apellido2,cedula, fecha, sexo, estado_Civil,grupo,
             profesion,telefono,movil,email,direccion,tabaquismo,ingesta,alcoholismo,rehabilitacion,diabetes,diabetes_trat,
             hipertension,hipertension_trat,dolor_cabeza,epilepsia,vertigo,depresion,falta_aire,enf_ojos_oidos,observaciones);

            frm.ShowDialog();
        }
    }
}
