namespace end_version
{
    partial class FrmShipper
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
            splitContainer1 = new SplitContainer();
            txtLicense = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtArea = new TextBox();
            label7 = new Label();
            txtHomeTown = new TextBox();
            HomeTown = new Label();
            btnRemove = new Button();
            dgvInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfo).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtLicense);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(txtPhone);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtName);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtArea);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(txtHomeTown);
            splitContainer1.Panel2.Controls.Add(HomeTown);
            splitContainer1.Panel2.Controls.Add(btnRemove);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(847, 179);
            splitContainer1.SplitterDistance = 399;
            splitContainer1.TabIndex = 1;
            // 
            // txtLicense
            // 
            txtLicense.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLicense.Enabled = false;
            txtLicense.Location = new Point(130, 136);
            txtLicense.Name = "txtLicense";
            txtLicense.Size = new Size(230, 23);
            txtLicense.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(25, 144);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 8;
            label6.Text = "License plates :";
            label6.Click += label6_Click;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Enabled = false;
            txtPhone.Location = new Point(130, 79);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(230, 23);
            txtPhone.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(25, 87);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 4;
            label3.Text = "Phone number :";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Enabled = false;
            txtName.Location = new Point(130, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // txtArea
            // 
            txtArea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtArea.Enabled = false;
            txtArea.Location = new Point(145, 79);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(230, 23);
            txtArea.TabIndex = 13;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(40, 87);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 12;
            label7.Text = "Area :";
            // 
            // txtHomeTown
            // 
            txtHomeTown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHomeTown.Enabled = false;
            txtHomeTown.Location = new Point(145, 21);
            txtHomeTown.Name = "txtHomeTown";
            txtHomeTown.Size = new Size(230, 23);
            txtHomeTown.TabIndex = 11;
            // 
            // HomeTown
            // 
            HomeTown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            HomeTown.AutoSize = true;
            HomeTown.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            HomeTown.Location = new Point(40, 29);
            HomeTown.Name = "HomeTown";
            HomeTown.Size = new Size(76, 15);
            HomeTown.TabIndex = 10;
            HomeTown.Text = "Home town :";
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRemove.BackColor = Color.FromArgb(224, 224, 224);
            btnRemove.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = SystemColors.HotTrack;
            btnRemove.Location = new Point(145, 122);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(230, 37);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // dgvInfo
            // 
            dgvInfo.AllowUserToAddRows = false;
            dgvInfo.AllowUserToDeleteRows = false;
            dgvInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfo.Dock = DockStyle.Fill;
            dgvInfo.Location = new Point(0, 179);
            dgvInfo.MultiSelect = false;
            dgvInfo.Name = "dgvInfo";
            dgvInfo.ReadOnly = true;
            dgvInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfo.Size = new Size(847, 214);
            dgvInfo.TabIndex = 2;
            dgvInfo.CellClick += dgvInfo_CellClick;
            // 
            // FrmShipper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(847, 393);
            Controls.Add(dgvInfo);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmShipper";
            Text = "Shipper";
            Load += frmShipper_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtName;
        private Label label1;
        private TextBox txtLicense;
        private Label label6;
        private Button btnRemove;
        private DataGridView dgvInfo;
        private TextBox txtArea;
        private Label label7;
        private TextBox txtHomeTown;
        private Label HomeTown;
    }
}