using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGO_font.慶陽
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {

        }

        private void btn_Live_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            Live f = new Live();
            f.MdiParent = this;
            f.Parent = this.splitContainer2.Panel2;
            f.Show();
        }
    }
}
