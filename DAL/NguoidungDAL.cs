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
    public class NguoidungDAL
    {
        string conString = DbConnection.StrCon;

        public NguoidungDTO KiemTraDangNhap(string user, string pass)
        {
            NguoidungDTO result = null;
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                string sql = "SELECT tenDN, vaiTro FROM NguoiDung WHERE tenDN = @u AND matKhau = @p";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);

                sqlCon.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = new NguoidungDTO
                    {
                        TenDN = reader["tenDN"].ToString(),
                        VaiTro = reader["vaiTro"].ToString()
                    };
                }
            }
            return result; //trả về null nếu không tìm thấy
        }
        public DataTable GetTable()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT maND, hoTen, tenDN, matKhau, email, SDT, vaiTro, phongBan, chucVu FROM NguoiDung", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool KiemTraTrungMa(string maND)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "SELECT COUNT(*) FROM NguoiDung WHERE maND = @ma";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", maND);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public bool Them(NguoidungDTO nd)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "INSERT INTO NguoiDung(maND, hoTen, tenDN, matKhau, email, SDT, vaiTro, phongBan, chucVu) " +
                             "VALUES(@ma, @ten, @tendn, @mk, @email, @sdt, @vaitro, @pb, @cv)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", nd.MaND);
                cmd.Parameters.AddWithValue("@ten", nd.HoTen);
                cmd.Parameters.AddWithValue("@tendn", nd.TenDN);
                cmd.Parameters.AddWithValue("@mk", nd.MatKhau);
                cmd.Parameters.AddWithValue("@email", (object)nd.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@sdt", (object)nd.SDT ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@vaitro", nd.VaiTro);
                cmd.Parameters.AddWithValue("@pb", (object)nd.PhongBan ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@cv", (object)nd.ChucVu ?? DBNull.Value);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Sua(NguoidungDTO nd)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "UPDATE NguoiDung SET hoTen=@ten, tenDN=@tendn, matKhau=@mk, email=@email, " +
                             "SDT=@sdt, vaiTro=@vaitro, phongBan=@pb, chucVu=@cv WHERE maND=@ma";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ma", nd.MaND);
                cmd.Parameters.AddWithValue("@ten", nd.HoTen);
                cmd.Parameters.AddWithValue("@tendn", nd.TenDN);
                cmd.Parameters.AddWithValue("@mk", nd.MatKhau);
                cmd.Parameters.AddWithValue("@email", (object)nd.Email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@sdt", (object)nd.SDT ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@vaitro", nd.VaiTro);
                cmd.Parameters.AddWithValue("@pb", (object)nd.PhongBan ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@cv", (object)nd.ChucVu ?? DBNull.Value);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Xoa(string maND)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM NguoiDung WHERE maND=@ma", con);
                cmd.Parameters.AddWithValue("@ma", maND);
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable Tim(string maND)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string sql = "SELECT * FROM NguoiDung WHERE maND LIKE @ma";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@ma", "%" + maND + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
