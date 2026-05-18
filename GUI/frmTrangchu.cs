using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WinFormsApp1;
using DoAn1.DTO;
using DoAn1.DAL;

namespace DoAn1
{
    public partial class frmTrangchu : Form
    {
        //khai báo đối tượng để lưu trữ thông tin dùng chung cho cả Form
        private DoAn1.DTO.NguoidungDTO user;

        //hàm tạo để nhận dữ liệu từ Form Đăng Nhập
        public frmTrangchu(DoAn1.DTO.NguoidungDTO userLogin)
        {
            InitializeComponent();
            this.user = userLogin; //gán dữ liệu nhận được vào biến 'user' của lớp
        }
        public frmTrangchu()
        {
            InitializeComponent();
        }

        private void frmTrangchu_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                lblTenacc.Text = user.TenDN;
                lblVaitro.Text = user.VaiTro;

                //phân quyền
                if (user.VaiTro == "Nhân viên")
                {
                    btnQLDA.Visible = false;
                    btnTV.Visible = false;
                    btnQLCV.Visible = false;
                }
            }
        }
        private Form currentForm;
        private Button currentButton;
        private void OpenChildForm(Form childForm)
        {
            // Đóng form cũ nếu có
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }

            currentForm = childForm;

            childForm.TopLevel = false;                       // bắt buộc để nhúng vào Panel
            childForm.FormBorderStyle = FormBorderStyle.None; // bỏ viền để trông như 1 màn hình
            childForm.Dock = DockStyle.Fill;                  // chiếm toàn bộ panel

            panel3.Controls.Clear();                    // chỉ hiển thị 1 form
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        private void ActiveButton(Button btn)
        {
            // trả nút cũ về màu cũ
            if (currentButton != null)
            {
                currentButton.BackColor = Color.CadetBlue;
            }

            // cập nhật nút hiện tại
            currentButton = btn;

            // đổi màu nút mới
            currentButton.BackColor = Color.DarkSlateGray;
        }
        private void btnQLDA_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDA());
            ActiveButton(btnQLDA);
        }

        private void btnQLCV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCV());
            ActiveButton(btnQLCV);
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTV());
            ActiveButton(btnTV);
        }

        private void btnTD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTiendo());
            ActiveButton(btnTD);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTK());
            ActiveButton(btnTK);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn muốn đăng xuất không",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmDN f = new frmDN();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
