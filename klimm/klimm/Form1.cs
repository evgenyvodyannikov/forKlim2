﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace klimm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int Method(int first, int second, int three, out int max)
        {
            max = 0;
            int min = 0;
            min = first;
            if (second < min)
            { min = second; }
            if (three < min)
            { min = three; }
            for (int i = 1; i <= min; i++)
            {
                if (first % i == 0 && second % i == 0 && three % i == 0)
                { max = i; }
            }
            return max;
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
