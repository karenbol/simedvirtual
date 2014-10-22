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


        // 1 ver 2 editar
        public frm_registraEmpresa(string cedula_juridica, string nombre, string descripcion, string direccion, int telefono1,
              string encargado1, int telefono2, string encargado2, int accion)
        {
            InitializeComponent();

            txtCedula_Juridica.Text = cedula_juridica;
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtDireccion.Text = direccion;
            txtTelefono1.Text = telefono1.ToString();
            txtEncargado1.Text = encargado1;
            txtTelefono2.Text = telefono2.ToString();
            txtEncargado2.Text = encargado2;

            //ver
            if (accion == 1)
            {
                lblTitle.Text = "VER EMPRESAS";
                panel2.Enabled = false;
                btnGuardar.Visible = false;
            }
            else if (accion == 2)
            {
                txtCedula_Juridica.Enabled = false;
            }
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
                    frm_empresa splash = new frm_empresa();
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

        private void frm_registraEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_empresa splash = new frm_empresa();
            splash.ShowDialog();
        }
    }
}
