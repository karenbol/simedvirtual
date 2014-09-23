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
        string datosUsuario = "karen probando";
        public Frm_Ingreso()
        {
            InitializeComponent();
        }

        //private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //this.Hide();
        //    Frm_Registro_Medico rm = new Frm_Registro_Medico();
        //    rm.ShowDialog();
        //}

        //private void secretariaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //this.Hide();
        //    Frm_Registro_Secretaria rm = new Frm_Registro_Secretaria();
        //    rm.ShowDialog();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Char tipoUsuario;
            int parsedValue;

            //validamos que no hayan campos vacios al ingresar
            if (txtUsuario.Text != string.Empty && txtContrasena.Text != string.Empty)
            {
                //valido que se escriban solo numeros en el campo usuario
                if (!int.TryParse(txtUsuario.Text, out parsedValue))
                {
                    txtUsuario.Text = string.Empty;
                    txtContrasena.Text = string.Empty;
                    DialogResult dialogResult = MessageBox.Show("Por Favor digite SOLO LETRAS en el Campo Usuario",
                   "Solo Letras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //determina si los datos de ingreso son correctos
                    if (UsuarioIT.Ingreso(Convert.ToInt32(txtUsuario.Text.Trim()), txtContrasena.Text.Trim()))
                    {
                        //determinamos nombre y apellido del usuario
                        //recibe por el nombre de usuario y me trae la informacion
                        List<MedicoEntity> doctor = UsuarioIT.getNombreApeDr(txtUsuario.Text.Trim());
                        //concatenamos nombre y apellido del usuario
                        datosUsuario = doctor.ElementAt(0).nombre.ToString();
                        datosUsuario += " " + doctor.ElementAt(0).apellido1.ToString();

                        tipoUsuario = UsuarioIT.TipoUsuario(Convert.ToInt32(txtUsuario.Text));
                        if (tipoUsuario == 'a')
                        {
                            this.Hide();
                            //si es adm lo lleva a la pantalla principal
                            Frm_Splash pr = new Frm_Splash(datosUsuario);
                            pr.ShowDialog();

                        }
                        else if (tipoUsuario == 'm')
                        {
                            //si es medico lo lleva a los expedientes
                            //MessageBox.Show("eres Medico");
                            this.Hide();
                            frm_ExpedienteMG pr = new frm_ExpedienteMG(datosUsuario);
                            pr.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error con el tipo de usuario");
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

        }
    }
}
