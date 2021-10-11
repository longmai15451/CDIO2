using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Project_CDIO2
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
       
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string admin = "admin1";
            string pass = "123456";
            if (admin.Equals(txt_Username.Text) && pass.Equals(txt_Pass.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                Admin_Teacher ad = new Admin_Teacher();
                ad.Show();
            }
            string sqlDangNhap = "select count (*) from TaiKhoan where Username = '" + txt_Username.Text + "' and Pasword = '" + txt_Pass.Text + "'";
            int kq = (int)lopchung.login(sqlDangNhap);
            if (kq >= 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_GiangVien_Page main = new frm_GiangVien_Page();
                main.Show();
            }
            else
                MessageBox.Show("Đăng nhập thất bại");

            //string sqlDangNhap = "select count (*) from AFR where username = '" + txt_Username.Text + "' and password = '" + txt_Pass.Text + "'";
            //int kq = (int)lopchung.login(sqlDangNhap);
            //if (kq >= 1)
            //{
            //    MessageBox.Show("Đăng nhập thành công");
            //    Admin_Teacher main = new Admin_Teacher();
            //    main.Show();
            //}
            //else
            //    MessageBox.Show("Đăng nhập thất bại");
        }
    }
}
