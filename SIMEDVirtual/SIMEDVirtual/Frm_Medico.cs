﻿using SIMEDVirtual.DA;
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
    public partial class Frm_Medico : Form
    {
        string usuarioPublico = "";

        public Frm_Medico(string usuario)
        {
            InitializeComponent();
            usuarioPublico = usuario;
            label4.Text = usuario;
        }

        private void Frm_Medico_Load(object sender, EventArgs e)
        {
            this.cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            //cargamos todos la info de drs en el datagrid
            var pts = new BindingList<MedicoEntity>(MedicoIT.selectMedico());
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = pts;
            //agregar el evento 
            dataGridView1.CellContentDoubleClick += dataGridView1_CellDoubleClick;

            //se asignan datos al datagrid
            for (int j = 0; j < pts.Count; j++)
            {
                dataGridView1.Rows[j].Cells[0].Value = pts.ElementAt(j).cedula.ToString();
                dataGridView1.Rows[j].Cells[1].Value = pts.ElementAt(j).apellido1.ToString();
                dataGridView1.Rows[j].Cells[2].Value = pts.ElementAt(j).nombre.ToString();
                dataGridView1.Rows[j].Cells[3].Value = pts.ElementAt(j).codigo.ToString();
                dataGridView1.Rows[j].Cells[4].Value = pts.ElementAt(j).especialidad.ToString();
                dataGridView1.Rows[j].Cells[5].Value = pts.ElementAt(j).correo.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                int ced = Convert.ToInt32(selectedRow.Cells["Cedula"].Value);
                //devuelve datos del medico segun la cedula
                var pts = new BindingList<MedicoEntity>(MedicoIT.selectMedico2(Convert.ToString(ced)));

                string nombre = pts.ElementAt(0).nombre.ToString();
                String ape1 = pts.ElementAt(0).apellido1.ToString();
                String ape2 = pts.ElementAt(0).apellido2.ToString();
                DateTime fecha = Convert.ToDateTime(pts.ElementAt(0).fecha_nacimiento.ToString());
                String direccion = pts.ElementAt(0).direccion.ToString();
                int codigo = Convert.ToInt32(pts.ElementAt(0).codigo.ToString());
                String u = pts.ElementAt(0).universidad.ToString();
                String especialidad = pts.ElementAt(0).especialidad.ToString();
                String correo = pts.ElementAt(0).correo.ToString();
                int telefono1 = Convert.ToInt32(pts.ElementAt(0).telefono1.ToString());
                int telefono2 = Convert.ToInt32(pts.ElementAt(0).telefono2.ToString());

                this.Hide();
                Frm_Registro_Medico frm = new Frm_Registro_Medico(nombre, ape1, ape2, ced, fecha, direccion,
                    codigo, u, especialidad, correo, telefono1, telefono2, false);
                frm.ShowDialog();
            }
        }
        //agregar medico
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Registro_Medico pan = new Frm_Registro_Medico(usuarioPublico);
            pan.ShowDialog();
        }

        private void Frm_Medico_FormClosing(object sender, FormClosingEventArgs e)
        {
            //al cerrar nos devolvemos a pantalla principal
            this.Hide();
            Frm_Splash frm = new Frm_Splash(usuarioPublico);
            frm.ShowDialog();
        }

        //elimina el medico
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DialogResult dialog = MessageBox.Show(
     "Seguro que Desea Eliminar el Registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialog == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                    string ced = Convert.ToString(selectedRow.Cells["Cedula"].Value);

                    //eliminar dr y usuario
                    if (MedicoIT.deleteMedico(ced) && (MedicoIT.deleteUsuario(ced)))
                    {
                        MessageBox.Show("El Registro se ha Eliminado Correctamente!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.cargarDataGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("NO HAY DATOS SELECCIONADOS");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //cargamos todos la info de drs en el datagrid
            int cedula = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //selecciona el medico dependiento de la cedula
            var pts = new BindingList<MedicoEntity>(MedicoIT.selectMedico2(Convert.ToString(cedula)));
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = pts;

            string nombre = pts.ElementAt(0).nombre.ToString();
            String ape1 = pts.ElementAt(0).apellido1.ToString();
            String ape2 = pts.ElementAt(0).apellido2.ToString();
            DateTime fecha = Convert.ToDateTime(pts.ElementAt(0).fecha_nacimiento.ToString());
            String direccion = pts.ElementAt(0).direccion.ToString();
            int codigo = Convert.ToInt32(pts.ElementAt(0).codigo.ToString());
            String u = pts.ElementAt(0).universidad.ToString();
            String especialidad = pts.ElementAt(0).especialidad.ToString();
            String correo = pts.ElementAt(0).correo.ToString();
            int telefono1 = Convert.ToInt32(pts.ElementAt(0).telefono1.ToString());
            int telefono2 = Convert.ToInt32(pts.ElementAt(0).telefono2.ToString());


            this.Hide();
            Frm_Registro_Medico frm = new Frm_Registro_Medico(nombre, ape1, ape2, cedula, fecha, direccion,
                codigo, u, especialidad, correo, telefono1, telefono2, true);
            frm.ShowDialog();
        }
    }
}
