using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практ_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabul tabul1 = new tabul();

            double xn, xk, h, a;

            xn = Convert.ToDouble(this.textBox1.Text);
            xk = Convert.ToDouble(this.textBox2.Text);
            h = Convert.ToDouble(this.textBox3.Text);
            a = Convert.ToDouble(this.textBox4.Text);

            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            tabul1.tab(xn, xk, h, a);

            for (int i = 0; i < tabul1.n; i++)
            {
                dataGridView1.Rows.Add(Math.Round(tabul1.xy[i, 0], 2).ToString(),
                    Math.Round(tabul1.xy[i, 1], 3).ToString());
                chart1.Series[0].Points.AddXY(tabul1.xy[i, 0], tabul1.xy[i, 1]);
            }
        }
    }
}
