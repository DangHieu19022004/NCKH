using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shipper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem ComboBox đã chọn giá trị chưa
            if (comboBox1.SelectedIndex != -1) // -1 là chỉ không có mục nào được chọn
            {
                // Nếu ComboBox đã chọn giá trị, chuyển sang Form 2
                Form2 form2 = new Form2();
                form2.Text = comboBox1.Text;
                form2.Show();
            }
            else
            {
                // Nếu ComboBox chưa chọn giá trị, hiển thị thông báo
                MessageBox.Show("Vui lòng chọn giá trị");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
