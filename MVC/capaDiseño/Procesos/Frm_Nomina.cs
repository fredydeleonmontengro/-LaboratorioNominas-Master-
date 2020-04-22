using capaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDiseño.Procesos
{
    public partial class Frm_Nomina : Form
    {
        logica logic = new logica();
        public Frm_Nomina()
        {
            InitializeComponent();
            mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            Guardar2();

        }
        public void Guardar()

        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string codorden = Convert.ToString(textBox1.Text);
                string codempleado = Convert.ToString(row.Cells["Column1"].Value);
                string codconcepto = Convert.ToString(row.Cells["Column2"].Value);
                string total = Convert.ToString(row.Cells["Column3"].Value);

                OdbcDataReader cita = logic.nominad(codorden, codempleado, codconcepto, total);

            }
        }
        public void Guardar2()

        {
            string codorden = Convert.ToString(textBox1.Text);
            string fechainicial = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string fechafinal = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            OdbcDataReader cita = logic.nominae(codorden, fechainicial, fechafinal);

        }
        public void mostrar()

        {
            
            int val1 = 0;
            int val2 = 0;
            int total;

            OdbcDataReader mostrar = logic.concepto();
            OdbcDataReader empleado = logic.empleado();
            try
            {   
                while (empleado.Read() && mostrar.Read())
                { 

                  val1 =val1 +empleado.GetInt32(4);
                  val2 =val2 + mostrar.GetInt32(3);
                    total = val1 + val2;

                    dataGridView1.Rows.Add(empleado.GetString(0), mostrar.GetString(0), total);
                    
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }


        }
    }
}
