using System;
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
        public Admin_Teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_GiangVien gv = new frm_GiangVien();
            gv.TopLevel = false;
            panel1.Controls.Add(gv);
            gv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gv.Dock = DockStyle.Fill;
            gv.Show();

        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_SinhVien sv = new frm_SinhVien();
            sv.TopLevel = false;
            panel1.Controls.Add(sv);
            sv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sv.Dock = DockStyle.Fill;
            sv.Show();
        }
    }
}
