using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn1.DTO;
using Microsoft.Data.SqlClient;

namespace DoAn1.DAL
{
    public class ThongkeDAL
    {
        string conString = DbConnection.StrCon;

        public DataTable LocCongViec(string tuKhoa, string trangThai, string doUuTien)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                //sử dụng LEFT JOIN để lấy hết công việc, việc nào chưa phân công thì maNV sẽ bị NULL
                string sql = @"SELECT cv.maCV, cv.tenCV, cv.moTa, cv.thoiHan, cv.doUuTien, 
                              cv.trangThai, cv.ptramHoanThanh, cv.maDA, cv.nguoiTao, 
                              cv.ngayTao, cv.ngayCapNhat, pc.maNV 
                       FROM CongViec cv
                       LEFT JOIN PhanCong pc ON cv.maCV = pc.maCV
                       WHERE 1=1";

                //tìm kiếm nâng cao theo: Tên công việc, Mã công việc, hoặc Mã nhân viên được phân công
                if (!string.IsNullOrEmpty(tuKhoa))
                    sql += " AND (cv.tenCV LIKE @tuKhoa OR cv.maCV LIKE @tuKhoa OR pc.maNV LIKE @tuKhoa)";

                if (!string.IsNullOrEmpty(trangThai)) sql += " AND cv.trangThai = @tt";
                if (!string.IsNullOrEmpty(doUuTien)) sql += " AND cv.doUuTien = @du";

                SqlCommand cmd = new SqlCommand(sql, con);
                if (!string.IsNullOrEmpty(tuKhoa)) cmd.Parameters.AddWithValue("@tuKhoa", "%" + tuKhoa + "%");
                if (!string.IsNullOrEmpty(trangThai)) cmd.Parameters.AddWithValue("@tt", trangThai);
                if (!string.IsNullOrEmpty(doUuTien)) cmd.Parameters.AddWithValue("@du", doUuTien);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //thống kê số liệu và phần trăm
        public ThongkeDTO LaySoLieuThongKe(string maDA)
        {
            ThongkeDTO tk = new ThongkeDTO();
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = @"SELECT 
                    COUNT(*) as Tong,
                    SUM(CASE WHEN trangThai = N'Hoàn thành' THEN 1 ELSE 0 END) as HT,
                    SUM(CASE WHEN trangThai = N'Đang thực hiện' THEN 1 ELSE 0 END) as TH,
                    SUM(CASE WHEN trangThai = N'Chưa thực hiện' THEN 1 ELSE 0 END) as CT
                    FROM CongViec WHERE maDA = @mada";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mada", maDA);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tk.TongSoViec = dr["Tong"] != DBNull.Value ? Convert.ToInt32(dr["Tong"]) : 0;
                    tk.HoanThanh = dr["HT"] != DBNull.Value ? Convert.ToInt32(dr["HT"]) : 0;
                    tk.DangThucHien = dr["TH"] != DBNull.Value ? Convert.ToInt32(dr["TH"]) : 0;
                    tk.ChuaThucHien = dr["CT"] != DBNull.Value ? Convert.ToInt32(dr["CT"]) : 0;

                    if (tk.TongSoViec > 0)
                        tk.PhanTram = (double)tk.HoanThanh / tk.TongSoViec * 100;
                }
            }
            return tk;
        }
    }
}
