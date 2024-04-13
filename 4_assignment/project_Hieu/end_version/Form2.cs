using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace end_version
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form4 form = new Form4();
            form.Text = button1.Text;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Text = button2.Text;
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Text = button1.Text;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Text = button3.Text;
            form.Show();
        }
    }
}
