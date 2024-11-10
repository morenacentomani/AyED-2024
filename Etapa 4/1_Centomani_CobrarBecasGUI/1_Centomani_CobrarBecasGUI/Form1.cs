using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Centomani_CobrarBecasGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Dejaste el recuadro blanco, no seas boludo", "ERROR JA");
                return;
            }

            
            int años;

            if (!int.TryParse(textBox1.Text, out años))
            {
                MessageBox.Show("¿Que te pensas? No seas chanta, pone un nímero válido.", "ERROR");
                return;
            }

            // creo una variable que funcion como la opcion elegida dentro del comboBox1
            string ingresel = comboBox1.SelectedItem.ToString();

            if (años >= 19 && (ingresel == "100,001 - 200,000" || ingresel == "Más de 200,000"))
            {
                MessageBox.Show("Listo. Toma tu beca.", "¿Tenes tu beca?");
            }
            else
            {
                MessageBox.Show("Ja, no cumplis con los requisitos. ja.", "¿Tenes tu beca?");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
