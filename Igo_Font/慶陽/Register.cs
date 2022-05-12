using Igo_Font;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace IGO_font
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }
        IGOEntities dbcontext = new IGOEntities();


        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_Phone.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("*為必填欄位!");
                return;
            }
            if(lb_Phone.ForeColor == Color.Red||lb_email.ForeColor == Color.Red)
            {
                MessageBox.Show("資料格式不正確!");
                return;
            }

            var q2 = dbcontext.Customers.Where(n => n.Phone == txt_Phone.Text);
            if (q2.ToList().Count != 0)
            {
                MessageBox.Show("此號碼已有使用者!");
                return;
            }

            if(dtp_Birth.Value > DateTime.Now)
            {
                MessageBox.Show("無效日期");
                return;
            }
           
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if(pic_Photo.Image == null)
            {
                pic_Photo.Image = pic_Photo.ErrorImage;
            }
            pic_Photo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] byt = (byte[])ms.GetBuffer();

            string password = txt_Password.Text;
            password = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");

            var insert = new Customer
            {

                Phone = txt_Phone.Text,
                Password = password,
                LastName = txt_LastName.Text ,
                FirstName = txt_FirstName.Text ,
                Gender = cbx_Gender.Text,
                Birth = dtp_Birth.Value.Date,
                Email = txt_Email.Text ,
                Address = txt_Address.Text ,
                Photo = byt

            };
                dbcontext.Customers.Add(insert);
                dbcontext.SaveChanges();

            MessageBox.Show("註冊成功!\n跳轉回登入介面!");
            this.Close();
        }

        private void btn_Browses_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_Photo.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            int a = 0;
            if (!int.TryParse(txt_Phone.Text, out a))
            {
                lb_Phone.Text = "*輸入格式不正確!";
                lb_Phone.ForeColor = Color.Red;
                return;
            }
            if (!txt_Phone.Text.StartsWith("09"))
            {
                lb_Phone.Text = "*輸入格式不正確!";
                lb_Phone.ForeColor = Color.Red;
                return;
            }
            if (txt_Phone.Text.Length != 10)
            {
                lb_Phone.Text = "*輸入格式不正確!";
                lb_Phone.ForeColor = Color.Red;
                return;
            }
            else
            {
            lb_Phone.Text = "*格式正確!";
            lb_Phone.ForeColor = Color.Green;
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (txt_Email.Text.Contains("@") && txt_Email.Text.Contains(".com"))
            {
                lb_email.Text = "*格式正確!";
                lb_email.ForeColor = Color.Green;
            }
            else
            {
                lb_email.Text = "**輸入格式不正確!!";
                lb_email.ForeColor = Color.Red;
                return;
            }
        }

      
    }
}
