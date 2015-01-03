using SIMEDVirtual.IT;
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
    public partial class Frm_Registro_Secretaria : Form
    {
        private Boolean edicion = false;
        char sexo = 'f';

        public Frm_Registro_Secretaria()
        {
            InitializeComponent();
            label10.Text = Frm_Ingreso.datosUsuario[0] + " " + Frm_Ingreso.datosUsuario[1];
        }

        //ver informacion del administrativo
        public Frm_Registro_Secretaria(string nombre, string ape1, string ape2, string cedula, DateTime fecha, string edad, char sexo, string puesto,
            string direccion, string email, int tel1, int tel2, bool editar)
        {
            InitializeComponent();
            edicion = editar;

            label10.Text = Frm_Ingreso.datosUsuario[0] + " " + Frm_Ingreso.datosUsuario[1];
            txtNombre.Text = nombre;
            txtApellido1.Text = ape1;
            txtApellido2.Text = ape2;
            txtCedula.Text = cedula;
            dtfecha.Value = fecha;
            txtEdad.Text = edad;
            //combo
            txtPuesto.Text = puesto;
            txtDireccion.Text = direccion;
            txtCorreo.Text = email;

            telefono1.Text = tel1.ToString();
            telefono2.Text = tel2.ToString();
            txtcontrasena.Visible = false;
            txtconfirmacion.Visible = false;

            lblpass.Visible = false;
            lblconfirmapass.Visible = false;

            //si voy a editar
            if (edicion)
            {
                txtCedula.Enabled = false;
                btnGuardar.Visible = true;
                groupBox1.Enabled = true;
            }
            else
            //si voy a ver
            {
                btnGuardar.Visible = false;
                groupBox1.Enabled = false;
            }
        }

        private void Frm_Registro_Secretaria_Load(object sender, EventArgs e)
        {
            cbSexo.SelectedIndex = 1;
        }

        private void dtfecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNac = dtfecha.Value;

            TimeSpan dias = DateTime.Now - dtfecha.Value;
            txtEdad.Text = this.direfenciaFechas(fechaNac, DateTime.Now);
        }

        //calcula edad (anios, meses,dias) basado en la fecha de nacimiento
        public string direfenciaFechas(DateTime New, DateTime old)
        {
            int anios = New.Year - old.Year;
            int meses = New.Month - old.Month;
            int dias = New.Day - old.Day;

            string respuesta = Math.Abs(anios) + " Años " + Math.Abs(meses) + " Meses " + Math.Abs(dias) + " Dias";
            return respuesta;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //si todos los campos estan llenos 
            if (txtNombre.Text != string.Empty && txtApellido1.Text != string.Empty
                 && txtApellido2.Text != string.Empty && txtCedula.Text != string.Empty
                && dtfecha.Text != string.Empty && txtDireccion.Text != string.Empty
              && txtPuesto.Text != string.Empty
                && telefono1.Text != string.Empty && telefono2.Text != string.Empty
               && txtCorreo.Text != string.Empty)
            {
                //si no estoy editando, entonces inserto
                if (edicion != true)
                {
                    if (this.cbSexo.SelectedIndex == 1)
                    {
                        sexo = 'm';
                    }
                    //para insertar ocupo contrasenas llenas e iguales
                    if (Frm_Registro_Medico.comparaContrasena(txtcontrasena.Text, txtconfirmacion.Text)
                        && txtcontrasena.Text != string.Empty && txtconfirmacion.Text != string.Empty)
                    {
                        //si se inserto bien imprime e inserta en la tabla persona
                        if (PersonaIT.InsertaAdministrativo(txtNombre.Text, txtApellido1.Text, txtApellido2.Text,
              txtCedula.Text, Convert.ToDateTime(dtfecha.Text), txtDireccion.Text, txtEdad.Text, sexo, txtPuesto.Text,
               Convert.ToInt32(telefono1.Text), Convert.ToInt32(telefono2.Text), txtCorreo.Text, false, DateTime.Now))
                        {
                            //insertamos en la tabla de usuario 1 adm 2 medico
                            if (UsuarioIT.InsertaUsuario(txtcontrasena.Text, txtCedula.Text, 1))
                            {
                                MessageBox.Show("LOS DATOS HAN SIDO INSERTADOS CON EXITO!", "INSERCION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.Hide();
                                Frm_Administrativo frm = new Frm_Administrativo();
                                frm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("HA OCURRIDO UN ERROR EN LA INSERCION DEL USUARIO", "ERROR AL INSERTARr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("HA OCURRIDO UN ERROR CON LA INSERCION DEL REGISTRO\nPUEDE QUE LA CEDULA YA EXISTA", "ERROR AL INSERTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN", "ERROR EN LAS CONTRASEÑAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //de lo contrario, edito
                }
                //editar los datos del administrativo
                else
                {

                    if (PersonaIT.UpdateAdministrativo(txtNombre.Text, txtApellido1.Text, txtApellido2.Text,
                 txtCedula.Text, Convert.ToDateTime(dtfecha.Text), txtDireccion.Text, txtEdad.Text, sexo, txtPuesto.Text,
                Convert.ToInt32(telefono1.Text), Convert.ToInt32(telefono2.Text), txtCorreo.Text))
                    {
                        MessageBox.Show("LOS DATOS SE HAN ACTUALIZADO CORRECTAMENTE!", "EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                        Frm_Administrativo frm = new Frm_Administrativo();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("HA OCURRIDO UN ERROR CON LA ACTUALIZACION DEL REGISTRO", "ERROR AL EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Algunos Campos estan Vacíos!", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
