namespace end_version
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel_top = new Panel();
            label1 = new Label();
            panel_body = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_top.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 450);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.Tomato;
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 268);
            button4.Name = "button4";
            button4.Size = new Size(153, 57);
            button4.TabIndex = 4;
            button4.Text = "Setting";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 211);
            button3.Name = "button3";
            button3.Size = new Size(153, 57);
            button3.TabIndex = 3;
            button3.Text = "About";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 154);
            button2.Name = "button2";
            button2.Size = new Size(153, 57);
            button2.TabIndex = 2;
            button2.Text = "Orders";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 97);
            button1.Name = "button1";
            button1.Size = new Size(153, 57);
            button1.TabIndex = 1;
            button1.Text = "Shipper";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo_ĐH_Thủy_Lợi;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 97);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.RoyalBlue;
            panel_top.Controls.Add(label1);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(153, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(647, 97);
            panel_top.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(243, 29);
            label1.Name = "label1";
            label1.Size = new Size(155, 40);
            label1.TabIndex = 0;
            label1.Text = "WELCOM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel_body
            // 
            panel_body.BackgroundImage = Properties.Resources._f3b1a7d1_b911_44ac_aed2_ba37957bec6a;
            panel_body.BackgroundImageLayout = ImageLayout.Stretch;
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(153, 97);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(647, 353);
            panel_body.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_body);
            Controls.Add(panel_top);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel_top;
        private Panel panel_body;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
    }
}
