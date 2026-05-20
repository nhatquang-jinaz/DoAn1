using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DoAn1.DAL;
using DoAn1.DTO;

namespace DoAn1.BUS
{
    public class CongviecBUS
    {
        CongviecDAL dal = new CongviecDAL();
        private string Validate(CongviecDTO cv, bool isUpdate = false)
        {
            if (string.IsNullOrWhiteSpace(cv.MaCV)) return "Mã công việc không được để trống.";
            if (string.IsNullOrWhiteSpace(cv.TenCV)) return "Tên công việc không được để trống.";
            if (string.IsNullOrWhiteSpace(cv.MoTa)) return "Vui lòng nhập mô tả.";
            if (string.IsNullOrWhiteSpace(cv.MaDA)) return "Mã dự án không được để trống.";
            if (string.IsNullOrWhiteSpace(cv.NguoiTao)) return "Mã người tạo không được để trống";

            //sau khi chắc chắn không trống thì kiểm tra định dạng định dạng Regex
            string patternCD = @"^CV\d{2}$";
            if (!Regex.IsMatch(cv.MaCV.ToUpper(), patternCD))
                return "Mã công việc phải đúng định dạng CVXX (Ví dụ: CV01, CV99)!";

            string patternDA = @"^DA\d{2}$";
            if (!Regex.IsMatch(cv.MaDA.ToUpper(), patternDA))
                return "Mã dự án phải đúng định dạng DAXX (Ví dụ: DA01, DA99)!";

            string patternND = @"^ND\d{2}$";
            if (!Regex.IsMatch(cv.NguoiTao.ToUpper(), patternND))
                return "Mã người tạo phải đúng định dạng NDXX (Ví dụ: ND01, ND99)!";

            //kiểm tra các logic nghiệp vụ khác
            string[] dsUuTien = { "Bình thường", "Gấp", "Rất gấp" };
            if (!dsUuTien.Contains(cv.DoUuTien)) return "Độ ưu tiên không hợp lệ.";

            string[] dsTrangThai = { "Chưa thực hiện", "Đang thực hiện", "Hoàn thành" };
            if (!dsTrangThai.Contains(cv.TrangThai)) return "Trạng thái không hợp lệ.";

            if (cv.PTramHoanThanh < 0 || cv.PTramHoanThanh > 100) return "% phải từ 0-100!";

            if (cv.ThoiHan < DateTime.Now.Date && !isUpdate)
                return "Thời hạn công việc không thể ở quá khứ.";

            return null; // Không có lỗi
        }
        // Logic Load dữ liệu: Nếu maDA trống thì lấy hết, ngược lại lấy theo Dự án
        public DataTable LayDanhSach(string maDA = null)
        {
            if (string.IsNullOrEmpty(maDA)) return dal.GetAll();
            return dal.GetTableByDuAn(maDA);
        }

        public DataTable LayDSNhanVien() => dal.GetNhanVienDePhanCong();

        public string Them(CongviecDTO cv)
        {
            string error = Validate(cv, false);
            if (error != null) return error;

            if (dal.KiemTraTrungMa(cv.MaCV)) return "Mã công việc đã tồn tại!";
            return dal.Them(cv) ? "SUCCESS" : "Lỗi khi thêm công việc!";
        }

        public string Sua(CongviecDTO cv)
        {
            string error = Validate(cv, true);
            if (error != null) return error;

            return dal.Sua(cv) ? "SUCCESS" : "Lỗi khi cập nhật công việc!";
        }

        public string Xoa(string maCV) => dal.Xoa(maCV) ? "SUCCESS" : "Lỗi khi xóa!";

        public DataTable TimKiem(string maCV) => dal.TimKiem(maCV);

        public string PhanCong(string maCV, List<string> dsMaNV)
        {
            if (string.IsNullOrEmpty(maCV)) return "Chưa chọn công việc!";
            foreach (var maNV in dsMaNV)
            {
                try { dal.PhanCongNV(maCV, maNV); } catch { }
            }
            return "SUCCESS";
        }
    }
}
