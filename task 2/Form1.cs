using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int class_a = int.Parse(textBox1.Text);
            int class_b = int.Parse(textBox2.Text);
            int class_c = int.Parse(textBox3.Text);
            label9.Text = $"{class_a * 15: 0.00} €";
            label10.Text = $"{class_b * 12: 0.00} €";
            label11.Text = $"{class_c * 9: 0.00} €";
            label12.Text = $"{class_c * 9 + class_b * 12 + class_a* 15 : 0.00} €";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
