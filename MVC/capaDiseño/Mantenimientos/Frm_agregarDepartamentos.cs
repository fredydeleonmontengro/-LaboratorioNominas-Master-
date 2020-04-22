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
    public partial class Frm_agregarDepartamentos : Form
    {
        logica logic = new logica();
        public Frm_agregarDepartamentos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.departamentos(textBox3.Text, textBox4.Text);
            MessageBox.Show("guardando");
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
