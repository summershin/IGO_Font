
namespace IGO_font
{
    partial class Register
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
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.dtp_Birth = new System.Windows.Forms.DateTimePicker();
            this.cbx_Gender = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Browses = new System.Windows.Forms.Button();
            this.pic_Photo = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_email.Location = new System.Drawing.Point(174, 231);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(161, 25);
            this.lb_email.TabIndex = 82;
            this.lb_email.Text = "*輸入格式不正確";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Phone.Location = new System.Drawing.Point(174, 9);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(161, 25);
            this.lb_Phone.TabIndex = 81;
            this.lb_Phone.Text = "*輸入格式不正確";
            // 
            // dtp_Birth
            // 
            this.dtp_Birth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_Birth.Location = new System.Drawing.Point(597, 168);
            this.dtp_Birth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Birth.Name = "dtp_Birth";
            this.dtp_Birth.Size = new System.Drawing.Size(204, 34);
            this.dtp_Birth.TabIndex = 80;
            this.dtp_Birth.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // cbx_Gender
            // 
            this.cbx_Gender.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_Gender.FormattingEnabled = true;
            this.cbx_Gender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbx_Gender.Location = new System.Drawing.Point(180, 172);
            this.cbx_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Gender.Name = "cbx_Gender";
            this.cbx_Gender.Size = new System.Drawing.Size(128, 41);
            this.cbx_Gender.TabIndex = 79;
            this.cbx_Gender.Text = "性別";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackgroundImage = global::Igo_Font.Properties.Resources.圖片401;
            this.btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancel.Location = new System.Drawing.Point(750, 339);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(129, 56);
            this.btn_Cancel.TabIndex = 77;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackgroundImage = global::Igo_Font.Properties.Resources.圖片401;
            this.btn_Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Register.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Register.Location = new System.Drawing.Point(750, 281);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(129, 52);
            this.btn_Register.TabIndex = 76;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Browses
            // 
            this.btn_Browses.BackColor = System.Drawing.Color.Transparent;
            this.btn_Browses.BackgroundImage = global::Igo_Font.Properties.Resources.圖片40;
            this.btn_Browses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Browses.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Browses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Browses.Location = new System.Drawing.Point(1002, 378);
            this.btn_Browses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Browses.Name = "btn_Browses";
            this.btn_Browses.Size = new System.Drawing.Size(177, 52);
            this.btn_Browses.TabIndex = 75;
            this.btn_Browses.Text = "Browse...";
            this.btn_Browses.UseVisualStyleBackColor = false;
            this.btn_Browses.Click += new System.EventHandler(this.btn_Browses_Click);
            // 
            // pic_Photo
            // 
            this.pic_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Photo.Location = new System.Drawing.Point(885, 49);
            this.pic_Photo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Photo.Name = "pic_Photo";
            this.pic_Photo.Size = new System.Drawing.Size(294, 323);
            this.pic_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Photo.TabIndex = 74;
            this.pic_Photo.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(878, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 35);
            this.label9.TabIndex = 73;
            this.label9.Text = "Photo: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(34, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 35);
            this.label8.TabIndex = 72;
            this.label8.Text = "Address: ";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Address.Location = new System.Drawing.Point(174, 333);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(507, 42);
            this.txt_Address.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(481, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 35);
            this.label7.TabIndex = 70;
            this.label7.Text = "Birth: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(45, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 35);
            this.label6.TabIndex = 69;
            this.label6.Text = "Gender: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(58, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 35);
            this.label5.TabIndex = 68;
            this.label5.Text = "E-mail: ";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Email.Location = new System.Drawing.Point(174, 271);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(507, 42);
            this.txt_Email.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(420, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 35);
            this.label4.TabIndex = 66;
            this.label4.Text = "First Name: ";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_FirstName.Location = new System.Drawing.Point(597, 101);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(204, 42);
            this.txt_FirstName.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 35);
            this.label3.TabIndex = 64;
            this.label3.Text = "Last Name:";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_LastName.Location = new System.Drawing.Point(180, 104);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(217, 42);
            this.txt_LastName.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(420, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 35);
            this.label2.TabIndex = 62;
            this.label2.Text = "Password: *";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Password.Location = new System.Drawing.Point(597, 39);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(204, 42);
            this.txt_Password.TabIndex = 61;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 35);
            this.label1.TabIndex = 60;
            this.label1.Text = "Phone: *";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Phone.Location = new System.Drawing.Point(180, 42);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(217, 42);
            this.txt_Phone.TabIndex = 59;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Igo_Font.Properties.Resources.圖片38;
            this.ClientSize = new System.Drawing.Size(1189, 492);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.dtp_Birth);
            this.Controls.Add(this.cbx_Gender);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Browses);
            this.Controls.Add(this.pic_Photo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Phone);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.ShowIcon = false;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.DateTimePicker dtp_Birth;
        private System.Windows.Forms.ComboBox cbx_Gender;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Browses;
        private System.Windows.Forms.PictureBox pic_Photo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Phone;
    }
}