using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.DTO
{
    public class LocCongViecDTO
    {
        public string TuKhoa { get; set; }
        public string TrangThai { get; set; }
        public string DoUuTien { get; set; }
    }
    public class ThongkeDTO
    {
        public int TongSoViec { get; set; }
        public int HoanThanh { get; set; }
        public int DangThucHien { get; set; }
        public int ChuaThucHien { get; set; }
        public double PhanTram { get; set; } // Dùng để chạy ProgressBar
    }
}
