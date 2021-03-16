using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej11_AñoBisiesto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int año = 0;
            if (!int.TryParse(textBox1.Text, out año))
                MessageBox.Show("debe ingresar un valor numerico");


            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                textBox2.Text = string.Format("El año {0} es bisiesto", año);
            else
                textBox2.Text = string.Format("El año {0} no es bisiesto", año);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult salir;
            salir = MessageBox.Show("Deseas salir de la aplicacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Close();
            }
        }
}
