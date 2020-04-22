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
    public partial class Frm_agregarPuestos : Form
    {
        logica logic = new logica();
        public Frm_agregarPuestos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.puestos(textBox1.Text, textBox2.Text);
            MessageBox.Show("guardando");
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
