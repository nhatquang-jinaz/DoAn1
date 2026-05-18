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
using DoAn1.DTO;
using DoAn1.BUS;
using DoAn1.DAL;

namespace DoAn1
{
    public partial class frmDA : Form
    {
        //khởi tạo đối tượng BUS để điều phối dữ liệu
        private DuanBUS bus = new DuanBUS();

        public frmDA()
        {
            InitializeComponent();
        }
        private void frmDA_Load(object sender, EventArgs e)
        {
            //thiết lập giá trị mặc định cho ComboBox Trạng thái
            cboTTDA.Items.Clear();
            cboTTDA.Items.AddRange(new string[] { "Chưa thực hiện", "Đang thực hiện", "Hoàn thành" });
            cboTTDA.SelectedIndex = -1;

            //tải dữ liệu lên GridView
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            try
            {
                dgvDuan.DataSource = bus.LayDanhSach();

                //tùy chỉnh tiêu đề cột cho nó đẹp
                if (dgvDuan.Columns.Count > 0)
                {
                    dgvDuan.Columns["maDA"].HeaderText = "Mã Dự Án";
                    dgvDuan.Columns["tenDA"].HeaderText = "Tên Dự Án";
                    dgvDuan.Columns["moTa"].HeaderText = "Mô Tả";
                    dgvDuan.Columns["ngayBatDau"].HeaderText = "Ngày Bắt Đầu";
                    dgvDuan.Columns["ngayKT"].HeaderText = "Ngày Kết Thúc";
                    dgvDuan.Columns["trangThai"].HeaderText = "Trạng Thái";
                    dgvDuan.Columns["maQuanLy"].HeaderText = "Mã Quản Lý";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        //hàm giúp dọn dẹp dữ liệu trên các ô
        private void ClearInputs()
        {
            txtMaDA.ReadOnly = false;//mở khóa mã để có thể thêm dự án
            txtMaDA.Clear();
            txtTenDA.Clear();
            txtMotaDA.Clear();
            dtpBatdauDA.Value = DateTime.Now;
            dtpKetDA.Value = DateTime.Now;
            cboTTDA.SelectedIndex = -1;
            txtMAQL.Clear();
            txtMaDA.Focus();
        }

        //hàm để đóng gói các dữ liệu mà người dùng nhập vào DTO
        private DuanDTO GetInputData()
        {
            return new DuanDTO
            {
                MaDA = txtMaDA.Text.Trim(),
                TenDA = txtTenDA.Text.Trim(),
                MoTa = txtMotaDA.Text.Trim(),
                NgayBatDau = dtpBatdauDA.Value,
                NgayKT = dtpKetDA.Value,
                TrangThai = cboTTDA.Text,
                MaQuanLy = txtMAQL.Text.Trim()
            };
        }

        private void dgvDuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hangchon = e.RowIndex;
            if (hangchon >= 0)
            {
                txtMaDA.Text = dgvDuan[0, hangchon].Value.ToString();
                txtTenDA.Text = dgvDuan[1, hangchon].Value.ToString();
                txtMotaDA.Text = dgvDuan[2, hangchon].Value.ToString();
                dtpBatdauDA.Text = dgvDuan[3, hangchon].Value.ToString();
                dtpKetDA.Text = dgvDuan[4, hangchon].Value.ToString();
                cboTTDA.Text = dgvDuan[5, hangchon].Value.ToString();
                txtMAQL.Text = dgvDuan[6, hangchon].Value.ToString();
                txtMaDA.ReadOnly = true;//tránh việc sửa mã dự án
            }
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            DuanDTO da = GetInputData();

            //xác nhận trước khi thêm
            if (MessageBox.Show("Xác nhận thêm dự án mới?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;

            string ketQua = bus.Them(da);

            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Thêm thành công!", "Thông báo");
                HienThiDanhSach();
                ClearInputs(); //làm sạch các ô sau khi thêm
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi");
            }
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            DuanDTO da = GetInputData();

            if (MessageBox.Show("Xác nhận cập nhật thông tin dự án?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;

            string ketQua = bus.Sua(da);

            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Cập nhật thành công!");
                HienThiDanhSach();
                ClearInputs();
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi");
            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            string maDA = txtMaDA.Text.Trim();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dự án này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            string ketQua = bus.Xoa(maDA);

            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Xóa thành công!");
                HienThiDanhSach();
                ClearInputs();
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi");
            }
        }

        private void btnTim1_Click(object sender, EventArgs e)
        {
            string maTim = txtMaDA.Text.Trim();
            string error;

            //gọi BUS xử lý logic tìm kiếm
            DataTable dt = bus.Tim(maTim, out error);

            if (error != null)
            {
                //thông báo "Vui lòng nhập mã..."
                MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDA.Focus();
            }
            else
            {
                //hiển thị kết quả 
                dgvDuan.DataSource = dt;
            }
        }

        private void btnLamMoi1_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}
