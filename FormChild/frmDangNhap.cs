

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HH
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            clsNV clsNV = new clsNV();
            clsNV.TenDangNhap = txtTenDangNhap.Text;
            clsNV.MatKhau = txtMK.Text;
            if (KiemTraDangNhap(txtTenDangNhap.Text, txtMK.Text,clsNV) == true)
            {
                clsNV.LayThongTin();
                frmThongTinUser.HoTen = clsNV.HoTen;
                frmThongTinUser.TenDangNhap = clsNV.TenDangNhap;
                frmThongTinUser.MatKhau = clsNV.MatKhau;
                frmThongTinUser.GioiTinh = clsNV.GioiTinh;
                frmThongTinUser.NgaySinh = clsNV.NgaySinh;
                frmThongTinUser.TrinhDo = clsNV.TrinhDo;
                frmThongTinUser.ChucVu = clsNV.ChucVu;
                frmThongTinUser.Email = clsNV.Email;
                frmThongTinUser.Tel = clsNV.Tel;
                frmThongTinUser.ThongTinThem = clsNV.ThongTinThem;

                ((frmmain)this.ParentForm).LoginSuccess();
                this.Close();
            }
            else
            {
                MessageBox.Show("TÊN ĐĂNG NHẬP HOẶC MẬT KHẨU KHÔNG CHÍNH XÁC");
            }
            
        }

        private bool KiemTraDangNhap(string p1, string p2, clsNV clsNV)
        {

            
            if(clsNV.CheckLogin()==true)
            {
                return true;
            }
            return false;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
