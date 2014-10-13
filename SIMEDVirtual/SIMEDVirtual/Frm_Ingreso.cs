using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;
using SIMEDVirtual.IT;
using SIMEDVirtual.Entity;
using SIMEDVirtual.DA;

namespace SIMEDVirtual
{
    public partial class Frm_Ingreso : Form
    {
        public static String datosUsuario = "karen probando";
        //variable estatico con la cedula del usuario
        public static String cedulaUsuario = "2";
        public static String tipoUsuario;

        public Frm_Ingreso()
        {
            InitializeComponent();
        }

        //boton para ingresar
        private void button1_Click(object sender, EventArgs e)
        {
            int parsedValue;

            //validamos que no hayan campos vacios al ingresar
            if (txtUsuario.Text != string.Empty && txtContrasena.Text != string.Empty)
            {
                //valido que no se escriban carecteres especiales en el campo usuario
                //if (!int.TryParse(txtUsuario.Text, out parsedValue))
                //{
                //    txtUsuario.Text = string.Empty;
                //    txtContrasena.Text = string.Empty;
                //    DialogResult dialogResult = MessageBox.Show("Por Favor digite SOLO LETRAS en el Campo Usuario",
                //   "Solo Letras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                //determina si los datos de ingreso estan en la tabla usuarios
                if (UsuarioIT.Ingreso(txtUsuario.Text.Trim(), txtContrasena.Text.Trim()))
                {
                    //guardo la cedula del usuario
                    cedulaUsuario = txtUsuario.Text.Trim();

                    //determinamos nombre y apellido del usuario en una variable statica
                    //recibe el nombre de usuario y me trae la informacion
                    List<PersonaEntity> doctor = UsuarioIT.getNombreApeDr(txtUsuario.Text.Trim());
                    //concatenamos nombre y apellido del usuario

                    if (doctor.Count != 0)
                    {
                        datosUsuario = doctor.ElementAt(0).nombre.ToString();
                        datosUsuario += " " + doctor.ElementAt(0).ape1.ToString();

                        tipoUsuario = UsuarioIT.TipoUsuario((txtUsuario.Text));
                        if (tipoUsuario == "1")
                        {
                            this.Hide();
                            //si es adm lo lleva a la pantalla principal
                            Frm_Splash pr = new Frm_Splash();
                            pr.ShowDialog();


                        }
                        else if (tipoUsuario == "2")
                        {
                            //si es medico lo lleva a los expedientes
                            //MessageBox.Show("eres Medico");
                            this.Hide();
                            frm_ExpedienteMG pr = new frm_ExpedienteMG();
                            pr.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error con el tipo de usuario");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se Encuentra registrado el Usuario");
                    }


                }
                else
                //si la informacion de ingreso no es correcta
                {
                    DialogResult dialogResult = MessageBox.Show("Ingreso Fallido, Vuelve a intentarlo",
           "Log In Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //limpiamos los campos
                    txtUsuario.Text = string.Empty;
                    txtContrasena.Text = string.Empty;
                }
                //}
            }
            //si hay campos vacios notifica
            else
            {
                DialogResult dialogResult = MessageBox.Show("Algunos Campos de Texto estan Vacios",
       "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Frm_Ingreso_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Ingreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            NpgsqlConnection.ClearAllPools();
        }
    }
}
