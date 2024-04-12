namespace end_version
{
    partial class Form4
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
            dgvShipper = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShipper).BeginInit();
            SuspendLayout();
            // 
            // dgvShipper
            // 
            dgvShipper.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShipper.Dock = DockStyle.Top;
            dgvShipper.Enabled = false;
            dgvShipper.Location = new Point(0, 0);
            dgvShipper.Name = "dgvShipper";
            dgvShipper.RowHeadersWidth = 51;
            dgvShipper.Size = new Size(800, 140);
            dgvShipper.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 290);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvShipper);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvShipper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShipper;
        private Label label1;
    }
}