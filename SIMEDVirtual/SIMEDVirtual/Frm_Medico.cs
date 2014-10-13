using SIMEDVirtual.DA;
using SIMEDVirtual.Entity;
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

        public Frm_Medico()
        {
            InitializeComponent();
            usuarioPublico = Frm_Ingreso.datosUsuario;
            label4.Text = Frm_Ingreso.datosUsuario;
        }

        private void Frm_Medico_Load(object sender, EventArgs e)
        {
            this.cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            //cargamos todos la info de drs en el datagrid
            var pts = new BindingList<PersonaEntity>(PersonaIT.selectMedico());
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = pts;
            //agregar el evento 
            dataGridView1.CellContentDoubleClick += dataGridView1_CellDoubleClick;

            //se asignan datos al datagrid
            for (int j = 0; j < pts.Count; j++)
            {
                dataGridView1.Rows[j].Cells[0].Value = pts.ElementAt(j).cedula.ToString();
                dataGridView1.Rows[j].Cells[1].Value = pts.ElementAt(j).ape1.ToString();
                dataGridView1.Rows[j].Cells[2].Value = pts.ElementAt(j).nombre.ToString();
                dataGridView1.Rows[j].Cells[3].Value = pts.ElementAt(j).codigo.ToString();
                dataGridView1.Rows[j].Cells[4].Value = pts.ElementAt(j).especialidad.ToString();
                dataGridView1.Rows[j].Cells[5].Value = pts.ElementAt(j).email.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                string ced = (selectedRow.Cells["Cedula"].Value.ToString());
                //devuelve datos del medico segun la cedula
                var pts = new BindingList<PersonaEntity>(PersonaIT.selectMedico2(Convert.ToString(ced)));

                string nombre = pts.ElementAt(0).nombre.ToString();
                String ape1 = pts.ElementAt(0).ape1.ToString();
                String ape2 = pts.ElementAt(0).ape2.ToString();
                DateTime fecha = Convert.ToDateTime(pts.ElementAt(0).fecha.ToString());
                String direccion = pts.ElementAt(0).direccion.ToString();
                int codigo = Convert.ToInt32(pts.ElementAt(0).codigo.ToString());
                String u = pts.ElementAt(0).universidad.ToString();
                String especialidad = pts.ElementAt(0).especialidad.ToString();
                String correo = pts.ElementAt(0).email.ToString();
                int telefono1 = Convert.ToInt32(pts.ElementAt(0).telefono_fijo.ToString());
                int telefono2 = Convert.ToInt32(pts.ElementAt(0).telefono_movil.ToString());
                byte foto = Convert.ToByte(pts.ElementAt(0).fotoBinaria);

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
            Frm_Splash frm = new Frm_Splash();
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
                    if (PersonaIT.deleteMedico(ced) && (PersonaIT.deleteUsuario(ced)))
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

        //doble click para ver la info del medico
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //cargamos todos la info de drs en el datagrid
            string cedula = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //selecciona el medico dependiento de la cedula
            var pts = new BindingList<PersonaEntity>(PersonaIT.selectMedico2(Convert.ToString(cedula)));
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = pts;

            string nombre = pts.ElementAt(0).nombre.ToString();
            String ape1 = pts.ElementAt(0).ape1.ToString();
            String ape2 = pts.ElementAt(0).ape2.ToString();
            DateTime fecha = Convert.ToDateTime(pts.ElementAt(0).fecha.ToString());
            String direccion = pts.ElementAt(0).direccion.ToString();
            int codigo = Convert.ToInt32(pts.ElementAt(0).codigo.ToString());
            String u = pts.ElementAt(0).universidad.ToString();
            String especialidad = pts.ElementAt(0).especialidad.ToString();
            String correo = pts.ElementAt(0).email.ToString();
            int telefono1 = Convert.ToInt32(pts.ElementAt(0).telefono_fijo.ToString());
            int telefono2 = Convert.ToInt32(pts.ElementAt(0).telefono_movil.ToString());
            //byte foto = Convert.ToByte(pts.ElementAt(0).foto);
            
            this.Hide();
            Frm_Registro_Medico frm = new Frm_Registro_Medico(nombre, ape1, ape2, cedula, fecha, direccion,
                codigo, u, especialidad, correo, telefono1, telefono2, true);
            frm.ShowDialog();
        }
    }
}

