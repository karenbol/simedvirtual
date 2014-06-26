using SIMEDVirtual.Entity;
using SIMEDVirtual.IT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMEDVirtual
{
    public partial class Frm_Membresia : Form
    {
        List<EmpresaEntity> x = new List<EmpresaEntity>();
        public Frm_Membresia()
        {
            InitializeComponent();
            x = EmpresaIT.InfoEmpresa();
            comboBox1.DataSource = x;
            comboBox1.DisplayMember = "nombre";


        }

        private void Frm_Membresia_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Frm_Splash splash = new Frm_Splash();
            splash.ShowDialog();

        }

        private void Frm_Membresia_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aqui ocupamps empleados de la empresa selecionada
            int id = EmpresaIT.IdEmpresa(comboBox1.SelectedItem.ToString());
                        
            dataGridView1.DataSource = x;
            for (int j = 0; j < x.Count; j++)
            {
                dataGridView1.Rows[j].Cells[0].Value = x.ElementAt(j).nombre.ToString();
                //dataGridView1.Rows[j].Cells[1].Value = x.ElementAt(j).ap.ToString();
            }


        }

    }
}
