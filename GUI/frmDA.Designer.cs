namespace DoAn1
{
    partial class frmDA
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
            dgvDuan = new DataGridView();
            groupBox1 = new GroupBox();
            btnLamMoi1 = new Button();
            button1 = new Button();
            txtMAQL = new TextBox();
            label7 = new Label();
            btnXoa1 = new Button();
            btnSua1 = new Button();
            btnThem1 = new Button();
            dtpBatdauDA = new DateTimePicker();
            dtpKetDA = new DateTimePicker();
            cboTTDA = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            txtMotaDA = new TextBox();
            label1 = new Label();
            txtTenDA = new TextBox();
            txtMaDA = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDuan).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDuan
            // 
            dgvDuan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDuan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDuan.BackgroundColor = Color.White;
            dgvDuan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDuan.GridColor = Color.Black;
            dgvDuan.Location = new Point(12, 294);
            dgvDuan.Name = "dgvDuan";
            dgvDuan.RowHeadersWidth = 51;
            dgvDuan.Size = new Size(691, 213);
            dgvDuan.TabIndex = 42;
            dgvDuan.CellClick += dgvDuan_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnLamMoi1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtMAQL);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnXoa1);
            groupBox1.Controls.Add(btnSua1);
            groupBox1.Controls.Add(btnThem1);
            groupBox1.Controls.Add(dtpBatdauDA);
            groupBox1.Controls.Add(dtpKetDA);
            groupBox1.Controls.Add(cboTTDA);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMotaDA);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTenDA);
            groupBox1.Controls.Add(txtMaDA);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 276);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý dự án";
            // 
            // btnLamMoi1
            // 
            btnLamMoi1.Anchor = AnchorStyles.Top;
            btnLamMoi1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi1.Location = new Point(548, 215);
            btnLamMoi1.Name = "btnLamMoi1";
            btnLamMoi1.Size = new Size(108, 46);
            btnLamMoi1.TabIndex = 79;
            btnLamMoi1.Text = "Làm mới";
            btnLamMoi1.UseVisualStyleBackColor = true;
            btnLamMoi1.Click += btnLamMoi1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(419, 215);
            button1.Name = "button1";
            button1.Size = new Size(108, 46);
            button1.TabIndex = 78;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtMAQL
            // 
            txtMAQL.Anchor = AnchorStyles.Top;
            txtMAQL.Location = new Point(487, 168);
            txtMAQL.Name = "txtMAQL";
            txtMAQL.Size = new Size(192, 30);
            txtMAQL.TabIndex = 77;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(349, 167);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 76;
            label7.Text = "Mã quản lý: ";
            // 
            // btnXoa1
            // 
            btnXoa1.Anchor = AnchorStyles.Top;
            btnXoa1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa1.Location = new Point(290, 215);
            btnXoa1.Name = "btnXoa1";
            btnXoa1.Size = new Size(108, 46);
            btnXoa1.TabIndex = 74;
            btnXoa1.Text = "Xóa";
            btnXoa1.UseVisualStyleBackColor = true;
            btnXoa1.Click += btnXoa1_Click;
            // 
            // btnSua1
            // 
            btnSua1.Anchor = AnchorStyles.Top;
            btnSua1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua1.Location = new Point(161, 215);
            btnSua1.Name = "btnSua1";
            btnSua1.Size = new Size(108, 46);
            btnSua1.TabIndex = 73;
            btnSua1.Text = "Sửa";
            btnSua1.UseVisualStyleBackColor = true;
            btnSua1.Click += btnSua1_Click;
            // 
            // btnThem1
            // 
            btnThem1.Anchor = AnchorStyles.Top;
            btnThem1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem1.Location = new Point(32, 215);
            btnThem1.Name = "btnThem1";
            btnThem1.Size = new Size(108, 46);
            btnThem1.TabIndex = 72;
            btnThem1.Text = "Thêm";
            btnThem1.UseVisualStyleBackColor = true;
            btnThem1.Click += btnThem1_Click;
            // 
            // dtpBatdauDA
            // 
            dtpBatdauDA.Anchor = AnchorStyles.Top;
            dtpBatdauDA.Location = new Point(487, 70);
            dtpBatdauDA.Name = "dtpBatdauDA";
            dtpBatdauDA.Size = new Size(192, 30);
            dtpBatdauDA.TabIndex = 71;
            // 
            // dtpKetDA
            // 
            dtpKetDA.Anchor = AnchorStyles.Top;
            dtpKetDA.Location = new Point(487, 119);
            dtpKetDA.Name = "dtpKetDA";
            dtpKetDA.Size = new Size(192, 30);
            dtpKetDA.TabIndex = 70;
            // 
            // cboTTDA
            // 
            cboTTDA.Anchor = AnchorStyles.Top;
            cboTTDA.FormattingEnabled = true;
            cboTTDA.Location = new Point(487, 20);
            cboTTDA.Name = "cboTTDA";
            cboTTDA.Size = new Size(192, 31);
            cboTTDA.TabIndex = 69;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(349, 119);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 68;
            label2.Text = "Ngày kết thúc: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(349, 71);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 67;
            label3.Text = "Ngày bắt đầu: ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(349, 23);
            label6.Name = "label6";
            label6.Size = new Size(104, 25);
            label6.TabIndex = 66;
            label6.Text = "Trạng thái: ";
            // 
            // txtMotaDA
            // 
            txtMotaDA.Anchor = AnchorStyles.Top;
            txtMotaDA.Location = new Point(114, 124);
            txtMotaDA.Name = "txtMotaDA";
            txtMotaDA.Size = new Size(192, 30);
            txtMotaDA.TabIndex = 65;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 126);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 64;
            label1.Text = "Mô tả: ";
            // 
            // txtTenDA
            // 
            txtTenDA.Anchor = AnchorStyles.Top;
            txtTenDA.Location = new Point(114, 80);
            txtTenDA.Name = "txtTenDA";
            txtTenDA.Size = new Size(192, 30);
            txtTenDA.TabIndex = 63;
            // 
            // txtMaDA
            // 
            txtMaDA.Anchor = AnchorStyles.Top;
            txtMaDA.Location = new Point(114, 36);
            txtMaDA.Name = "txtMaDA";
            txtMaDA.Size = new Size(192, 30);
            txtMaDA.TabIndex = 62;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 82);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 61;
            label4.Text = "Tên dự án: ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 38);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 60;
            label5.Text = "Mã dự án: ";
            // 
            // frmDA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 519);
            Controls.Add(groupBox1);
            Controls.Add(dgvDuan);
            Name = "frmDA";
            Text = "frmDA";
            Load += frmDA_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDuan).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvDuan;
        private GroupBox groupBox1;
        private TextBox txtMAQL;
        private Label label7;
        private Button btnXoa1;
        private Button btnSua1;
        private Button btnThem1;
        private DateTimePicker dtpBatdauDA;
        private DateTimePicker dtpKetDA;
        private ComboBox cboTTDA;
        private Label label2;
        private Label label3;
        private Label label6;
        private TextBox txtMotaDA;
        private Label label1;
        private TextBox txtTenDA;
        private TextBox txtMaDA;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button btnLamMoi1;
    }
}