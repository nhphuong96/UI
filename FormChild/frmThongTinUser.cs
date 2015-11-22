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
    public partial class frmThongTinUser : Form
    {
        public frmThongTinUser()
        {
            InitializeComponent();
        }

        public static string HoTen = string.Empty;
        public static string TenDangNhap = string.Empty;
        public static string MatKhau = string.Empty;
        public static string GioiTinh = string.Empty;
        public static DateTime NgaySinh;
        public static string ChucVu = string.Empty;
        public static string TrinhDo = string.Empty;
        public static string Email = string.Empty;
        public static string Tel = string.Empty;
        public static string ThongTinThem = string.Empty;

        private void frmThongTinUser_Load(object sender, EventArgs e)
        {
            lblTenUser.Text = HoTen;
            txtTenTk.Text = TenDangNhap;
            txtMatKhau.Text = MatKhau;
            ltbGioiTinh.Text = GioiTinh;
            // dtpNgaySinh.Text = (string)NgaySinh;
            ltbTrinhDo.Text = TrinhDo;
            txtChucVu.Text = ChucVu;
            txtEmail.Text = Email;
            txttel.Text = Tel;
            txtThongTinThem.Text = ThongTinThem;
            
        }

        private void grbQLUser_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtẢnhĐạiDiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTenUser_Click(object sender, EventArgs e)
        {

        }

        private void Back_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
            frmmain frmmain = new frmmain();
            frmmain.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmmain.CheckThongTinUser = false;
            this.Close();
        }
    }
}
