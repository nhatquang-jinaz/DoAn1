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
    public class TiendoBUS
    {
        TiendoDAL dal = new TiendoDAL();

        public DataTable LayLichSu() => dal.LayLichSu();
        public DataTable LayCongViecDuAn(string maDA) => dal.LayCongViecTheoDuAn(maDA);

        public string Validate(TiendoDTO td)
        {
            if (string.IsNullOrWhiteSpace(td.MaTienDo))
                return "Mã tiến độ không được để trống!";
            
            string patternTD = @"^TD\d{2}$"; //bắt buộc định dạng mã phải bắt đầu bằng TD đi cùng 2 chữ số
            if (!Regex.IsMatch(td.MaTienDo.ToUpper(), patternTD))
            {
                return "Mã tiến độ phải đúng định dạng TDXX (Ví dụ: TD01, TD99)!";
            }

            if (string.IsNullOrWhiteSpace(td.MaCongViec))
                return "Mã công việc không được để trống!";
            
            string patternCV = @"^CV\d{2}$";
            if (!Regex.IsMatch(td.MaCongViec.ToUpper(), patternCV))
            {
                return "Mã công việc phải đúng định dạng CVXX (Ví dụ: CV01, CV99)!";
            }
            
            if (string.IsNullOrWhiteSpace(td.NguoiCapNhat))
                return "Người cập nhật không được để trống!";
            
            string patternND = @"^ND\d{2}$";
            if (!Regex.IsMatch(td.NguoiCapNhat.ToUpper(), patternND))
            {
                return "Mã người cập nhật phải đúng định dạng NDXX (Ví dụ: ND01, ND99)!";
            }

            if (td.PhanTramHoanThanh < 0 || td.PhanTramHoanThanh > 100)
                return "Phần trăm hoàn thành phải nằm trong khoảng từ 0 đến 100!";

            if (string.IsNullOrWhiteSpace(td.GhiChu))
                return "Ghi chú không được để trống!";

            if (td.GhiChu != null && td.GhiChu.Length > 200)
                return "Ghi chú quá dài (tối đa 200 ký tự)!";

            return null; //trả về null nếu mọi thứ đều hợp lệ
        }

        public string CapNhat(TiendoDTO td)
        {
            //gọi hàm validate
            string error = Validate(td);
            if (error != null) return error;

            //nếu qua được bước validate thì mới gọi DAL
            return dal.CapnhatTienDo(td) ? "SUCCESS" : "Lỗi cập nhật CSDL!";
        }

        public string Xoa(string maTD)
        {
            if (string.IsNullOrWhiteSpace(maTD)) return "Vui lòng chọn bản ghi cần xóa!";
            return dal.XoaTiendo(maTD) ? "SUCCESS" : "Lỗi khi xóa bản ghi!";
        }
    }
}
