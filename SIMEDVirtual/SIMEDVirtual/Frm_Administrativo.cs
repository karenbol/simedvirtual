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
    public partial class Frm_Administrativo : Form
    {
        public Frm_Administrativo()
        {
            InitializeComponent();
            dgAdministrativos.Columns[0].Width = 170;
            dgAdministrativos.Columns[1].Width = 150;
            dgAdministrativos.Columns[2].Width = 180;
            dgAdministrativos.Columns[3].Width = 180;
            dgAdministrativos.Columns[4].Width = 180;
            dgAdministrativos.Columns[5].Width = 150;
        }

        private void Frm_Administrativo_Load(object sender, EventArgs e)
        {
            this.cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            //cargamos todos la info de drs en el datagrid
            var pts = new BindingList<PersonaEntity>(PersonaIT.selectAdministrativo());
            dgAdministrativos.AutoGenerateColumns = false;
            dgAdministrativos.DataSource = pts;
            //agregar el evento 
            //dgAdministrativos.CellContentDoubleClick += dgAdministrativos_CellDoubleClick;

            //se asignan datos al datagrid
            for (int j = 0; j < pts.Count; j++)
            {
                dgAdministrativos.Rows[j].Cells[0].Value = pts.ElementAt(j).cedula.ToString();
                dgAdministrativos.Rows[j].Cells[1].Value = pts.ElementAt(j).ape1.ToString();
                dgAdministrativos.Rows[j].Cells[2].Value = pts.ElementAt(j).ape2.ToString();
                dgAdministrativos.Rows[j].Cells[3].Value = pts.ElementAt(j).nombre.ToString();
                dgAdministrativos.Rows[j].Cells[4].Value = pts.ElementAt(j).profesion.ToString();
                dgAdministrativos.Rows[j].Cells[5].Value = pts.ElementAt(j).email.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Registro_Secretaria x = new Frm_Registro_Secretaria();
            x.ShowDialog();
        }

        private void Frm_Administrativo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Frm_Splash x = new Frm_Splash();
            x.ShowDialog();

        }
    }
}
