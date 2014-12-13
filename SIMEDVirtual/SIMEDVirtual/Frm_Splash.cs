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

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        string usuarioPublico = "";

        public Frm_Splash()
        {
            InitializeComponent();
            //label1.Text = usuario;
            usuarioPublico = Frm_Ingreso.datosUsuario;
            label2.Text = Frm_Ingreso.datosUsuario;
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
            Frm_Membresia mem = new Frm_Membresia(usuarioPublico);
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

        private void planesEmpresarialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            Frm_Membresia x = new Frm_Membresia(usuarioPublico);
            x.ShowDialog();*/
        }

        private void Frm_Splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Frm_Ingreso frm = new Frm_Ingreso();
            //frm.Close();
            //Application.Exit();

            var x = new Frm_Ingreso();
            this.Hide();
            x.ShowDialog();
            //this.Show();
                       
            
            /*this.Hide();
            Frm_Ingreso x = new Frm_Ingreso();
            x.ShowDialog();*/
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

                       
            
            /*this.Hide();
            Frm_Ingreso pantalla = new Frm_Ingreso();
            pantalla.ShowDialog();*/
        }

        private void medicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medico pantalla = new Frm_Medico();
            pantalla.ShowDialog();
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            frm_Cliente pantalla = new frm_Cliente();
            pantalla.ShowDialog();*/
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_empresa pantalla = new frm_empresa();
            pantalla.ShowDialog();
                    }

        private void administrativosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
