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
    public partial class Frm_Administrativo : Form
    {
        public Frm_Administrativo()
        {
            InitializeComponent();
            dgAdministrativos.Columns[0].Width = 170;
            dgAdministrativos.Columns[1].Width = 150;
            dgAdministrativos.Columns[2].Width = 180;
            dgAdministrativos.Columns[3].Width = 180;
            dgAdministrativos.Columns[4].Width = 180;
            dgAdministrativos.Columns[5].Width = 150;
        }

        private void Frm_Administrativo_Load(object sender, EventArgs e)
        {
            this.cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            //cargamos todos la info de drs en el datagrid
            var pts = new BindingList<PersonaEntity>(PersonaIT.selectAdministrativo());
            dgAdministrativos.AutoGenerateColumns = false;
            dgAdministrativos.DataSource = pts;

            //se asignan datos al datagrid
            for (int j = 0; j < pts.Count; j++)
            {
                dgAdministrativos.Rows[j].Cells[0].Value = pts.ElementAt(j).cedula.ToString();
                dgAdministrativos.Rows[j].Cells[1].Value = pts.ElementAt(j).ape1.ToString();
                dgAdministrativos.Rows[j].Cells[2].Value = pts.ElementAt(j).ape2.ToString();
                dgAdministrativos.Rows[j].Cells[3].Value = pts.ElementAt(j).nombre.ToString();
                dgAdministrativos.Rows[j].Cells[4].Value = pts.ElementAt(j).profesion.ToString();
                dgAdministrativos.Rows[j].Cells[5].Value = pts.ElementAt(j).email.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Registro_Secretaria x = new Frm_Registro_Secretaria();
            x.ShowDialog();
        }

        private void Frm_Administrativo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Frm_Splash x = new Frm_Splash();
            x.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgAdministrativos.SelectedCells.Count > 0)
            {
                DialogResult dialog = MessageBox.Show(
     "SEGURO QUE DESEA ELIMINAR EL REGISTRO?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialog == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dgAdministrativos.Rows[dgAdministrativos.SelectedCells[0].RowIndex];
                    string ced = Convert.ToString(selectedRow.Cells["Cedula"].Value);

                    //eliminar dr y usuario
                    if (PersonaIT.deletePersona(ced) && (PersonaIT.deleteUsuario(ced)))
                    {
                        this.cargarDataGrid();
                        MessageBox.Show("EL REGISTRO SE HA ELIMINADO CORRECTAMENTE!", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            else
            {
                MessageBox.Show("NO HAY DATOS SELECCIONADOS");
            }
        }

        private void dgAdministrativos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //cargamos todos la info de drs en el datagrid
                string cedula = dgAdministrativos.Rows[e.RowIndex].Cells[0].Value.ToString();
                //selecciona el medico dependiento de la cedula
                var pts = new BindingList<PersonaEntity>(PersonaIT.selectClientePorCedula(Convert.ToString(cedula)));

                string nombre = pts.ElementAt(0).nombre.ToString();
                String ape1 = pts.ElementAt(0).ape1.ToString();
                String ape2 = pts.ElementAt(0).ape2.ToString();
                DateTime fecha = Convert.ToDateTime(pts.ElementAt(0).fecha.ToString());
                String direccion = pts.ElementAt(0).direccion.ToString();
                String puesto = pts.ElementAt(0).profesion.ToString();
                String correo = pts.ElementAt(0).email.ToString();
                char sexo = Convert.ToChar(pts.ElementAt(0).sexo);
                String edad = pts.ElementAt(0).edad.ToString();
                int telefono1 = Convert.ToInt32(pts.ElementAt(0).telefono_fijo.ToString());
                int telefono2 = Convert.ToInt32(pts.ElementAt(0).telefono_movil.ToString());
                //byte foto = Convert.ToByte(pts.ElementAt(0).fotoBinaria);

                //this.Hide();
                Frm_Registro_Secretaria frm = new Frm_Registro_Secretaria(nombre, ape1, ape2, cedula, fecha, edad, sexo, puesto, direccion,
                   correo, telefono1, telefono2,false);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("SELECCION NO VALIDA\nPOR FAVOR SELECCIONE UN MEDICO E INTENTELO DE NUEVO", "Seleccion Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgAdministrativos.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dgAdministrativos.Rows[dgAdministrativos.SelectedCells[0].RowIndex];
                string ced = (selectedRow.Cells["Cedula"].Value.ToString());
                //devuelve datos del medico segun la cedula
                var pts = new BindingList<PersonaEntity>(PersonaIT.selectClientePorCedula(Convert.ToString(ced)));

                string nombre = pts.ElementAt(0).nombre.ToString();
                String ape1 = pts.ElementAt(0).ape1.ToString();
                String ape2 = pts.ElementAt(0).ape2.ToString();
                DateTime fecha = Convert.ToDateTime(pts.ElementAt(0).fecha.ToString());
                String direccion = pts.ElementAt(0).direccion.ToString();
                String correo = pts.ElementAt(0).email.ToString();
                char sexo = Convert.ToChar(pts.ElementAt(0).sexo);
                String edad = pts.ElementAt(0).edad.ToString();
                String puesto = pts.ElementAt(0).profesion.ToString();
                int telefono1 = Convert.ToInt32(pts.ElementAt(0).telefono_fijo.ToString());
                int telefono2 = Convert.ToInt32(pts.ElementAt(0).telefono_movil.ToString());
               
                this.Hide();
                Frm_Registro_Secretaria frm = new Frm_Registro_Secretaria(nombre, ape1, ape2, ced, fecha, edad,sexo,puesto,
                    direccion, correo, telefono1, telefono2, true);
                frm.ShowDialog();

            }
        }
    }
}
