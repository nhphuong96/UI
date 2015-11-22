using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HH
{
    public class clsNV
    {
        private string _MSNV;

        public string MSNV
        {
            set { _MSNV = value; }
            get { return _MSNV; }
        }

        private string _HoTen;
        public string HoTen
        {
            set { _HoTen = value; }
            get { return _HoTen; }
        } 

        
        private string _TenDangNhap;
        public string TenDangNhap
        {
            set { _TenDangNhap = value; }
            get { return _TenDangNhap; }
        }
        private string _MatKhau;
        public string MatKhau
        {
            set { _MatKhau = value; }
            get { return _MatKhau; }
        }

        private string _GioiTinh;
        public string GioiTinh
        {
            set { _GioiTinh = value; }
            get { return _GioiTinh; }
        }
        private DateTime _NgaySinh;
        public DateTime NgaySinh
        {
            set { _NgaySinh = value; }
            get { return _NgaySinh; }
        }
        private string _ChucVu;
        public string ChucVu
        {
            set { _ChucVu = value; }
            get { return _ChucVu; }
        }
        private string _TrinhDo;
        public string TrinhDo
        {
            set { _TrinhDo = value; }
            get { return _TrinhDo; }
        }
        private string _Email;
        public string Email
        {
            set { _Email = value; }
            get { return _Email; }
        }
        private string _Tel;
        public string Tel
        {
            set { _Tel = value; }
            get { return _Tel; }
        }
        private string _ThongTinThem;
        public string ThongTinThem
        {
            set { _ThongTinThem = value; }
            get { return _ThongTinThem; }
        }

        public bool CheckLogin () // Hàm kiểm tra đăng nhập
        {
            bool check = false;

            // 1. Tạo đối tượng kết nối
            string strChuoiKetNoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=HH;Integrated Security=True";
            SqlConnection con = new SqlConnection(strChuoiKetNoi);
            // 2. Mở kết nối
            con.Open();
            // 3. Tạo đối tượng command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format(" Select COUNT(*) from THONGTINNV where TenDangNhap = '{0}' and MatKhau = '{1}' ", this.TenDangNhap, this.MatKhau);
            cmd.Connection = con;
            // 4. Thực thi cmd và sử lý kết quả
            int iRow = (int)cmd.ExecuteScalar();
            if(iRow !=0)
            {
                return check = true;
            }

            // 5. Đóng kết nối
            con.Close();

            return check;

        }

        public bool LayThongTin ( ) // lấy thông tin dựa trên tên đăng nhập
        {
            bool check = false;

            // 1. Tạo đối tượng kết nối
            string strChuoiKetNoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=HH;Integrated Security=True";
            SqlConnection con = new SqlConnection(strChuoiKetNoi);
            // 2. Mở kết nối
            con.Open();
            // 3. Tạo đối tượng command
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("select * from THONGTINNV Where TenDangNhap = '{0}'",this.TenDangNhap);
            cmd.Connection = con;
            // 4. Thực thi cmd và sử lý kết quả
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                if (!dr.IsDBNull(0))
                    this.MSNV = (string)dr["MSNV"];
                if (!dr.IsDBNull(1))
                    this.HoTen = (string)dr["HoTen"];
                if (!dr.IsDBNull(2))
                    this.TenDangNhap = (string)dr["TenDangNhap"];
                if (!dr.IsDBNull(3))
                    this.MatKhau = (string)dr["MatKhau"];
                if (!dr.IsDBNull(4))
                    this.GioiTinh = (string)dr["GioiTinh"];
                if (!dr.IsDBNull(5))
                    this.NgaySinh = (DateTime)dr["NgaySinh"];
                if (!dr.IsDBNull(6))
                    this.ChucVu = (string)dr["ChucVu"];
                if (!dr.IsDBNull(7))
                    this.TrinhDo = (string)dr["TrinhDo"];
                if (!dr.IsDBNull(8))
                    this.Email = (string)dr["Email"];
                if (!dr.IsDBNull(9))
                    this.Tel = (string)dr["Tel"];
                if (!dr.IsDBNull(10))
                    this.ThongTinThem = (string)dr["ThongTinThem"];
                check = true;
                dr.Close();
            }
            


            // 5. Đóng kết nối
            con.Close();

            return check;
        }

    }
}
