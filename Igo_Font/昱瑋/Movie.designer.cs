
namespace IGO_font
{
    partial class Movie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DGV_Movie = new System.Windows.Forms.DataGridView();
            this.cmb_MovieAdress = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_ticket = new System.Windows.Forms.ComboBox();
            this.btn_seat = new System.Windows.Forms.Button();
            this.cmb_Movie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Count = new System.Windows.Forms.ComboBox();
            this.btn_time = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_shop = new System.Windows.Forms.Button();
            this.dgv_shoppingcar = new System.Windows.Forms.DataGridView();
            this.btn_delet = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_shop_car = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shoppingcar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(380, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "電影";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(60, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "日期區間";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 47);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 25);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(384, 47);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(178, 25);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // DGV_Movie
            // 
            this.DGV_Movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Movie.Location = new System.Drawing.Point(38, 76);
            this.DGV_Movie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_Movie.Name = "DGV_Movie";
            this.DGV_Movie.RowHeadersWidth = 62;
            this.DGV_Movie.RowTemplate.Height = 31;
            this.DGV_Movie.Size = new System.Drawing.Size(692, 122);
            this.DGV_Movie.TabIndex = 6;
            this.DGV_Movie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Movie_CellClick);
            this.DGV_Movie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmb_MovieAdress
            // 
            this.cmb_MovieAdress.FormattingEnabled = true;
            this.cmb_MovieAdress.Location = new System.Drawing.Point(65, 10);
            this.cmb_MovieAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_MovieAdress.Name = "cmb_MovieAdress";
            this.cmb_MovieAdress.Size = new System.Drawing.Size(271, 23);
            this.cmb_MovieAdress.TabIndex = 8;
            this.cmb_MovieAdress.Text = "請選擇影城";
            this.cmb_MovieAdress.SelectedIndexChanged += new System.EventHandler(this.cmb_MovieAdress_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(60, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "票種";
            // 
            // cmb_ticket
            // 
            this.cmb_ticket.FormattingEnabled = true;
            this.cmb_ticket.Items.AddRange(new object[] {
            "全票",
            "優待票"});
            this.cmb_ticket.Location = new System.Drawing.Point(116, 208);
            this.cmb_ticket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_ticket.Name = "cmb_ticket";
            this.cmb_ticket.Size = new System.Drawing.Size(132, 23);
            this.cmb_ticket.TabIndex = 10;
            this.cmb_ticket.Text = "請選擇票種";
            // 
            // btn_seat
            // 
            this.btn_seat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_seat.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_seat.Location = new System.Drawing.Point(485, 212);
            this.btn_seat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_seat.Name = "btn_seat";
            this.btn_seat.Size = new System.Drawing.Size(76, 30);
            this.btn_seat.TabIndex = 11;
            this.btn_seat.Text = "劃位";
            this.btn_seat.UseVisualStyleBackColor = false;
            this.btn_seat.Click += new System.EventHandler(this.btn_seat_Click);
            // 
            // cmb_Movie
            // 
            this.cmb_Movie.FormattingEnabled = true;
            this.cmb_Movie.Location = new System.Drawing.Point(449, 10);
            this.cmb_Movie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Movie.Name = "cmb_Movie";
            this.cmb_Movie.Size = new System.Drawing.Size(291, 23);
            this.cmb_Movie.TabIndex = 12;
            this.cmb_Movie.Text = "請選擇電影";
            this.cmb_Movie.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(284, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "數量";
            // 
            // cmb_Count
            // 
            this.cmb_Count.FormattingEnabled = true;
            this.cmb_Count.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_Count.Location = new System.Drawing.Point(340, 208);
            this.cmb_Count.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Count.Name = "cmb_Count";
            this.cmb_Count.Size = new System.Drawing.Size(108, 23);
            this.cmb_Count.TabIndex = 14;
            this.cmb_Count.Text = "請選擇數量";
            this.cmb_Count.SelectedIndexChanged += new System.EventHandler(this.cmb_Count_SelectedIndexChanged);
            // 
            // btn_time
            // 
            this.btn_time.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_time.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_time.Location = new System.Drawing.Point(603, 37);
            this.btn_time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(76, 38);
            this.btn_time.TabIndex = 15;
            this.btn_time.Text = "查詢";
            this.btn_time.UseVisualStyleBackColor = false;
            this.btn_time.Click += new System.EventHandler(this.btn_time_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(11, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "購物清單";
            // 
            // btn_shop
            // 
            this.btn_shop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_shop.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_shop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_shop.Location = new System.Drawing.Point(581, 212);
            this.btn_shop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_shop.Name = "btn_shop";
            this.btn_shop.Size = new System.Drawing.Size(158, 33);
            this.btn_shop.TabIndex = 18;
            this.btn_shop.Text = "加入購物清單";
            this.btn_shop.UseVisualStyleBackColor = false;
            this.btn_shop.Click += new System.EventHandler(this.btn_shop_Click);
            // 
            // dgv_shoppingcar
            // 
            this.dgv_shoppingcar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_shoppingcar.Location = new System.Drawing.Point(15, 286);
            this.dgv_shoppingcar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_shoppingcar.Name = "dgv_shoppingcar";
            this.dgv_shoppingcar.RowHeadersWidth = 62;
            this.dgv_shoppingcar.RowTemplate.Height = 31;
            this.dgv_shoppingcar.Size = new System.Drawing.Size(741, 107);
            this.dgv_shoppingcar.TabIndex = 19;
            // 
            // btn_delet
            // 
            this.btn_delet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_delet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delet.Location = new System.Drawing.Point(116, 252);
            this.btn_delet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(107, 28);
            this.btn_delet.TabIndex = 20;
            this.btn_delet.Text = "刪除該筆";
            this.btn_delet.UseVisualStyleBackColor = false;
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clear.Location = new System.Drawing.Point(228, 252);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 28);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "清除購物車";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_shop_car
            // 
            this.btn_shop_car.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_shop_car.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_shop_car.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_shop_car.Location = new System.Drawing.Point(340, 243);
            this.btn_shop_car.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_shop_car.Name = "btn_shop_car";
            this.btn_shop_car.Size = new System.Drawing.Size(132, 37);
            this.btn_shop_car.TabIndex = 22;
            this.btn_shop_car.Text = "加入購物車";
            this.btn_shop_car.UseVisualStyleBackColor = false;
            this.btn_shop_car.Click += new System.EventHandler(this.btn_shop_car_Click);
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 402);
            this.Controls.Add(this.btn_shop_car);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delet);
            this.Controls.Add(this.dgv_shoppingcar);
            this.Controls.Add(this.btn_shop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_time);
            this.Controls.Add(this.cmb_Count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Movie);
            this.Controls.Add(this.btn_seat);
            this.Controls.Add(this.cmb_ticket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_MovieAdress);
            this.Controls.Add(this.DGV_Movie);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Movie";
            this.Text = "Movie";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shoppingcar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView DGV_Movie;
        private System.Windows.Forms.ComboBox cmb_MovieAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_ticket;
        private System.Windows.Forms.Button btn_seat;
        private System.Windows.Forms.ComboBox cmb_Movie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Count;
        private System.Windows.Forms.Button btn_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_shop;
        private System.Windows.Forms.DataGridView dgv_shoppingcar;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_shop_car;
    }
}