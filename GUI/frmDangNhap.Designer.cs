namespace WinFormsApp1
{
    partial class frmDN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDN));
            btnXoa1 = new Button();
            btnDN = new Button();
            txtMK = new TextBox();
            txtTenTK = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnXoa1
            // 
            btnXoa1.Anchor = AnchorStyles.Top;
            btnXoa1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa1.Location = new Point(36, 343);
            btnXoa1.Name = "btnXoa1";
            btnXoa1.Size = new Size(164, 44);
            btnXoa1.TabIndex = 24;
            btnXoa1.Text = "Xóa";
            btnXoa1.UseVisualStyleBackColor = true;
            btnXoa1.Click += btnXoa1_Click_1;
            // 
            // btnDN
            // 
            btnDN.Anchor = AnchorStyles.Top;
            btnDN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDN.Location = new Point(249, 343);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(164, 44);
            btnDN.TabIndex = 23;
            btnDN.Text = "Đăng Nhập";
            btnDN.UseVisualStyleBackColor = true;
            btnDN.Click += btnDN_Click_1;
            // 
            // txtMK
            // 
            txtMK.Anchor = AnchorStyles.Top;
            txtMK.Location = new Point(36, 287);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(377, 27);
            txtMK.TabIndex = 22;
            // 
            // txtTenTK
            // 
            txtTenTK.Anchor = AnchorStyles.Top;
            txtTenTK.Location = new Point(36, 199);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(377, 27);
            txtTenTK.TabIndex = 21;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 259);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 20;
            label4.Text = "Mật khẩu: ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 171);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 19;
            label5.Text = "Tên tài khoản: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 153);
            panel1.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(117, 24);
            label7.Name = "label7";
            label7.Size = new Size(213, 31);
            label7.TabIndex = 3;
            label7.Text = "XIN CHÀO MỪNG!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(185, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmDN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(448, 445);
            Controls.Add(panel1);
            Controls.Add(btnXoa1);
            Controls.Add(btnDN);
            Controls.Add(txtMK);
            Controls.Add(txtTenTK);
            Controls.Add(label4);
            Controls.Add(label5);
            MaximizeBox = false;
            Name = "frmDN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Đăng Nhập";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXoa1;
        private Button btnDN;
        private TextBox txtMK;
        private TextBox txtTenTK;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox1;
    }
}
