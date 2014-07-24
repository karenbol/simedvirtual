﻿using System;
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
            //ocultamos la ventana
            this.Hide();
            //determinamos nombre y apellido del usuario
            List<MedicoEntity> doctor = UsuarioIT.getNombreApeDr(textBox1.Text.Trim());

            datosUsuario = doctor.ElementAt(0).nombre.ToString();
            datosUsuario += " " + doctor.ElementAt(0).apellido1.ToString();

            //determina si los datos de ingreso son correctos
            if (UsuarioIT.Ingreso(Convert.ToInt32(textBox1.Text.Trim()), textBox2.Text.Trim()))
            {
                tipoUsuario = UsuarioIT.TipoUsuario(Convert.ToInt32(textBox1.Text));
                if (tipoUsuario == 'a')
                {
                    //si es adm lo lleva a la pantalla principal
                    Frm_Splash pr = new Frm_Splash(datosUsuario);
                    pr.ShowDialog();
                }
                else if (tipoUsuario == 'm')
                {
                    //si es medico lo lleva a los expedientes
                    MessageBox.Show("eres Medico");
                    frm_ExpedienteMG pr = new frm_ExpedienteMG(datosUsuario);
                    pr.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ha ocurrido un error con el tipo de usuario");
                }
            }
            else
            //si la informacion no es correcta
            {
                DialogResult dialogResult = MessageBox.Show("Ingreso Fallido, Vuelve a intentarlo",
       "Log In Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //limpiamos los campos
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                //volvemos a mostrar la pantalla
                this.Show();
            }
        }


        private void Frm_Ingreso_Load(object sender, EventArgs e)
        {

        }
    }
}