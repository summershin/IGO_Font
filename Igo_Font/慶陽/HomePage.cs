using IGO;
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

            label1.Text = "使用者: " + customer.Name;
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            View f = new View();
            f.MdiParent = this;
            f.Parent = this.splitContainer2.Panel2;
            f.Show();
        }

        private void btn_Live_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            Live f = new Live();
            f.MdiParent = this;
            f.Parent = this.splitContainer2.Panel2;
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Movie_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            Movie f = new Movie();
            f.MdiParent = this;
            f.Parent = this.splitContainer2.Panel2;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            CheckOut f = new CheckOut();
            f.MdiParent = this;
            f.Parent = this.splitContainer2.Panel2;
            f.Show();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            OrderAndComment f = new OrderAndComment();
            f.MdiParent = this;
            f.Parent = this.splitContainer2.Panel2;
            f.Show();
        }
    }
}
