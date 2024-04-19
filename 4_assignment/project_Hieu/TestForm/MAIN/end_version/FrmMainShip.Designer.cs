namespace shipper_end
{
    partial class FrmMain
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
            dgvOrder = new DataGridView();
            lbShow = new Label();
            label5 = new Label();
            button1 = new Button();
            txbW = new TextBox();
            label1 = new Label();
            txbWeight = new Label();
            label6 = new Label();
            panel6 = new Panel();
            label2 = new Label();
            txbShipCost = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            txtAdre = new TextBox();
            panel2 = new Panel();
            txtName = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Dock = DockStyle.Fill;
            dgvOrder.Location = new Point(0, 199);
            dgvOrder.Margin = new Padding(4, 5, 4, 5);
            dgvOrder.MultiSelect = false;
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(905, 135);
            dgvOrder.TabIndex = 25;
            dgvOrder.CellClick += dgvOrder_CellClick;
            // 
            // lbShow
            // 
            lbShow.Dock = DockStyle.Fill;
            lbShow.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbShow.Location = new Point(0, 29);
            lbShow.Margin = new Padding(4, 0, 4, 0);
            lbShow.Name = "lbShow";
            lbShow.Size = new Size(905, 165);
            lbShow.TabIndex = 4;
            lbShow.Text = "a -> b -> d";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 89);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone number";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(601, 132);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(180, 42);
            button1.TabIndex = 10;
            button1.Text = "Trả hàng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txbW
            // 
            txbW.Location = new Point(601, 81);
            txbW.Margin = new Padding(4, 5, 4, 5);
            txbW.Name = "txbW";
            txbW.ReadOnly = true;
            txbW.Size = new Size(180, 27);
            txbW.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // txbWeight
            // 
            txbWeight.AutoSize = true;
            txbWeight.Location = new Point(499, 92);
            txbWeight.Margin = new Padding(4, 0, 4, 0);
            txbWeight.Name = "txbWeight";
            txbWeight.Size = new Size(71, 20);
            txbWeight.TabIndex = 15;
            txbWeight.Text = "Cân nặng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 148);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 5;
            label6.Text = "Adress";
            // 
            // panel6
            // 
            panel6.Controls.Add(lbShow);
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 334);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(905, 194);
            panel6.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 29);
            label2.TabIndex = 3;
            label2.Text = "Lộ trình gợi ý";
            // 
            // txbShipCost
            // 
            txbShipCost.Location = new Point(601, 28);
            txbShipCost.Margin = new Padding(4, 5, 4, 5);
            txbShipCost.Name = "txbShipCost";
            txbShipCost.ReadOnly = true;
            txbShipCost.Size = new Size(180, 27);
            txbShipCost.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 35);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 13;
            label4.Text = "Tiền ship";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(149, 81);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(300, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtAdre
            // 
            txtAdre.Location = new Point(149, 140);
            txtAdre.Margin = new Padding(4, 5, 4, 5);
            txtAdre.Name = "txtAdre";
            txtAdre.ReadOnly = true;
            txtAdre.Size = new Size(300, 27);
            txtAdre.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txbW);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txbWeight);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txbShipCost);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtAdre);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(905, 199);
            panel2.TabIndex = 23;
            // 
            // txtName
            // 
            txtName.Location = new Point(149, 28);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(300, 27);
            txtName.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 528);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 34);
            panel1.TabIndex = 22;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(905, 562);
            Controls.Add(dgvOrder);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label lbShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txbWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbShipCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
    }
}