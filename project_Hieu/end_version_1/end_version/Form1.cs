namespace end_version
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;//ko hiện x
            childForm.Dock = DockStyle.Fill;//điền toàn màn hình
            panel_body.Controls.Add(childForm);//thêm vào phần panel body
            panel_body.Tag = childForm;
            childForm.BringToFront();//mang về phía trước
            childForm.Show();//hiển thị ra
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
            label1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
            label1.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5());
            label1.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            label1.Text = button4.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "WELCOM";
        }
    }
}
