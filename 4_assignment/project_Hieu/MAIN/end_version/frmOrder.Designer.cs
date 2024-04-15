namespace end_version
{
    partial class ord
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
            btnSplitOrders = new Button();
            dgvOrrders = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txtSumCost = new TextBox();
            label7 = new Label();
            groupBox4 = new GroupBox();
            txtLicense = new TextBox();
            label8 = new Label();
            txtPhoneShip = new TextBox();
            label5 = new Label();
            txtNameShip = new TextBox();
            label6 = new Label();
            txtStatus = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtAdressCus = new TextBox();
            label3 = new Label();
            txtPhoneCus = new TextBox();
            label2 = new Label();
            txtNameCus = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvOrrders).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSplitOrders
            // 
            btnSplitOrders.BackColor = Color.FromArgb(255, 224, 192);
            btnSplitOrders.Dock = DockStyle.Bottom;
            btnSplitOrders.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSplitOrders.ForeColor = SystemColors.HotTrack;
            btnSplitOrders.Location = new Point(0, 508);
            btnSplitOrders.Margin = new Padding(3, 2, 3, 2);
            btnSplitOrders.Name = "btnSplitOrders";
            btnSplitOrders.Size = new Size(731, 47);
            btnSplitOrders.TabIndex = 5;
            btnSplitOrders.Text = "Split orders";
            btnSplitOrders.UseVisualStyleBackColor = false;
            btnSplitOrders.Click += btnSplitOrders_Click;
            // 
            // dgvOrrders
            // 
            dgvOrrders.AllowUserToAddRows = false;
            dgvOrrders.AllowUserToDeleteRows = false;
            dgvOrrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrrders.Dock = DockStyle.Fill;
            dgvOrrders.GridColor = SystemColors.MenuBar;
            dgvOrrders.Location = new Point(0, 0);
            dgvOrrders.Margin = new Padding(3, 2, 3, 2);
            dgvOrrders.MultiSelect = false;
            dgvOrrders.Name = "dgvOrrders";
            dgvOrrders.ReadOnly = true;
            dgvOrrders.RowHeadersWidth = 51;
            dgvOrrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrrders.Size = new Size(455, 508);
            dgvOrrders.TabIndex = 7;
            dgvOrrders.CellClick += dataGridView1_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 508);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Details";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(txtSumCost);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(txtStatus);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(3, 217);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(270, 257);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Shipping information";
            // 
            // txtSumCost
            // 
            txtSumCost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSumCost.Enabled = false;
            txtSumCost.Location = new Point(137, 206);
            txtSumCost.Name = "txtSumCost";
            txtSumCost.Size = new Size(124, 23);
            txtSumCost.TabIndex = 6;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(19, 209);
            label7.Name = "label7";
            label7.Size = new Size(112, 15);
            label7.TabIndex = 5;
            label7.Text = "Total shipping cost :";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(txtLicense);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(txtPhoneShip);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(txtNameShip);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(6, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(264, 142);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Shipper";
            // 
            // txtLicense
            // 
            txtLicense.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLicense.Enabled = false;
            txtLicense.Location = new Point(123, 93);
            txtLicense.Name = "txtLicense";
            txtLicense.Size = new Size(135, 23);
            txtLicense.TabIndex = 11;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(13, 101);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 10;
            label8.Text = "License plates :";
            // 
            // txtPhoneShip
            // 
            txtPhoneShip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneShip.Enabled = false;
            txtPhoneShip.Location = new Point(123, 57);
            txtPhoneShip.Name = "txtPhoneShip";
            txtPhoneShip.Size = new Size(135, 23);
            txtPhoneShip.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(13, 65);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 6;
            label5.Text = "Phone number :";
            // 
            // txtNameShip
            // 
            txtNameShip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNameShip.Enabled = false;
            txtNameShip.Location = new Point(123, 25);
            txtNameShip.Name = "txtNameShip";
            txtNameShip.Size = new Size(135, 23);
            txtNameShip.TabIndex = 5;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(13, 33);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 4;
            label6.Text = "Name :";
            // 
            // txtStatus
            // 
            txtStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatus.Enabled = false;
            txtStatus.Location = new Point(137, 177);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(124, 23);
            txtStatus.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(19, 180);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 2;
            label4.Text = "Status :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAdressCus);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPhoneCus);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNameCus);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 198);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer";
            // 
            // txtAdressCus
            // 
            txtAdressCus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAdressCus.Enabled = false;
            txtAdressCus.Location = new Point(70, 95);
            txtAdressCus.Multiline = true;
            txtAdressCus.Name = "txtAdressCus";
            txtAdressCus.Size = new Size(191, 81);
            txtAdressCus.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(16, 98);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Adress :";
            // 
            // txtPhoneCus
            // 
            txtPhoneCus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneCus.Enabled = false;
            txtPhoneCus.Location = new Point(126, 59);
            txtPhoneCus.Name = "txtPhoneCus";
            txtPhoneCus.Size = new Size(135, 23);
            txtPhoneCus.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(16, 62);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Phone number :";
            // 
            // txtNameCus
            // 
            txtNameCus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNameCus.Enabled = false;
            txtNameCus.Location = new Point(126, 18);
            txtNameCus.Name = "txtNameCus";
            txtNameCus.Size = new Size(135, 23);
            txtNameCus.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(455, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 508);
            panel1.TabIndex = 6;
            // 
            // ord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(731, 555);
            Controls.Add(dgvOrrders);
            Controls.Add(panel1);
            Controls.Add(btnSplitOrders);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ord";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Orders";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrrders).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnSplitOrders;
        private DataGridView dgvOrrders;
        private GroupBox groupBox2;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox txtStatus;
        private Label label4;
        private TextBox txtAdressCus;
        private Label label3;
        private TextBox txtPhoneCus;
        private Label label2;
        private TextBox txtNameCus;
        private GroupBox groupBox4;
        private TextBox txtPhoneShip;
        private Label label5;
        private TextBox txtNameShip;
        private Label label6;
        private TextBox txtSumCost;
        private Label label7;
        private TextBox txtLicense;
        private Label label8;
    }
}