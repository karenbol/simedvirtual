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
        public int accionArealizar = 0;

        public frm_Cliente()
        {
            InitializeComponent();
            cargaComboEmpresas();
            cbEstado.SelectedIndex = 0;
            cbSangre.SelectedIndex = 0;
            cbSexo.SelectedIndex = 0;
            editar = 3;
        }

        public frm_Cliente(string cedula, int pver)
        {
            InitializeComponent();
            accionArealizar = pver;

            //igualo a la variable estatica
            editar = pver;
            this.determinaCliente(cedula);
            pbFotoCliente.Image = PersonaIT.GetImagePacient(cedula);
            //si solo voy a ver deshabilito todo
            if (pver == 1)
            {
                lblTitulo.Text = "INFORMACION DEL CLIENTE";
                this.btnGuardar.Hide();
                ((Control)this.tabPageInfoPersonal).Enabled = false;
            }
            else if (pver == 2)
            //si voy a editar deshabilito la cedula
            {
                txtCedula.Enabled = false;
                lblTitulo.Text = "EDITAR CLIENTES";
            }
        }

        //quema la interfaz con los datos del cliente
        public void determinaCliente(string pCedula)
        {
            List<PersonaEntity> listaCliente = PersonaIT.selectClientePorCedula(pCedula);

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

            cbEstado.SelectedIndex = cbEstado.Items.IndexOf(listaCliente.ElementAt(0).estado_civil.ToString());

            cbSangre.SelectedIndex = cbSangre.Items.IndexOf(listaCliente.ElementAt(0).grupo_sanguineo.ToString());

            cargaComboEmpresas();

            cbEmpresa.SelectedValue = listaCliente.ElementAt(0).empresa;

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

        //metodo que carga TODAS LAS EMPRESAS registradas EN EL  COMBO BOX
        public void cargaComboEmpresas()
        {
            List<EmpresaEntity> listaEmpresas = new List<EmpresaEntity>();
            listaEmpresas = EmpresaIT.getAllEmpresas();

            if (listaEmpresas.Count != 0)
            {
                //asigno los datos al combobox
                cbEmpresa.DataSource = listaEmpresas;
                //lo que quiero obtener
                cbEmpresa.ValueMember = "id";
                //lo q voy a mostrar
                cbEmpresa.DisplayMember = "nombre";
                cbEmpresa.SelectedIndex = 0;
            }
        }

        private void pbFotoCliente_Click(object sender, EventArgs e)
        {
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
                int empresa = Convert.ToInt32(cbEmpresa.SelectedValue);

                this.verificaFoto();

                switch (editar)
                {
                    case 2:
                        //update
                        if (PersonaIT.UpdateCliente(txtNombre.Text, txtApe1.Text, txtApe2.Text, txtCedula.Text, fecha, txtDireccion.Text, txtEdad.Text, sexo,
                            estado, grupo, txtProfesion.Text, telefono, movil, txtEmail.Text, empresa, fotoBinaria, false))
                        {
                            MessageBox.Show("EL CLIENTE SE HA ACTUALIZADO CON EXITO", "ACTUALIZACION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Hide();
                            frmVerExpediente splash = new frmVerExpediente();
                            splash.ShowDialog();
                            
                        }
                        else
                        {
                            MessageBox.Show("ERROR AL ACTUALIZAR EL CLIENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case 3:
                        //ingresar
                        //si se inserto bn en el cliente y la anamnesis y el expediente
                        if (PersonaIT.InsertaCliente(txtNombre.Text, txtApe1.Text, txtApe2.Text, txtCedula.Text, fecha,
                        txtDireccion.Text, txtEdad.Text, sexo, estado, grupo, txtProfesion.Text, telefono, movil,
                        txtEmail.Text, empresa, fotoBinaria, false, DateTime.Now))
                        {
                            MessageBox.Show("CLIENTE GUARDADO CON EXITO", "INSERCION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Hide();
                            frmVerExpediente splash = new frmVerExpediente();
                            splash.ShowDialog();
                            
                        }
                        //si hay campos vacios imprime error
                        else
                        {
                            MessageBox.Show("ERROR AL INSERTAR EL CLIENTE\nES POSIBLE QUE LA CEDULA YA EXISTA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("HAY CAMPOS OBLIGATORIOS VACIOS", "CAMPOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frm_Cliente_Load(object sender, EventArgs e)
        {
            toolTip1.InitialDelay = 1;

            toolTip1.SetToolTip(pbFotoCliente, "Click Para Seleccionar Foto");
            toolTip1.SetToolTip(btnGuardar, "Guardar la Información del Cliente");

            toolTip1.SetToolTip(btnEliminarFoto, "Elimina la Foto Seleccionada");
        }

        public void verificaFoto()
        {
            if (fotoBinaria == null)
            {
                fotoBinaria = this.saveImage(frm_ExpedienteMG.rutaDefault);
            }
        }

        private void frm_Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            //si lo quiere es ver me devuelvo a ver los expedientes
            if ((accionArealizar == 1) || (accionArealizar == 2))
            {
                this.Hide();
                frmVerExpediente splash = new frmVerExpediente();
                splash.ShowDialog();                
            }
            //si soy adm e ingrese desde splash, me devuelvo a splash
            else if (Frm_Ingreso.datosUsuario[3].Equals("1") && accionArealizar == 0)
            {
                this.Hide();
                Frm_Splash splash = new Frm_Splash();
                splash.ShowDialog();                
            }
        }

        private void btnEliminarFoto_Click(object sender, EventArgs e)
        {
            pbFotoCliente.ImageLocation = frm_ExpedienteMG.rutaDefault;
        }
    }
}
