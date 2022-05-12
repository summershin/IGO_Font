using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGO_font
{
    
    public partial class MovieSeat : Form
    {
        protected int limit;
        protected List<Model> checkBoxes;
        public List<string> CheckedSeats;
        public MovieSeat(int limit, List<string> lockedSeats)
        {
            InitializeComponent();
            this.limit = limit;
            this.checkBoxes = new List<Model>();
            this.checkBoxes.Add(new Model("A1", this.chkA1));
            this.checkBoxes.Add(new Model("A2", this.chkA2));
            this.checkBoxes.Add(new Model("A3", this.chkA3));
            this.checkBoxes.Add(new Model("A4", this.chkA4));
            this.checkBoxes.Add(new Model("A5", this.chkA5));
            this.checkBoxes.Add(new Model("A6", this.chkA6));
            this.checkBoxes.Add(new Model("A7", this.chkA7));
            this.checkBoxes.Add(new Model("A8", this.chkA8));
            this.checkBoxes.Add(new Model("A9", this.chkA9));
            this.checkBoxes.Add(new Model("A10", this.chkA10));
            this.checkBoxes.Add(new Model("A11", this.chkA11));
            this.checkBoxes.Add(new Model("A12", this.chkA12));
            this.checkBoxes.Add(new Model("A13", this.chkA13));
            this.checkBoxes.Add(new Model("A14", this.chkA14));
            this.checkBoxes.Add(new Model("A15", this.chkA15));
            this.checkBoxes.Add(new Model("A16", this.chkA16));
            this.checkBoxes.Add(new Model("A17", this.chkA17));
            this.checkBoxes.Add(new Model("A18", this.chkA18));
            this.checkBoxes.Add(new Model("A19", this.chkA19));
            this.checkBoxes.Add(new Model("A20", this.chkA20));
            this.checkBoxes.Add(new Model("A21", this.chkA21));
            this.checkBoxes.Add(new Model("A22", this.chkA22));
            this.checkBoxes.Add(new Model("A23", this.chkA23));
            this.checkBoxes.Add(new Model("A24", this.chkA24));
            this.checkBoxes.Add(new Model("A25", this.chkA25));

            foreach (var name in lockedSeats)
            {
                Model model = this.checkBoxes.Find(x => x.Name == name);
                model.Locked = true;
                model.Chk.Checked = true;
                model.Chk.Enabled = false;
            }
        }

        private void chkA_CheckedChanged(object sender, EventArgs e)
        {
            int checkedCount = this.checkBoxes.Count(x => !x.Locked && x.Chk.Checked);

            if (checkedCount >= limit)
            {
                foreach (CheckBox checkBox in this.checkBoxes.Where(x => !x.Chk.Checked).Select(x => x.Chk))
                {
                    checkBox.Enabled = false;
                }
            }
            else 
            {
                foreach (CheckBox checkBox in this.checkBoxes.Where(x => !x.Locked).Select(x => x.Chk))
                {
                    checkBox.Enabled = true;
                }
            }
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            this.CheckedSeats = this.checkBoxes.Where(x => !x.Locked && x.Chk.Checked).Select(x => x.Name).ToList();

            int diff = this.limit - this.CheckedSeats.Count;
            if (diff > 0)
            {
                MessageBox.Show("還有" + diff + "個座位沒有劃位。", "系統訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        protected class Model
        {
            public Model(string name, CheckBox chk)
            {
                Name = name;
                Chk = chk;
            }
            public string Name { get; set; }

            public CheckBox Chk { get; set; }

            public bool Locked { get; set; }
        }
    }
}


    




