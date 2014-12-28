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
using System.Threading;

namespace SIMEDVirtual
{
    public partial class Frm_Ingreso : Form
    {
        //public static String datosUsuario = "Usuario NO Identificado";
        //0=nombre 1=apelli 2=cedula 3=tipo
        public static String[] datosUsuario = new String[] { "Usuario", "NO Identificado", "2", "" };
        //variable estatico con la cedula del usuario
        //public static String cedulaUsuario = "2";
        //public static String tipoUsuario;

        public Frm_Ingreso()
        {
            InitializeComponent();
        }

        //boton para ingresar
        private void button1_Click(object sender, EventArgs e)
        {
            //validamos que no hayan campos vacios al ingresar
            if (txtUsuario.Text != string.Empty && txtContrasena.Text != string.Empty)
            {
                //determina si los datos de ingreso estan en la tabla usuarios
                if (UsuarioIT.Ingreso(txtUsuario.Text.Trim(), txtContrasena.Text.Trim()))
                {
                    //guardo la cedula del usuario

                    datosUsuario[2] = txtUsuario.Text.Trim();

                    //determinamos nombre y apellido del usuario en una variable statica
                    //recibe el nombre de usuario y me trae la informacion
                    List<PersonaEntity> doctor = UsuarioIT.getNombreApeDr(txtUsuario.Text.Trim());
                    //concatenamos nombre y apellido del usuario

                    if (doctor.Count != 0)
                    {
                        datosUsuario[0] = doctor.ElementAt(0).nombre.ToString();
                        datosUsuario[1] = doctor.ElementAt(0).ape1.ToString();
                        datosUsuario[3] = UsuarioIT.TipoUsuario((txtUsuario.Text)).Trim();

                        txtUsuario.Clear();
                        txtContrasena.Clear();

                        if (datosUsuario[3] == "1")
                        {
                            /*
                            var x = new Form2();
                            this.Hide();
                            x.ShowDialog();
                            this.Show();*/
                            this.Hide();
                            Frm_Splash pr = new Frm_Splash();
                            pr.ShowDialog();
                        }
                        else if (datosUsuario[3] == "2")
                        {
                            //si es medico lo lleva a los expedientes
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
                    this.Close();
                }
                else
                //si la informacion de ingreso no es correcta
                {
                    //limpiamos los campos
                    txtUsuario.Text = string.Empty;
                    txtContrasena.Text = string.Empty;
                    DialogResult dialogResult = MessageBox.Show("Ingreso Fallido, Vuelve a intentarlo",
           "Log In Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
            NpgsqlConnection.ClearAllPools();
        }

        private void Frm_Ingreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Thread.CurrentThread.Abort();
            Application.Exit();
            NpgsqlConnection.ClearAllPools();
        }
    }
}
