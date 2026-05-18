using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn1.DTO;
using DoAn1.DAL;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace DoAn1.BUS
{
    internal class DuanBUS
    {
        DuanDAL dal = new DuanDAL();

        public DataTable LayDanhSach() => dal.GetTable();

        //kiểm tra dữ liệu chung
        private string Validate(DuanDTO da, bool isUpdate = false)
        {
            
            string patternDA = @"^DA\d{2}$";
            if (!Regex.IsMatch(da.MaDA.ToUpper(), patternDA))
            {
                return "Mã dự án phải đúng định dạng DAXX (Ví dụ: DA01, DA99)!";
            }
            if (string.IsNullOrWhiteSpace(da.MaDA)) return "Mã dự án không được trống.";
            if (string.IsNullOrWhiteSpace(da.TenDA)) return "Tên dự án không được trống.";
            if (da.NgayBatDau > da.NgayKT) return "Ngày bắt đầu không được sau ngày kết thúc.";
            if (da.NgayBatDau.Date < DateTime.Today)
            {
                return "Ngày bắt đầu không được nhỏ hơn ngày hiện tại!";
            }
            if (string.IsNullOrWhiteSpace(da.MaQuanLy)) return "Mã quản lý không được trống.";
            if (!isUpdate && dal.KiemTraTrungMa(da.MaDA))
            {
                return "Mã dự án đã tồn tại.";
            }
            return null; //không có lỗi
        }

        public string Them(DuanDTO da)
        {
            string error = Validate(da, false);
            if (error != null) return error;

            try
            {
                return dal.Them(da) ? "SUCCESS" : "Thêm thất bại.";
            }
            catch (Exception)
            {
                return "Lỗi: Mã dự án đã tồn tại hoặc Mã quản lý không đúng!";
            }
        }

        public string Sua(DuanDTO da)
        {
            string error = Validate(da, true);
            if (error != null) return error;

            return dal.Sua(da) ? "SUCCESS" : "Không tìm thấy dự án để sửa.";
        }

        public string Xoa(string maDA)
        {
            if (string.IsNullOrWhiteSpace(maDA)) return "Vui lòng chọn mã dự án cần xóa.";
            return dal.Xoa(maDA) ? "SUCCESS" : "Xóa thất bại.";
        }
        public DataTable Tim(string maDA, out string error)
        {
            error = null;
            //thông báo nếu để trống
            if (string.IsNullOrWhiteSpace(maDA))
            {
                error = "Vui lòng nhập mã dự án cần tìm";
                return null;
            }

            DataTable dt = dal.Tim(maDA);

            //truy vấn không có kết quả, trả về bảng trống
            return dt;
        }
    }
}
