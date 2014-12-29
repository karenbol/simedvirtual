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
using System.IO;


namespace SIMEDVirtual
{
    public partial class Frm_Splash : Form
    {
        public Frm_Splash()
        {
            InitializeComponent();
            label2.Text = Frm_Ingreso.datosUsuario[0] +" "+ Frm_Ingreso.datosUsuario[1];
        }

        private void Frm_Splash_Load(object sender, EventArgs e)
        {
            toolTip1.InitialDelay = 1;

            toolTip1.SetToolTip(btnSalir, "Salir del Programa");
            NpgsqlConnection.ClearAllPools();
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
            Frm_Administrativo mem = new Frm_Administrativo();
            mem.ShowDialog();
        }

        private void expedientesMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ExpedienteMG mem = new frm_ExpedienteMG();
            mem.ShowDialog();
        }


        private void Frm_Splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            var x = new Frm_Ingreso();
            this.Hide();
            x.ShowDialog();
        }

        private void expedientesMedicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVerExpediente x = new frmVerExpediente();
            x.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var x = new Frm_Ingreso();
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        private void medicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medico pantalla = new Frm_Medico();
            pantalla.ShowDialog();

        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_empresa pantalla = new frm_empresa();
            pantalla.ShowDialog();
        }
    }
}
