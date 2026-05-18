namespace DoAn1
{
    partial class frmTiendo
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
            groupBox1 = new GroupBox();
            btnLamMoi4 = new Button();
            btnXoaTD = new Button();
            btnCapNhatTD = new Button();
            txtNguoiCN = new TextBox();
            txtGhichuTD = new TextBox();
            txtPTHT2 = new TextBox();
            txtMaCVTD = new TextBox();
            txtMaTD = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvTiendo = new DataGridView();
            cboChonduan2 = new ComboBox();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTiendo).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnLamMoi4);
            groupBox1.Controls.Add(btnXoaTD);
            groupBox1.Controls.Add(btnCapNhatTD);
            groupBox1.Controls.Add(txtNguoiCN);
            groupBox1.Controls.Add(txtGhichuTD);
            groupBox1.Controls.Add(txtPTHT2);
            groupBox1.Controls.Add(txtMaCVTD);
            groupBox1.Controls.Add(txtMaTD);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cập nhật tiến độ";
            // 
            // btnLamMoi4
            // 
            btnLamMoi4.Anchor = AnchorStyles.Top;
            btnLamMoi4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi4.Location = new Point(301, 168);
            btnLamMoi4.Name = "btnLamMoi4";
            btnLamMoi4.Size = new Size(108, 38);
            btnLamMoi4.TabIndex = 100;
            btnLamMoi4.Text = "Làm mới";
            btnLamMoi4.UseVisualStyleBackColor = true;
            btnLamMoi4.Click += btnLamMoi4_Click;
            // 
            // btnXoaTD
            // 
            btnXoaTD.Anchor = AnchorStyles.Top;
            btnXoaTD.Location = new Point(426, 168);
            btnXoaTD.Name = "btnXoaTD";
            btnXoaTD.Size = new Size(119, 38);
            btnXoaTD.TabIndex = 99;
            btnXoaTD.Text = "Xóa";
            btnXoaTD.UseVisualStyleBackColor = true;
            btnXoaTD.Click += btnXoaTD_Click;
            // 
            // btnCapNhatTD
            // 
            btnCapNhatTD.Anchor = AnchorStyles.Top;
            btnCapNhatTD.Location = new Point(560, 168);
            btnCapNhatTD.Name = "btnCapNhatTD";
            btnCapNhatTD.Size = new Size(119, 38);
            btnCapNhatTD.TabIndex = 98;
            btnCapNhatTD.Text = "Cập nhật";
            btnCapNhatTD.UseVisualStyleBackColor = true;
            btnCapNhatTD.Click += btnCapNhatTD_Click;
            // 
            // txtNguoiCN
            // 
            txtNguoiCN.Anchor = AnchorStyles.Top;
            txtNguoiCN.Location = new Point(505, 120);
            txtNguoiCN.Name = "txtNguoiCN";
            txtNguoiCN.Size = new Size(174, 31);
            txtNguoiCN.TabIndex = 97;
            // 
            // txtGhichuTD
            // 
            txtGhichuTD.Anchor = AnchorStyles.Top;
            txtGhichuTD.Location = new Point(487, 77);
            txtGhichuTD.Name = "txtGhichuTD";
            txtGhichuTD.Size = new Size(192, 31);
            txtGhichuTD.TabIndex = 95;
            // 
            // txtPTHT2
            // 
            txtPTHT2.Anchor = AnchorStyles.Top;
            txtPTHT2.Location = new Point(561, 34);
            txtPTHT2.Name = "txtPTHT2";
            txtPTHT2.Size = new Size(118, 31);
            txtPTHT2.TabIndex = 96;
            // 
            // txtMaCVTD
            // 
            txtMaCVTD.Anchor = AnchorStyles.Top;
            txtMaCVTD.Location = new Point(137, 83);
            txtMaCVTD.Name = "txtMaCVTD";
            txtMaCVTD.Size = new Size(192, 31);
            txtMaCVTD.TabIndex = 95;
            // 
            // txtMaTD
            // 
            txtMaTD.Anchor = AnchorStyles.Top;
            txtMaTD.Location = new Point(137, 40);
            txtMaTD.Name = "txtMaTD";
            txtMaTD.Size = new Size(192, 31);
            txtMaTD.TabIndex = 94;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(356, 126);
            label6.Name = "label6";
            label6.Size = new Size(143, 25);
            label6.TabIndex = 93;
            label6.Text = "Người cập nhật:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(356, 83);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 92;
            label4.Text = "Ghi chú:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(356, 40);
            label3.Name = "label3";
            label3.Size = new Size(199, 25);
            label3.TabIndex = 91;
            label3.Text = "Phần trăm hoàn thành:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 89);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 90;
            label2.Text = "Mã công việc:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 89;
            label1.Text = "Mã tiến độ:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dgvTiendo);
            groupBox2.Controls.Add(cboChonduan2);
            groupBox2.Controls.Add(label10);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 238);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(691, 315);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Xem tiến độ theo dự án";
            // 
            // dgvTiendo
            // 
            dgvTiendo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvTiendo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTiendo.BackgroundColor = Color.White;
            dgvTiendo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiendo.GridColor = Color.Black;
            dgvTiendo.Location = new Point(14, 89);
            dgvTiendo.Name = "dgvTiendo";
            dgvTiendo.RowHeadersWidth = 51;
            dgvTiendo.Size = new Size(665, 220);
            dgvTiendo.TabIndex = 89;
            dgvTiendo.CellContentClick += dgvTiendo_CellContentClick;
            // 
            // cboChonduan2
            // 
            cboChonduan2.FormattingEnabled = true;
            cboChonduan2.Location = new Point(101, 38);
            cboChonduan2.Name = "cboChonduan2";
            cboChonduan2.Size = new Size(217, 33);
            cboChonduan2.TabIndex = 102;
            cboChonduan2.SelectedIndexChanged += cboChonduan2_SelectedIndexChanged;
            cboChonduan2.TextChanged += cboChonduan2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(25, 46);
            label10.Name = "label10";
            label10.Size = new Size(70, 25);
            label10.TabIndex = 101;
            label10.Text = "Dự án: ";
            // 
            // frmTiendo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 565);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTiendo";
            Text = "frmTiendo";
            Load += frmTiendo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTiendo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnXoaTD;
        private Button btnCapNhatTD;
        private TextBox txtNguoiCN;
        private TextBox txtGhichuTD;
        private TextBox txtPTHT2;
        private TextBox txtMaCVTD;
        private TextBox txtMaTD;
        private ComboBox cboChonduan2;
        private Label label10;
        private DataGridView dgvTiendo;
        private Button btnLamMoi4;
    }
}