using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn1.BUS;
using DoAn1.DTO;

namespace DoAn1
{
    public partial class frmTV : Form
    {
        private NguoidungBUS bus = new NguoidungBUS();
        public frmTV()
        {
            InitializeComponent();
        }

        private void frmTV_Load(object sender, EventArgs e)
        {
            cboVaitro.Items.Clear();
            cboVaitro.Items.AddRange(new string[] { "Quản lý", "Nhân viên" });
            cboVaitro.SelectedIndex = -1;
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            try
            {
                // Đổ dữ liệu từ BUS vào GridView
                dgvTV.DataSource = bus.LayDanhSach();

                // Tùy chỉnh tiêu đề cột cho chuyên nghiệp theo đúng kiểu bạn muốn
                if (dgvTV.Columns.Count > 0)
                {
                    dgvTV.Columns["maND"].HeaderText = "Mã Người Dùng";
                    dgvTV.Columns["hoTen"].HeaderText = "Họ Và Tên";
                    dgvTV.Columns["tenDN"].HeaderText = "Tên Đăng Nhập";
                    dgvTV.Columns["matKhau"].HeaderText = "Mật Khẩu";
                    dgvTV.Columns["email"].HeaderText = "Email";
                    dgvTV.Columns["SDT"].HeaderText = "Số Điện Thoại";
                    dgvTV.Columns["vaiTro"].HeaderText = "Vai Trò";
                    dgvTV.Columns["phongBan"].HeaderText = "Phòng Ban";
                    dgvTV.Columns["chucVu"].HeaderText = "Chức Vụ";

                    //ẩn nếu không muốn hiện mật khẩu ra grid
                    //dgvThanhVien.Columns["matKhau"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                //thông báo lỗi nếu có vấn đề về kết nối hoặc truy vấn
                MessageBox.Show("Lỗi khi tải dữ liệu thành viên: " + ex.Message, "Lỗi Hệ Thống");
            }
        }
        private void ClearInputs()
        {
            txtMaND.ReadOnly = false;
            txtMaND.BackColor = Color.White;
            txtMaND.Clear();
            txtHotenTV.Clear();
            txtTenDNTV.Clear();
            txtMKTV.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtPhongban.Clear();
            txtChucvu.Clear();
            cboVaitro.SelectedIndex = -1;
            txtMaND.Focus();
        }
        private NguoidungDTO GetInput()
        {
            return new NguoidungDTO
            {
                MaND = txtMaND.Text.Trim(),
                HoTen = txtHotenTV.Text.Trim(),
                TenDN = txtTenDNTV.Text.Trim(),
                MatKhau = txtMKTV.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                VaiTro = cboVaitro.Text,
                PhongBan = txtPhongban.Text.Trim(),
                ChucVu = txtChucvu.Text.Trim()
            };
        }

        private void btnThem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thêm thành viên?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;
            string res = bus.Them(GetInput());
            if (res == "SUCCESS")
            {
                MessageBox.Show("Thêm thành công!");
                HienThiDanhSach();
                ClearInputs();
            }
            else MessageBox.Show(res);
        }

        private void btnSua3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận sửa thông tin?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;
            string res = bus.Sua(GetInput());
            if (res == "SUCCESS")
            {
                MessageBox.Show("Cập nhật thành công!");
                HienThiDanhSach();
            }
            else MessageBox.Show(res);
        }

        private void btnXoa3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa thành viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            string res = bus.Xoa(txtMaND.Text.Trim());
            if (res == "SUCCESS")
            {
                MessageBox.Show("Xóa thành công!");
                HienThiDanhSach();
                ClearInputs();
            }
            else MessageBox.Show(res);
        }

        private void btnTim3_Click(object sender, EventArgs e)
        {
            string error;
            DataTable dt = bus.TimKiem(txtMaND.Text.Trim(), out error);
            if (error != null)
            {
                MessageBox.Show(error, "Thông báo");
            }
            else
            {
                dgvTV.DataSource = dt;
            }
        }

        private void dgvTV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaND.Text = dgvTV.Rows[i].Cells["maND"].Value.ToString();
                txtHotenTV.Text = dgvTV.Rows[i].Cells["hoTen"].Value.ToString();
                txtTenDNTV.Text = dgvTV.Rows[i].Cells["tenDN"].Value.ToString();
                txtMKTV.Text = dgvTV.Rows[i].Cells["matKhau"].Value.ToString();
                txtEmail.Text = dgvTV.Rows[i].Cells["email"].Value.ToString();
                txtSDT.Text = dgvTV.Rows[i].Cells["SDT"].Value.ToString();
                cboVaitro.Text = dgvTV.Rows[i].Cells["vaiTro"].Value.ToString();
                txtPhongban.Text = dgvTV.Rows[i].Cells["phongBan"].Value.ToString();
                txtChucvu.Text = dgvTV.Rows[i].Cells["chucVu"].Value.ToString();

                // KHÔNG CHO SỬA MÃ
                txtMaND.ReadOnly = true;
                txtMaND.BackColor = Color.LightGray;
            }
        }

        private void btnLamMoi3_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}
