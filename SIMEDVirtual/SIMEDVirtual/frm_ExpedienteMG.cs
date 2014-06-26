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
    public partial class frm_ExpedienteMG : Form
    {
        public frm_ExpedienteMG()
        {
            InitializeComponent();
        }
        private void pbPaciente_Click(object sender, EventArgs e)
        {
            lblPb.Visible = false;
            opFile.Title = "Cargar Foto Médico";
            if (opFile.ShowDialog() == DialogResult.OK)
            {

                string x = opFile.FileName;
                MessageBox.Show(x);
                opFile.Dispose();
                pbPaciente.ImageLocation = x;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Anamnesis_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
