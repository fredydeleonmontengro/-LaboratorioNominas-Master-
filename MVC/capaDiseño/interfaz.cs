using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDiseño.Mantenimientos;
using capaDiseño.Procesos;

namespace capaDiseño
{
    public partial class interfaz : UserControl
    {
        public interfaz()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Frm_agregarDepartamentos form = new Frm_agregarDepartamentos();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_agregarConceptos form = new Frm_agregarConceptos();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_agregarEmpleados form = new Frm_agregarEmpleados();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_agregarPuestos form = new Frm_agregarPuestos();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_Nomina form = new Frm_Nomina();
            form.ShowDialog();
        }
    }
}
