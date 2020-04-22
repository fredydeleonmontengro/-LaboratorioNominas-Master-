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

namespace capaDiseño.Mantenimientos
{
    public partial class Frm_agregarConceptos : Form
    {
        string valor;
        logica logic= new logica();
        public Frm_agregarConceptos()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(checkBox1.Checked == true)
            {
              valor = "1";

            }

            if (checkBox2.Checked == true)
            {
               valor = "2";

            }

            OdbcDataReader cita = logic.conceptos(textBox1.Text,textBox2.Text,valor, textBox3.Text);
            MessageBox.Show("guardando");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            checkBox1.Checked = false;
            checkBox1.Checked = false;


        }

        private void Frm_agregarConceptos_Load(object sender, EventArgs e)
        {

        }
    }
}
