namespace shipper_end
{
    partial class frmInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PictureBox pictureBox1;
            panel1 = new Panel();
            btnReturn = new Button();
            button1 = new Button();
            label4 = new Label();
            txtLicenses = new TextBox();
            cbArea = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtHomeTown = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = end_version.Properties.Resources.Users;
            pictureBox1.Location = new Point(178, 14);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtLicenses);
            panel1.Controls.Add(cbArea);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtHomeTown);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 519);
            panel1.TabIndex = 0;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(255, 224, 192);
            btnReturn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.Blue;
            btnReturn.Location = new Point(27, 433);
            btnReturn.Margin = new Padding(4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(87, 44);
            btnReturn.TabIndex = 17;
            btnReturn.Text = "<<";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(178, 433);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(202, 44);
            button1.TabIndex = 16;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(27, 350);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 16);
            label4.TabIndex = 15;
            label4.Text = "Licenses plates :";
            // 
            // txtLicenses
            // 
            txtLicenses.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLicenses.Location = new Point(178, 343);
            txtLicenses.Margin = new Padding(4);
            txtLicenses.Name = "txtLicenses";
            txtLicenses.Size = new Size(283, 26);
            txtLicenses.TabIndex = 14;
            // 
            // cbArea
            // 
            cbArea.Font = new Font("Microsoft Sans Serif", 12F);
            cbArea.FormattingEnabled = true;
            cbArea.Items.AddRange(new object[] { "Ba Đình", "Cầu Giấy", "Đống Đa", "Hai Bà Trưng", "Hoàn Kiếm", "Thanh Xuân", "Hoàng Mai", "Long Biên", "Hà Đông", "Tây Hồ", "Nam Từ Liêm", "Bắc Từ Liêm" });
            cbArea.Location = new Point(178, 279);
            cbArea.Margin = new Padding(4);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(283, 28);
            cbArea.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(27, 286);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 16);
            label3.TabIndex = 12;
            label3.Text = "Area :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(27, 224);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 10;
            label2.Text = "Home town :";
            // 
            // txtHomeTown
            // 
            txtHomeTown.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHomeTown.Location = new Point(178, 217);
            txtHomeTown.Margin = new Padding(4);
            txtHomeTown.Name = "txtHomeTown";
            txtHomeTown.Size = new Size(283, 26);
            txtHomeTown.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(27, 171);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 7;
            label1.Text = "Name :";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(178, 164);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 26);
            txtName.TabIndex = 6;
            // 
            // frmInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 519);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInfo";
            Load += frmInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHomeTown;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLicenses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReturn;
    }
}