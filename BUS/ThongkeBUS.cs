using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DoAn1.BUS;
using DoAn1.DTO;
using DoAn1.DAL;

namespace DoAn1.BUS
{
    public class ThongkeBUS
    {
        ThongkeDAL dal = new ThongkeDAL();

        public string ValidateLoc(string tuKhoa, string trangThai, string doUuTien)
        {
            //kiểm tra từ khóa: Không cho phép ký tự lạ nguy hiểm hoặc quá dài
            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                if (tuKhoa.Length > 50) return "Từ khóa tìm kiếm quá dài (tối đa 50 ký tự).";
                if (tuKhoa.Contains("'") || tuKhoa.Contains("-")) return "Từ khóa chứa ký tự không hợp lệ.";
            }
            //kiểm tra nếu k có từ khóa & k chọn tiêu chí lọc
            if (string.IsNullOrWhiteSpace(tuKhoa) && string.IsNullOrWhiteSpace(trangThai) && string.IsNullOrWhiteSpace(doUuTien))
            {
                return "Vui lòng chọn tiêu chí lọc hoặc thêm từ khóa!";
            }
            //kiểm tra Trạng thái
            if (!string.IsNullOrWhiteSpace(trangThai))
            {
                string[] validTT = { "Chưa thực hiện", "Đang thực hiện", "Hoàn thành" };
                if (!validTT.Contains(trangThai)) return "Trạng thái lọc không hợp lệ.";
            }

            //kiểm tra Độ ưu tiên
            if (!string.IsNullOrWhiteSpace(doUuTien))
            {
                string[] validDU = { "Bình thường", "Gấp", "Rất gấp" };
                if (!validDU.Contains(doUuTien)) return "Độ ưu tiên lọc không hợp lệ.";
            }

            return null; 
        }

        public string ValidateThongKe(string maDA)
        {
            if (string.IsNullOrWhiteSpace(maDA)) return "Vui lòng chọn một dự án để thống kê.";
            return null;
        }

        public DataTable LocCongViec(string tuKhoa, string trangThai, string doUuTien)
        {
            // Làm sạch dữ liệu trước khi gửi xuống DAL
            string tk = string.IsNullOrWhiteSpace(tuKhoa) ? null : tuKhoa.Trim();
            string tt = string.IsNullOrWhiteSpace(trangThai) ? null : trangThai.Trim();
            string du = string.IsNullOrWhiteSpace(doUuTien) ? null : doUuTien.Trim();

            return dal.LocCongViec(tk, tt, du);
        }

        public ThongkeDTO LayThongKe(string maDA)
        {
            if (string.IsNullOrEmpty(maDA))
            {
                return new ThongkeDTO { TongSoViec = 0, PhanTram = 0 };
            }

            ThongkeDTO result = dal.LaySoLieuThongKe(maDA);

            // Xử lý làm tròn số và giới hạn biên cho phần trăm
            if (result.PhanTram > 100) result.PhanTram = 100;
            if (result.PhanTram < 0) result.PhanTram = 0;

            result.PhanTram = Math.Round(result.PhanTram, 2);

            return result;
        }
    }
}
