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
        public int accion_ejecutar = 0;

        public frm_registraEmpresa()
        {
            InitializeComponent();
            btnEliminar1.Visible = false;
            btnEliminar2.Visible = false;
            
            
        }


        // 1 ver 2 editar
        public frm_registraEmpresa(string cedula_juridica, string nombre, string descripcion, string direccion, int telefono1,
              string encargado1, int telefono2, string encargado2, int accion)
        {
            InitializeComponent();
            
            btnEliminar1.Visible = false;
            btnEliminar2.Visible = false;

            accion_ejecutar = accion;
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

                if (telefono1 != 0 && encargado1 != "")
                {
                    btnEliminar1.Visible = true;
                }

                if (telefono2 != 0 && encargado2 != "")
                {
                    btnEliminar2.Visible = true;
                }
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty && txtCedula_Juridica.Text != string.Empty && txtDireccion.Text != string.Empty && txtDescripcion.Text != string.Empty)
            {
                //si vamos a ver
                //0 insertar, 2 editar
                if (accion_ejecutar == 0)
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
                else if (accion_ejecutar == 2)
                //editar
                {
                    if ((EmpresaIT.updateEmpresa(txtCedula_Juridica.Text, txtNombre.Text, txtDireccion.Text, txtDescripcion.Text)))
                    {

                        if (txtTelefono1.Text != string.Empty && txtEncargado1.Text != string.Empty)
                        {
                            EmpresaIT.updateTelefono(txtCedula_Juridica.Text, Convert.ToInt32(txtTelefono1.Text), txtEncargado1.Text);
                        }

                        if (txtTelefono2.Text != string.Empty && txtEncargado2.Text != string.Empty)
                        {
                            EmpresaIT.updateTelefono(txtCedula_Juridica.Text, Convert.ToInt32(txtTelefono2.Text), txtEncargado2.Text);
                        }
                        MessageBox.Show("La Empresa se ha Editado con Exito", "Edicion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                        frm_empresa splash = new frm_empresa();
                        splash.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido Editar La Empresa", "Error al Editar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else
            {
                MessageBox.Show("Algunos Campos estan Vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frm_registraEmpresa_Load(object sender, EventArgs e)
        {
            this.label4.Text = Frm_Ingreso.datosUsuario;
           
        }

        private void frm_registraEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frm_empresa splash = new frm_empresa();
            splash.ShowDialog();
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            if (EmpresaIT.deleteTelefono(txtCedula_Juridica.Text, Convert.ToInt32(txtTelefono1.Text)))
            {
                txtTelefono1.Text = 0.ToString();
                txtEncargado1.Text = "";
            }
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            if (EmpresaIT.deleteTelefono(txtCedula_Juridica.Text, Convert.ToInt32(txtTelefono2.Text)))
            {
                txtTelefono2.Text = 0.ToString();
                txtEncargado2.Text = "";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
