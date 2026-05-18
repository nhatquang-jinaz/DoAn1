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
    public partial class frmTK : Form
    {
        ThongkeBUS busTK = new ThongkeBUS();
        DuanBUS busDA = new DuanBUS(); // Để nạp danh sách dự án
        public frmTK()
        {
            InitializeComponent();
        }
        private void LoadDataGrid(string tuKhoa, string trangThai, string doUuTien)
        {
            try
            {
                DataTable dt = busTK.LocCongViec(tuKhoa, trangThai, doUuTien);
                dgvKQloc.DataSource = dt;

                // Thực hiện đổi tên hiển thị cho toàn bộ các cột đổ về từ bảng CongViec + PhanCong
                if (dgvKQloc.Columns.Count > 0)
                {
                    if (dgvKQloc.Columns["maCV"] != null) dgvKQloc.Columns["maCV"].HeaderText = "Mã Công Việc";
                    if (dgvKQloc.Columns["tenCV"] != null) dgvKQloc.Columns["tenCV"].HeaderText = "Tên Công Việc";
                    if (dgvKQloc.Columns["moTa"] != null) dgvKQloc.Columns["moTa"].HeaderText = "Mô Tả";
                    if (dgvKQloc.Columns["thoiHan"] != null) dgvKQloc.Columns["thoiHan"].HeaderText = "Thời Hạn";
                    if (dgvKQloc.Columns["doUuTien"] != null) dgvKQloc.Columns["doUuTien"].HeaderText = "Độ Ưu Tiên";
                    if (dgvKQloc.Columns["trangThai"] != null) dgvKQloc.Columns["trangThai"].HeaderText = "Trạng Thái";
                    if (dgvKQloc.Columns["ptramHoanThanh"] != null) dgvKQloc.Columns["ptramHoanThanh"].HeaderText = "% Hoàn Thành";
                    if (dgvKQloc.Columns["maDA"] != null) dgvKQloc.Columns["maDA"].HeaderText = "Mã Dự Án";
                    if (dgvKQloc.Columns["nguoiTao"] != null) dgvKQloc.Columns["nguoiTao"].HeaderText = "Người Tạo";
                    if (dgvKQloc.Columns["ngayTao"] != null) dgvKQloc.Columns["ngayTao"].HeaderText = "Ngày Tạo";
                    if (dgvKQloc.Columns["ngayCapNhat"] != null) dgvKQloc.Columns["ngayCapNhat"].HeaderText = "Ngày Cập Nhật";
                    if (dgvKQloc.Columns["maNV"] != null) dgvKQloc.Columns["maNV"].HeaderText = "Nhân Viên Thực Hiện"; // Cột vừa join thêm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách công việc: " + ex.Message, "Lỗi");
            }
        }
        private void frmTK_Load(object sender, EventArgs e)
        {
            LoadDataGrid("", "", "");// Load toàn bộ dữ liệu
            // Nạp dữ liệu ComboBox Lọc
            cboTTloc.Items.AddRange(new string[] { "Chưa thực hiện", "Đang thực hiện", "Hoàn thành" });
            cboDoUTloc.Items.AddRange(new string[] { "Bình thường", "Gấp", "Rất gấp" });

            // Nạp danh sách dự án vào cboDuAn (phần Thống kê)
            cboChonduan3.DataSource = busDA.LayDanhSach();
            cboChonduan3.DisplayMember = "tenDA";
            cboChonduan3.ValueMember = "maDA";
            cboChonduan3.SelectedIndex = -1;

            // Thiết lập ProgressBar
            prgTiendo.Minimum = 0;
            prgTiendo.Maximum = 100;
            prgTiendo.Value = 0;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTKL.Text;
            string tt = cboTTloc.Text;
            string du = cboDoUTloc.Text;

            string check = busTK.ValidateLoc(tuKhoa, tt, du);
            if (check != null)
            {
                MessageBox.Show(check, "Thông báo");
                return;
            }

            LoadDataGrid(tuKhoa, tt, du); //gọi hàm nạp theo điều kiện lọc
        }

        private void btnXoaloc_Click(object sender, EventArgs e)
        {
            txtTKL.Clear();
            cboTTloc.SelectedIndex = -1;
            cboDoUTloc.SelectedIndex = -1;
            LoadDataGrid("", "", ""); // Load lại toàn bộ
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            string maDA = cboChonduan3.SelectedValue?.ToString();

            // Gọi Validate
            string check = busTK.ValidateThongKe(maDA);
            if (check != null)
            {
                MessageBox.Show(check, "Thông báo");
                return;
            }

            ThongkeDTO tk = busTK.LayThongKe(maDA);

            //cập nhật các label TS, HT, TH, CT
            lblTongViec.Text = tk.TongSoViec.ToString();
            lblHT.Text = tk.HoanThanh.ToString();
            lblTH.Text = tk.DangThucHien.ToString();
            lblCTH.Text = tk.ChuaThucHien.ToString();

            //cập nhật ProgressBar và nhãn phần trăm
            int phanTramHienThi = (int)Math.Round(tk.PhanTram);
            prgTiendo.Value = phanTramHienThi;
            lblPhantram.Text = phanTramHienThi.ToString() + "%";

            if (tk.TongSoViec == 0) MessageBox.Show("Dự án này chưa có công việc nào.");
        }
    }

}
