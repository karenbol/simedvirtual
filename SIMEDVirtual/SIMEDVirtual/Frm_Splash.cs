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
            Frm_Registro_Secretaria mem = new Frm_Registro_Secretaria(usuarioPublico);
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
            this.Hide();
            Frm_Membresia x = new Frm_Membresia(usuarioPublico);
            x.ShowDialog();
        }

        private void Frm_Splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Frm_Ingreso frm = new Frm_Ingreso();
            //frm.Close();
            //Application.Exit();
            this.Hide();
            Frm_Ingreso x = new Frm_Ingreso();
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
            this.Hide();
            Frm_Ingreso pantalla = new Frm_Ingreso();
            pantalla.ShowDialog();
        }

        private void medicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medico pantalla = new Frm_Medico();
            pantalla.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Cliente pantalla = new frm_Cliente();
            pantalla.ShowDialog();
        }



        public void SaveProduct(string productName, string productImageFilePath)
        {
            using (NpgsqlConnection pgConnection = new NpgsqlConnection("server=192.168.2.103;user id=postgres;password=123;database=simedvirtual"))
            {
                try
                {
                    using (FileStream pgFileStream = new FileStream(productImageFilePath, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader pgReader = new BinaryReader(new BufferedStream(pgFileStream)))
                        {
                            byte[] pgByteA = pgReader.ReadBytes(Convert.ToInt32(pgFileStream.Length));
                            using (NpgsqlCommand pgCommand = new NpgsqlCommand("INSERT INTO fotos(product_name, product_image) SELECT @ProductName, @ProductImage", pgConnection))
                            {
                                pgCommand.Parameters.AddWithValue("@ProductName", productName);
                                pgCommand.Parameters.AddWithValue("@ProductImage", pgByteA);
                                try
                                {
                                    pgConnection.Open();
                                    pgCommand.ExecuteNonQuery();
                                }
                                catch
                                {
                                    throw;
                                }
                            }
                        }
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
