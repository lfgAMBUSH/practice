using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint x = uint.Parse(textBox1.Text);
            uint n = uint.Parse(textBox2.Text);
            double sum = 1;
            double sum1;
            for (int i = 1; i <= n; i++)
            {
                sum1 = 1;
                for (int j = 1; j <= i; j++)
                {
                    sum1 *= (i * i / (2 * j + 1) + x);
                }
                sum *= sum1;

            }
            textBox3.Text = sum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
