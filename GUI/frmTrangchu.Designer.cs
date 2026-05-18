namespace DoAn1
{
    partial class frmTrangchu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangchu));
            pnlTitle = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnDangXuat = new Button();
            btnTK = new Button();
            btnTD = new Button();
            btnTV = new Button();
            btnQLCV = new Button();
            btnQLDA = new Button();
            panel2 = new Panel();
            lblTenacc = new Label();
            lblVaitro = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pnlTitle.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.DarkSlateGray;
            pnlTitle.Controls.Add(label1);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(981, 32);
            pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(438, 28);
            label1.TabIndex = 0;
            label1.Text = "HỆ THỐNG QUẢN LÝ CÔNG VIỆC THEO DỰ ÁN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(btnTK);
            panel1.Controls.Add(btnTD);
            panel1.Controls.Add(btnTV);
            panel1.Controls.Add(btnQLCV);
            panel1.Controls.Add(btnQLDA);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 32);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 588);
            panel1.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Anchor = AnchorStyles.Bottom;
            btnDangXuat.BackColor = Color.CadetBlue;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.ImageIndex = 3;
            btnDangXuat.Location = new Point(59, 534);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(124, 41);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnTK
            // 
            btnTK.BackColor = Color.CadetBlue;
            btnTK.FlatStyle = FlatStyle.Flat;
            btnTK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTK.ForeColor = Color.White;
            btnTK.Location = new Point(12, 198);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(222, 54);
            btnTK.TabIndex = 5;
            btnTK.Text = "Tìm kiếm thống kê";
            btnTK.UseVisualStyleBackColor = false;
            btnTK.Click += btnTK_Click;
            // 
            // btnTD
            // 
            btnTD.BackColor = Color.CadetBlue;
            btnTD.FlatStyle = FlatStyle.Flat;
            btnTD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTD.ForeColor = Color.White;
            btnTD.Location = new Point(12, 122);
            btnTD.Name = "btnTD";
            btnTD.Size = new Size(222, 54);
            btnTD.TabIndex = 4;
            btnTD.Text = "Cập nhật tiến độ";
            btnTD.UseVisualStyleBackColor = false;
            btnTD.Click += btnTD_Click;
            // 
            // btnTV
            // 
            btnTV.BackColor = Color.CadetBlue;
            btnTV.FlatStyle = FlatStyle.Flat;
            btnTV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTV.ForeColor = Color.White;
            btnTV.ImageIndex = 3;
            btnTV.Location = new Point(12, 424);
            btnTV.Name = "btnTV";
            btnTV.Size = new Size(222, 54);
            btnTV.TabIndex = 3;
            btnTV.Text = "Quản lý thành viên";
            btnTV.UseVisualStyleBackColor = false;
            btnTV.Click += btnTV_Click;
            // 
            // btnQLCV
            // 
            btnQLCV.BackColor = Color.CadetBlue;
            btnQLCV.FlatStyle = FlatStyle.Flat;
            btnQLCV.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLCV.ForeColor = Color.White;
            btnQLCV.ImageIndex = 0;
            btnQLCV.Location = new Point(12, 348);
            btnQLCV.Name = "btnQLCV";
            btnQLCV.Size = new Size(222, 54);
            btnQLCV.TabIndex = 2;
            btnQLCV.Text = "Quản lý công việc";
            btnQLCV.UseVisualStyleBackColor = false;
            btnQLCV.Click += btnQLCV_Click;
            // 
            // btnQLDA
            // 
            btnQLDA.BackColor = Color.CadetBlue;
            btnQLDA.FlatStyle = FlatStyle.Flat;
            btnQLDA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQLDA.ForeColor = Color.White;
            btnQLDA.ImageIndex = 0;
            btnQLDA.Location = new Point(12, 274);
            btnQLDA.Name = "btnQLDA";
            btnQLDA.Size = new Size(222, 52);
            btnQLDA.TabIndex = 1;
            btnQLDA.Text = "Quản lý dự án";
            btnQLDA.UseVisualStyleBackColor = false;
            btnQLDA.Click += btnQLDA_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTenacc);
            panel2.Controls.Add(lblVaitro);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(246, 82);
            panel2.TabIndex = 0;
            // 
            // lblTenacc
            // 
            lblTenacc.AutoSize = true;
            lblTenacc.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenacc.ForeColor = Color.Transparent;
            lblTenacc.Location = new Point(81, 44);
            lblTenacc.Name = "lblTenacc";
            lblTenacc.Size = new Size(91, 31);
            lblTenacc.TabIndex = 4;
            lblTenacc.Text = "Tên acc";
            // 
            // lblVaitro
            // 
            lblVaitro.AutoSize = true;
            lblVaitro.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVaitro.ForeColor = Color.Transparent;
            lblVaitro.Location = new Point(81, 13);
            lblVaitro.Name = "lblVaitro";
            lblVaitro.Size = new Size(84, 31);
            lblVaitro.TabIndex = 4;
            lblVaitro.Text = "Vai trò";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(248, 32);
            panel3.Margin = new Padding(10);
            panel3.Name = "panel3";
            panel3.Size = new Size(733, 588);
            panel3.TabIndex = 2;
            // 
            // frmTrangchu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 620);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pnlTitle);
            Name = "frmTrangchu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTrangchu";
            Load += frmTrangchu_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cboThoigian;
        private Panel pnlTitle;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblTenacc;
        private Label lblVaitro;
        private Button btnQLDA;
        private Button btnTK;
        private Button btnTD;
        private Button btnTV;
        private Button btnQLCV;
        private Panel panel3;
        private Button btnDangXuat;
    }
}