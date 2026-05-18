namespace DoAn1
{
    partial class frmTK
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
            cboDoUTloc = new ComboBox();
            cboTTloc = new ComboBox();
            btnLoc = new Button();
            btnXoaloc = new Button();
            txtTKL = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox6 = new GroupBox();
            lblCTH = new Label();
            groupBox5 = new GroupBox();
            lblTH = new Label();
            groupBox4 = new GroupBox();
            lblHT = new Label();
            groupBox3 = new GroupBox();
            lblTongViec = new Label();
            lblPhantram = new Label();
            prgTiendo = new ProgressBar();
            cboChonduan3 = new ComboBox();
            label10 = new Label();
            btnThongke = new Button();
            dgvKQloc = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKQloc).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(cboDoUTloc);
            groupBox1.Controls.Add(cboTTloc);
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(btnXoaloc);
            groupBox1.Controls.Add(txtTKL);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 322);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm và lọc";
            // 
            // cboDoUTloc
            // 
            cboDoUTloc.Anchor = AnchorStyles.Top;
            cboDoUTloc.FormattingEnabled = true;
            cboDoUTloc.Location = new Point(16, 207);
            cboDoUTloc.Name = "cboDoUTloc";
            cboDoUTloc.Size = new Size(196, 33);
            cboDoUTloc.TabIndex = 101;
            // 
            // cboTTloc
            // 
            cboTTloc.Anchor = AnchorStyles.Top;
            cboTTloc.FormattingEnabled = true;
            cboTTloc.Location = new Point(16, 135);
            cboTTloc.Name = "cboTTloc";
            cboTTloc.Size = new Size(196, 33);
            cboTTloc.TabIndex = 100;
            // 
            // btnLoc
            // 
            btnLoc.Anchor = AnchorStyles.Top;
            btnLoc.Location = new Point(122, 270);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(90, 38);
            btnLoc.TabIndex = 99;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // btnXoaloc
            // 
            btnXoaloc.Anchor = AnchorStyles.Top;
            btnXoaloc.Location = new Point(16, 270);
            btnXoaloc.Name = "btnXoaloc";
            btnXoaloc.Size = new Size(90, 38);
            btnXoaloc.TabIndex = 98;
            btnXoaloc.Text = "Xóa lọc";
            btnXoaloc.UseVisualStyleBackColor = true;
            btnXoaloc.Click += btnXoaloc_Click;
            // 
            // txtTKL
            // 
            txtTKL.Anchor = AnchorStyles.Top;
            txtTKL.Location = new Point(16, 65);
            txtTKL.Name = "txtTKL";
            txtTKL.Size = new Size(196, 31);
            txtTKL.TabIndex = 94;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 175);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 91;
            label3.Text = "Độ ưu tiên:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 103);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 90;
            label2.Text = "Trạng thái:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 33);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 89;
            label1.Text = "Từ khóa:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(groupBox6);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(lblPhantram);
            groupBox2.Controls.Add(prgTiendo);
            groupBox2.Controls.Add(cboChonduan3);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btnThongke);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(256, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 322);
            groupBox2.TabIndex = 102;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống kê";
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top;
            groupBox6.Controls.Add(lblCTH);
            groupBox6.Location = new Point(236, 181);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(167, 78);
            groupBox6.TabIndex = 108;
            groupBox6.TabStop = false;
            groupBox6.Text = "Chưa thực hiện";
            // 
            // lblCTH
            // 
            lblCTH.AutoSize = true;
            lblCTH.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCTH.Location = new Point(43, 27);
            lblCTH.Name = "lblCTH";
            lblCTH.Size = new Size(50, 38);
            lblCTH.TabIndex = 110;
            lblCTH.Text = "CT";
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top;
            groupBox5.Controls.Add(lblTH);
            groupBox5.Location = new Point(54, 181);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(156, 78);
            groupBox5.TabIndex = 108;
            groupBox5.TabStop = false;
            groupBox5.Text = "Thực hiện";
            // 
            // lblTH
            // 
            lblTH.AutoSize = true;
            lblTH.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTH.Location = new Point(42, 27);
            lblTH.Name = "lblTH";
            lblTH.Size = new Size(54, 38);
            lblTH.TabIndex = 110;
            lblTH.Text = "TH";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top;
            groupBox4.Controls.Add(lblHT);
            groupBox4.Location = new Point(236, 88);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(167, 78);
            groupBox4.TabIndex = 108;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hoàn thành";
            // 
            // lblHT
            // 
            lblHT.AutoSize = true;
            lblHT.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHT.Location = new Point(39, 27);
            lblHT.Name = "lblHT";
            lblHT.Size = new Size(54, 38);
            lblHT.TabIndex = 110;
            lblHT.Text = "HT";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top;
            groupBox3.Controls.Add(lblTongViec);
            groupBox3.Location = new Point(54, 88);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(156, 78);
            groupBox3.TabIndex = 107;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tổng số việc";
            // 
            // lblTongViec
            // 
            lblTongViec.AutoSize = true;
            lblTongViec.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongViec.Location = new Point(42, 27);
            lblTongViec.Name = "lblTongViec";
            lblTongViec.Size = new Size(49, 38);
            lblTongViec.TabIndex = 109;
            lblTongViec.Text = "TS";
            // 
            // lblPhantram
            // 
            lblPhantram.Anchor = AnchorStyles.Top;
            lblPhantram.AutoSize = true;
            lblPhantram.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhantram.Location = new Point(63, 262);
            lblPhantram.Name = "lblPhantram";
            lblPhantram.Size = new Size(61, 46);
            lblPhantram.TabIndex = 106;
            lblPhantram.Text = "PT";
            // 
            // prgTiendo
            // 
            prgTiendo.Anchor = AnchorStyles.Top;
            prgTiendo.Location = new Point(130, 265);
            prgTiendo.Name = "prgTiendo";
            prgTiendo.Size = new Size(254, 43);
            prgTiendo.TabIndex = 105;
            // 
            // cboChonduan3
            // 
            cboChonduan3.Anchor = AnchorStyles.Top;
            cboChonduan3.FormattingEnabled = true;
            cboChonduan3.Location = new Point(130, 40);
            cboChonduan3.Name = "cboChonduan3";
            cboChonduan3.Size = new Size(148, 33);
            cboChonduan3.TabIndex = 104;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(54, 48);
            label10.Name = "label10";
            label10.Size = new Size(70, 25);
            label10.TabIndex = 103;
            label10.Text = "Dự án: ";
            // 
            // btnThongke
            // 
            btnThongke.Anchor = AnchorStyles.Top;
            btnThongke.Location = new Point(284, 35);
            btnThongke.Name = "btnThongke";
            btnThongke.Size = new Size(119, 38);
            btnThongke.TabIndex = 99;
            btnThongke.Text = "Thống kê";
            btnThongke.UseVisualStyleBackColor = true;
            btnThongke.Click += btnThongke_Click;
            // 
            // dgvKQloc
            // 
            dgvKQloc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvKQloc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKQloc.BackgroundColor = Color.White;
            dgvKQloc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKQloc.GridColor = Color.Black;
            dgvKQloc.Location = new Point(12, 340);
            dgvKQloc.Name = "dgvKQloc";
            dgvKQloc.RowHeadersWidth = 51;
            dgvKQloc.Size = new Size(691, 201);
            dgvKQloc.TabIndex = 104;
            // 
            // frmTK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 553);
            Controls.Add(dgvKQloc);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTK";
            Text = "frmTK";
            Load += frmTK_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKQloc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLoc;
        private Button btnXoaloc;
        private TextBox txtTKL;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboDoUTloc;
        private ComboBox cboTTloc;
        private GroupBox groupBox2;
        private Button btnThongke;
        private ComboBox cboChonduan3;
        private Label label10;
        private DataGridView dgvKQloc;
        private Label lblPhantram;
        private ProgressBar prgTiendo;
        private GroupBox groupBox3;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Label lblTongViec;
        private Label lblCTH;
        private Label lblTH;
        private Label lblHT;
    }
}