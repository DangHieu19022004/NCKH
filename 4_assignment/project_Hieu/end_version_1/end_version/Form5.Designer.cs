namespace end_version
{
    partial class Form5
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
            panel1 = new Panel();
            panel2 = new Panel();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            panel3 = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(90, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(772, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(28, 450);
            panel2.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label14.Location = new Point(0, 281);
            label14.Margin = new Padding(30, 30, 3, 0);
            label14.Name = "label14";
            label14.Padding = new Padding(10);
            label14.Size = new Size(453, 47);
            label14.TabIndex = 13;
            label14.Text = "Thank you everyone for your interest !";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label15.Location = new Point(0, 224);
            label15.Margin = new Padding(30, 30, 3, 0);
            label15.Name = "label15";
            label15.Padding = new Padding(10);
            label15.Size = new Size(579, 47);
            label15.TabIndex = 14;
            label15.Text = "Our team consists of 3 members Anh,Hiếu,Quang";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label16.Location = new Point(0, 166);
            label16.Margin = new Padding(30, 30, 3, 0);
            label16.Name = "label16";
            label16.Padding = new Padding(10);
            label16.Size = new Size(785, 47);
            label16.TabIndex = 15;
            label16.Text = "Designed and ideated by our team under the guidance of Mrs.Chau. ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label17.Location = new Point(0, 112);
            label17.Margin = new Padding(30, 30, 3, 0);
            label17.Name = "label17";
            label17.Padding = new Padding(10);
            label17.Size = new Size(906, 47);
            label17.TabIndex = 16;
            label17.Text = "This is a demo of the application of the algorithm to find the most optimal path.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label18.Location = new Point(0, 63);
            label18.Margin = new Padding(30, 30, 3, 0);
            label18.Name = "label18";
            label18.Padding = new Padding(10);
            label18.Size = new Size(203, 47);
            label18.TabIndex = 17;
            label18.Text = "Hello everyone,";
            label18.Click += label18_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label14);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(90, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(682, 450);
            panel3.TabIndex = 2;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form5";
            Text = "Form5";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Panel panel3;
    }
}