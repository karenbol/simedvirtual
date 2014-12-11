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
            int indice= cbSexo.SelectedIndex;
            if (indice==0)
            {
                sexo = 'f';
            }

            if (AdministrativoIT.InsertaAdm(txtApellido1.Text, txtApellido1.Text, txtApellido2.Text,
               Convert.ToInt32(txtCedula.Text), txtDireccion.Text,sexo,
                txtPuesto.Text, Convert.ToDateTime(dtfecha.Text)))
            {
                MessageBox.Show("Se ha insertado un administrativo");
            }
        }

        private void Frm_Registro_Secretaria_Load(object sender, EventArgs e)
        {
            cbSexo.SelectedIndex = 1;
        }

        private void dtfecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNac = dtfecha.Value;

            TimeSpan dias = DateTime.Now - dtfecha.Value;
            txtEdad.Text = this.direfenciaFechas(fechaNac, DateTime.Now);
        }

        //calcula edad (anios, meses,dias) basado en la fecha de nacimiento
        public string direfenciaFechas(DateTime New, DateTime old)
        {
            int anios = New.Year - old.Year;
            int meses = New.Month - old.Month;
            int dias = New.Day - old.Day;

            string respuesta = Math.Abs(anios) + " Años " + Math.Abs(meses) + " Meses " + Math.Abs(dias) + " Dias";
            return respuesta;
        }
    }
}
