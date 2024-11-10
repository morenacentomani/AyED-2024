using System.Diagnostics.Contracts;

namespace _3_Centomani_TerminosYCondiciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ControlBox = true;
            }
        }
    }
}
