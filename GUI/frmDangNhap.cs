using System.Windows.Forms;
using DoAn1;
using Microsoft.Data.SqlClient;
using DoAn1.DTO;
using DoAn1.BUS;
using DoAn1.DAL;

namespace WinFormsApp1
{
    public partial class frmDN : Form
    {
        NguoidungBUS bus = new NguoidungBUS();
        public frmDN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDN_Click_1(object sender, EventArgs e)
        {
            //gọi tầng BUS xử lý
            NguoidungDTO ketQua = bus.DangNhap(txtTenTK.Text, txtMK.Text);

            if (ketQua != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                this.Hide();
                //truyền đối tượng ketqua
                frmTrangchu f = new frmTrangchu(ketQua);
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật không khẩu chính xác!", "Thông báo");
                txtTenTK.Focus();
            }
        }

        private void btnXoa1_Click_1(object sender, EventArgs e)
        {
            txtTenTK.Clear();
            txtMK.Clear();
            txtTenTK.Focus();
        }
    }
}
