using SIMEDVirtual.IT;
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
    public partial class frm_registraEmpresa : Form
    {
        public frm_registraEmpresa()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text != string.Empty && txtCedula_Juridica.Text != string.Empty && txtDireccion.Text != string.Empty && txtDescripcion.Text != string.Empty)
            {
                if ((EmpresaIT.InsertaEmpresa(txtNombre.Text, txtCedula_Juridica.Text, txtDireccion.Text, txtDescripcion.Text)))
                {
                    if (txtTelefono1.Text != string.Empty && txtEncargado1.Text != string.Empty)
                    {
                        EmpresaIT.InsertaEmpresaTelefono(txtCedula_Juridica.Text, Convert.ToInt32(txtTelefono1.Text), txtEncargado1.Text);
                    }

                    if (txtTelefono2.Text != string.Empty && txtEncargado2.Text != string.Empty)
                    {
                        EmpresaIT.InsertaEmpresaTelefono(txtCedula_Juridica.Text, Convert.ToInt32(txtTelefono2.Text), txtEncargado2.Text);
                    }


                    MessageBox.Show("La Empresa se ha Insertado con Exito", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    Frm_Splash splash = new Frm_Splash();
                    splash.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se ha podido insertar La Empresa", "Error al Insertar", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
            else
            {
                MessageBox.Show("Algunos Campos estan Vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frm_registraEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
