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
    public partial class frm_empresa : Form
    {
        public frm_empresa()
        {
            InitializeComponent();
            cargarDataGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_registraEmpresa splash = new frm_registraEmpresa();
            splash.ShowDialog();
        }

        //cargamos las empresas
        private void cargarDataGrid()
        {
            //cargamos todos la info de drs en el datagrid
            var pts = new BindingList<EmpresaEntity>(EmpresaIT.getAllEmpresas());
            dgEmpresas.AutoGenerateColumns = false;
            dgEmpresas.DataSource = pts;
            //agregar el evento 
            //dgEmpresas.CellContentDoubleClick += dgClientes_CellClick;

            //se asignan datos al datagrid

            dgEmpresas.Rows[0].Cells[0].Value = "esto es una prueba";



            //for (int j = 0; j < pts.Count; j++)
            //{
            //    dgEmpresas.Rows[j].Cells[0].Value = pts.ElementAt(j).nombre.ToString();
            //    dgEmpresas.Rows[j].Cells[1].Value = pts.ElementAt(j).cedula.ToString();
            //    dgEmpresas.Rows[j].Cells[2].Value = pts.ElementAt(j).direccion.ToString();

            //    List<EmpresaEntity> empresa = EmpresaIT.getTelefono(pts.ElementAt(j).cedula.ToString());
            //    if (empresa.Count != 0)
            //    {
            //        dgEmpresas.Rows[j].Cells[3].Value = empresa[0].telefono1;
            //    }
            //    else
            //    {
            //        dgEmpresas.Rows[j].Cells[3].Value = "";
            //    }
            //}
        }
    }
}
