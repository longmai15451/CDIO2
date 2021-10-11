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
        List<Panel> listPanel = new List<Panel>();
        int index;
        public Admin_Teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frm_GiangVien gv = new frm_GiangVien();
            //gv.TopLevel = false;
            //panel_Admin1.Controls.Add(gv);
            //gv.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //gv.Dock = DockStyle.Fill;
            //gv.Show();
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

        private void Admin_Teacher_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel_Admin1);
            listPanel.Add(panel_Admin2);
            listPanel[index].BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
