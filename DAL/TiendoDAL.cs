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
    public class TiendoDAL
    {
        string conString = DbConnection.StrCon;

        //lấy lịch sử cập nhật (Grid to bên dưới)
        public DataTable LayLichSu()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = @"SELECT t.maTD, t.maCV, c.tenCV, c.thoiHan, c.trangThai, 
                              t.ptramHoanThanh, t.ghiChu, t.nguoiCapNhat, t.ngayCapNhat 
                       FROM TienDo t 
                       INNER JOIN CongViec c ON t.maCV = c.maCV 
                       ORDER BY t.ngayCapNhat DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        //lấy danh sách công việc của 1 dự án
        public DataTable LayCongViecTheoDuAn(string maDA)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = @"SELECT t.maTD, t.maCV, c.tenCV, c.thoiHan, c.trangThai, 
                                  t.ptramHoanThanh, t.ghiChu, t.nguoiCapNhat, t.ngayCapNhat 
                           FROM TienDo t 
                           INNER JOIN CongViec c ON t.maCV = c.maCV 
                           WHERE c.maDA = @maDA
                           ORDER BY t.ngayCapNhat DESC";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maDA", maDA);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool CapnhatTienDo(TiendoDTO td)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                try
                {
                    //chèn vào bảng lịch sử TienDo
                    string sqlHistory = "INSERT INTO TienDo(maTD, maCV, ptramHoanThanh, ghiChu, nguoiCapNhat, ngayCapNhat) VALUES(@ma, @macv, @pt, @gc, @nguoi, GETDATE())";
                    SqlCommand cmd1 = new SqlCommand(sqlHistory, con, trans);
                    cmd1.Parameters.AddWithValue("@ma", td.MaTienDo);
                    cmd1.Parameters.AddWithValue("@macv", td.MaCongViec);
                    cmd1.Parameters.AddWithValue("@pt", td.PhanTramHoanThanh);
                    cmd1.Parameters.AddWithValue("@gc", td.GhiChu);
                    cmd1.Parameters.AddWithValue("@nguoi", td.NguoiCapNhat);
                    cmd1.ExecuteNonQuery();

                    //cập nhật bên bảng CongViec
                    string trangThai = (td.PhanTramHoanThanh == 100) ? "Hoàn thành" : "Đang thực hiện";
                    string sqlUpdateCV = "UPDATE CongViec SET trangThai = @tt, ptramHoanThanh = @ptram WHERE maCV = @macv";

                    SqlCommand cmd2 = new SqlCommand(sqlUpdateCV, con, trans);
                    cmd2.Parameters.AddWithValue("@tt", trangThai);
                    cmd2.Parameters.AddWithValue("@ptram", td.PhanTramHoanThanh); 
                    cmd2.Parameters.AddWithValue("@macv", td.MaCongViec);
                    cmd2.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    return false;
                }
            }
        }
        public bool XoaTiendo(string maTD)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "DELETE FROM TienDo WHERE maTD = @ma";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", maTD);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
