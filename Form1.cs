
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
    public partial class frmmain : Form
    {
        public static bool CheckThongTinUser = false;  // biến kiểm tra đảm bảo mỗi loại form chỉ đc mở khi loại form đó chưa được mở
        public static bool CheckQLBN = false;
        public static bool CheckQLP = false;
        public static bool CheckQLBS = false;
        public static bool CheckDanhMucThuoc = false;
        public static bool CheckKeDon = false;
        public static bool CheckThongTinPhanMem = false;
        public static bool CheckThongTinNhaPhatTrien = false;
        public static bool CheckCaiDat = false;


        
        
        
        public frmmain()
        {
            InitializeComponent();
        }

        private void mnuthongtinuser_Click(object sender, EventArgs e)
        {
            frmThongTinUser frmThongTinUser = new frmThongTinUser();
            if(CheckThongTinUser == false)
            { 
                
                frmThongTinUser.MdiParent = this;
                frmThongTinUser.Show();
                CheckThongTinUser = true;
            }

            frmThongTinUser.BringToFront(); // Object tạo sau thì nó sẽ nằm trên cái tạo trước

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("BẠN THỰC SỰ MUỐN THOÁT CHƯƠNG TRÌNH") == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void mnuQLBN_Click(object sender, EventArgs e)
        {
            frmQLBN frmQLBN = new frmQLBN();
            if(CheckQLBN == false)        //form QLBN chi mở khi chua co form quan ly benh nhan nao mở
            { 
                
                frmQLBN.MdiParent = this;
                frmQLBN.Show();
                CheckQLBN = true;
            }
            else
            {
                MessageBox.Show("Loại form này đã được mở, yêu cầu tắt form trước khi mở một form cũng loại");
            }
            frmQLBN.BringToFront(); // Object tạo sau thì nó sẽ nằm trên cái tạo trước
        }

        private void mnukedon_Click(object sender, EventArgs e)
        {
            frmKeDon frmKeDon = new frmKeDon();
            if(CheckKeDon == false)    //form KeDon chi mở khi chưa có form kê đơn nào mở
            { 
               
                frmKeDon.MdiParent = this;
                frmKeDon.Show();
                CheckKeDon = true;
            }
            else
            {
                MessageBox.Show("Loại form này đã được mở, yêu cầu tắt form trước khi mở một form cũng loại");
            }
            frmKeDon.BringToFront(); // Object tạo sau thì nó sẽ nằm trên cái tạo trước
        }

        private void mnuQLBS_Click(object sender, EventArgs e)
        {
            frmQLBS frmQLBS = new frmQLBS();
            if(CheckQLBS == false)
            { 
                frmQLBS.MdiParent = this;
                frmQLBS.Show();
                CheckQLBS = true;
            }
            else
            {
                MessageBox.Show("Loại form này đã được mở, yêu cầu tắt form trước khi mở một form cũng loại");
            }
            frmQLBS.BringToFront(); // Object tạo sau thì nó sẽ nằm trên cái tạo trước
        }

        private void dANHMỤCTHUỐCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMucThuoc frmDanhMucThuoc = new frmDanhMucThuoc();
            
            if(CheckDanhMucThuoc == false)
            { 
                frmDanhMucThuoc.MdiParent = this;
                frmDanhMucThuoc.Show();
                CheckDanhMucThuoc = true;
            }
            else
            {
                MessageBox.Show("Loại form này đã được mở, yêu cầu tắt form trước khi mở một form cũng loại");
            }
            frmDanhMucThuoc.BringToFront();

        }

        private void tHÔNGTINPHẦNMỀMToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmThongTinPhanMem frmThongTinPhanMem = new frmThongTinPhanMem();
            if (CheckThongTinPhanMem == false)
            { 
                frmThongTinPhanMem.MdiParent = this;
                frmThongTinPhanMem.Show();
                CheckThongTinPhanMem = true;
            }
            else
            {
                MessageBox.Show("Loại form này đã được mở, yêu cầu tắt form trước khi mở một form cũng loại");
            }
            frmThongTinPhanMem.BringToFront();
        }

        private void tHÔNGTINNHÀPHÁTTRIỂNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinNhaPhatTrien frmThongTinNhaPhatTrien = new frmThongTinNhaPhatTrien();
            if (CheckThongTinNhaPhatTrien == false)
            {
                frmThongTinNhaPhatTrien.MdiParent = this;
                frmThongTinNhaPhatTrien.Show();
                CheckThongTinNhaPhatTrien = true;
            }
            else
            {
                MessageBox.Show("Loại form này đã được mở, yêu cầu tắt form trước khi mở một form cũng loại");
            }
            frmThongTinNhaPhatTrien.BringToFront();
        }

        private void cÀIĐẶTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaiDat frmCaiDat = new frmCaiDat();
            if (CheckCaiDat == false)
            {
                frmCaiDat.MdiParent = this;
                frmCaiDat.Show();
                CheckCaiDat = true;

            }
            else
            {
                MessageBox.Show("Loại form này đã được mở, yêu cầu tắt form trước khi mở một form cũng loại");
            }
            frmCaiDat.BringToFront();
        }

        private void mnuQLP_Click(object sender, EventArgs e)
        {
            frmQLP frmQLP = new frmQLP();
            frmQLP.MdiParent = this;
            frmQLP.Show();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            // mở form đăng nhập
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.MdiParent = this;
            mnumain.Enabled = true;
            frmDangNhap.Show();

            // ẩn các chức năng
            mnumain.Enabled = false;



        }
        public void LoginSuccess()
        {
            mnumain.Enabled = true;
            MessageBox.Show("              ĐĂNG NHẬP THÀNH CÔNG ");
        }
        
    }
}
