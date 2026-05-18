using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.DTO
{
    public class TiendoDTO
    {
        public string MaTienDo { get; set; }
        public string MaCongViec { get; set; }
        public int PhanTramHoanThanh { get; set; }
        public string GhiChu { get; set; }
        public string NguoiCapNhat { get; set; }
        public DateTime NgayCapNhat { get; set; }
    }
}
