namespace DoAn1
{
    partial class frmCV
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
            dgvCV = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnLamMoi2 = new Button();
            txtTenCV = new TextBox();
            txtMaCV = new TextBox();
            txtPTHT = new TextBox();
            cboTTCV = new ComboBox();
            cboDoUT = new ComboBox();
            dtpThoihanCV = new DateTimePicker();
            txtMDACV = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label9 = new Label();
            txtMotaCV = new TextBox();
            txtNguoitaoCV = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            btnThem2 = new Button();
            btnXoa3 = new Button();
            btnSua2 = new Button();
            tabPage2 = new TabPage();
            btnPhancong = new Button();
            clbDSNV = new CheckedListBox();
            label12 = new Label();
            txtMaCVPC = new TextBox();
            label11 = new Label();
            btnTim2 = new Button();
            txtTimCV = new TextBox();
            label10 = new Label();
            cboChonduan = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCV).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCV
            // 
            dgvCV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCV.BackgroundColor = Color.White;
            dgvCV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCV.GridColor = Color.Black;
            dgvCV.Location = new Point(12, 390);
            dgvCV.Name = "dgvCV";
            dgvCV.RowHeadersWidth = 51;
            dgvCV.Size = new Size(691, 175);
            dgvCV.TabIndex = 45;
            dgvCV.CellClick += dgvCV_CellClick;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 52);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(691, 333);
            tabControl1.TabIndex = 46;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(btnLamMoi2);
            tabPage1.Controls.Add(txtTenCV);
            tabPage1.Controls.Add(txtMaCV);
            tabPage1.Controls.Add(txtPTHT);
            tabPage1.Controls.Add(cboTTCV);
            tabPage1.Controls.Add(cboDoUT);
            tabPage1.Controls.Add(dtpThoihanCV);
            tabPage1.Controls.Add(txtMDACV);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtMotaCV);
            tabPage1.Controls.Add(txtNguoitaoCV);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btnThem2);
            tabPage1.Controls.Add(btnXoa3);
            tabPage1.Controls.Add(btnSua2);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(683, 297);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý công việc";
            // 
            // btnLamMoi2
            // 
            btnLamMoi2.Anchor = AnchorStyles.Top;
            btnLamMoi2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi2.Location = new Point(483, 242);
            btnLamMoi2.Name = "btnLamMoi2";
            btnLamMoi2.Size = new Size(108, 46);
            btnLamMoi2.TabIndex = 101;
            btnLamMoi2.Text = "Làm mới";
            btnLamMoi2.UseVisualStyleBackColor = true;
            btnLamMoi2.Click += btnLamMoi2_Click;
            // 
            // txtTenCV
            // 
            txtTenCV.Anchor = AnchorStyles.Top;
            txtTenCV.Location = new Point(137, 66);
            txtTenCV.Name = "txtTenCV";
            txtTenCV.Size = new Size(169, 30);
            txtTenCV.TabIndex = 113;
            // 
            // txtMaCV
            // 
            txtMaCV.Anchor = AnchorStyles.Top;
            txtMaCV.Location = new Point(137, 22);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.Size = new Size(169, 30);
            txtMaCV.TabIndex = 112;
            // 
            // txtPTHT
            // 
            txtPTHT.Anchor = AnchorStyles.Top;
            txtPTHT.Location = new Point(559, 101);
            txtPTHT.Name = "txtPTHT";
            txtPTHT.Size = new Size(118, 30);
            txtPTHT.TabIndex = 111;
            // 
            // cboTTCV
            // 
            cboTTCV.Anchor = AnchorStyles.Top;
            cboTTCV.FormattingEnabled = true;
            cboTTCV.Location = new Point(485, 53);
            cboTTCV.Name = "cboTTCV";
            cboTTCV.Size = new Size(192, 31);
            cboTTCV.TabIndex = 110;
            // 
            // cboDoUT
            // 
            cboDoUT.Anchor = AnchorStyles.Top;
            cboDoUT.FormattingEnabled = true;
            cboDoUT.Location = new Point(485, 10);
            cboDoUT.Name = "cboDoUT";
            cboDoUT.Size = new Size(192, 31);
            cboDoUT.TabIndex = 109;
            // 
            // dtpThoihanCV
            // 
            dtpThoihanCV.Anchor = AnchorStyles.Top;
            dtpThoihanCV.Location = new Point(125, 154);
            dtpThoihanCV.Name = "dtpThoihanCV";
            dtpThoihanCV.Size = new Size(181, 30);
            dtpThoihanCV.TabIndex = 108;
            // 
            // txtMDACV
            // 
            txtMDACV.Anchor = AnchorStyles.Top;
            txtMDACV.Location = new Point(488, 148);
            txtMDACV.Name = "txtMDACV";
            txtMDACV.Size = new Size(189, 30);
            txtMDACV.TabIndex = 106;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 24);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 86;
            label5.Text = "Mã công việc:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 68);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 87;
            label4.Text = "Tên công việc:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 112);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 90;
            label1.Text = "Mô tả:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 156);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 102;
            label9.Text = "Thời hạn:";
            // 
            // txtMotaCV
            // 
            txtMotaCV.Anchor = AnchorStyles.Top;
            txtMotaCV.Location = new Point(125, 110);
            txtMotaCV.Name = "txtMotaCV";
            txtMotaCV.Size = new Size(181, 30);
            txtMotaCV.TabIndex = 91;
            // 
            // txtNguoitaoCV
            // 
            txtNguoitaoCV.Anchor = AnchorStyles.Top;
            txtNguoitaoCV.Location = new Point(488, 195);
            txtNguoitaoCV.Name = "txtNguoitaoCV";
            txtNguoitaoCV.Size = new Size(189, 30);
            txtNguoitaoCV.TabIndex = 101;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(349, 9);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 92;
            label6.Text = "Độ ưu tiên: ";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(349, 197);
            label8.Name = "label8";
            label8.Size = new Size(133, 25);
            label8.TabIndex = 100;
            label8.Text = "Mã người tạo: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(349, 56);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 93;
            label3.Text = "Trạng thái:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(349, 150);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 99;
            label7.Text = "Mã dự án:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(349, 103);
            label2.Name = "label2";
            label2.Size = new Size(204, 25);
            label2.TabIndex = 94;
            label2.Text = "Phần trăm hoàn thành: ";
            // 
            // btnThem2
            // 
            btnThem2.Anchor = AnchorStyles.Top;
            btnThem2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem2.Location = new Point(90, 242);
            btnThem2.Name = "btnThem2";
            btnThem2.Size = new Size(108, 46);
            btnThem2.TabIndex = 95;
            btnThem2.Text = "Thêm";
            btnThem2.UseVisualStyleBackColor = true;
            btnThem2.Click += btnThem2_Click;
            // 
            // btnXoa3
            // 
            btnXoa3.Anchor = AnchorStyles.Top;
            btnXoa3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa3.Location = new Point(352, 242);
            btnXoa3.Name = "btnXoa3";
            btnXoa3.Size = new Size(108, 46);
            btnXoa3.TabIndex = 97;
            btnXoa3.Text = "Xóa";
            btnXoa3.UseVisualStyleBackColor = true;
            btnXoa3.Click += btnXoa3_Click;
            // 
            // btnSua2
            // 
            btnSua2.Anchor = AnchorStyles.Top;
            btnSua2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua2.Location = new Point(221, 242);
            btnSua2.Name = "btnSua2";
            btnSua2.Size = new Size(108, 46);
            btnSua2.TabIndex = 96;
            btnSua2.Text = "Sửa";
            btnSua2.UseVisualStyleBackColor = true;
            btnSua2.Click += btnSua2_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnPhancong);
            tabPage2.Controls.Add(clbDSNV);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(txtMaCVPC);
            tabPage2.Controls.Add(label11);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(683, 297);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Phân công";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPhancong
            // 
            btnPhancong.Anchor = AnchorStyles.Top;
            btnPhancong.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPhancong.Location = new Point(464, 210);
            btnPhancong.Name = "btnPhancong";
            btnPhancong.Size = new Size(123, 39);
            btnPhancong.TabIndex = 117;
            btnPhancong.Text = "Phân Công";
            btnPhancong.UseVisualStyleBackColor = true;
            btnPhancong.Click += btnPhancong_Click;
            // 
            // clbDSNV
            // 
            clbDSNV.Anchor = AnchorStyles.Top;
            clbDSNV.FormattingEnabled = true;
            clbDSNV.Location = new Point(105, 113);
            clbDSNV.Name = "clbDSNV";
            clbDSNV.Size = new Size(300, 129);
            clbDSNV.TabIndex = 116;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(105, 75);
            label12.Name = "label12";
            label12.Size = new Size(248, 25);
            label12.TabIndex = 115;
            label12.Text = "Nhân viên có thể phân công:";
            // 
            // txtMaCVPC
            // 
            txtMaCVPC.Anchor = AnchorStyles.Top;
            txtMaCVPC.Location = new Point(236, 35);
            txtMaCVPC.Name = "txtMaCVPC";
            txtMaCVPC.Size = new Size(169, 30);
            txtMaCVPC.TabIndex = 114;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(105, 37);
            label11.Name = "label11";
            label11.Size = new Size(125, 25);
            label11.TabIndex = 113;
            label11.Text = "Mã công việc:";
            // 
            // btnTim2
            // 
            btnTim2.Anchor = AnchorStyles.Top;
            btnTim2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim2.Location = new Point(567, 15);
            btnTim2.Name = "btnTim2";
            btnTim2.Size = new Size(104, 34);
            btnTim2.TabIndex = 98;
            btnTim2.Text = "Tìm kiếm";
            btnTim2.UseVisualStyleBackColor = true;
            btnTim2.Click += btnTim2_Click;
            // 
            // txtTimCV
            // 
            txtTimCV.Anchor = AnchorStyles.Top;
            txtTimCV.Location = new Point(365, 18);
            txtTimCV.Multiline = true;
            txtTimCV.Name = "txtTimCV";
            txtTimCV.Size = new Size(185, 30);
            txtTimCV.TabIndex = 89;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(45, 20);
            label10.Name = "label10";
            label10.Size = new Size(70, 25);
            label10.TabIndex = 99;
            label10.Text = "Dự án: ";
            // 
            // cboChonduan
            // 
            cboChonduan.Anchor = AnchorStyles.Top;
            cboChonduan.FormattingEnabled = true;
            cboChonduan.Location = new Point(121, 18);
            cboChonduan.Name = "cboChonduan";
            cboChonduan.Size = new Size(201, 28);
            cboChonduan.TabIndex = 100;
            cboChonduan.SelectedIndexChanged += cboChonduan_SelectedIndexChanged;
            cboChonduan.TextChanged += cboChonduan_TextChanged;
            // 
            // frmCV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 577);
            Controls.Add(cboChonduan);
            Controls.Add(label10);
            Controls.Add(txtTimCV);
            Controls.Add(tabControl1);
            Controls.Add(dgvCV);
            Controls.Add(btnTim2);
            Name = "frmCV";
            Text = "frmCV";
            Load += frmCV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCV).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCV;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cboVaitro;
        private TextBox txtMaND;
        private TextBox txtMDACV;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtSDT;
        private TextBox txtHotenTV;
        private Label label1;
        private Label label9;
        private TextBox txtMotaCV;
        private TextBox txtNguoitaoCV;
        private Label label6;
        private Label label8;
        private Label label3;
        private Label label7;
        private Label label2;
        private Button btnTim2;
        private Button btnThem2;
        private Button btnXoa3;
        private Button btnSua2;
        private TextBox txtTimCV;
        private Label label10;
        private ComboBox cboChonduan;
        private DateTimePicker dtpThoihanCV;
        private TextBox txtPTHT;
        private ComboBox cboTTCV;
        private ComboBox cboDoUT;
        private TextBox txtTenCV;
        private TextBox txtMaCV;
        private Button btnPhancong;
        private CheckedListBox clbDSNV;
        private Label label12;
        private TextBox txtMaCVPC;
        private Label label11;
        private Button btnLamMoi2;
    }
}