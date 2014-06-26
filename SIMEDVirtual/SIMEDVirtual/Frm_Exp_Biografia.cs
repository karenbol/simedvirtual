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
    public partial class Frm_Exp_Biografia : Form
    {
        public Frm_Exp_Biografia()
        {
            InitializeComponent();
           dateTimePicker1.Value= DateTime.Now;
        }

        private void Frm_Exp_Biografia_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Frm_Splash splash = new Frm_Splash();
            splash.ShowDialog();
        }

        private void Frm_Exp_Biografia_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Anamnesis frm = new Frm_Anamnesis();
            frm.ShowDialog();

        }
    }
}
