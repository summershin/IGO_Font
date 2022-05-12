using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Web.Security;
using Igo_Font;
using IGO_font.慶陽;
using IGO_font;

namespace 期中專題
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        IGOEntities IgoContext = new IGOEntities();
        private void btn_IgoLogin_Click(object sender, EventArgs e)
        {

            string AccountID = txt_Phone.Text;
            string Password = txt_password.Text;

            //string passwod = txt_password.Text;
            //  passwod=FormsAuthentication.HashPasswordForStoringInConfigFile(passwod, "SHA1");

            bool q = IgoContext.Customers.AsQueryable().Any(c => c.Phone == txt_Phone.Text && c.Password == txt_password.Text);
            bool q2 = IgoContext.Customers.AsQueryable().Any(c => c.Phone == txt_Phone.Text && c.Password != txt_password.Text);


            if (q)
                {
                    {
                        MessageBox.Show("登入成功","溫腥小提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     var q1 = IgoContext.Customers.AsEnumerable().Where(c => c.Phone == txt_Phone.Text).Select(c => new { c.CustumerID,c.FirstName}).FirstOrDefault();
                    txt_CusName_hide.Text = q1.FirstName;


                    this.Text = $" Dear{txt_CusName_hide.Text}歡迎使用IGO";
                    MessageBox.Show($"Dear {txt_CusName_hide.Text} 歡迎使用IGO");

                    customer.customerID = q1.CustumerID;
                    customer.Name = q1.FirstName;
                    HomePage homepage = new HomePage();
                    //Frm_Login Login = new Frm_Login();
                    this.Visible = false;
                    
                    homepage.ShowDialog();
                    this.Close();
                    
                    
                }
                }
           
                else if (txt_Phone == null)
                {
                    MessageBox.Show
                    ("登入失敗，請輸入帳號密碼！", "溫腥小提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                else if (txt_password == null)
                {
                    MessageBox.Show("請輸入密碼", "登入失敗 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("帳號或密碼輸入錯誤", "登入失敗 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        private void btn_IgoRegister_Click(object sender, EventArgs e)
        {

            Register register = new Register();
            register.ShowDialog();
        }
    }
        
    }
 

