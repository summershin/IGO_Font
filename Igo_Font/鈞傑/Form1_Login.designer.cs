
namespace 期中專題
{
    partial class Frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_IgoLgoin = new System.Windows.Forms.Label();
            this.lbl_IgoPW = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_IgoLogin = new System.Windows.Forms.Button();
            this.btn_IgoRegister = new System.Windows.Forms.Button();
            this.txt_CusName_hide = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_IgoLgoin
            // 
            this.lbl_IgoLgoin.AutoSize = true;
            this.lbl_IgoLgoin.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_IgoLgoin.Location = new System.Drawing.Point(130, 28);
            this.lbl_IgoLgoin.Name = "lbl_IgoLgoin";
            this.lbl_IgoLgoin.Size = new System.Drawing.Size(237, 37);
            this.lbl_IgoLgoin.TabIndex = 0;
            this.lbl_IgoLgoin.Text = "IGO 會員登入";
            // 
            // lbl_IgoPW
            // 
            this.lbl_IgoPW.AutoSize = true;
            this.lbl_IgoPW.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_IgoPW.Location = new System.Drawing.Point(111, 145);
            this.lbl_IgoPW.Name = "lbl_IgoPW";
            this.lbl_IgoPW.Size = new System.Drawing.Size(71, 29);
            this.lbl_IgoPW.TabIndex = 1;
            this.lbl_IgoPW.Text = "密碼";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Phone.Location = new System.Drawing.Point(10, 90);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(214, 29);
            this.lbl_Phone.TabIndex = 2;
            this.lbl_Phone.Text = "登錄帳號/ Phone";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Phone.Location = new System.Drawing.Point(239, 90);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(208, 36);
            this.txt_Phone.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_password.Location = new System.Drawing.Point(239, 138);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(208, 36);
            this.txt_password.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.lbl_Phone);
            this.panel1.Controls.Add(this.txt_Phone);
            this.panel1.Controls.Add(this.lbl_IgoPW);
            this.panel1.Controls.Add(this.lbl_IgoLgoin);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 215);
            this.panel1.TabIndex = 0;
            // 
            // btn_IgoLogin
            // 
            this.btn_IgoLogin.Location = new System.Drawing.Point(128, 245);
            this.btn_IgoLogin.Name = "btn_IgoLogin";
            this.btn_IgoLogin.Size = new System.Drawing.Size(175, 59);
            this.btn_IgoLogin.TabIndex = 1;
            this.btn_IgoLogin.Text = "登入";
            this.btn_IgoLogin.UseVisualStyleBackColor = true;
            this.btn_IgoLogin.Click += new System.EventHandler(this.btn_IgoLogin_Click);
            // 
            // btn_IgoRegister
            // 
            this.btn_IgoRegister.Location = new System.Drawing.Point(318, 245);
            this.btn_IgoRegister.Name = "btn_IgoRegister";
            this.btn_IgoRegister.Size = new System.Drawing.Size(175, 59);
            this.btn_IgoRegister.TabIndex = 2;
            this.btn_IgoRegister.Text = "註冊帳號";
            this.btn_IgoRegister.UseVisualStyleBackColor = true;
            this.btn_IgoRegister.Click += new System.EventHandler(this.btn_IgoRegister_Click);
            // 
            // txt_CusName_hide
            // 
            this.txt_CusName_hide.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_CusName_hide.Location = new System.Drawing.Point(330, 383);
            this.txt_CusName_hide.Name = "txt_CusName_hide";
            this.txt_CusName_hide.Size = new System.Drawing.Size(208, 36);
            this.txt_CusName_hide.TabIndex = 5;
            // 
            // Frm1_Login_Front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 313);
            this.Controls.Add(this.txt_CusName_hide);
            this.Controls.Add(this.btn_IgoRegister);
            this.Controls.Add(this.btn_IgoLogin);
            this.Controls.Add(this.panel1);
            this.Name = "Frm1_Login_Front";
            this.Text = "登入IGO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IgoLgoin;
        private System.Windows.Forms.Label lbl_IgoPW;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_IgoLogin;
        private System.Windows.Forms.Button btn_IgoRegister;
        private System.Windows.Forms.TextBox txt_CusName_hide;
    }
}