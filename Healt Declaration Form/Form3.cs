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

namespace Healt_Declaration_Form
{
    public partial class OpenFile : Form
    {
        public OpenFile()
        {
            InitializeComponent();
        }

        private void OpenFilebtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog Read = new OpenFileDialog();

            if (Read.ShowDialog() == DialogResult.OK)
            {
                DisplayBox.Text = File.ReadAllText(Read.FileName);
            }
        }
    }
}
