using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.DTO
{
    public class CongviecDTO
    {
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public string MoTa { get; set; }
        public DateTime ThoiHan { get; set; }
        public string DoUuTien { get; set; }
        public string TrangThai { get; set; }
        public int PTramHoanThanh { get; set; }
        public string MaDA { get; set; }
        public string NguoiTao { get; set; }

    }
    public class PhanCongDTO
    {
        public string MaCV { get; set; }
        public string MaNV { get; set; }
    }
}
