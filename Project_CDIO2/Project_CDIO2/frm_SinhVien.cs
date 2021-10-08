using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Data.SqlClient;

namespace Project_CDIO2
{
    public partial class frm_SinhVien : Form
    {
        Capture grabber; 
        Image<Bgr, byte> currentFrame;
        Image<Gray, byte> gray, result, result2, result3, result4, TrainedFace = null, TrainedEyes = null, TrainedMouth = null, TrainedNose = null;

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

       

        public frm_SinhVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {

        }
    }
}
