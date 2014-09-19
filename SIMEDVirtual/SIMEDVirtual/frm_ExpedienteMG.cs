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
    public partial class frm_ExpedienteMG : Form
    {
        //parametro que me dice si guardo toda la info o solo la reconsulta
        public bool expOreconsulta;
        public string cedulaPublica = "";
        public string usuarioPublico = "";


        //metodo para constructor, en caso de que se quiera editar, se elimna una tab
        //public frm_ExpedienteMG(Boolean editar)
        //{
        //    if (editar)
        //    {

        //        //tabControl1.Remove(tabPageEpicrisis);


        //        int idx = tabControl1.TabPages.IndexOf(tabPageEpicrisis);
        //        tabControl1.TabPages.RemoveAt(idx);
        //        //tabControl1.TabPages.Add(tabPagePrueba);
        //        //tabControl1.TabPages.Remove(tabPagePrueba);
        //    }
        //}


        public frm_ExpedienteMG(string datosUsuario)
        {
            InitializeComponent();
            //asignamos el nombre del usuario
            label29.Text = datosUsuario;
            usuarioPublico = datosUsuario;

            //vamos a guardar en el cliente y en el expediente
            expOreconsulta = false;

            txtTratDiabetes.Visible = false;
            lblTratamiento.Visible = false;

            txtTratHipertension.Visible = false;
            lblTratHipertension.Visible = false;

            fecha_nacimiento.Format = DateTimePickerFormat.Custom;
            fecha_nacimiento.CustomFormat = "yyyy/MM/dd";

            //iniciamos los combos
            cbEstado.SelectedIndex = 0;
            cbSangre.SelectedIndex = 0;
            cbSexo.SelectedIndex = 0;
        }

        //segundo metodo constructor para la reconsulta
        public frm_ExpedienteMG(
            string nombre, string apellido1, string apellido2, string cedula, DateTime fecha, char sexo, string estado_Civil,
            string grupo, string profesion, int telefono, int movil, string email, string direccion, char tabaquismo,
            char ingesta, char alcoholismo, char rehabilitacion, char diabetes, string diabetes_trat,
            char hipertension, string hipertension_trat, char dolor_cabeza, char epilepsia, char vertigo, char depresion,
           char falta_aire, char enf_ojos_oidos, string observaciones, bool editar)
        {
            InitializeComponent();

            //vamos a guardar solo en el exp
            expOreconsulta = true;
            cedulaPublica = cedula;

            txtNombre.Text = nombre;
            txtApe1.Text = apellido1;
            txtApe2.Text = apellido2;
            txtCedula.Text = cedula;
            fecha_nacimiento.Value = fecha;

            //combo del sexo
            if (sexo == 'f')
            {
                cbSexo.SelectedIndex = 0;
            }
            else
            {
                cbSexo.SelectedIndex = 1;
            }
            //combo de estado civil
            if (estado_Civil == "SOLTERO")
            {
                cbEstado.SelectedIndex = 0;
            }
            else if (estado_Civil == "CASADO")
            {
                cbEstado.SelectedIndex = 1;
            }
            else if (estado_Civil == "VIUDO")
            {
                cbEstado.SelectedIndex = 2;
            }
            else if (estado_Civil == "DIVORCIADO")
            {
                cbEstado.SelectedIndex = 3;
            }
            else
            {
                cbEstado.SelectedIndex = 2;
            }

            //combo de la sangre
            if (grupo == "A+")
            {
                cbSangre.SelectedIndex = 0;
            }
            else if (grupo == "A-")
            {
                cbSangre.SelectedIndex = 1;
            }
            else if (grupo == "B+")
            {
                cbSangre.SelectedIndex = 2;
            }
            else if (grupo == "B-")
            {
                cbSangre.SelectedIndex = 3;
            }
            else if (grupo == "AB+")
            {
                cbSangre.SelectedIndex = 4;
            }
            else if (grupo == "AB-")
            {
                cbSangre.SelectedIndex = 5;
            }
            else if (grupo == "O+")
            {
                cbSangre.SelectedIndex = 6;
            }
            else
            {
                cbSangre.SelectedIndex = 7;
            }


            txtProfesion.Text = profesion;
            txtTelefono.Text = telefono.ToString();
            txtMovil.Text = movil.ToString();
            txtEmail.Text = email;
            txtDireccion.Text = direccion;
            txtObservaciones.Text = observaciones;

            //anamnesis
            if (tabaquismo == 's')
            {
                check1.Checked = true;
            }
            else if (tabaquismo == 'n')
            {
                check2.Checked = true;
            }
            //ingesta medicamentos
            if (ingesta == 's')
            {
                check3.Checked = true;
            }
            else if (ingesta == 'n')
            {
                check4.Checked = true;
            }
            //alcoholismo
            if (alcoholismo == 's')
            {
                check5.Checked = true;
            }
            else if (alcoholismo == 'n')
            {
                check6.Checked = true;
            }
            //reahabilitacion
            if (rehabilitacion == 's')
            {
                check7.Checked = true;
            }
            else if (rehabilitacion == 'n')
            {
                check8.Checked = true;
            }
            //diabetes
            if (diabetes == 's')
            {
                check9.Checked = true;
            }
            else if (diabetes == 'n')
            {
                check10.Checked = true;
            }
            //diabetes tratamiento
            txtTratDiabetes.Text = diabetes_trat;
            txtTratHipertension.Text = hipertension_trat;
            //hipertension
            if (hipertension == 's')
            {
                check11.Checked = true;
            }
            else if (hipertension == 'n')
            {
                check12.Checked = true;
            }
            //dolor cabeza
            if (dolor_cabeza == 's')
            {
                check13.Checked = true;
            }
            else if (dolor_cabeza == 'n')
            {
                check14.Checked = true;
            }
            //epilepsia
            if (epilepsia == 's')
            {
                check15.Checked = true;
            }
            else if (epilepsia == 'n')
            {
                check16.Checked = true;
            }
            //vertigo
            if (vertigo == 's')
            {
                check17.Checked = true;
            }
            else if (vertigo == 'n')
            {
                check18.Checked = true;
            }
            //depresion
            if (depresion == 's')
            {
                check19.Checked = true;
            }
            else if (depresion == 'n')
            {
                check20.Checked = true;
            }
            //falta_aire
            if (falta_aire == 's')
            {
                check21.Checked = true;
            }
            else if (falta_aire == 'n')
            {
                check22.Checked = true;
            }
            //enf oidos ojos
            if (enf_ojos_oidos == 's')
            {
                check23.Checked = true;
            }
            else if (enf_ojos_oidos == 'n')
            {
                check24.Checked = true;
            }

            //aqui no se puede editar nada
            if (editar == false)
            {
                this.DisableAnamnesis();
                this.DisableInfoPersonal();
            }
            else
            {
                txtCedula.Enabled = false;
            }

        }
        //deshabilita los campos de info personal
        public void DisableInfoPersonal()
        {
            this.txtNombre.Enabled = false;
            this.txtApe1.Enabled = false;
            this.txtApe2.Enabled = false;
            this.txtCedula.Enabled = false;
            this.fecha_nacimiento.Enabled = false;
            this.cbSexo.Enabled = false;
            this.cbEstado.Enabled = false;
            this.cbSangre.Enabled = false;
            this.txtProfesion.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtMovil.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtDireccion.Enabled = false;
        }
        //deshabilita los campos de anamnesis
        public void DisableAnamnesis()
        {
            this.check1.Enabled = false;
            this.check2.Enabled = false;
            this.check3.Enabled = false;
            this.check4.Enabled = false;
            this.check5.Enabled = false;
            this.check6.Enabled = false;
            this.check7.Enabled = false;
            this.check8.Enabled = false;
            this.check9.Enabled = false;
            this.check10.Enabled = false;
            this.check11.Enabled = false;
            this.check12.Enabled = false;
            this.check13.Enabled = false;
            this.check14.Enabled = false;
            this.check15.Enabled = false;
            this.check16.Enabled = false;
            this.check17.Enabled = false;
            this.check18.Enabled = false;
            this.check19.Enabled = false;
            this.check20.Enabled = false;
            this.check21.Enabled = false;
            this.check22.Enabled = false;
            this.check23.Enabled = false;
            this.check24.Enabled = false;

            txtTratDiabetes.Enabled = false;
            txtTratHipertension.Enabled = false;
            txtObservaciones.Enabled = false;
        }

        //opciond e cargar foto de paciente
        private void pbPaciente_Click(object sender, EventArgs e)
        {
            lblPb.Visible = false;
            opFile.Title = "Cargar Foto Médico";
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                string x = opFile.FileName;
                MessageBox.Show(x);
                opFile.Dispose();
                pbPaciente.ImageLocation = x;
            }
        }
        //-----------------checks---------------------------------------
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (check1.Checked)
            {
                check2.Enabled = false;
            }
            else if (check1.Checked == false)
            {
                check2.Enabled = true;
            }
        }
        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (check2.Checked)
            {
                check1.Enabled = false;
            }
            else if (check2.Checked == false)
            {
                check1.Enabled = true;
            }
        }
        private void check3_Click(object sender, EventArgs e)
        {
            if (check3.Checked)
            {
                check4.Enabled = false;
            }
            else if (check3.Checked == false)
            {
                check4.Enabled = true;
            }
        }
        private void check4_Click(object sender, EventArgs e)
        {
            if (check4.Checked)
            {
                check3.Enabled = false;
            }
            else if (check4.Checked == false)
            {
                check3.Enabled = true;
            }
        }
        private void check5_Click(object sender, EventArgs e)
        {
            if (check5.Checked)
            {
                check6.Enabled = false;
            }
            else if (check5.Checked == false)
            {
                check6.Enabled = true;
            }
        }
        private void check6_Click(object sender, EventArgs e)
        {

            if (check6.Checked)
            {
                check5.Enabled = false;
            }
            else if (check6.Checked == false)
            {
                check5.Enabled = true;
            }
        }
        private void check7_Click(object sender, EventArgs e)
        {
            if (check7.Checked)
            {
                check8.Enabled = false;
            }
            else if (check7.Checked == false)
            {
                check8.Enabled = true;
            }
        }
        private void check8_Click(object sender, EventArgs e)
        {
            if (check8.Checked)
            {
                check7.Enabled = false;
            }
            else if (check8.Checked == false)
            {
                check7.Enabled = true;
            }
        }
        private void check9_Click(object sender, EventArgs e)
        {
            if (check9.Checked)
            {
                txtTratDiabetes.Visible = true;
                lblTratamiento.Visible = true;
                check10.Enabled = false;
            }
            else if (!check9.Checked)
            {
                txtTratDiabetes.Visible = false;
                lblTratamiento.Visible = false;
                check10.Enabled = true;
            }
        }
        private void check10_Click(object sender, EventArgs e)
        {
            if (check10.Checked)
            {
                check9.Enabled = false;
            }
            else if (check10.Checked == false)
            {
                check9.Enabled = true;
            }
        }
        private void check11_Click(object sender, EventArgs e)
        {
            if (check11.Checked)
            {
                txtTratHipertension.Visible = true;
                lblTratHipertension.Visible = true;
                check12.Enabled = false;
            }
            else if (!check11.Checked)
            {
                txtTratHipertension.Visible = false;
                lblTratHipertension.Visible = false;
                check12.Enabled = true;
            }
        }
        private void check12_Click(object sender, EventArgs e)
        {

        }
        private void check13_Click(object sender, EventArgs e)
        {
            if (check13.Checked)
            {
                check14.Enabled = false;
            }
            else if (check13.Checked == false)
            {
                check14.Enabled = true;
            }
        }
        private void check14_Click(object sender, EventArgs e)
        {
            if (check14.Checked)
            {
                check13.Enabled = false;
            }
            else if (check14.Checked == false)
            {
                check13.Enabled = true;
            }
        }
        private void check15_Click(object sender, EventArgs e)
        {
            if (check15.Checked)
            {
                check16.Enabled = false;
            }
            else if (check15.Checked == false)
            {
                check16.Enabled = true;
            }
        }
        private void check16_Click(object sender, EventArgs e)
        {
            if (check16.Checked)
            {
                check15.Enabled = false;
            }
            else if (check16.Checked == false)
            {
                check15.Enabled = true;
            }
        }
        private void check17_Click(object sender, EventArgs e)
        {
            if (check17.Checked)
            {
                check18.Enabled = false;
            }
            else if (check17.Checked == false)
            {
                check18.Enabled = true;
            }
        }
        private void check18_Click(object sender, EventArgs e)
        {
            if (check18.Checked)
            {
                check17.Enabled = false;
            }
            else if (check18.Checked == false)
            {
                check17.Enabled = true;
            }
        }
        private void check19_Click(object sender, EventArgs e)
        {
            if (check19.Checked)
            {
                check20.Enabled = false;
            }
            else if (check19.Checked == false)
            {
                check20.Enabled = true;
            }
        }
        private void check20_Click(object sender, EventArgs e)
        {
            if (check20.Checked)
            {
                check19.Enabled = false;
            }
            else if (check20.Checked == false)
            {
                check19.Enabled = true;
            }
        }
        private void check21_Click(object sender, EventArgs e)
        {
            if (check21.Checked)
            {
                check22.Enabled = false;
            }
            else if (check21.Checked == false)
            {
                check22.Enabled = true;
            }
        }
        private void check22_Click(object sender, EventArgs e)
        {
            if (check22.Checked)
            {
                check21.Enabled = false;
            }
            else if (check22.Checked == false)
            {
                check21.Enabled = true;
            }
        }
        private void check23_Click(object sender, EventArgs e)
        {
            if (check23.Checked)
            {
                check24.Enabled = false;
            }
            else if (check23.Checked == false)
            {
                check24.Enabled = true;
            }
        }
        private void check24_Click(object sender, EventArgs e)
        {
            if (check24.Checked)
            {
                check23.Enabled = false;
            }
            else if (check24.Checked == false)
            {
                check23.Enabled = true;
            }
        }

        //guarda el expediente. inserta en cliente y expediente
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (expOreconsulta == true)
            {
                if (txtTerapeutica.Text != string.Empty || txtDiagnostico.Text != string.Empty || txtObs.Text != string.Empty)
                {
                    //guardamos solo en el expediente
                    if (ExpedienteIT.InsertaExpediente(cedulaPublica, Convert.ToDateTime(dtFechaConsulta.Text), txtTerapeutica.Text, txtObs.Text))
                    {
                        MessageBox.Show("Reconsulta Insertada con Exito", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                        frmVerExpediente splash = new frmVerExpediente(usuarioPublico);
                        splash.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("No se puede insertar un Expediente con Campos Vacios", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                char sexo = 'f';
                char tabaquismo = ' ';
                char ingesta = ' ';
                char alcoholismo = ' ';
                char rehabilitacion = ' ';
                char diabetes = ' ';
                char hipertension = ' ';
                char dolor_cabeza = ' ';
                char epilepsia = ' ';
                char vertigo = ' ';
                char depresion = ' ';
                char falta_aire = ' ';
                char oidos_ojos = ' ';

                //determinar la fecha de nacimiento
                DateTime fecha = Convert.ToDateTime(fecha_nacimiento.Text);
                //determinar el sexo            
                if (this.cbSexo.SelectedIndex == 1)
                {
                    sexo = 'm';
                }
                //determinar el estado civil
                string estado = cbEstado.SelectedItem.ToString();
                string grupo = cbSangre.SelectedItem.ToString();

                //determinar check de anamnesis
                //tabaquismo
                if (check1.Checked == true)
                {
                    tabaquismo = 's';
                }
                else if (check2.Checked == true)
                {
                    tabaquismo = 'n';
                }
                //ingesta de medicamentos
                if (check3.Checked == true)
                {
                    ingesta = 's';
                }
                else if (check4.Checked == true)
                {
                    ingesta = 'n';
                }
                //alcoholismo
                if (check5.Checked == true)
                {
                    alcoholismo = 's';
                }
                else if (check6.Checked == true)
                {
                    alcoholismo = 'n';
                }
                //rehabilitacion
                if (check7.Checked == true)
                {
                    rehabilitacion = 's';
                }
                else if (check8.Checked == true)
                {
                    rehabilitacion = 'n';
                }
                //diabetes
                if (check9.Checked == true)
                {
                    diabetes = 's';
                }
                else if (check10.Checked == true)
                {
                    diabetes = 'n';
                }
                //hipertension
                if (check11.Checked == true)
                {
                    hipertension = 's';
                }
                else if (check12.Checked == true)
                {
                    hipertension = 'n';
                }
                //dolor de cabeza
                if (check13.Checked == true)
                {
                    dolor_cabeza = 's';
                }
                else if (check14.Checked == true)
                {
                    dolor_cabeza = 'n';
                }
                //epilepsia
                if (check15.Checked == true)
                {
                    epilepsia = 's';
                }
                else if (check16.Checked == true)
                {
                    epilepsia = 'n';
                }
                //vertigo
                if (check17.Checked == true)
                {
                    vertigo = 's';
                }
                else if (check18.Checked == true)
                {
                    vertigo = 'n';
                }
                //depresion
                if (check19.Checked == true)
                {
                    depresion = 's';
                }
                else if (check20.Checked == true)
                {
                    depresion = 'n';
                }
                //falta de aire
                if (check21.Checked == true)
                {
                    falta_aire = 's';
                }
                else if (check22.Checked == true)
                {
                    falta_aire = 'n';
                }
                //ojos y oidos
                if (check23.Checked == true)
                {
                    oidos_ojos = 's';
                }
                else if (check24.Checked == true)
                {
                    oidos_ojos = 'n';
                }
                //guardamos la cedula en una variable
                string cedula = txtCedula.Text;

                //--------------------------------------------------------insertar---------------

                //llamamos al metodo para insertar clientes
                try
                {
                    //se inserta solo si los campos obligatorios estan llenos 
                    if ((txtNombre.Text != string.Empty && txtApe1.Text != string.Empty && txtApe2.Text != string.Empty &&
                        txtCedula.Text != string.Empty && fecha_nacimiento.Text != string.Empty && cbSexo.Text != string.Empty &&
                        cbEstado.Text != string.Empty && cbSangre.Text != string.Empty && txtProfesion.Text != string.Empty &&
                        txtDireccion.Text != string.Empty) && (txtTerapeutica.Text != string.Empty || txtObs.Text != string.Empty))
                    {
                        if (ClienteIT.InsertaCliente(txtNombre.Text, txtApe1.Text, txtApe2.Text, cedula,
         fecha, sexo, estado, grupo, txtProfesion.Text, Convert.ToInt32(txtTelefono.Text),
         Convert.ToInt32(txtMovil.Text), txtEmail.Text, txtDireccion.Text,
         tabaquismo, ingesta, alcoholismo, rehabilitacion, diabetes, txtTratDiabetes.Text, hipertension, txtTratHipertension.Text,
         dolor_cabeza, epilepsia, vertigo, depresion, falta_aire, oidos_ojos, txtObservaciones.Text) &&
         (ExpedienteIT.InsertaExpediente(cedula, Convert.ToDateTime(dtFechaConsulta.Text), txtTerapeutica.Text, txtObs.Text)))
                        {

                            MessageBox.Show("Expediente Guardado con Exito", "Insercion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Hide();
                            frmVerExpediente splash = new frmVerExpediente(usuarioPublico);
                            splash.ShowDialog();
                        }
                    }
                    //si hay campos vacios imprime error
                    else
                    {
                        MessageBox.Show("Hay Campos Obligatorios Vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void frm_ExpedienteMG_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmVerExpediente splash = new frmVerExpediente(usuarioPublico);
            splash.ShowDialog();
        }

        private void btnVerExp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVerExpediente frm = new frmVerExpediente(usuarioPublico);
            frm.ShowDialog();
        }

        private void frm_ExpedienteMG_Load(object sender, EventArgs e)
        {
            toolTip1.InitialDelay = 1;

            toolTip1.SetToolTip(btnVerExp, "Ver Todos los Expedientes");
            toolTip1.SetToolTip(btnGuardar, "Guardar la Informacion del Paciente");

            //carga todas las empresas en el combo box
            cargaComboEmpresas();


        }

        //metodo que carga TODAS LAS EMPRESAS registradas EN EL  COMBO BOX
        public void cargaComboEmpresas()
        {
            List<EmpresaEntity> listaEmpresas = new List<EmpresaEntity>();
            listaEmpresas = EmpresaIT.getAllEmpresas();
            for (int i = 0; i < listaEmpresas.Count; i++)
            {
                comboBox1.Items.Add(listaEmpresas[i].nombre.ToUpper().ToString());
            }
        }

        private void tabPageInfoPersonal_Click(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void tabPageExFisico_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton68_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void label113_Click(object sender, EventArgs e)
        {

        }

        private void radioButton76_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton75_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


