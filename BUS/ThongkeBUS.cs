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

        public string ValidateLoc(LocCongViecDTO loc)
        {
            if (!string.IsNullOrWhiteSpace(loc.TuKhoa))
            {
                if (loc.TuKhoa.Length > 50) return "Từ khóa tìm kiếm quá dài (tối đa 50 ký tự).";
                if (loc.TuKhoa.Contains("'") || loc.TuKhoa.Contains("-")) return "Từ khóa chứa ký tự không hợp lệ.";
            }

            if (string.IsNullOrWhiteSpace(loc.TuKhoa) && string.IsNullOrWhiteSpace(loc.TrangThai) && string.IsNullOrWhiteSpace(loc.DoUuTien))
            {
                return "Vui lòng chọn tiêu chí lọc hoặc thêm từ khóa!";
            }

            if (!string.IsNullOrWhiteSpace(loc.TrangThai))
            {
                string[] validTT = { "Chưa thực hiện", "Đang thực hiện", "Hoàn thành" };
                if (!validTT.Contains(loc.TrangThai)) return "Trạng thái lọc không hợp lệ.";
            }

            if (!string.IsNullOrWhiteSpace(loc.DoUuTien))
            {
                string[] validDU = { "Bình thường", "Gấp", "Rất gấp" };
                if (!validDU.Contains(loc.DoUuTien)) return "Độ ưu tiên lọc không hợp lệ.";
            }

            return null;
        }

        public DataTable LocCongViec(LocCongViecDTO loc)
        {
            // Làm sạch dữ liệu trực tiếp trong object dto trước khi gửi xuống DAL
            loc.TuKhoa = string.IsNullOrWhiteSpace(loc.TuKhoa) ? null : loc.TuKhoa.Trim();
            loc.TrangThai = string.IsNullOrWhiteSpace(loc.TrangThai) ? null : loc.TrangThai.Trim();
            loc.DoUuTien = string.IsNullOrWhiteSpace(loc.DoUuTien) ? null : loc.DoUuTien.Trim();

            return dal.LocCongViec(loc);
        }

        public string ValidateThongKe(string maDA)
        {
            if (string.IsNullOrWhiteSpace(maDA)) return "Vui lòng chọn một dự án để thống kê.";
            return null;
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
