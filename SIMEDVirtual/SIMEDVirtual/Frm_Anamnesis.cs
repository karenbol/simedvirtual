using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMEDVirtual
{
    public partial class Frm_Anamnesis : Form
    {
        public Frm_Anamnesis()
        {
            InitializeComponent();

            //DataTable table = new DataTable();
            //table.Columns.Add("PATOLOGIA", typeof(string));
            //table.Columns.Add("SI", typeof(Boolean));
            //table.Columns.Add("NO", typeof(Boolean));


            //DataRow fila = table.NewRow();
            //fila["patologia"] = "tabaquismo";

            //table.Rows.Add(fila);
            dataGridView1.Rows.Add(5);

            dataGridView1.Rows[0].Cells[0].Value = "TABAQUISMO";
            dataGridView1.Rows[1].Cells[0].Value = "INGESTA DE MEDICAMENTOS";
            dataGridView1.Rows[2].Cells[0].Value = "CONSUMO DE ALCOHOL";
            dataGridView1.Rows[3].Cells[0].Value = "ALCOHOLISMO ACTUAL O PREVIO";
            dataGridView1.Rows[4].Cells[0].Value = "REHABILITACION FISICA O MENTAL";


            dataGridView2.Rows.Add(2);

            dataGridView2.Rows[0].Cells[0].Value = "INSULINA";
            dataGridView2.Rows[1].Cells[0].Value = "OTROS HORMONALES";

            dataGridView3.Rows.Add(13);

            dataGridView3.Rows[0].Cells[0].Value = "DOLOR DE CABEZA";
            dataGridView3.Rows[1].Cells[0].Value = "INGESTA DE MEDICAMENTOS";
            dataGridView3.Rows[2].Cells[0].Value = "EPILEPCIA";
            dataGridView3.Rows[3].Cells[0].Value = "VERTIGO";
            dataGridView3.Rows[4].Cells[0].Value = "DEPRESION";
            dataGridView3.Rows[5].Cells[0].Value = "DOLOR DE PECHO(PRECORDIAL)";
            dataGridView3.Rows[6].Cells[0].Value = "PRESION ALTA";
            dataGridView3.Rows[7].Cells[0].Value = "DIABETES";
            dataGridView3.Rows[8].Cells[0].Value = "USA LENTES PARA LEER";
            dataGridView3.Rows[9].Cells[0].Value = "DISNEA O FALTA DE AIRE";
            dataGridView3.Rows[10].Cells[0].Value = "ENFERMEDADES DE OJOS U OIDOS";
            dataGridView3.Rows[11].Cells[0].Value = "USA LENTES PARA CONDUCIR";
            dataGridView3.Rows[12].Cells[0].Value = "AUTORIZACION PARA DONAR ORGANOS";


        }

        private void Frm_Anamnesis_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
