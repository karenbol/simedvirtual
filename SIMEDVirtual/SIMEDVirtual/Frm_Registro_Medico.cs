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
    public partial class Frm_Registro_Medico : Form
    {
        private Boolean edicion = false;
        public Frm_Registro_Medico()
        {
            InitializeComponent();
        }

        public Frm_Registro_Medico(string nombre, string apellido1, string apellido2, int cedula,
            DateTime fecha, string direccion, int codigon, string universidad,
            string especialidad, string correo, int telefono1p, int telefono2p, Boolean ver)
        {
            InitializeComponent();

            txtNombre.Text = nombre;
            txtApellido1.Text = apellido1;
            txtApellido2.Text = apellido2;
            mtcedula.Text = cedula.ToString();
            fecha_nacimiento.Value = fecha;
            txtDireccion.Text = direccion;
            codigo.Text = codigon.ToString();
            txtU.Text = universidad;
            txtEspecialidad.Text = especialidad;
            txtCorreo.Text = correo;
            telefono1.Text = telefono1p.ToString();
            telefono2.Text = telefono2p.ToString();
            txtcontrasena.Visible = false;
            txtconfirmacion.Visible = false;
            //si lo que quiero es ver la info
            if (ver)
            {
                //deshabilito edicion xq solo quiero ver
                ReadOnlyTxt();
                this.Text = "Información de Médicos";
                this.lblTitle.Text = "Información de Médicos";
                lblpass.Visible = false;
                lblconfirmapass.Visible = false;
                btnCargarFoto.Visible = false;
                btnGuardar.Visible = false;
            }
            else
            {
                edicion = true;
                this.Text = "Editar Información de Médicos";
                this.lblTitle.Text = "Editar Información de Médicos";
                btnCargarFoto.Visible = false;
                btnGuardar.Visible = true;
                btnGuardar.Image = Image.FromFile("update.png");
                btnCargarFoto.Visible = true;
                mtcedula.Enabled = false;
            }
        }

        private void ReadOnlyTxt()
        {
            txtNombre.ReadOnly = true;
            txtApellido1.ReadOnly = true;
            txtApellido2.ReadOnly = true;
            mtcedula.ReadOnly = true;
            fecha_nacimiento.Enabled = false;
            txtDireccion.ReadOnly = true;
            codigo.ReadOnly = true;
            txtU.ReadOnly = true;
            txtEspecialidad.ReadOnly = true;
            txtU.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            telefono1.ReadOnly = true;
            telefono2.ReadOnly = true;
        }

        private void Frm_Registro_Medico_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Frm_Medico splash = new Frm_Medico();
            splash.ShowDialog();
        }

        //metodo que compara los campos de la contrasena
        public Boolean comparaContrasena(string contrasena, string confirmacion)
        {
            if (contrasena == confirmacion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //si todos los campos estan llenos 
            if (txtNombre.Text != string.Empty && txtApellido1.Text != string.Empty
                 && txtApellido2.Text != string.Empty && mtcedula.Text != string.Empty
                && fecha_nacimiento.Text != string.Empty & txtDireccion.Text != string.Empty
                && codigo.Text != string.Empty && txtU.Text != string.Empty && txtEspecialidad.Text != string.Empty
                && txtCorreo.Text != string.Empty&& telefono1.Text!= string.Empty && telefono2.Text!= string.Empty)
            {
                //si no estoy editando, entonces inserto
                if (edicion != true)
                {
                    //para insertar ocupo contrasenas llenas e iguales
                    if (comparaContrasena(txtcontrasena.Text, txtconfirmacion.Text)
                        && txtcontrasena.Text != string.Empty && txtconfirmacion.Text != string.Empty)
                    {
                        //si se inserto bien imprime e inserta en la tabla usuario
                        if (MedicoIT.InsertaMedico(txtNombre.Text, txtApellido1.Text, txtApellido2.Text,
                Convert.ToInt32(mtcedula.Text), Convert.ToDateTime(fecha_nacimiento.Text), txtDireccion.Text,
                Convert.ToInt32(codigo.Text), txtU.Text, txtEspecialidad.Text, txtCorreo.Text, Convert.ToInt32(telefono1.Text),
                Convert.ToInt32(telefono2.Text)))
                        {
                            //insertamos en la tabla de usuario
                            if (UsuarioIT.InsertaUsuario(txtcontrasena.Text, Convert.ToInt32(mtcedula.Text), 'm'))
                            {
                                MessageBox.Show("Los Datos han sido Insertados Correctamente !", "Error al Insertar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                            MessageBox.Show("Ha Ocurrido un Error en la Insercion del Medico", "Error al Insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (MedicoIT.UpdateMedico(txtNombre.Text, txtApellido1.Text, txtApellido2.Text,
            Convert.ToInt32(mtcedula.Text), Convert.ToDateTime(fecha_nacimiento.Text), txtDireccion.Text,
            Convert.ToInt32(codigo.Text), txtU.Text, txtEspecialidad.Text, txtCorreo.Text,
            Convert.ToInt32(telefono1.Text), Convert.ToInt32(telefono2.Text))) ;
                    {
                        MessageBox.Show("Los Datos han sido Actualizados Correctamente!", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                        Frm_Splash frm = new Frm_Splash();
                        frm.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Algunos Campos estan Vacíos!", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //DialogResult dialog = MessageBox.Show("Algunos Campos estan Vacíos", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            opFile.Title = "Cargar Foto Médico";
            if (opFile.ShowDialog() == DialogResult.OK)
            {

                string x = opFile.FileName;
                MessageBox.Show(x);
                opFile.Dispose();
                pbFotoDr.ImageLocation = x;
            }
        }

        private void Frm_Registro_Medico_Load(object sender, EventArgs e)
        {

        }
    }
}
