using Npgsql;
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
using System.Windows.Forms;

namespace SIMEDVirtual
{
    public partial class frm_Cliente : Form
    {
        public int editar;
        public byte[] fotoBinaria;

        public frm_Cliente()
        {
            InitializeComponent();
            this.cargaComboEmpresas();
            cbEstado.SelectedIndex = 0;
            cbSangre.SelectedIndex = 0;
            cbSexo.SelectedIndex = 0;
            editar = 3;
        }

        public frm_Cliente(string cedula, int pver)
        {
            InitializeComponent();

            //igualo a la variable estatica
            editar = pver;
            determinaCliente(cedula);
            //si solo voy a ver deshabilito todo
            if (pver == 1)
            {
                ((Control)this.tabPageInfoPersonal).Enabled = false;
            }
            else if (pver == 2)
            //si voy a editar deshabilito la cedula
            {
                txtCedula.Enabled = false;
                lblTitulo.Text = "EDITAR MÉDICOS";
            }
        }

        //quema la interfaz con los datos del cliente
        public void determinaCliente(string pCedula)
        {
            List<ClienteEntity> listaCliente = ClienteIT.selectClientePorCedula(pCedula);

            txtNombre.Text = listaCliente.ElementAt(0).nombre;
            txtApe1.Text = listaCliente.ElementAt(0).ape1;
            txtApe2.Text = listaCliente.ElementAt(0).ape2;
            txtCedula.Text = listaCliente.ElementAt(0).cedula;

            fecha_nacimiento.Value = listaCliente.ElementAt(0).fecha;
            txtEdad.Text = listaCliente.ElementAt(0).edad;

            //combo del sexo
            Char sexo = listaCliente.ElementAt(0).sexo;
            if (sexo == 'f')
            {
                cbSexo.SelectedIndex = 0;
            }
            else
            {
                cbSexo.SelectedIndex = 1;
            }

            txtDireccion.Text = listaCliente.ElementAt(0).direccion;

            cbEstado.SelectedIndex = cbEstado.Items.IndexOf(listaCliente.ElementAt(0).estado_civil.ToString()); ;

            cbSangre.SelectedIndex = cbSangre.Items.IndexOf(listaCliente.ElementAt(0).grupo_sanguineo.ToString());

            cargaComboEmpresas();

            cbEmpresa.SelectedIndex = cbEmpresa.Items.IndexOf(listaCliente.ElementAt(0).empresa.ToString());

            txtProfesion.Text = listaCliente.ElementAt(0).profesion.ToString();

            txtTelefono.Text = listaCliente.ElementAt(0).telefono_fijo.ToString();
            txtMovil.Text = listaCliente.ElementAt(0).telefono_movil.ToString();
            txtEmail.Text = listaCliente.ElementAt(0).email.ToString();

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

        private void pbFotoCliente_Click(object sender, EventArgs e)
        {
            //lblPb.Visible = false;
            openFileDialog1.Title = "Cargar Foto Cliente";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string x = openFileDialog1.FileName;

                openFileDialog1.Dispose();
                pbFotoCliente.ImageLocation = x;
                fotoBinaria = this.saveImage(x);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //si los campos obligatorios estan llenos 
            if (txtNombre.Text != string.Empty && txtApe1.Text != string.Empty && txtApe2.Text != string.Empty &&
                txtCedula.Text != string.Empty && fecha_nacimiento.Text != string.Empty && cbSexo.Text != string.Empty &&
                cbEstado.Text != string.Empty && cbSangre.Text != string.Empty && txtProfesion.Text != string.Empty &&
                txtDireccion.Text != string.Empty)
            {
                int telefono = 0;
                int movil = 0;

                if (txtTelefono.Text.Length != 0)
                {
                    telefono = Convert.ToInt32(txtTelefono.Text);
                }

                if (txtMovil.Text.Length != 0)
                {
                    movil = Convert.ToInt32(txtMovil.Text);
                }

                DateTime fecha = Convert.ToDateTime(fecha_nacimiento.Text);
                //determinar el sexo   
                char sexo = 'f';
                if (this.cbSexo.SelectedIndex == 1)
                {
                    sexo = 'm';
                }
                //determinar el estado civil
                string estado = cbEstado.SelectedItem.ToString();
                string grupo = cbSangre.SelectedItem.ToString();
                string empresa = cbEmpresa.SelectedItem.ToString();

                switch (editar)
                {
                    case 2:
                        //update
                        if (ClienteIT.UpdateCliente(txtNombre.Text, txtApe1.Text, txtApe2.Text, txtCedula.Text, fecha, txtEdad.Text, sexo, txtDireccion.Text, estado, grupo, empresa,
                            txtProfesion.Text, telefono, movil, txtEmail.Text))
                        {
                            MessageBox.Show("El Cliente se ha Actualizado con Exito", "Actualizacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Hide();
                            frmVerExpediente splash = new frmVerExpediente();
                            splash.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Error al Actualizar el Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case 3:
                        //ingresar
                        //si se inserto bn en el cliente y la anamnesis y el expediente
                        //if (ClienteIT.InsertaCliente(txtNombre.Text, txtApe1.Text, txtApe2.Text, txtCedula.Text, fecha,
                        //sexo, estado, grupo, txtProfesion.Text, telefono, movil,
                        //txtEmail.Text, txtDireccion.Text, txtEdad.Text, empresa,fotoBinaria))
                        //{
                        //    MessageBox.Show("Cliente Guardado con Exito", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //    this.Hide();
                        //    frmVerExpediente splash = new frmVerExpediente();
                        //    splash.ShowDialog();
                        //}
                        ////si hay campos vacios imprime error
                        //else
                        //{
                        //    MessageBox.Show("Error al insertar el Cliente\n Es Posible que esa cedula ya exista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //}
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Hay Campos Obligatorios Vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        public void cargaComboEmpresas()
        {
            List<EmpresaEntity> listaEmpresas = new List<EmpresaEntity>();
            listaEmpresas = EmpresaIT.getAllEmpresas();
            for (int i = 0; i < listaEmpresas.Count; i++)
            {
                cbEmpresa.Items.Add(listaEmpresas[i].nombre.ToUpper().ToString());
            }
            cbEmpresa.SelectedIndex = 1;
        }

        private void frm_Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
