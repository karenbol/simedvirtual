using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Configuration;
using SIMEDVirtual.Entity;
using SIMEDVirtual.DA;


namespace SIMEDVirtual
{
    public partial class Frm_Splash : Form
    {

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        string usuarioPublico = "";

        public Frm_Splash(string usuario)
        {
            InitializeComponent();
            //label1.Text = usuario;
            usuarioPublico = usuario;
            label2.Text = usuario;
        }

        private void Frm_Splash_Load(object sender, EventArgs e)
        {

        }

        private void membresiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Membresia mem = new Frm_Membresia(usuarioPublico);
            mem.ShowDialog();

        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medico mem = new Frm_Medico(usuarioPublico);
            mem.ShowDialog();

        }

        private void secretariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Registro_Secretaria mem = new Frm_Registro_Secretaria(usuarioPublico);
            mem.ShowDialog();
        }

        private void expedientesMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ExpedienteMG mem = new frm_ExpedienteMG(usuarioPublico);
            mem.ShowDialog();

        }

        private void Frm_Splash_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void planesEmpresarialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Membresia x = new Frm_Membresia(usuarioPublico);
            x.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Ingreso frm = new Frm_Ingreso();
            frm.Close();
            Application.Exit();
        }

        private void expedientesMedicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVerExpediente x = new frmVerExpediente(usuarioPublico);
            x.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Ingreso pantalla = new Frm_Ingreso();
            pantalla.ShowDialog();
        }
    }
}
