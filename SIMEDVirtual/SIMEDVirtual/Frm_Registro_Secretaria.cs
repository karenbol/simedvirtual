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
    public partial class Frm_Registro_Secretaria : Form
    {
        string usuarioPublico = "";
        public Frm_Registro_Secretaria(string usuario)
        {
            InitializeComponent();
            usuarioPublico = usuario;
        }

        private void Frm_Registro_Secretaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Frm_Splash splash = new Frm_Splash();
            splash.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Char sexo='m';
            int indice= comboBox1.SelectedIndex;
            if (indice==0)
            {
                sexo = 'f';
            }

            if (AdministrativoIT.InsertaAdm(txtNombre.Text, txtApe1.Text, txtApe2.Text,
               Convert.ToInt32(txtcedula.Text), txtDireccion.Text,sexo,
                txtPuesto.Text, Convert.ToDateTime(dtfecha.Text)))
            {
                MessageBox.Show("Se ha insertado un administrativo");
            }
        }

        private void Frm_Registro_Secretaria_Load(object sender, EventArgs e)
        {

        }


    }
}
