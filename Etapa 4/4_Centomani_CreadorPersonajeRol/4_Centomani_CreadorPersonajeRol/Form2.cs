using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace _4_Centomani_CreadorPersonajeRol
{
    public partial class Form2 : Form
    {
        public Form2(string nombre, string nivel, string tipo, string personalidad, string casa, string nucleovar)
        {
            InitializeComponent();
            label9.Text = nombre;
            label10.Text = nivel;
            label11.Text = tipo;
            label12.Text = personalidad;
            label13.Text = casa;
            label14.Text = nucleovar;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ya está. ¿Qué más queres?");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
