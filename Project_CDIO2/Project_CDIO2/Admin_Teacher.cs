﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CDIO2
{
    public partial class Admin_Teacher : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public Admin_Teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
            }
            
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }
        public void LoadGV()
        {
            string sqlGV = "select g.MaGiangVien, g.TenGiangVien, g.GioiTinh, g.Khoa, t.Username, t.Pasword from GiangVien g, TaiKhoan t where g.MaGiangVien = t.MaGiangVien";
            dataGridViewGV.DataSource = lopchung.LoadDL(sqlGV);
        }
        private void Admin_Teacher_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel_Admin1);
            listPanel.Add(panel_Admin2);
            listPanel[index].BringToFront();
            LoadGV();

        }

        private void btn_AddGV_Click(object sender, EventArgs e)
        {
            int loai = 1;
            string sqlThemGV = "insert into GiangVien values('"+txt_MaGiangVien.Text+"',N'"+txt_TenGV.Text+"', '"+cbo_GioiTinh.SelectedValue+"', '"+cb_Khoa.SelectedValue+"')";
            string sqlThemGV2 = "insert into TaiKhoan values('"+txt_usename.Text+"','"+txt_Pass.Text+"', '"+cbo_GioiTinh.SelectedValue+"', '"+txt_MaGiangVien.Text+"')";
            int kq1 = (int)lopchung.themXoaSua(sqlThemGV);
            int kq2 = (int)lopchung.themXoaSua(sqlThemGV2);
            if(kq1 >=1 && kq2 >= 1)
            {
                MessageBox.Show("Thêm giảng viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            txt_MaGiangVien.Text = "";
            txt_TenGV.Text = "";
            txt_usename.Text = "";
            txt_Pass.Text = "";
            LoadGV();
        }

        private void dataGridViewGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaGiangVien.Text = dataGridViewGV.CurrentRow.Cells["MaGiangVien"].Value.ToString();
            txt_TenGV.Text = dataGridViewGV.CurrentRow.Cells["TenGiangVien"].Value.ToString();
            txt_usename.Text = dataGridViewGV.CurrentRow.Cells["Username"].Value.ToString();
            txt_Pass.Text = dataGridViewGV.CurrentRow.Cells["Pasword"].Value.ToString();
            cb_Khoa.Text = dataGridViewGV.CurrentRow.Cells["Khoa"].Value.ToString();
            cbo_GioiTinh.Text = dataGridViewGV.CurrentRow.Cells["GioiTinh"].Value.ToString();
        }

        private void btn_DelGV_Click(object sender, EventArgs e)
        {
            string sqlXoa = "delete from GiangVien where MaGiangVien = '"+txt_MaGiangVien.Text+"'";
            string sqlXoa2 = "delete from TaiKhoan where Username = '" + txt_usename.Text + "'";
            int kq1 = (int)lopchung.themXoaSua(sqlXoa2);
            int kq2 = (int)lopchung.themXoaSua(sqlXoa);
            if(kq1 >=1 && kq2 >= 1)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            LoadGV();
        }
    }
}
