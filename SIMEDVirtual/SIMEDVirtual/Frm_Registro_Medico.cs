using SIMEDVirtual.Entity;
using SIMEDVirtual.IT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMEDVirtual
{
    public partial class Frm_Registro_Medico : Form
    {
        private Boolean edicion = false;
        //string usuarioPublico = "";
        public byte[] fotoBinaria;
        char sexo = 'f';

        public Frm_Registro_Medico()
        {
            InitializeComponent();
            //usuarioPublico = Frm_Ingreso.datosUsuario;
            cbSexo.SelectedIndex = 1;
            this.cargarEspeciliades();
        }

        public Frm_Registro_Medico(string nombre, string apellido1, string apellido2, string cedula,
            DateTime fecha, string direccion, int codigon, string universidad,
            int especialidad, string correo, char sexop, string edad, int telefono1p, int telefono2p, Boolean ver)
        {
            InitializeComponent();

            this.cargarEspeciliades();
            txtNombre.Text = nombre;
            txtApellido1.Text = apellido1;
            txtApellido2.Text = apellido2;
            txtCedula.Text = cedula.ToString();
            fecha_nacimiento.Value = fecha;
            txtDireccion.Text = direccion;
            codigo.Text = codigon.ToString();
            txtU.Text = universidad;

            cbEspecialidad.SelectedValue = especialidad;

            txtCorreo.Text = correo;
            txtEdad.Text = edad;
            telefono1.Text = telefono1p.ToString();
            telefono2.Text = telefono2p.ToString();
            txtcontrasena.Visible = false;
            txtconfirmacion.Visible = false;

            if (sexop == 'f')
            {
                cbSexo.SelectedIndex = 0;
            }
            else
            {
                cbSexo.SelectedIndex = 1;
            }

            var foto = PersonaIT.GetImageMedico(cedula);

            if (foto == null)
            {
                pbFotoDr.ImageLocation = frm_ExpedienteMG.rutaDefault;
            }
            else
            {
                pbFotoDr.Image = foto;
            }

            //si lo que quiero es ver la info
            if (ver)
            {
                //deshabilito edicion xq solo quiero ver
                groupBox1.Enabled = false;
                this.Text = "INFORMACION DE MÉDICOS";
                this.lblTitle.Text = "INFORMACION DE MÉDICOS";
                lblCampoNumerico.Visible = false;
                lblEspacioVacio.Visible = false;
                lblpass.Visible = false;
                lblconfirmapass.Visible = false;
                btnGuardar.Visible = false;
                cbSexo.Enabled = false;
                pbFotoDr.Enabled = false;
            }
            else
            //edito al medico
            {
                edicion = true;
                this.Text = "Editar Información de Médicos";
                this.lblTitle.Text = "EDITAR INFORMACION DE MÉDICOS";
                btnGuardar.Visible = true;
                btnGuardar.Image = Image.FromFile("update.png");
                txtCedula.Enabled = false;
                lblpass.Visible = false;
                lblconfirmapass.Visible = false;
            }
        }

        private void Frm_Registro_Medico_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Frm_Medico splash = new Frm_Medico();
            splash.ShowDialog();
            
        }

        //metodo que compara los campos de la contrasena
        public static Boolean comparaContrasena(string contrasena, string confirmacion)
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

        //guarda un nuevo medico
        private void button1_Click(object sender, EventArgs e)
        {
            //si todos los campos estan llenos 
            if (txtNombre.Text != string.Empty && txtApellido1.Text != string.Empty
                 && txtApellido2.Text != string.Empty && txtCedula.Text != string.Empty
                && fecha_nacimiento.Text != string.Empty & txtDireccion.Text != string.Empty
                && codigo.Text != string.Empty && txtU.Text != string.Empty && txtCorreo.Text != string.Empty &&
                telefono1.Text != string.Empty && telefono2.Text != string.Empty
                && txtEdad.Text != string.Empty)
            {
                //si no estoy editando, entonces inserto
                if (edicion != true)
                {
                    if (this.cbSexo.SelectedIndex == 1)
                    {
                        sexo = 'm';
                    }
                    //para insertar ocupo contrasenas llenas e iguales
                    if (comparaContrasena(txtcontrasena.Text, txtconfirmacion.Text)
                        && txtcontrasena.Text != string.Empty && txtconfirmacion.Text != string.Empty)
                    {
                        //si se inserto bien imprime e inserta en la tabla usuario
                        if (PersonaIT.InsertaMedico(txtNombre.Text, txtApellido1.Text, txtApellido2.Text,
              txtCedula.Text, Convert.ToDateTime(fecha_nacimiento.Text), txtDireccion.Text, txtEdad.Text, sexo,
               Convert.ToInt32(telefono1.Text), Convert.ToInt32(telefono2.Text), txtCorreo.Text, fotoBinaria, Convert.ToInt32(codigo.Text),
                txtU.Text, Convert.ToInt32(cbEspecialidad.SelectedValue), true))
                        {
                            //insertamos en la tabla de usuario 1 adm 2 medico
                            if (UsuarioIT.InsertaUsuario(txtcontrasena.Text, txtCedula.Text, 2))
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
                            MessageBox.Show("Ha Ocurrido un Error en la Insercion del Medico\n Puede que esa Cedula ya se encuentre Registrada", "Error al Insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (PersonaIT.UpdateMedico(txtNombre.Text, txtApellido1.Text, txtApellido2.Text,
                 txtCedula.Text, Convert.ToDateTime(fecha_nacimiento.Text), txtDireccion.Text, txtEdad.Text, sexo,
                Convert.ToInt32(telefono1.Text), Convert.ToInt32(telefono2.Text), txtCorreo.Text, fotoBinaria,
                Convert.ToInt32(codigo.Text), txtU.Text, Convert.ToInt32(cbEspecialidad.SelectedValue)))
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
            }
        }

        private void Frm_Registro_Medico_Load(object sender, EventArgs e)
        {
            toolTip1.InitialDelay = 1;

            toolTip1.SetToolTip(btnGuardar, "Registrar Médico");
            toolTip1.SetToolTip(pbFotoDr, "Cargar Foto");


            fotoBinaria = saveImage(frm_ExpedienteMG.rutaDefault);
        }
        //accion del picture Box
        private void pbFotoDr_Click(object sender, EventArgs e)
        {
            opFile.Title = "Cargar Foto Médico";
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                string x = opFile.FileName;
                //MessageBox.Show(x);
                opFile.Dispose();
                pbFotoDr.ImageLocation = x;
                fotoBinaria = this.saveImage(x);
            }
        }


        //guardar la imagen, ocupo la ruta
        public byte[] saveImage(string productImageFilePath)
        {
            try
            {
                using (FileStream pgFileStream = new FileStream(productImageFilePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader pgReader = new BinaryReader(new BufferedStream(pgFileStream)))
                    {
                        byte[] pgByteA = pgReader.ReadBytes(Convert.ToInt32(pgFileStream.Length));
                        return pgByteA;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        //muestra todas las especiaildades en un combo
        public void cargarEspeciliades()
        {
            List<EspecialidadEntity> especialidad = EspecialidadIT.getAllEspecialidades();

            //si hay especialidades se llena y selecciona index
            if (especialidad.Count != 0)
            {
                //asigno los datos al combobox
                cbEspecialidad.DataSource = especialidad;
                //lo que quiero obtener
                cbEspecialidad.ValueMember = "id";
                //lo q voy a mostrar
                cbEspecialidad.DisplayMember = "nombre";
                cbEspecialidad.SelectedIndex = 0;
            }

            /*if (especialidad.Count != 0)
            {
                for (int i = 0; i < especialidad.Count; i++)
                {
                    cbEspecialidad.Items.Add(especialidad[i].ToUpper().ToString());
                }

                if (cbEspecialidad.Items.Count != 0)
                {
                    cbEspecialidad.SelectedIndex = 0;
                }
            }*/
        }

        private void fecha_nacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNac = fecha_nacimiento.Value;

            TimeSpan dias = DateTime.Now - fecha_nacimiento.Value;
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
    }
}
