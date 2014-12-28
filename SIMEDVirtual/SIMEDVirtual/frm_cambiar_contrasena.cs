using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIMEDVirtual.IT;

namespace SIMEDVirtual
{
    public partial class frm_cambiar_contrasena : Form
    {
        public frm_cambiar_contrasena()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txt_pass_anterior.Text != string.Empty && txt_nueva_pass.Text != string.Empty && txtconfirmacion.Text != string.Empty)
            {




                if (Frm_Registro_Medico.comparaContrasena(txt_nueva_pass.Text, txtconfirmacion.Text))
                {
                    //cambiamos la contrasena
                    //recibe la cedula y la nueva pass
                    if (UsuarioIT.CambiarPass(Frm_Ingreso.datosUsuario[2], txt_nueva_pass.Text))
                    {
                        MessageBox.Show("CONTRASEÑA CAMBIADA CON ÉXITO!", "EDICIÓN EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("NO SE HA PODIDO CAMBIAR LA CONTRASEÑA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("LAS CONTRASEÑAS INGRESADAS NO COINCIDEN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ALGUNOS CAMPOS DE TEXTO ESTAN VACIOS", "CAMPOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
