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


        //parametro que me dice si guardo toda la info o solo la reconsulta
        public bool expOreconsulta;
        public string cedulaPublica = "";
        public string usuarioPublico = "";

        public frm_ExpedienteMG(string datosUsuario)
        {
            InitializeComponent();
            label29.Text = datosUsuario;  //asignamos el nombre del usuario
            usuarioPublico = datosUsuario;

            //vamos a guardar en el cliente y en el expediente
            expOreconsulta = false;

            txtTratDiabetes.Visible = false;
            lblTratamiento.Visible = false;

            txtTratHipertension.Visible = false;
            lblTratHipertension.Visible = false;

            txtTratAsma.Visible = false;
            lblTratAsma.Visible = false;

            txtTratTiroides.Visible = false;
            lblTratTiroides.Visible = false;

            txtAlergias.Visible = false;

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

            //vamos a guardar solo en el exp xq es reconsulta
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

            //----------------------------anamnesis----------------------

            // revision de combo boxes anamnesis
            if (tabaquismo == 's')
            {
                r1.Checked = true;
            }
            else if (tabaquismo == 'n')
            {
                r2.Checked = true;
            }

            //ingesta medicamentos
            if (ingesta == 's')
            {
                r3.Checked = true;
            }
            else if (ingesta == 'n')
            {
                r4.Checked = true;
            }

            //alcoholismo
            if (alcoholismo == 's')
            {
                r5.Checked = true;
            }
            else if (alcoholismo == 'n')
            {
                r6.Checked = true;
            }

            //rehabilitacion
            if (rehabilitacion == 's')
            {
                r7.Checked = true;
            }
            else if (rehabilitacion == 'n')
            {
                r8.Checked = true;
            }

            //dolor cabeza
            if (dolor_cabeza == 's')
            {
                r9.Checked = true;
            }
            else if (dolor_cabeza == 'n')
            {
                r10.Checked = true;
            }

            //epilepsia
            if (epilepsia == 's')
            {
                r11.Checked = true;
            }
            else if (epilepsia == 'n')
            {
                r12.Checked = true;
            }
            //vertigo
            if (vertigo == 's')
            {
                r13.Checked = true;
            }
            else if (vertigo == 'n')
            {
                r14.Checked = true;
            }

            //depresion
            if (depresion == 's')
            {
                r15.Checked = true;
            }
            else if (depresion == 'n')
            {
                r16.Checked = true;
            }

            //falta_aire
            if (falta_aire == 's')
            {
                r17.Checked = true;
            }
            else if (falta_aire == 'n')
            {
                r18.Checked = true;
            }
            //enf oidos ojos
            if (enf_ojos_oidos == 's')
            {
                r19.Checked = true;
            }
            else if (enf_ojos_oidos == 'n')
            {
                r20.Checked = true;
            }
            //aqui falta dolor de pecho, enfermedades nerviosas y alergias



            //diabetes
            if (diabetes == 's')
            {
                r27.Checked = true;
            }
            else if (diabetes == 'n')
            {
                r28.Checked = true;
            }

            txtTratDiabetes.Text = diabetes_trat; //diabetes tratamiento

            //hipertension
            if (hipertension == 's')
            {
                r29.Checked = true;
            }
            else if (hipertension == 'n')
            {
                r30.Checked = true;
            }
            txtTratHipertension.Text = hipertension_trat;//tratmiento de hipertension

            //aqui falta asma y tiroides

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
            this.r1.Enabled = false;
            this.r2.Enabled = false;
            this.r3.Enabled = false;
            this.r4.Enabled = false;
            this.r5.Enabled = false;
            this.r6.Enabled = false;
            this.r7.Enabled = false;
            this.r8.Enabled = false;
            this.r9.Enabled = false;
            this.r10.Enabled = false;
            this.r11.Enabled = false;
            this.r12.Enabled = false;
            this.r13.Enabled = false;
            this.r14.Enabled = false;
            this.r15.Enabled = false;
            this.r16.Enabled = false;
            this.r17.Enabled = false;
            this.r18.Enabled = false;
            this.r19.Enabled = false;
            this.r20.Enabled = false;
            this.r21.Enabled = false;
            this.r22.Enabled = false;
            this.r23.Enabled = false;
            this.r24.Enabled = false;
            this.r25.Enabled = false;
            this.r26.Enabled = false;
            this.r27.Enabled = false;
            this.r28.Enabled = false;
            this.r29.Enabled = false;
            this.r30.Enabled = false;
            this.r31.Enabled = false;
            this.r32.Enabled = false;
            this.r33.Enabled = false;
            this.r34.Enabled = false;


            txtTratDiabetes.Enabled = false;
            txtTratHipertension.Enabled = false;
            txtObservaciones.Enabled = false;
        }

        //opciond de cargar foto de paciente
        private void pbPaciente_Click(object sender, EventArgs e)
        {
            //lblPb.Visible = false;
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
        //private void checkBox1_Click(object sender, EventArgs e)
        //{
        //    if (check1.Checked)
        //    {
        //        check2.Enabled = false;
        //    }
        //    else if (check1.Checked == false)
        //    {
        //        check2.Enabled = true;
        //    }
        //}
        //private void checkBox2_Click(object sender, EventArgs e)
        //{
        //    if (check2.Checked)
        //    {
        //        check1.Enabled = false;
        //    }
        //    else if (check2.Checked == false)
        //    {
        //        check1.Enabled = true;
        //    }
        //}
        //private void check3_Click(object sender, EventArgs e)
        //{
        //    if (check3.Checked)
        //    {
        //        check4.Enabled = false;
        //    }
        //    else if (check3.Checked == false)
        //    {
        //        check4.Enabled = true;
        //    }
        //}
        //private void check4_Click(object sender, EventArgs e)
        //{
        //    if (check4.Checked)
        //    {
        //        check3.Enabled = false;
        //    }
        //    else if (check4.Checked == false)
        //    {
        //        check3.Enabled = true;
        //    }
        //}
        //private void check5_Click(object sender, EventArgs e)
        //{
        //    if (check5.Checked)
        //    {
        //        check6.Enabled = false;
        //    }
        //    else if (check5.Checked == false)
        //    {
        //        check6.Enabled = true;
        //    }
        //}
        //private void check6_Click(object sender, EventArgs e)
        //{

        //    if (check6.Checked)
        //    {
        //        check5.Enabled = false;
        //    }
        //    else if (check6.Checked == false)
        //    {
        //        check5.Enabled = true;
        //    }
        //}
        //private void check7_Click(object sender, EventArgs e)
        //{
        //    if (check7.Checked)
        //    {
        //        check8.Enabled = false;
        //    }
        //    else if (check7.Checked == false)
        //    {
        //        check8.Enabled = true;
        //    }
        //}
        //private void check8_Click(object sender, EventArgs e)
        //{
        //    if (check8.Checked)
        //    {
        //        check7.Enabled = false;
        //    }
        //    else if (check8.Checked == false)
        //    {
        //        check7.Enabled = true;
        //    }
        //}
        //private void check9_Click(object sender, EventArgs e)
        //{
        //    if (check9.Checked)
        //    {
        //        txtTratDiabetes.Visible = true;
        //        lblTratamiento.Visible = true;
        //        check10.Enabled = false;
        //    }
        //    else if (!check9.Checked)
        //    {
        //        txtTratDiabetes.Visible = false;
        //        lblTratamiento.Visible = false;
        //        check10.Enabled = true;
        //    }
        //}
        //private void check10_Click(object sender, EventArgs e)
        //{
        //    if (check10.Checked)
        //    {
        //        check9.Enabled = false;
        //    }
        //    else if (check10.Checked == false)
        //    {
        //        check9.Enabled = true;
        //    }
        //}
        //private void check11_Click(object sender, EventArgs e)
        //{
        //    if (check11.Checked)
        //    {
        //        txtTratHipertension.Visible = true;
        //        lblTratHipertension.Visible = true;
        //        check12.Enabled = false;
        //    }
        //    else if (!check11.Checked)
        //    {
        //        txtTratHipertension.Visible = false;
        //        lblTratHipertension.Visible = false;
        //        check12.Enabled = true;
        //    }
        //}
        //private void check12_Click(object sender, EventArgs e)
        //{

        //}
        //private void check13_Click(object sender, EventArgs e)
        //{
        //    if (check13.Checked)
        //    {
        //        check14.Enabled = false;
        //    }
        //    else if (check13.Checked == false)
        //    {
        //        check14.Enabled = true;
        //    }
        //}
        //private void check14_Click(object sender, EventArgs e)
        //{
        //    if (check14.Checked)
        //    {
        //        check13.Enabled = false;
        //    }
        //    else if (check14.Checked == false)
        //    {
        //        check13.Enabled = true;
        //    }
        //}
        //private void check15_Click(object sender, EventArgs e)
        //{
        //    if (check15.Checked)
        //    {
        //        check16.Enabled = false;
        //    }
        //    else if (check15.Checked == false)
        //    {
        //        check16.Enabled = true;
        //    }
        //}
        //private void check16_Click(object sender, EventArgs e)
        //{
        //    if (check16.Checked)
        //    {
        //        check15.Enabled = false;
        //    }
        //    else if (check16.Checked == false)
        //    {
        //        check15.Enabled = true;
        //    }
        //}
        //private void check17_Click(object sender, EventArgs e)
        //{
        //    if (check17.Checked)
        //    {
        //        check18.Enabled = false;
        //    }
        //    else if (check17.Checked == false)
        //    {
        //        check18.Enabled = true;
        //    }
        //}
        //private void check18_Click(object sender, EventArgs e)
        //{
        //    if (check18.Checked)
        //    {
        //        check17.Enabled = false;
        //    }
        //    else if (check18.Checked == false)
        //    {
        //        check17.Enabled = true;
        //    }
        //}
        //private void check19_Click(object sender, EventArgs e)
        //{
        //    if (check19.Checked)
        //    {
        //        check20.Enabled = false;
        //    }
        //    else if (check19.Checked == false)
        //    {
        //        check20.Enabled = true;
        //    }
        //}
        //private void check20_Click(object sender, EventArgs e)
        //{
        //    if (check20.Checked)
        //    {
        //        check19.Enabled = false;
        //    }
        //    else if (check20.Checked == false)
        //    {
        //        check19.Enabled = true;
        //    }
        //}
        //private void check21_Click(object sender, EventArgs e)
        //{
        //    if (check21.Checked)
        //    {
        //        check22.Enabled = false;
        //    }
        //    else if (check21.Checked == false)
        //    {
        //        check22.Enabled = true;
        //    }
        //}
        //private void check22_Click(object sender, EventArgs e)
        //{
        //    if (check22.Checked)
        //    {
        //        check21.Enabled = false;
        //    }
        //    else if (check22.Checked == false)
        //    {
        //        check21.Enabled = true;
        //    }
        //}
        //private void check23_Click(object sender, EventArgs e)
        //{
        //    if (check23.Checked)
        //    {
        //        check24.Enabled = false;
        //    }
        //    else if (check23.Checked == false)
        //    {
        //        check24.Enabled = true;
        //    }
        //}
        //private void check24_Click(object sender, EventArgs e)
        //{
        //    if (check24.Checked)
        //    {
        //        check23.Enabled = false;
        //    }
        //    else if (check24.Checked == false)
        //    {
        //        check23.Enabled = true;
        //    }
        //}

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

                //se verifican cuales checks estan seleccionados
                seleccionChecks();

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
        //determina cuales checks de la amamnesis estan seleccionados y asigna valor a la variable
        public void seleccionChecks()
        {
            //determinar check de anamnesis
            //tabaquismo
            if (r1.Checked == true)
            {
                tabaquismo = 's';
            }
            else if (r2.Checked == true)
            {
                tabaquismo = 'n';
            }
            //ingesta de medicamentos
            if (r3.Checked == true)
            {
                ingesta = 's';
            }
            else if (r4.Checked == true)
            {
                ingesta = 'n';
            }
            //alcoholismo
            if (r5.Checked == true)
            {
                alcoholismo = 's';
            }
            else if (r6.Checked == true)
            {
                alcoholismo = 'n';
            }

            //rehabilitacion
            if (r7.Checked == true)
            {
                rehabilitacion = 's';
            }
            else if (r8.Checked == true)
            {
                rehabilitacion = 'n';
            }
            //dolor de cabeza
            if (r9.Checked == true)
            {
                dolor_cabeza = 's';
            }
            else if (r10.Checked == true)
            {
                dolor_cabeza = 'n';
            }
            //epilepsia
            if (r11.Checked == true)
            {
                epilepsia = 's';
            }
            else if (r12.Checked == true)
            {
                epilepsia = 'n';
            }
            //vertigo
            if (r13.Checked == true)
            {
                vertigo = 's';
            }
            else if (r14.Checked == true)
            {
                vertigo = 'n';
            }
            //depresion
            if (r15.Checked == true)
            {
                depresion = 's';
            }
            else if (r16.Checked == true)
            {
                depresion = 'n';
            }
            //falta de aire
            if (r17.Checked == true)
            {
                falta_aire = 's';
            }
            else if (r18.Checked == true)
            {
                falta_aire = 'n';
            }
            //ojos y oidos
            if (r19.Checked == true)
            {
                oidos_ojos = 's';
            }
            else if (r20.Checked == true)
            {
                oidos_ojos = 'n';
            }


            //falta dolor pecho, enfermedades nerviosas y alergias



            //diabetes
            if (r27.Checked == true)
            {
                diabetes = 's';
            }
            else if (r28.Checked == true)
            {
                diabetes = 'n';
            }

            //hipertension
            if (r29.Checked == true)
            {
                hipertension = 's';
            }
            else if (r30.Checked == true)
            {
                hipertension = 'n';
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

            toolTip1.SetToolTip(pbPaciente, "Cargar Foto de Paciente");

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
        //////////////////////////////////////////////


        //si se activa el check de diabetess
        private void r27_Click(object sender, EventArgs e)
        {
            txtTratDiabetes.Visible = true;
            lblTratamiento.Visible = true;
        }

        private void r28_Click(object sender, EventArgs e)
        {
            txtTratDiabetes.Visible = false;
            lblTratamiento.Visible = false;
        }



        //check de hipertension
        private void r29_Click(object sender, EventArgs e)
        {
            txtTratHipertension.Visible = true;
            lblTratHipertension.Visible = true;
        }
        private void r30_Click(object sender, EventArgs e)
        {
            txtTratHipertension.Visible = false;
            lblTratHipertension.Visible = false;
        }

        //check de asma
        private void r31_Click(object sender, EventArgs e)
        {
            txtTratAsma.Visible = true;
            lblTratAsma.Visible = true;
        }
        private void r32_Click(object sender, EventArgs e)
        {
            txtTratAsma.Visible = false;
            lblTratAsma.Visible = false;
        }


        //check de tiroides
        private void r33_Click(object sender, EventArgs e)
        {
            txtTratTiroides.Visible = true;
            lblTratTiroides.Visible = true;
        }
        private void r34_Click(object sender, EventArgs e)
        {
            txtTratTiroides.Visible = false;
            lblTratTiroides.Visible = false;
        }

        //check de alergias
        private void r25_Click(object sender, EventArgs e)
        {
            txtAlergias.Visible = true;
        }

        private void r26_Click(object sender, EventArgs e)
        {
            txtAlergias.Visible = !true;
        }
    }
}


