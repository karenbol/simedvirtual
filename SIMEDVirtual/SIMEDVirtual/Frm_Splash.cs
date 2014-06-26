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

        public Frm_Splash()
        {
            InitializeComponent();
        }

        private void Frm_Splash_Load(object sender, EventArgs e)
        {

        }

        private void membresiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Membresia mem = new Frm_Membresia();
            mem.ShowDialog();

        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medico mem = new Frm_Medico();
            mem.ShowDialog();

        }

        private void secretariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Registro_Secretaria mem = new Frm_Registro_Secretaria();
            mem.ShowDialog();
        }

        private void expedientesMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Exp_Biografia mem = new Frm_Exp_Biografia();
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
            Frm_Membresia x = new Frm_Membresia();
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
    }
}
