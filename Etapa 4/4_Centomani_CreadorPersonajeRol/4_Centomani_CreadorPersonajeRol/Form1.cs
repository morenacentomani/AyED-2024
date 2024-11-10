using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _4_Centomani_CreadorPersonajeRol
{
    public partial class Form1 : Form
    {
        bool chequea = false;
        bool chequeapersonajes = false;
        int num_pj;
        bool intervalo;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || intervalo == false || comboBox1.Text == "No queres ser un muggle, no?" || comboBox2.Text == "Es muy importante." || chequea == false || comboBox2.Text == "Elegí bien (ahre)." || chequeapersonajes == false)
            {
                MessageBox.Show("Te faltan datos o algunos estan mal, muggle.", "Dios.");
            }
            else
            {
                Form2 form2 = new Form2(textBox1.Text, textBox2.Text, comboBox1.Text, comboBox2.Text, label10.Text, comboBox3.Text);
                form2.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) < 0 || 100 < int.Parse(textBox2.Text))
            {
                intervalo = false;
            }
            else
            {
                intervalo = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chequea = true;
            if (chequea)
            {
                switch (comboBox2.Text)
                {
                    case "Valiente y osado.":
                        label10.Text = ("Gryffindor");
                        BackColor = Color.FromArgb(255, 128, 128);
                        break;

                    case "Inteligente y curioso.":
                        label10.Text = ("Ravenclaw");
                        BackColor = Color.FromArgb(128, 128, 255);
                        break;

                    case "Ambicioso y astuto.":
                        label10.Text = ("Slytherin");
                        BackColor = Color.FromArgb(128, 255, 128);
                        break;

                    case "Leal y honesto.":
                        label10.Text = ("Hufflepuff");
                        BackColor = Color.FromArgb(255, 255, 128);
                        break;
                }
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            chequeapersonajes = true;
            num_pj = 0; 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            chequeapersonajes = true;
            num_pj = 1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            chequeapersonajes = true;
            num_pj = 2;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            chequeapersonajes = true;
            num_pj = 3;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
