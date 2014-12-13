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
            label10.Text = Frm_Ingreso.datosUsuario;
        }

        private void Frm_Registro_Secretaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            Frm_Administrativo splash = new Frm_Administrativo();
            splash.ShowDialog();

            
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
                                MessageBox.Show("Los Datos han sido Insertados Correctamente !", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.Close();
                                Frm_Splash frm = new Frm_Splash();
                                frm.ShowDialog();
                                
                            }
                            else
                            {
                                MessageBox.Show("Ha Ocurrido un Error en la Insercion del Usuario", "Error al Insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ha Ocurrido un Error en la Insercion del Registro\n Puede que esa Cedula ya se encuentre Registrada", "Error al Insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contrasenas NO coinciden", "Error en Contraseñas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //de lo contrario, edito
                }
                else
                {
                    string hey = "u";
                    /* if (PersonaIT.UpdateMedico(txtNombre.Text, txtApellido1.Text, txtApellido2.Text,
                  txtCedula.Text, Convert.ToDateTime(fecha_nacimiento.Text), txtDireccion.Text, txtEdad.Text, sexo,
                 Convert.ToInt32(telefono1.Text), Convert.ToInt32(telefono2.Text), txtCorreo.Text, fotoBinaria,
                 Convert.ToInt32(codigo.Text), txtU.Text, Convert.ToInt32(cbEspecialidad.SelectedValue)))
                     {
                         MessageBox.Show("Los Datos han sido Actualizados Correctamente!", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                         this.Close();
                         Frm_Splash frm = new Frm_Splash();
                         frm.ShowDialog();
                     }*/
                }
            }
            else
            {
                MessageBox.Show("Algunos Campos estan Vacíos!", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
