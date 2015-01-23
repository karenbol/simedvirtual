using Npgsql;
using SIMEDVirtual.DA;
using SIMEDVirtual.Entity;
using SIMEDVirtual.IT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIMEDVirtual
{
    public partial class frm_ExpedienteMG : Form
    {
        public byte[] fotoBinaria;
        public static string rutaDefault = "C:\\SIMEDVirtual\\SIMEDVirtual\\SIMEDVirtual\\Properties\\camera.png";
        //anamnesis
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
        char dolor_pecho = ' ';
        char enf_nerviosas = ' ';
        char alergia = ' ';
        char asma = ' ';
        char tiroides = ' ';
        //************************ variables del expediente********************************************8
        string pulso = "";
        string presion_arterial = "";
        char soplos = ' ';
        char dolor_precordial = ' ';
        char edemas = ' ';
        char arritmias = ' ';
        char disnea = ' ';
        string observaciones_sc = "";
        string talla = "";
        string peso = "";
        string observaciones_sm = "";
        string brazo_derecho = "";
        string brazo_izquierdo = "";
        string pierna_derecha = "";
        string pierna_izquierda = "";
        char bicipal_derecho = ' ';
        char bicipal_izquierdo = ' ';
        char patelar_derecho = ' ';
        char patelar_izquierdo = ' ';
        char alquileano_derecho = ' ';
        char alquileano_izquierdo = ' ';
        char flexion = ' ';
        char extensiones = ' ';
        char rotacion = ' ';
        char inclinacion_lateral = ' ';
        string observaciones_cc = "";
        string malformaciones = "";
        char observaciones_dl = ' ';
        string observaciones_dl_txt = "";
        char petequias = ' ';
        char equimosis = ' ';
        char sangrado = ' ';
        string observaciones_sh = "";
        string examen_neurologico = "";
        string orl = "";
        string abdomen = "";
        char auscultacion = ' ';
        string observaciones_sr = "";
        char convulciones = ' ';
        char espasmos = ' ';
        char temblores = ' ';
        char movimientos_anormales = ' ';
        string otros_sn = "";
        string observaciones_sn = "";
        string otros_examen2 = "";
        DateTime fecha_expediente;
        string diagnostico = "";
        string terapeutica = "";
        string observaciones_generales = "";
        string motivo_consulta = "";
        string saturacionOx = "";
        string temperatura = "";
        //parametro que me dice si guardo toda la info o solo la reconsulta
        public bool expOreconsulta;
        public bool editarExpediente;
        bool casoEspecial = false;
        public int id_pacient = 0;
        public string cedulaPublica = "";
        //public string usuarioPublico = "";

        //da valor a los parametros para llenar el expediente medico
        public void determinaExpediente()
        {
            pulso = txtPulso.Text;
            presion_arterial = txtPresionArterial.Text;

            //soplos
            if (rx1.Checked)
            {
                soplos = 's';
            }
            else if (rx2.Checked)
            {
                soplos = 'n';
            }

            //dolor precordial
            if (rx3.Checked)
            {
                dolor_precordial = 's';
            }
            else if (rx4.Checked)
            {
                dolor_precordial = 'n';
            }

            //edemas
            if (rx5.Checked)
            {
                edemas = 's';
            }
            else if (rx6.Checked)
            {
                edemas = 'n';
            }

            //arritmias
            if (rx7.Checked)
            {
                arritmias = 's';
            }
            else if (rx8.Checked)
            {
                arritmias = 'n';
            }

            //disneas
            if (rx9.Checked)
            {
                disnea = 's';
            }
            else if (rx10.Checked)
            {
                disnea = 'n';
            }

            observaciones_sc = txtObservacionesSC.Text;
            talla = txtTalla.Text;
            peso = txtPeso.Text;
            observaciones_sm = txtObservacionesSE.Text;
            brazo_derecho = txtBrazoDech.Text;
            brazo_izquierdo = txtBrazoIzq.Text;
            pierna_derecha = txtPiernaDer.Text;
            pierna_izquierda = txtPiernaIzq.Text;

            //bicipal derecho
            if (rx11.Checked)
            {
                bicipal_derecho = 'n';
            }
            else if (rx12.Checked)
            {
                bicipal_derecho = 'a';
            }

            //bicipal izq
            if (rx13.Checked)
            {
                bicipal_izquierdo = 'n';
            }
            else if (rx14.Checked)
            {
                bicipal_izquierdo = 'a';
            }

            //patelar derch
            if (rx15.Checked)
            {
                patelar_derecho = 'n';
            }
            else if (rx16.Checked)
            {
                patelar_derecho = 'a';
            }

            //patelar izq
            if (rx17.Checked)
            {
                patelar_izquierdo = 'n';
            }
            else if (rx18.Checked)
            {
                patelar_izquierdo = 'a';
            }

            //alquieano derch
            if (rx19.Checked)
            {
                alquileano_derecho = 'n';
            }
            else if (rx20.Checked)
            {
                alquileano_derecho = 'a';
            }

            //alquieano izq
            if (rx21.Checked)
            {
                alquileano_izquierdo = 'n';
            }
            else if (rx22.Checked)
            {
                alquileano_izquierdo = 'a';
            }

            //flexion
            if (rx23.Checked)
            {
                flexion = 'n';
            }
            else if (rx24.Checked)
            {
                flexion = 'a';
            }

            //extensiones
            if (rx25.Checked)
            {
                extensiones = 'n';
            }
            else if (rx26.Checked)
            {
                extensiones = 'a';
            }

            //rotacion
            if (rx27.Checked)
            {
                rotacion = 'n';
            }
            else if (rx28.Checked)
            {
                rotacion = 'a';
            }

            //inclinacion lateral
            if (rx29.Checked)
            {
                inclinacion_lateral = 'n';
            }
            else if (rx30.Checked)
            {
                inclinacion_lateral = 'a';
            }

            observaciones_cc = txtObservacionesCC.Text;
            malformaciones = txtMalformaciones.Text;

            //observaciones dl
            if (rx31.Checked)
            {
                observaciones_dl = 'n';
            }
            else if (rx32.Checked)
            {
                observaciones_dl = 'a';
            }

            observaciones_dl_txt = txtObservacionesCDL.Text;

            //**************** examen fisico 2*********************

            //petequias
            if (rx33.Checked)
            {
                petequias = 's';
            }
            else if (rx34.Checked)
            {
                petequias = 'n';
            }

            //equimosis
            if (rx35.Checked)
            {
                equimosis = 's';
            }
            else if (rx36.Checked)
            {
                equimosis = 'n';
            }

            //sangrado
            if (rx37.Checked)
            {
                sangrado = 's';
            }
            else if (rx38.Checked)
            {
                sangrado = 'n';
            }

            observaciones_sh = txtObservacionesSH.Text;
            examen_neurologico = txtExamenNeurologico.Text;
            orl = txtOrl.Text;
            abdomen = txtAbdomen.Text;

            //auscultacion
            if (rx39.Checked)
            {
                auscultacion = 'n';
            }
            else if (rx40.Checked)
            {
                auscultacion = 'a';
            }

            observaciones_sr = txtObservacionesSR.Text;

            //convulciones
            if (rx41.Checked)
            {
                convulciones = 's';
            }
            else if (rx42.Checked)
            {
                convulciones = 'n';
            }

            //espasmos
            if (rx43.Checked)
            {
                espasmos = 's';
            }
            else if (rx44.Checked)
            {
                espasmos = 'n';
            }

            //temblores
            if (rx45.Checked)
            {
                temblores = 's';
            }
            else if (rx46.Checked)
            {
                temblores = 'n';
            }

            //mov anormales
            if (rx47.Checked)
            {
                movimientos_anormales = 's';
            }
            else if (rx48.Checked)
            {
                movimientos_anormales = 'n';
            }

            otros_sn = txtOtrosSN.Text;
            observaciones_sn = txtObservacionesSN.Text;
            otros_examen2 = txtOtrosExamen2.Text;
            //fecha creacion de expediente
            fecha_expediente = Convert.ToDateTime(dtFechaConsulta.Text);
            diagnostico = txtDiagnostico.Text;
            terapeutica = txtTerapeutica.Text;
            observaciones_generales = txtObs.Text;

            motivo_consulta = txtMotivoConsulta.Text;
            saturacionOx = txtSaturacionOx.Text;
            temperatura = txtTemperatura.Text;
            //falta la cedula y el id medico 
        }
        //determina el tipo se sangre y lo asigna al combo
        public void determinaTipoSangre(string grupo)
        {
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
        }

        public void determinaEstadoCivil(string estado_Civil)
        {
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
            else if (estado_Civil == "UNION LIBRE")
            {
                cbEstado.SelectedIndex = 4;
            }
        }

        public void determinaAnamnesis(string cedula)
        {
            List<anamnesis> listaAnamnesis = anamnesisIT.selectAnamnesisPorCedula(cedula);

            //anamnesis
            if (listaAnamnesis.Count != 0)
            {
                char tabaquismo = Convert.ToChar(listaAnamnesis.ElementAt(0).tabaquismo);
                char ingesta = Convert.ToChar(listaAnamnesis.ElementAt(0).ingesta_medicamentos);
                char alcoholismo = Convert.ToChar(listaAnamnesis.ElementAt(0).alcoholismo);
                char rehabilitacion = Convert.ToChar(listaAnamnesis.ElementAt(0).rehabilitacion);
                char diabetes = Convert.ToChar(listaAnamnesis.ElementAt(0).diabetes);
                char hipertension = Convert.ToChar(listaAnamnesis.ElementAt(0).hipertension);
                char dolor_cabeza = Convert.ToChar(listaAnamnesis.ElementAt(0).dolor_Cabeza);
                char epilepsia = Convert.ToChar(listaAnamnesis.ElementAt(0).epilepsia);
                char vertigo = Convert.ToChar(listaAnamnesis.ElementAt(0).vertigo);
                char depresion = Convert.ToChar(listaAnamnesis.ElementAt(0).depre);
                char falta_aire = Convert.ToChar(listaAnamnesis.ElementAt(0).falta_aire);
                char enf_ojos_oidos = Convert.ToChar(listaAnamnesis.ElementAt(0).enf_ojos_oidos);
                char dolor_pecho = Convert.ToChar(listaAnamnesis.ElementAt(0).dolor_pecho);
                char enf_nerviosas = Convert.ToChar(listaAnamnesis.ElementAt(0).enf_nerviosas);
                char alergia = Convert.ToChar(listaAnamnesis.ElementAt(0).alergias);
                string alergia_trat = Convert.ToString(listaAnamnesis.ElementAt(0).alergias_tratamiento);
                string diabetes_trat = Convert.ToString(listaAnamnesis.ElementAt(0).diabetes_trat);
                string hipertension_trat = Convert.ToString(listaAnamnesis.ElementAt(0).hipertension_trat);
                char asma = Convert.ToChar(listaAnamnesis.ElementAt(0).asma);
                string asma_trat = Convert.ToString(listaAnamnesis.ElementAt(0).asma_tratamiento);
                char tiroides = Convert.ToChar(listaAnamnesis.ElementAt(0).tiroides);
                string tiroides_trat = Convert.ToString(listaAnamnesis.ElementAt(0).tiroides_tratamiento);

                string hipertension_heredo = Convert.ToString(listaAnamnesis.ElementAt(0).hipertension_heredo);
                string diabetes_heredo = Convert.ToString(listaAnamnesis.ElementAt(0).diabetes_heredo);
                string cancer_heredo = Convert.ToString(listaAnamnesis.ElementAt(0).cancer_heredo);
                string tiroides_heredo = Convert.ToString(listaAnamnesis.ElementAt(0).tiroides_heredo);
                string asma_heredo = Convert.ToString(listaAnamnesis.ElementAt(0).asma_heredo);
                string otros_heredo = Convert.ToString(listaAnamnesis.ElementAt(0).otros_heredo);
                string observaciones = Convert.ToString(listaAnamnesis.ElementAt(0).observaciones);

                // revision de combobox anamnesis
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

                //dolor de pecho
                if (dolor_pecho == 's')
                {
                    r21.Checked = true;
                }
                else if (dolor_pecho == 'n')
                {
                    r22.Checked = true;
                }

                //enf nerviosas
                if (enf_nerviosas == 's')
                {
                    r23.Checked = true;
                }
                else if (enf_nerviosas == 'n')
                {
                    r24.Checked = true;
                }

                //alergia
                if (alergia == 's')
                {
                    r25.Checked = true;
                }
                else if (alergia == 'n')
                {
                    r26.Checked = true;
                }
                txtAlergias.Text = alergia_trat;

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
                //asma
                if (asma == 's')
                {
                    r31.Checked = true;
                }
                else if (asma == 'n')
                {
                    r32.Checked = true;
                }
                txtTratAsma.Text = asma_trat;

                //tiroides
                if (tiroides == 's')
                {
                    r33.Checked = true;
                }
                else if (tiroides == 'n')
                {
                    r34.Checked = true;
                }
                txtTratTiroides.Text = tiroides_trat;

                txtHipertensionHeredo.Text = hipertension_heredo;
                txtDiabetesHeredo.Text = diabetes_heredo;
                txtCancerHeredo.Text = cancer_heredo;
                txtTiroidesHeredo.Text = tiroides_heredo;
                txtAsmaHeredo.Text = asma_heredo;
                txtOtrosHeredo.Text = otros_heredo;
                txtObservaciones.Text = observaciones;
                ((Control)this.tbPageAnamnesis).Enabled = false;
            }
            else
            {
                ((Control)this.tbPageAnamnesis).Enabled = true;
                casoEspecial = true;
            }

        }


        public void determinaExpediente(string cedula_paciente, int id_paciente)
        {
            pbPaciente.Image = PersonaIT.GetImagePacient(cedula_paciente);

            //me trae el expediente segun la cedula y el id
            List<ExpedienteEntity> listaExpediente = ExpedienteIT.selectExpedienteById(cedula_paciente, id_paciente);
            //anamnesis
            txtPulso.Text = listaExpediente.ElementAt(0).pulso.ToString();
            txtPresionArterial.Text = listaExpediente.ElementAt(0).presion_arterial.ToString();

            char soplos = Convert.ToChar(listaExpediente.ElementAt(0).soplos);
            if (soplos == 's')
            {
                rx1.Checked = true;
            }
            else if (soplos == 'n')
            {
                rx2.Checked = true;
            }

            char dolor_precordial = Convert.ToChar(listaExpediente.ElementAt(0).dolor_precordial);
            if (dolor_precordial == 's')
            {
                rx3.Checked = true;
            }
            else if (dolor_precordial == 'n')
            {
                rx4.Checked = true;
            }

            char edemas = Convert.ToChar(listaExpediente.ElementAt(0).edemas);
            if (edemas == 's')
            {
                rx5.Checked = true;
            }
            else if (edemas == 'n')
            {
                rx6.Checked = true;
            }

            char arritmias = Convert.ToChar(listaExpediente.ElementAt(0).arritmias);
            if (arritmias == 's')
            {
                rx7.Checked = true;
            }
            else if (arritmias == 'n')
            {
                rx8.Checked = true;
            }

            char disnea = Convert.ToChar(listaExpediente.ElementAt(0).disnea);
            if (disnea == 's')
            {
                rx9.Checked = true;
            }
            else if (disnea == 'n')
            {
                rx10.Checked = true;
            }

            txtObservacionesSC.Text = listaExpediente.ElementAt(0).observaciones_sc.ToString();

            txtTalla.Text = listaExpediente.ElementAt(0).talla.ToString();
            txtPeso.Text = listaExpediente.ElementAt(0).peso.ToString();

            txtObservacionesSE.Text = listaExpediente.ElementAt(0).observaciones_sm.ToString();

            txtBrazoDech.Text = listaExpediente.ElementAt(0).brazo_derecho.ToString();
            txtBrazoIzq.Text = listaExpediente.ElementAt(0).brazo_izquierdo.ToString();
            txtPiernaDer.Text = listaExpediente.ElementAt(0).pierna_derecha.ToString();
            txtPiernaIzq.Text = listaExpediente.ElementAt(0).pierna_izquierda.ToString();

            char bicipal_derecho = Convert.ToChar(listaExpediente.ElementAt(0).bicipal_derecho);
            if (bicipal_derecho == 'n')
            {
                rx11.Checked = true;
            }
            else if (bicipal_derecho == 'a')
            {
                rx12.Checked = true;
            }
            char bicipal_izquierdo = Convert.ToChar(listaExpediente.ElementAt(0).bicipal_izquierdo);
            if (bicipal_izquierdo == 'n')
            {
                rx13.Checked = true;
            }
            else if (bicipal_izquierdo == 'a')
            {
                rx14.Checked = true;
            }
            char patelar_derecho = Convert.ToChar(listaExpediente.ElementAt(0).patelar_derecho);
            if (patelar_derecho == 'n')
            {
                rx15.Checked = true;
            }
            else if (patelar_derecho == 'a')
            {
                rx16.Checked = true;
            }

            char patelar_izquierdo = Convert.ToChar(listaExpediente.ElementAt(0).patelar_izquierdo);
            if (patelar_izquierdo == 'n')
            {
                rx17.Checked = true;
            }
            else if (patelar_izquierdo == 'a')
            {
                rx18.Checked = true;
            }

            char alquileano_derecho = Convert.ToChar(listaExpediente.ElementAt(0).alquileano_derecho);
            if (alquileano_derecho == 'n')
            {
                rx19.Checked = true;
            }
            else if (alquileano_derecho == 'a')
            {
                rx20.Checked = true;
            }

            char alquileano_izquierdo = Convert.ToChar(listaExpediente.ElementAt(0).alquileano_izquierdo);
            if (alquileano_izquierdo == 'n')
            {
                rx21.Checked = true;
            }
            else if (alquileano_izquierdo == 'a')
            {
                rx22.Checked = true;
            }

            char flexion = Convert.ToChar(listaExpediente.ElementAt(0).flexion);
            if (flexion == 'n')
            {
                rx23.Checked = true;
            }
            else if (flexion == 'a')
            {
                rx24.Checked = true;
            }

            char extensiones = Convert.ToChar(listaExpediente.ElementAt(0).extensiones);
            if (extensiones == 'n')
            {
                rx25.Checked = true;
            }
            else if (extensiones == 'a')
            {
                rx26.Checked = true;
            }

            char rotacion = Convert.ToChar(listaExpediente.ElementAt(0).rotacion);
            if (rotacion == 'n')
            {
                rx27.Checked = true;
            }
            else if (rotacion == 'a')
            {
                rx28.Checked = true;
            }

            char inclinacion_lateral = Convert.ToChar(listaExpediente.ElementAt(0).inclinacion_lateral);
            if (inclinacion_lateral == 'n')
            {
                rx29.Checked = true;
            }
            else if (inclinacion_lateral == 'a')
            {
                rx30.Checked = true;
            }

            txtObservacionesCC.Text = Convert.ToString(listaExpediente.ElementAt(0).observaciones_cc);
            txtMalformaciones.Text = Convert.ToString(listaExpediente.ElementAt(0).malformaciones);

            char observaciones_dl = Convert.ToChar(listaExpediente.ElementAt(0).observaciones_dl);
            if (observaciones_dl == 'n')
            {
                rx31.Checked = true;
            }
            else if (observaciones_dl == 'a')
            {
                rx32.Checked = true;
            }

            txtObservacionesCDL.Text = Convert.ToString(listaExpediente.ElementAt(0).observaciones_dl_txt);

            txtMotivoConsulta.Text = Convert.ToString(listaExpediente.ElementAt(0).motivo_consulta);
            txtSaturacionOx.Text = Convert.ToString(listaExpediente.ElementAt(0).saturacion_ox);
            txtTemperatura.Text = Convert.ToString(listaExpediente.ElementAt(0).temperatura);

            //------------------------examen fisico 2----------------------
            char petequias = Convert.ToChar(listaExpediente.ElementAt(0).petequias);
            if (petequias == 's')
            {
                rx33.Checked = true;
            }
            else if (petequias == 'n')
            {
                rx34.Checked = true;
            }

            char equimosis = Convert.ToChar(listaExpediente.ElementAt(0).equimosis);
            if (equimosis == 's')
            {
                rx35.Checked = true;
            }
            else if (equimosis == 'n')
            {
                rx36.Checked = true;
            }

            char sangrado = Convert.ToChar(listaExpediente.ElementAt(0).sangrado);
            if (sangrado == 's')
            {
                rx37.Checked = true;
            }
            else if (sangrado == 'n')
            {
                rx38.Checked = true;
            }

            txtObservacionesSH.Text = Convert.ToString(listaExpediente.ElementAt(0).observaciones_sh);
            txtExamenNeurologico.Text = Convert.ToString(listaExpediente.ElementAt(0).examen_neurologico);
            txtOrl.Text = Convert.ToString(listaExpediente.ElementAt(0).orl);
            txtAbdomen.Text = Convert.ToString(listaExpediente.ElementAt(0).abdomen);

            char auscultacion = Convert.ToChar(listaExpediente.ElementAt(0).auscultacion);
            if (auscultacion == 'n')
            {
                rx39.Checked = true;
            }
            else if (auscultacion == 'a')
            {
                rx40.Checked = true;
            }

            txtObservacionesSR.Text = Convert.ToString(listaExpediente.ElementAt(0).observaciones_sr);

            char convulciones = Convert.ToChar(listaExpediente.ElementAt(0).convulciones);
            if (convulciones == 's')
            {
                rx41.Checked = true;
            }
            else if (convulciones == 'n')
            {
                rx42.Checked = true;
            }

            char espasmos = Convert.ToChar(listaExpediente.ElementAt(0).espasmos);
            if (espasmos == 's')
            {
                rx43.Checked = true;
            }
            else if (espasmos == 'n')
            {
                rx44.Checked = true;
            }

            char temblores = Convert.ToChar(listaExpediente.ElementAt(0).temblores);
            if (temblores == 's')
            {
                rx45.Checked = true;
            }
            else if (temblores == 'n')
            {
                rx46.Checked = true;
            }

            char movimientos_anormales = Convert.ToChar(listaExpediente.ElementAt(0).movimientos_anormales);
            if (movimientos_anormales == 's')
            {
                rx47.Checked = true;
            }
            else if (movimientos_anormales == 'n')
            {
                rx48.Checked = true;
            }

            txtOtrosSN.Text = Convert.ToString(listaExpediente.ElementAt(0).otros_sn);
            txtObservacionesSN.Text = Convert.ToString(listaExpediente.ElementAt(0).observaciones_sn);
            txtOtrosExamen2.Text = Convert.ToString(listaExpediente.ElementAt(0).otros_examen2);

            DateTime fecha = Convert.ToDateTime(listaExpediente.ElementAt(0).fecha);

            dtFechaConsulta.Value = Convert.ToDateTime(listaExpediente.ElementAt(0).fecha);

            txtDiagnostico.Text = Convert.ToString(listaExpediente.ElementAt(0).diagnostico);
            txtTerapeutica.Text = Convert.ToString(listaExpediente.ElementAt(0).terapeutica);
            txtObs.Text = Convert.ToString(listaExpediente.ElementAt(0).observaciones_generales);
            string cedula = Convert.ToString(listaExpediente.ElementAt(0).cedula);
            string cedula_medico = Convert.ToString(listaExpediente.ElementAt(0).cedula_medico);
        }


        //constructor en blanco
        public frm_ExpedienteMG()//datos usuario me trae el nombre y apellido del usuario
        {
            InitializeComponent();
            label29.Text = Frm_Ingreso.datosUsuario[0] + " " + Frm_Ingreso.datosUsuario[1];  //asignamos el nombre del usuario

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

            //iniciamos los combos
            cbEstado.SelectedIndex = 0;
            cbSangre.SelectedIndex = 0;
            cbSexo.SelectedIndex = 0;

            cargaComboEmpresas();
        }

        //prueba, false, true,0);
        public frm_ExpedienteMG(string cedula_paciente, bool editar, bool verExpediente, int id_paciente, int valor)
        {
            InitializeComponent();

            this.label29.Text = Frm_Ingreso.datosUsuario[0] + Frm_Ingreso.datosUsuario[1];

            //vamos a guardar solo en el exp xq es reconsulta
            expOreconsulta = true;
            cedulaPublica = cedula_paciente;

            //me trae todo del cliente segun la cedula
            List<PersonaEntity> lista = PersonaIT.selectClientePorCedula(cedula_paciente);

            Char sexo = lista.ElementAt(0).sexo;
            string estado_Civil = lista.ElementAt(0).estado_civil.ToString();
            string grupo = lista.ElementAt(0).grupo_sanguineo.ToString();
            int telefono = Convert.ToInt32(lista.ElementAt(0).telefono_fijo);
            int movil = Convert.ToInt32(lista.ElementAt(0).telefono_movil);
            int empresa = Convert.ToInt32(lista.ElementAt(0).empresa);

            txtNombre.Text = lista.ElementAt(0).nombre.ToString();
            txtApe1.Text = lista.ElementAt(0).ape1.ToString();
            txtApe2.Text = lista.ElementAt(0).ape2.ToString();
            txtCedula.Text = lista.ElementAt(0).cedula.ToString();
            fecha_nacimiento.Value = lista.ElementAt(0).fecha;
            txtEdad.Text = lista.ElementAt(0).edad.ToString();

            //combo de empresa
            cargaComboEmpresas();
            if (empresa != -1)
            {
                //me trae id de la empresa
                cbEmpresa.SelectedValue = empresa;
            }

            //combo del sexo
            if (sexo == 'f')
            {
                cbSexo.SelectedIndex = 0;
            }
            else
            {
                cbSexo.SelectedIndex = 1;
            }
            //determina el estado civil y lo asigna
            determinaEstadoCivil(estado_Civil);
            //determina el tipo de sangre y lo asigna al combo
            determinaTipoSangre(grupo);
            txtProfesion.Text = lista.ElementAt(0).profesion.ToString();
            txtTelefono.Text = telefono.ToString();
            txtMovil.Text = movil.ToString();
            txtEmail.Text = lista.ElementAt(0).email.ToString();
            txtDireccion.Text = lista.ElementAt(0).direccion.ToString();
            //----------------------------anamnesis----------------------
            //me devuelve toda la anam
            this.determinaAnamnesis(cedula_paciente);

            pbPaciente.Image = PersonaIT.GetImagePacient(cedula_paciente);

            //aqui no se puede editar nada xq voy a ver el expediente
            //voy a editar todo el expediente
            //reconsulta
            if (verExpediente && editar == false && valor != 1)
            //dehabilito todo xq solo puedo ver
            {
                determinaExpediente(cedula_paciente, id_paciente);

                btnGuardar.Visible = false;

                ((Control)this.tabPageInfoPersonal).Enabled = false;
                ((Control)this.tbPageAnamnesis).Enabled = false;
                ((Control)this.tabPageExFisico).Enabled = false;
                ((Control)this.tabPageExFisicoII).Enabled = false;
                ((Control)this.tabPageEpicrisis).Enabled = false;

                txtCedula.Enabled = false;
            }
            else if (verExpediente == false && editar == false && valor != 1)
            {
                //variable que me indica que voy a editar el expediente
                editarExpediente = true;
                expOreconsulta = false;
                id_pacient = id_paciente;
                this.determinaExpediente(cedula_paciente, id_paciente);
                //no se puede editar ni la info personal ni la anamnesis
                ((Control)this.tabPageInfoPersonal).Enabled = false;
                ((Control)this.tbPageAnamnesis).Enabled = false;
            }
            else if (editar == false && valor == 1)
            //dehabilito la anamnesis y la info personal, para realizar reconsulta
            {
                ((Control)this.tabPageInfoPersonal).Enabled = false;
            }
        }


        //opciond de cargar foto de paciente
        private void pbPaciente_Click(object sender, EventArgs e)
        {
            opFile.Title = "Cargar Foto Médico";
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                string ruta = opFile.FileName;

                opFile.Dispose();
                pbPaciente.ImageLocation = ruta;
                //guardamos la imagen
                fotoBinaria = this.saveImage(ruta);
            }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (expOreconsulta == true)
            {//guardo la reconsulta
                //se guarda el expediente solo si estos campos estan llenos
                if (txtTerapeutica.Text != string.Empty || txtDiagnostico.Text != string.Empty || txtObs.Text != string.Empty)
                {
                    determinaExpediente();//metodo que da valor a parametros para el expediente


                    if (((Control)this.tabPageInfoPersonal).Enabled == false && ((Control)this.tbPageAnamnesis).Enabled == true)
                    {
                        //se verifican cuales checks estan seleccionados de la anamnesis
                        this.seleccionChecks();
                        //guardamos la cedula en una variable
                        string cedula = txtCedula.Text;

                        try
                        {
                            //si no hay foto asignada, asigna la ruta x defecto
                            this.verificaFoto();

                            if (anamnesisIT.InsertaAnamnesis(cedula, tabaquismo, ingesta, alcoholismo, rehabilitacion, diabetes, hipertension, dolor_cabeza,
                            epilepsia, vertigo, depresion, falta_aire, oidos_ojos, dolor_pecho, enf_nerviosas, alergia, txtAlergias.Text, txtTratDiabetes.Text,
                            txtTratHipertension.Text, asma, txtTratAsma.Text, tiroides, txtTratTiroides.Text, txtHipertensionHeredo.Text, txtDiabetesHeredo.Text,
                            txtCancerHeredo.Text, txtTiroidesHeredo.Text, txtAsmaHeredo.Text, txtOtrosHeredo.Text, txtObservaciones.Text, Frm_Ingreso.datosUsuario[2], fecha_expediente) &&
                                (ExpedienteIT.InsertaExpediente(pulso, presion_arterial, soplos, dolor_precordial, edemas, arritmias, disnea,
                            observaciones_sc, talla, peso, observaciones_sm, brazo_derecho, brazo_izquierdo, pierna_derecha, pierna_izquierda,
                            bicipal_derecho, bicipal_izquierdo, patelar_derecho, patelar_izquierdo, alquileano_derecho, alquileano_izquierdo,
                            flexion, extensiones, rotacion, inclinacion_lateral, observaciones_cc, malformaciones, observaciones_dl,
                            observaciones_dl_txt, petequias, equimosis, sangrado, observaciones_sh, examen_neurologico, orl, abdomen,
                            auscultacion, observaciones_sr, convulciones, espasmos, temblores, movimientos_anormales, otros_sn,
                            observaciones_sn, otros_examen2, fecha_expediente, diagnostico, terapeutica, observaciones_generales, cedula,
                            Frm_Ingreso.datosUsuario[2], motivo_consulta, saturacionOx, temperatura)))
                            {
                                MessageBox.Show("EXPEDIENTE GUARDADO CON EXITO", "INSERCION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.Hide();
                                frmVerExpediente splash = new frmVerExpediente();
                                splash.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("ERROR AL INSERTAR EL CLIENTE\nES POSIBLE QUE LA CEDULA YA EXISTA","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message);
                        }
                    }
                    else
                    {
                        //guardamos solo en el expediente
                        if (ExpedienteIT.InsertaExpediente(pulso, presion_arterial, soplos, dolor_precordial, edemas, arritmias, disnea,
                            observaciones_sc, talla, peso, observaciones_sm, brazo_derecho, brazo_izquierdo, pierna_derecha, pierna_izquierda,
                            bicipal_derecho, bicipal_izquierdo, patelar_derecho, patelar_izquierdo, alquileano_derecho, alquileano_izquierdo,
                            flexion, extensiones, rotacion, inclinacion_lateral, observaciones_cc, malformaciones, observaciones_dl,
                            observaciones_dl_txt, petequias, equimosis, sangrado, observaciones_sh, examen_neurologico, orl, abdomen,
                            auscultacion, observaciones_sr, convulciones, espasmos, temblores, movimientos_anormales, otros_sn,
                            observaciones_sn, otros_examen2, fecha_expediente, diagnostico, terapeutica, observaciones_generales, cedulaPublica,
                            Frm_Ingreso.datosUsuario[2], motivo_consulta, saturacionOx, temperatura))
                        {
                            MessageBox.Show("CONSULTA INSERTADA CON EXITO", "INSERCION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                            frmVerExpediente splash = new frmVerExpediente();
                            splash.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("PROBLEMAS AL INSERTAR LA CONSULTA", "PROBLEMAS AL INSERTAR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("NO SE PUEDE ISNERTAR UN EXPEDIENTE CON CAMPOS VACIOS", "CAMPOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            //editar el expediente
            else if (editarExpediente)
            {
                if (txtTerapeutica.Text != string.Empty || txtDiagnostico.Text != string.Empty || txtObs.Text != string.Empty)
                {
                    determinaExpediente();//metodo que da valor a parametros para el expediente
                    //guardamos solo en el expediente
                    if (ExpedienteIT.EditarExpediente(pulso, presion_arterial, soplos, dolor_precordial, edemas, arritmias, disnea,
                        observaciones_sc, talla, peso, observaciones_sm, brazo_derecho, brazo_izquierdo, pierna_derecha, pierna_izquierda,
                        bicipal_derecho, bicipal_izquierdo, patelar_derecho, patelar_izquierdo, alquileano_derecho, alquileano_izquierdo,
                        flexion, extensiones, rotacion, inclinacion_lateral, observaciones_cc, malformaciones, observaciones_dl,
                        observaciones_dl_txt, petequias, equimosis, sangrado, observaciones_sh, examen_neurologico, orl, abdomen,
                        auscultacion, observaciones_sr, convulciones, espasmos, temblores, movimientos_anormales, otros_sn,
                        observaciones_sn, otros_examen2, fecha_expediente, diagnostico, terapeutica, observaciones_generales, cedulaPublica,
                        Frm_Ingreso.datosUsuario[2], motivo_consulta, saturacionOx, temperatura, id_pacient))
                    {
                        MessageBox.Show("EXPEDIENTE ACTUALIZADO CON EXITO", "ACTUALIZACION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                        frmVerExpediente splash = new frmVerExpediente();
                        splash.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("PROBLEMAS AL ACTUALIZAR EL EXPEDIENTE", "PROBLEMAS AL EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("NO SE PUEDE EDITAR UN EXPEDIENTE CON CAMPOS VACIOS", "CAMPOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            //creo cliente, anamnesis y expediente
            else if (expOreconsulta == false)
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

                //se verifican cuales checks estan seleccionados de la anamnesis
                seleccionChecks();

                //guardamos la cedula en una variable
                string cedula = txtCedula.Text;

                //determinar empresa, en este caso me trae el id de la empresa seleccionada x eso es int
                int empresa = Convert.ToInt32(cbEmpresa.SelectedValue);

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
                        determinaExpediente();//metodo que da valor a parametros para el expediente
                        //determinar si el telefono esta vacio para insertar un 0 
                        int telefono = 0;
                        int movil = 0;

                        //bool f1 = CheckNullOrEmpty(telefono); 
                        if (txtTelefono.Text.Length != 0)
                        {
                            telefono = Convert.ToInt32(txtTelefono.Text);
                        }

                        if (txtMovil.Text.Length != 0)
                        {
                            movil = Convert.ToInt32(txtMovil.Text);
                        }
                        //si no hay foto asignada, asigna la ruta x defecto
                        this.verificaFoto();

                        if (PersonaIT.InsertaCliente(txtNombre.Text, txtApe1.Text, txtApe2.Text, cedula, fecha,
                        txtDireccion.Text, txtEdad.Text, sexo, estado, grupo, txtProfesion.Text, telefono, movil,
                        txtEmail.Text, empresa, fotoBinaria, false, fecha_expediente) &&
                            anamnesisIT.InsertaAnamnesis(cedula, tabaquismo, ingesta, alcoholismo, rehabilitacion, diabetes, hipertension, dolor_cabeza,
                        epilepsia, vertigo, depresion, falta_aire, oidos_ojos, dolor_pecho, enf_nerviosas, alergia, txtAlergias.Text, txtTratDiabetes.Text,
                        txtTratHipertension.Text, asma, txtTratAsma.Text, tiroides, txtTratTiroides.Text, txtHipertensionHeredo.Text, txtDiabetesHeredo.Text,
                        txtCancerHeredo.Text, txtTiroidesHeredo.Text, txtAsmaHeredo.Text, txtOtrosHeredo.Text, txtObservaciones.Text, Frm_Ingreso.datosUsuario[2], fecha_expediente) &&
                            (ExpedienteIT.InsertaExpediente(pulso, presion_arterial, soplos, dolor_precordial, edemas, arritmias, disnea,
                        observaciones_sc, talla, peso, observaciones_sm, brazo_derecho, brazo_izquierdo, pierna_derecha, pierna_izquierda,
                        bicipal_derecho, bicipal_izquierdo, patelar_derecho, patelar_izquierdo, alquileano_derecho, alquileano_izquierdo,
                        flexion, extensiones, rotacion, inclinacion_lateral, observaciones_cc, malformaciones, observaciones_dl,
                        observaciones_dl_txt, petequias, equimosis, sangrado, observaciones_sh, examen_neurologico, orl, abdomen,
                        auscultacion, observaciones_sr, convulciones, espasmos, temblores, movimientos_anormales, otros_sn,
                        observaciones_sn, otros_examen2, fecha_expediente, diagnostico, terapeutica, observaciones_generales, cedula,
                        Frm_Ingreso.datosUsuario[2], motivo_consulta, saturacionOx, temperatura)))
                        {
                            MessageBox.Show("EXPEDIENTE GUARDADO CON EXITO", "INSERCION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Hide();
                            frmVerExpediente splash = new frmVerExpediente();
                            splash.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("ERROR AL INSERTAR EL CLIENTE\nES POSIBLE QUE LA CEDULA YA EXISTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    //si hay campos vacios imprime error
                    else
                    {
                        MessageBox.Show("HAY CAMPOS OBLIGATORIOS VACIOS", "CAMPOS VACIOS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        public void verificaFoto()
        {
            if (fotoBinaria == null)
            {
                //MessageBox.Show("no se dijo foto");
                //string x = pbPaciente.ImageLocation;
                fotoBinaria = this.saveImage(rutaDefault);
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

            //dolor de pecho
            if (r21.Checked == true)
            {
                dolor_pecho = 's';
            }
            else if (r22.Checked == true)
            {
                dolor_pecho = 'n';
            }

            //enfermedades nerviosas
            if (r23.Checked == true)
            {
                enf_nerviosas = 's';
            }
            else if (r24.Checked == true)
            {
                enf_nerviosas = 'n';
            }

            //alergias
            if (r25.Checked == true)
            {
                alergia = 's';
            }
            else if (r26.Checked == true)
            {
                alergia = 'n';
            }

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

            //asma
            if (r31.Checked == true)
            {
                asma = 's';
            }
            else if (r32.Checked == true)
            {
                asma = 'n';
            }

            //tiroides
            if (r33.Checked == true)
            {
                tiroides = 's';
            }
            else if (r34.Checked == true)
            {
                tiroides = 'n';
            }
        }

        private void btnVerExp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVerExpediente frm = new frmVerExpediente();
            frm.ShowDialog();
            this.Dispose();
        }

        private void frm_ExpedienteMG_Load(object sender, EventArgs e)
        {
            toolTip1.InitialDelay = 1;

            toolTip1.SetToolTip(btnVerExp, "Ver Todos los Expedientes");
            toolTip1.SetToolTip(btnGuardar, "Guardar la Informacion del Paciente");

            toolTip1.SetToolTip(pbPaciente, "Cargar Foto de Paciente");
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

        //se activan los txt segun seleccion
        //check de alergias
        private void r25_CheckedChanged(object sender, EventArgs e)
        {
            txtAlergias.Visible = true;
        }
        private void r26_CheckedChanged(object sender, EventArgs e)
        {
            txtAlergias.Visible = !true;
        }

        //si se activa el check de diabetess
        private void r27_CheckedChanged(object sender, EventArgs e)
        {
            txtTratDiabetes.Visible = true;
            lblTratamiento.Visible = true;
        }
        private void r28_CheckedChanged(object sender, EventArgs e)
        {
            txtTratDiabetes.Visible = false;
            lblTratamiento.Visible = false;
        }

        //check de hipertension
        private void r29_CheckedChanged(object sender, EventArgs e)
        {
            txtTratHipertension.Visible = true;
            lblTratHipertension.Visible = true;
        }
        private void r30_CheckedChanged(object sender, EventArgs e)
        {
            txtTratHipertension.Visible = false;
            lblTratHipertension.Visible = false;
        }

        //check de asma
        private void r31_CheckedChanged(object sender, EventArgs e)
        {
            txtTratAsma.Visible = true;
            lblTratAsma.Visible = true;
        }
        private void r32_CheckedChanged(object sender, EventArgs e)
        {
            txtTratAsma.Visible = false;
            lblTratAsma.Visible = false;
        }

        //check de tiroides
        private void r33_CheckedChanged(object sender, EventArgs e)
        {
            txtTratTiroides.Visible = true;
            lblTratTiroides.Visible = true;
        }
        private void r34_CheckedChanged(object sender, EventArgs e)
        {
            txtTratTiroides.Visible = false;
            lblTratTiroides.Visible = false;
        }

        private void btnEliminarFoto_Click(object sender, EventArgs e)
        {
            pbPaciente.ImageLocation = rutaDefault;
        }

        private void fecha_nacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNac = fecha_nacimiento.Value;

            TimeSpan dias = DateTime.Now - fecha_nacimiento.Value;
            txtEdad.Text = this.direfenciaFechas(fechaNac, DateTime.Now);
        }

        //calcula edad (anios, meses,dias) basado en la fecha de nacimiento
        public string direfenciaFechas(DateTime New, DateTime old)
        {
            int anios = New.Year - old.Year;
            int meses = New.Month - old.Month;
            int dias = New.Day - old.Day;

            string respuesta = Math.Abs(anios) + " Años " + Math.Abs(meses) + " Meses " + Math.Abs(dias) + " Dias";
            return respuesta;
        }
    }
}


