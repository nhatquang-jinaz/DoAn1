using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn1.DTO;
using DoAn1.DAL;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.RegularExpressions;

namespace DoAn1.BUS
{
    internal class NguoidungBUS
    {
        NguoidungDAL dal = new NguoidungDAL();

        public NguoidungDTO DangNhap(string user, string pass)
        {
            //kiểm tra nghiệp vụ
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass) || pass.Length < 6)
            {
                return null;
            }
            //lấy thông tin từ DAL lên
            NguoidungDTO res = dal.KiemTraDangNhap(user, pass);

            //check lại xem có khớp chính xác từng chữ hoa/thường không
            if (res != null && res.TenDN.Equals(user))
            {
                return res;
            }

            return null; //từ chối nếu không khớp
            //return dal.KiemTraDangNhap(user, pass);
        }
        public DataTable LayDanhSach() => dal.GetTable();

        private string Validate(NguoidungDTO nd, bool isUpdate = false)
        {
            if (string.IsNullOrWhiteSpace(nd.MaND))
            {
                return "Mã người dùng không được để trống!";
            }
            string patternND = @"^ND\d{2}$";
            if (!Regex.IsMatch(nd.MaND.ToUpper(), patternND))
            {
                return "Mã người dùng phải đúng định dạng NDXX (Ví dụ: ND01, ND99)!";
            }

            string patternHoten = @"^[\p{L}\s]+$"; 
            if (string.IsNullOrWhiteSpace(nd.HoTen)) return "Họ tên không được để trống!";
            if (!Regex.IsMatch(nd.HoTen, patternHoten))
            {
                return "Họ tên chỉ được chứa chữ cái!";
            }

            if (string.IsNullOrWhiteSpace(nd.TenDN)) return "Tên đăng nhập không được để trống!";
            if (string.IsNullOrWhiteSpace(nd.MatKhau)) return "Mật khẩu không được để trống!";
            if (string.IsNullOrWhiteSpace(nd.VaiTro)) return "Vui lòng chọn vai trò!";
            if (!nd.Email.Contains("@") || !nd.Email.Contains("."))
            {
                return "Định dạng email phải bao gồm '@' và '.com'!";
            }
            
            string patternSDT = @"^0\d{9}$";
            if (string.IsNullOrWhiteSpace(nd.SDT))
                return "Số điện thoại không được để trống!";
            if (!Regex.IsMatch(nd.SDT, patternSDT))
            {
                return "Số điện thoại phải gồm 10 số, bắt đầu bằng số 0 và không chứa ký tự lạ!";
            }
            if (string.IsNullOrWhiteSpace(nd.ChucVu)) return "Chức vụ không được để trống!";
            if (string.IsNullOrWhiteSpace(nd.PhongBan)) return "Phòng ban không được để trống!";
            if (!isUpdate && dal.KiemTraTrungMa(nd.MaND))
            {
                return "Mã người dùng đã tồn tại.";
            }
            return null;
        }

        public string Them(NguoidungDTO nd)
        {
            string err = Validate(nd, false);
            if (err != null) return err;
            try
            {
                return dal.Them(nd) ? "SUCCESS" : "Thêm thất bại!";
            }
            catch
            {
                return "Lỗi: Mã người dùng hoặc Tên đăng nhập đã tồn tại!";
            }
        }

        public string Sua(NguoidungDTO nd)
        {
            string err = Validate(nd, true);
            if (err != null) return err;
            return dal.Sua(nd) ? "SUCCESS" : "Không tìm thấy người dùng để sửa!";
        }

        public string Xoa(string maND)
        {
            if (string.IsNullOrWhiteSpace(maND)) return "Vui lòng chọn mã người dùng cần xóa!";
            return dal.Xoa(maND) ? "SUCCESS" : "Xóa thất bại!";
        }

        public DataTable TimKiem(string maND, out string error)
        {
            error = null;
            if (string.IsNullOrWhiteSpace(maND))
            {
                error = "Vui lòng nhập mã người dùng cần tìm";
                return null;
            }
            return dal.Tim(maND);
        }
    }
}
