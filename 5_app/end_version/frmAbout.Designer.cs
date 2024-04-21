namespace end_version
{
    partial class frmAbout
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
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            label18 = new Label();
            label17 = new Label();
            label14 = new Label();
            label16 = new Label();
            label15 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(831, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(79, 457);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(74, 457);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label15);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 457);
            panel3.TabIndex = 5;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label18.Location = new Point(73, 43);
            label18.Margin = new Padding(26, 22, 3, 0);
            label18.Name = "label18";
            label18.Padding = new Padding(9, 8, 9, 8);
            label18.Size = new Size(171, 38);
            label18.TabIndex = 22;
            label18.Text = "Hello everyone,";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label17.Location = new Point(73, 118);
            label17.Margin = new Padding(26, 22, 3, 0);
            label17.Name = "label17";
            label17.Padding = new Padding(9, 8, 9, 8);
            label17.Size = new Size(749, 38);
            label17.TabIndex = 21;
            label17.Text = "This is a demo of the application of the algorithm to find the most optimal path.";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label14.Location = new Point(73, 343);
            label14.Margin = new Padding(26, 22, 3, 0);
            label14.Name = "label14";
            label14.Padding = new Padding(9, 8, 9, 8);
            label14.Size = new Size(383, 38);
            label14.TabIndex = 18;
            label14.Text = "Thank you everyone for your interest !";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label16.Location = new Point(73, 193);
            label16.Margin = new Padding(26, 22, 3, 0);
            label16.Name = "label16";
            label16.Padding = new Padding(9, 8, 9, 8);
            label16.Size = new Size(657, 38);
            label16.TabIndex = 20;
            label16.Text = "Designed and ideated by our team under the guidance of Mrs.Chau. ";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label15.Location = new Point(73, 268);
            label15.Margin = new Padding(26, 22, 3, 0);
            label15.Name = "label15";
            label15.Padding = new Padding(9, 8, 9, 8);
            label15.Size = new Size(482, 38);
            label15.TabIndex = 19;
            label15.Text = "Our team consists of 3 members Anh,Hiếu,Quang";
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(910, 457);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "frmAbout";
            Text = "frmAbout";
            Load += frmAbout_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label18;
        private Label label17;
        private Label label14;
        private Label label16;
        private Label label15;
    }
}