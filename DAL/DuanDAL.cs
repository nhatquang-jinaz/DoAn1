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
    internal class DuanDAL
    {
        string conString = DbConnection.StrCon;

        public DataTable GetTable()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT maDA, tenDA, moTa, ngayBatDau, ngayKT, trangThai, maQuanLy FROM DuAn", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool KiemTraTrungMa(string maDA)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "SELECT COUNT(*) FROM DuAn WHERE maDA = @ma";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", maDA);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public bool Them(DuanDTO da)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "INSERT INTO DuAn(maDA, tenDA, moTa, ngayBatDau, ngayKT, trangThai, maQuanLy) VALUES(@ma, @ten, @mota, @nbd, @nkt, @tt, @mql)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", da.MaDA);
                cmd.Parameters.AddWithValue("@ten", da.TenDA);
                cmd.Parameters.AddWithValue("@mota", (object)da.MoTa ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@nbd", da.NgayBatDau);
                cmd.Parameters.AddWithValue("@nkt", da.NgayKT);
                cmd.Parameters.AddWithValue("@tt", da.TrangThai);
                cmd.Parameters.AddWithValue("@mql", da.MaQuanLy);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(DuanDTO da)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "UPDATE DuAn SET tenDA=@ten, moTa=@mota, ngayBatDau=@nbd, ngayKT=@nkt, trangThai=@tt, maQuanLy=@mql, ngayCapNhat=GETDATE() WHERE maDA=@ma";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", da.MaDA);
                cmd.Parameters.AddWithValue("@ten", da.TenDA);
                cmd.Parameters.AddWithValue("@mota", (object)da.MoTa ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@nbd", da.NgayBatDau);
                cmd.Parameters.AddWithValue("@nkt", da.NgayKT);
                cmd.Parameters.AddWithValue("@tt", da.TrangThai);
                cmd.Parameters.AddWithValue("@mql", da.MaQuanLy);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maDA)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {

                string sql = @"
                        DELETE FROM TienDo WHERE maCV IN (SELECT maCV FROM CongViec WHERE maDA = @ma);
                        DELETE FROM PhanCong WHERE maCV IN (SELECT maCV FROM CongViec WHERE maDA = @ma);
                        DELETE FROM CongViec WHERE maDA = @ma;
                        DELETE FROM DuAn WHERE maDA = @ma;";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", maDA);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public DataTable Tim(string maDA)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "SELECT maDA, tenDA, moTa, ngayBatDau, ngayKT, trangThai, maQuanLy FROM DuAn WHERE maDA LIKE @ma";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@ma", "%" + maDA + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
