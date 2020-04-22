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
    public partial class Frm_agregarEmpleados : Form
    {
        logica logic = new logica();
        public Frm_agregarEmpleados()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) ){ MessageBox.Show("complete el codigo de trabajador"); }
            if (string.IsNullOrEmpty(textBox4.Text)) { MessageBox.Show("ingrese nombre empleado"); }
            if (string.IsNullOrEmpty(textBox1.Text)) { MessageBox.Show("ingrese codigo de puesto"); }
            if (string.IsNullOrEmpty(textBox2.Text)) { MessageBox.Show("ingrese el codigo departamento"); }
            if (string.IsNullOrEmpty(textBox5.Text)) { MessageBox.Show("ingrese el sueldo neto"); }
            OdbcDataReader cita = logic.empleados(textBox3.Text, textBox4.Text, textBox1.Text, textBox2.Text, textBox5.Text);
            MessageBox.Show("guardando");
            
        }
    }
}
