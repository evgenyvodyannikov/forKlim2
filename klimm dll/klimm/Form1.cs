using System;
using static ClassLibrary1.Class1;
using System.Windows.Forms;

namespace klimm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);
                Method(a, b, c, out int max);
                MessageBox.Show("НОД: " + max);
            }
            catch
            {

            }
        }
    }
}
