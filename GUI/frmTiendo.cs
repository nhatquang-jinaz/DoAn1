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
    public partial class frmTiendo : Form
    {
        TiendoBUS bus = new TiendoBUS();
        public frmTiendo()
        {
            InitializeComponent();
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
                    cboChonduan2.DataSource = dt;
                    cboChonduan2.DisplayMember = "tenDA"; // Hiển thị tên dự án cho người dùng chọn
                    cboChonduan2.ValueMember = "maDA";    // Giá trị ngầm định là mã dự án để ta truy vấn
                    cboChonduan2.SelectedIndex = -1;      // Để mặc định không chọn cái nào lúc mới mở
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách dự án vào ComboBox: " + ex.Message);
            }
        }
        private void Loadlstiendo()
        {
            try
            {
                //lấy toàn bộ CV hoặc CV theo dự án 
                dgvTiendo.DataSource = bus.LayLichSu();

                if (dgvTiendo.Columns.Count > 0)
                {
                    dgvTiendo.Columns["maTD"].HeaderText = "Mã Tiến độ";
                    dgvTiendo.Columns["maCV"].HeaderText = "Mã Công Việc";
                    dgvTiendo.Columns["tenCV"].HeaderText = "Tên Công Việc";
                    dgvTiendo.Columns["thoiHan"].HeaderText = "Thời hạn";
                    dgvTiendo.Columns["ptramHoanThanh"].HeaderText = "% Hoàn Thành";
                    dgvTiendo.Columns["ghiChu"].HeaderText = "Ghi chú";
                    dgvTiendo.Columns["ngayCapNhat"].HeaderText = "Ngày cập nhật";
                    dgvTiendo.Columns["nguoiCapNhat"].HeaderText = "Người cập nhật";
                }

                //đánh dấu đỏ các việc quá hạn ngay trên Grid lớn
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách công việc: " + ex.Message);
            }
        }
        private void LoadTdtheoDa(string maDA)
        {
            try
            {
                DataTable dt = bus.LayCongViecDuAn(maDA);
                dgvTiendo.DataSource = dt;

                if (dgvTiendo.Columns.Count > 0)
                {
                    dgvTiendo.Columns["maTD"].HeaderText = "Mã Tiến độ";
                    dgvTiendo.Columns["maCV"].HeaderText = "Mã Công Việc";
                    dgvTiendo.Columns["tenCV"].HeaderText = "Tên Công Việc";
                    dgvTiendo.Columns["thoiHan"].HeaderText = "Thời hạn";
                    dgvTiendo.Columns["trangThai"].HeaderText = "Trạng thái";
                    dgvTiendo.Columns["ptramHoanThanh"].HeaderText = "% Hoàn Thành";
                    dgvTiendo.Columns["ghiChu"].HeaderText = "Ghi chú";
                    dgvTiendo.Columns["ngayCapNhat"].HeaderText = "Ngày cập nhật";
                    dgvTiendo.Columns["nguoiCapNhat"].HeaderText = "Người cập nhật";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính toán tiến độ dự án: " + ex.Message);
            }
        }

        private void btnXoaTD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTD.Text))
            {
                MessageBox.Show("Vui lòng chọn một bản ghi tiến độ trong danh sách để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa bản ghi tiến độ này không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string res = bus.Xoa(txtMaTD.Text.Trim());
                if (res == "SUCCESS")
                {
                    MessageBox.Show("Xóa bản ghi thành công!");

                    if (cboChonduan2.SelectedValue != null && cboChonduan2.SelectedIndex != -1)
                        LoadTdtheoDa(cboChonduan2.SelectedValue.ToString());
                    else
                        Loadlstiendo();

                    txtMaTD.Clear();
                    txtMaCVTD.Clear();
                    txtPTHT2.Clear();
                    txtGhichuTD.Clear();
                    txtNguoiCN.Clear();
                }
                else
                {
                    MessageBox.Show(res);
                }
            }
        }

        private void btnCapNhatTD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật tiến độ không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;

            try
            {
                TiendoDTO td = new TiendoDTO
                {
                    MaTienDo = txtMaTD.Text.Trim(),
                    MaCongViec = txtMaCVTD.Text.Trim(),
                    PhanTramHoanThanh = int.Parse(txtPTHT2.Text),
                    GhiChu = txtGhichuTD.Text,
                    NguoiCapNhat = txtNguoiCN.Text
                };

                string res = bus.CapNhat(td);
                if (res == "SUCCESS")
                {
                    MessageBox.Show("Cập nhật tiến độ thành công");
                    Loadlstiendo();
                    if (cboChonduan2.SelectedValue != null)
                        LoadTdtheoDa(cboChonduan2.SelectedValue.ToString());

                    txtMaTD.Clear();
                    txtMaCVTD.Clear();
                    txtPTHT2.Clear();
                    txtGhichuTD.Clear();
                    txtNguoiCN.Clear();
                }
                else
                {
                    MessageBox.Show(res);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ: " + ex.Message);
            }
        }

        private void cboChonduan2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChonduan2.SelectedValue != null)
            {
                string maDA = cboChonduan2.SelectedValue.ToString();
                LoadTdtheoDa(maDA);
            }
        }

        private void cboChonduan2_TextChanged(object sender, EventArgs e)
        {
            //nếu xóa sạch chữ trong ô ComboBox
            if (string.IsNullOrWhiteSpace(cboChonduan2.Text))
            {
                Loadlstiendo();
            }
        }
        private void frmTiendo_Load(object sender, EventArgs e)
        {
            LoadComboDuAn(); // Đổ dữ liệu vào ComboBox dự án
            Loadlstiendo(); // Load dữ liệu ban đầu cho Grid lớn
        }

        private void dgvTiendo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaTD.Text = dgvTiendo.Rows[e.RowIndex].Cells["maTD"].Value.ToString();
                txtMaCVTD.Text = dgvTiendo.Rows[e.RowIndex].Cells["maCV"].Value.ToString();
                txtPTHT2.Text = dgvTiendo.Rows[e.RowIndex].Cells["ptramHoanThanh"].Value.ToString();
                txtGhichuTD.Text = dgvTiendo.Rows[e.RowIndex].Cells["ghiChu"].Value.ToString();
                txtNguoiCN.Text = dgvTiendo.Rows[e.RowIndex].Cells["nguoiCapNhat"].Value.ToString();
            }
        }

        private void btnLamMoi4_Click(object sender, EventArgs e)
        {
            txtMaTD.Clear();
            txtMaCVTD.Clear();
            txtPTHT2.Clear();
            txtGhichuTD.Clear();
            txtNguoiCN.Clear();
        }
    }
}
