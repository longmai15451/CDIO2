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
    public partial class frm_GiangVien_Page : Form
    {
        public frm_GiangVien_Page()
        {
            InitializeComponent();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_GiangVien_Click(object sender, EventArgs e)
        {
            frm_DiemDanh dd = new frm_DiemDanh();
            dd.TopLevel = false;
            panel1.Controls.Add(dd);
            dd.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dd.Dock = DockStyle.Fill;
            dd.Show();
        }
    }
}
