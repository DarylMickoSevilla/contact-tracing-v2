using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace Healt_Declaration_Form
{
    public partial class CodeScanner : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public CodeScanner()
        {
            InitializeComponent();
        }

        private void CodeScanner_Load(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
