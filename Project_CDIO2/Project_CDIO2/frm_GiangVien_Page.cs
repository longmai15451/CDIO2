using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Project_CDIO2
{
    public partial class frm_GiangVien_Page : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;
        public frm_GiangVien_Page()
        {
            InitializeComponent();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo info in cameras)
            {
                cb_cam.Items.Add(info.Name);
            }
            cb_cam.SelectedIndex = 0;
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_DiemDanh_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
            
        }
        private void btn_CaiDat_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
            }
        }
        private void frm_GiangVien_Page_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel_DiemDanh);
            listPanel.Add(panel_CaiDat);
            listPanel[index].BringToFront();

            
        }

        private void btn_turnOn_Click(object sender, EventArgs e)
        {
            //Neu cam dang bat hoac k co thi stop cam
            if(cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(cameras[cb_cam.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
        }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //tao anh Bitmap lay anh tu camera
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }

        private void frm_GiangVien_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cam.IsRunning == true)
            {
                cam.Stop(); 
            }
        }
    }
}
