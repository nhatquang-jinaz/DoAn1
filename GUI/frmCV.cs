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
    public partial class frmCV : Form
    {
        CongviecBUS bus = new CongviecBUS();
        public frmCV()
        {
            InitializeComponent();
        }

        private void frmCV_Load(object sender, EventArgs e)
        {
            LoadComboDuAn();        //đổ data vào cboDuAn
            LoadCheckedListNV();    //đổ nhân viên vào CheckedListBox ở Tab Phân công
            LoadGrid();
            cboDoUT.Items.AddRange(new string[] { "Bình thường", "Gấp", "Rất gấp" });
            cboDoUT.SelectedIndex = -1;
            cboTTCV.Items.AddRange(new string[] { "Chưa thực hiện", "Đang thực hiện", "Hoàn thành" });
            cboTTCV.SelectedIndex = -1;
        }
        private void LoadGrid(string maDA = null)
        {
            try
            {
                dgvCV.DataSource = bus.LayDanhSach(maDA);

                //tùy chỉnh tiêu đề cột cho nó đẹp
                if (dgvCV.Columns.Count > 0)
                {
                    dgvCV.Columns["maCV"].HeaderText = "Mã công việc";
                    dgvCV.Columns["tenCV"].HeaderText = "Tên công việc";
                    dgvCV.Columns["moTa"].HeaderText = "Mô Tả";
                    dgvCV.Columns["thoiHan"].HeaderText = "Thời hạn";
                    dgvCV.Columns["doUuTien"].HeaderText = "Độ ưu tiên";
                    dgvCV.Columns["trangThai"].HeaderText = "Trạng Thái";
                    dgvCV.Columns["ptramHoanThanh"].HeaderText = "% Hoàn thành";
                    dgvCV.Columns["maDA"].HeaderText = "Mã dự án";
                    dgvCV.Columns["nguoiTao"].HeaderText = "Người tạo";
                    dgvCV.Columns["ngayTao"].HeaderText = "Ngày tạo";
                    dgvCV.Columns["ngayCapNhat"].HeaderText = "Ngày cập nhật";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void LoadComboDuAn()
        {
            try
            {
                //sử dụng lại lớp BUS của Dự án để lấy danh sách
                DuanBUS daBus = new DuanBUS();
                DataTable dt = daBus.LayDanhSach();

                if (dt != null && dt.Rows.Count > 0)
                {
                    cboChonduan.DataSource = dt;
                    cboChonduan.DisplayMember = "tenDA"; // Hiển thị tên dự án cho người dùng chọn
                    cboChonduan.ValueMember = "maDA";    // Giá trị ngầm định là mã dự án để ta truy vấn
                    cboChonduan.SelectedIndex = -1;      // Để mặc định không chọn cái nào lúc mới mở
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách dự án vào ComboBox: " + ex.Message);
            }
        }

        private void cboChonduan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonduan.SelectedValue != null && !(cboChonduan.SelectedValue is DataRowView))
            {
                LoadGrid(cboChonduan.SelectedValue.ToString());
            }
        }
        private void LoadCheckedListNV()
        {
            clbDSNV.DataSource = bus.LayDSNhanVien();
            clbDSNV.DisplayMember = "hoTen";
            clbDSNV.ValueMember = "maND";
        }
        private void btnPhancong_Click(object sender, EventArgs e)
        {
            //lấy mã công việc (kiểm tra cả 2 nơi nếu cần)
            string maCV = txtMaCVPC.Text.Trim();
            if (string.IsNullOrEmpty(maCV))
            {
                MessageBox.Show("Vui lòng chọn công việc để phân công!");
                return;
            }

            //gom tất cả nhân viên được tích chọn vào một List
            List<string> selectedNV = new List<string>();
            foreach (var item in clbDSNV.CheckedItems)
            {
                //ép kiểu về DataRowView để lấy ID (maND)
                DataRowView row = item as DataRowView;
                if (row != null)
                {
                    selectedNV.Add(row["maND"].ToString());
                }
            }

            //kiểm tra xem có chọn ai không
            if (selectedNV.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một nhân viên!");
                return;
            }

            //gọi hàm PhanCong của BUS (truyền cả list sang)
            string kq = bus.PhanCong(maCV, selectedNV);

            if (kq == "SUCCESS")
            {
                MessageBox.Show($"Đã thực hiện phân công {selectedNV.Count} nhân viên thành công!");

                //bỏ tích các mục sau khi xong
                for (int i = 0; i < clbDSNV.Items.Count; i++)
                {
                    clbDSNV.SetItemChecked(i, false);
                }
            }
            else
            {
                MessageBox.Show(kq);
            }
        }
        private CongviecDTO LayDuLieuForm()
        {
            return new CongviecDTO
            {
                MaCV = txtMaCV.Text.Trim(),
                TenCV = txtTenCV.Text.Trim(),
                MoTa = txtMotaCV.Text.Trim(),
                ThoiHan = dtpThoihanCV.Value,
                DoUuTien = cboDoUT.Text,
                TrangThai = cboTTCV.Text,
                PTramHoanThanh = int.Parse(txtPTHT.Text.Trim()),
                MaDA = txtMDACV.Text,
                NguoiTao = txtNguoitaoCV.Text,
            };
        }
        private void btnThem2_Click(object sender, EventArgs e)
        {
            string kq = bus.Them(LayDuLieuForm());
            if (kq == "SUCCESS")
            {
                MessageBox.Show("Thêm công việc thành công!");
                LoadGrid(cboChonduan.SelectedValue?.ToString());
                ClearInputs();
            }
            else MessageBox.Show(kq);
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            string kq = bus.Sua(LayDuLieuForm());
            if (kq == "SUCCESS")
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadGrid(cboChonduan.SelectedValue?.ToString());
                ClearInputs();
            }
            else MessageBox.Show(kq);
        }

        private void btnXoa3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string kq = bus.Xoa(txtMaCV.Text.Trim());
                if (kq == "SUCCESS")
                {
                    LoadGrid(cboChonduan.SelectedValue?.ToString());
                    ClearInputs();
                }
                else MessageBox.Show(kq);
            }
        }

        private void btnTim2_Click(object sender, EventArgs e)
        {
            string maTim = txtTimCV.Text.Trim();
            DataTable dt = bus.TimKiem(maTim);
            if (dt.Rows.Count > 0) dgvCV.DataSource = dt;
            else MessageBox.Show("Không tìm thấy công việc với mã này!");
        }

        private void dgvCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCV.Rows[e.RowIndex];
                txtMaCV.Text = row.Cells["maCV"].Value.ToString();
                txtTenCV.Text = row.Cells["tenCV"].Value.ToString();
                txtMotaCV.Text = row.Cells["moTa"].Value.ToString();
                dtpThoihanCV.Text = row.Cells["thoiHan"].Value.ToString();
                cboDoUT.Text = row.Cells["doUuTien"].Value.ToString();
                cboTTCV.Text = row.Cells["trangThai"].Value.ToString();
                txtPTHT.Text = row.Cells["ptramHoanThanh"].Value.ToString();
                txtMDACV.Text = row.Cells["maDA"].Value.ToString();
                txtNguoitaoCV.Text = row.Cells["nguoiTao"].Value.ToString();

                txtMaCVPC.Text = row.Cells["maCV"].Value.ToString();
                txtMaCV.ReadOnly = true;//tránh việc sửa mã dự án
            }
        }
        private void ClearInputs()
        {
            txtMaCV.ReadOnly = false;//mở khóa mã để có thể thêm dự án
            txtMaCV.Clear();
            txtTenCV.Clear();
            txtMotaCV.Clear();
            dtpThoihanCV.Value = DateTime.Now;
            cboDoUT.SelectedIndex = -1;
            cboTTCV.SelectedIndex = -1;
            txtPTHT.Clear();
            txtMDACV.Clear();
            txtNguoitaoCV.Clear();
            txtMaCV.Focus();
        }

        private void btnLamMoi2_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void cboChonduan_TextChanged(object sender, EventArgs e)
        {
            //nếu xóa sạch chữ trong ô ComboBox
            if (string.IsNullOrWhiteSpace(cboChonduan.Text))
            {
                LoadGrid();
            }
        }
    }
}
