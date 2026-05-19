using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DoAn1.DTO;
using System.Data;

namespace DoAn1.DAL
{
    public class CongviecDAL
    {
        string conString = DbConnection.StrCon;

        //lấy full công việc khi không chọn dự án
        public DataTable GetAll()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = @"SELECT cv.*, pc.maNV 
                       FROM CongViec cv 
                       LEFT JOIN PhanCong pc ON cv.maCV = pc.maCV 
                       ORDER BY cv.ngayTao DESC";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTableByDuAn(string maDA)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = @"SELECT cv.*, pc.maNV
                       FROM CongViec cv 
                       LEFT JOIN PhanCong pc ON cv.maCV = pc.maCV 
                       WHERE cv.maDA = @ma";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@ma", maDA);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool KiemTraTrungMa(string maCV)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "SELECT COUNT(*) FROM CongViec WHERE maCV = @ma";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", maCV);
                con.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool Them(CongviecDTO cv)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "INSERT INTO CongViec(maCV, tenCV, moTa, thoiHan, doUuTien, trangThai, ptramHoanThanh, maDA, nguoiTao, ngayTao, ngayCapNhat) " +
                             "VALUES(@ma, @ten, @mt, @th, @du, @tt, @ptram, @mada, @nt, GETDATE(), GETDATE())";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", cv.MaCV);
                cmd.Parameters.AddWithValue("@ten", cv.TenCV);
                cmd.Parameters.AddWithValue("@mt", cv.MoTa);
                cmd.Parameters.AddWithValue("@th", cv.ThoiHan);
                cmd.Parameters.AddWithValue("@du", cv.DoUuTien);
                cmd.Parameters.AddWithValue("@tt", cv.TrangThai);
                cmd.Parameters.AddWithValue("@ptram", cv.PTramHoanThanh);
                cmd.Parameters.AddWithValue("@mada", cv.MaDA);
                cmd.Parameters.AddWithValue("@nt", cv.NguoiTao);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(CongviecDTO cv)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = @"UPDATE CongViec SET 
                       tenCV = @ten, 
                       moTa = @mt, 
                       thoiHan = @th, 
                       doUuTien = @du, 
                       trangThai = @tt, 
                       ptramHoanThanh = @ptram, 
                       maDA = @mada, 
                       nguoiTao = @nt, 
                       ngayTao = GETDATE(),
                       ngayCapNhat = GETDATE() 
                       WHERE maCV = @ma";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", cv.MaCV);
                cmd.Parameters.AddWithValue("@ten", cv.TenCV);
                cmd.Parameters.AddWithValue("@mt", cv.MoTa);
                cmd.Parameters.AddWithValue("@th", cv.ThoiHan);
                cmd.Parameters.AddWithValue("@du", cv.DoUuTien);
                cmd.Parameters.AddWithValue("@tt", cv.TrangThai);
                cmd.Parameters.AddWithValue("@ptram", cv.PTramHoanThanh);
                cmd.Parameters.AddWithValue("@mada", cv.MaDA);
                cmd.Parameters.AddWithValue("@nt", cv.NguoiTao);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maCV)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "DELETE FROM CongViec WHERE maCV=@ma";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", maCV);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable TimKiem(string maCV)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = @"SELECT cv.*, pc.maNV 
                       FROM CongViec cv 
                       LEFT JOIN PhanCong pc ON cv.maCV = pc.maCV 
                       WHERE cv.maCV = @ma";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", maCV);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetNhanVienDePhanCong()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "SELECT maND, hoTen FROM NguoiDung WHERE vaiTro = N'Nhân viên'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool PhanCongNV(string maCV, string maNV)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "INSERT INTO PhanCong(maCV, maNV) VALUES(@macv, @manv)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@macv", maCV);
                cmd.Parameters.AddWithValue("@manv", maNV);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
