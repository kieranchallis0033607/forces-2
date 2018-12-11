using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A = double.Parse(textBox1.Text);
            double f = double.Parse(textBox2.Text);
            double Fx = f * Cos(A);
            double Fy = f * Sin(A);
        }


        double sin(double A)

    }
}
