
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movie));
            this.label6 = new System.Windows.Forms.Label();
            this.btn_shop_car = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delet = new System.Windows.Forms.Button();
            this.dgv_shoppingcar = new System.Windows.Forms.DataGridView();
            this.btn_shop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_time = new System.Windows.Forms.Button();
            this.cmb_Count = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Movie = new System.Windows.Forms.ComboBox();
            this.btn_seat = new System.Windows.Forms.Button();
            this.cmb_ticket = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_MovieAdress = new System.Windows.Forms.ComboBox();
            this.DGV_Movie = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shoppingcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movie)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(60, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 37);
            this.label6.TabIndex = 43;
            this.label6.Text = "影城";
            // 
            // btn_shop_car
            // 
            this.btn_shop_car.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_shop_car.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_shop_car.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_shop_car.Image = global::Igo_Font.Properties.Resources.圖片38;
            this.btn_shop_car.Location = new System.Drawing.Point(885, 483);
            this.btn_shop_car.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_shop_car.Name = "btn_shop_car";
            this.btn_shop_car.Size = new System.Drawing.Size(214, 47);
            this.btn_shop_car.TabIndex = 42;
            this.btn_shop_car.Text = "加入購物車";
            this.btn_shop_car.UseVisualStyleBackColor = false;
            this.btn_shop_car.Click += new System.EventHandler(this.btn_shop_car_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_clear.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_clear.Image = global::Igo_Font.Properties.Resources.圖片38;
            this.btn_clear.Location = new System.Drawing.Point(397, 493);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(140, 37);
            this.btn_clear.TabIndex = 41;
            this.btn_clear.Text = "清除購物車";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delet
            // 
            this.btn_delet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_delet.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_delet.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_delet.Image = global::Igo_Font.Properties.Resources.圖片38;
            this.btn_delet.Location = new System.Drawing.Point(211, 493);
            this.btn_delet.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(160, 37);
            this.btn_delet.TabIndex = 40;
            this.btn_delet.Text = "刪除該筆";
            this.btn_delet.UseVisualStyleBackColor = false;
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click);
            // 
            // dgv_shoppingcar
            // 
            this.dgv_shoppingcar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_shoppingcar.Location = new System.Drawing.Point(38, 541);
            this.dgv_shoppingcar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgv_shoppingcar.Name = "dgv_shoppingcar";
            this.dgv_shoppingcar.RowHeadersWidth = 62;
            this.dgv_shoppingcar.RowTemplate.Height = 31;
            this.dgv_shoppingcar.Size = new System.Drawing.Size(1079, 163);
            this.dgv_shoppingcar.TabIndex = 39;
            // 
            // btn_shop
            // 
            this.btn_shop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_shop.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_shop.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_shop.Image = global::Igo_Font.Properties.Resources.圖片38;
            this.btn_shop.Location = new System.Drawing.Point(862, 402);
            this.btn_shop.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_shop.Name = "btn_shop";
            this.btn_shop.Size = new System.Drawing.Size(237, 60);
            this.btn_shop.TabIndex = 38;
            this.btn_shop.Text = "加入購物清單";
            this.btn_shop.UseVisualStyleBackColor = false;
            this.btn_shop.Click += new System.EventHandler(this.btn_shop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Image = global::Igo_Font.Properties.Resources.圖片38;
            this.label5.Location = new System.Drawing.Point(48, 493);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 37);
            this.label5.TabIndex = 37;
            this.label5.Text = "購物清單";
            // 
            // btn_time
            // 
            this.btn_time.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_time.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_time.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_time.Image = global::Igo_Font.Properties.Resources.圖片38;
            this.btn_time.Location = new System.Drawing.Point(939, 144);
            this.btn_time.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(160, 47);
            this.btn_time.TabIndex = 36;
            this.btn_time.Text = "查詢";
            this.btn_time.UseVisualStyleBackColor = false;
            this.btn_time.Click += new System.EventHandler(this.btn_time_Click);
            // 
            // cmb_Count
            // 
            this.cmb_Count.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this.cmb_Count.Location = new System.Drawing.Point(505, 398);
            this.cmb_Count.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmb_Count.Name = "cmb_Count";
            this.cmb_Count.Size = new System.Drawing.Size(193, 39);
            this.cmb_Count.TabIndex = 35;
            this.cmb_Count.Text = "請選擇數量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Image = global::Igo_Font.Properties.Resources.圖片38;
            this.label4.Location = new System.Drawing.Point(416, 400);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 37);
            this.label4.TabIndex = 34;
            this.label4.Text = "數量";
            // 
            // cmb_Movie
            // 
            this.cmb_Movie.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_Movie.FormattingEnabled = true;
            this.cmb_Movie.Location = new System.Drawing.Point(493, 76);
            this.cmb_Movie.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmb_Movie.Name = "cmb_Movie";
            this.cmb_Movie.Size = new System.Drawing.Size(424, 39);
            this.cmb_Movie.TabIndex = 33;
            this.cmb_Movie.Text = "請選擇電影";
            // 
            // btn_seat
            // 
            this.btn_seat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_seat.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_seat.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_seat.Image = global::Igo_Font.Properties.Resources.圖片38;
            this.btn_seat.Location = new System.Drawing.Point(732, 410);
            this.btn_seat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_seat.Name = "btn_seat";
            this.btn_seat.Size = new System.Drawing.Size(109, 48);
            this.btn_seat.TabIndex = 32;
            this.btn_seat.Text = "劃位";
            this.btn_seat.UseVisualStyleBackColor = false;
            this.btn_seat.Click += new System.EventHandler(this.btn_seat_Click);
            // 
            // cmb_ticket
            // 
            this.cmb_ticket.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_ticket.FormattingEnabled = true;
            this.cmb_ticket.Items.AddRange(new object[] {
            "全票",
            "優待票"});
            this.cmb_ticket.Location = new System.Drawing.Point(179, 398);
            this.cmb_ticket.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmb_ticket.Name = "cmb_ticket";
            this.cmb_ticket.Size = new System.Drawing.Size(175, 39);
            this.cmb_ticket.TabIndex = 31;
            this.cmb_ticket.Text = "請選擇票種";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Image = global::Igo_Font.Properties.Resources.圖片38;
            this.label3.Location = new System.Drawing.Point(60, 400);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 37);
            this.label3.TabIndex = 30;
            this.label3.Text = "票種";
            // 
            // cmb_MovieAdress
            // 
            this.cmb_MovieAdress.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_MovieAdress.FormattingEnabled = true;
            this.cmb_MovieAdress.Location = new System.Drawing.Point(150, 76);
            this.cmb_MovieAdress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cmb_MovieAdress.Name = "cmb_MovieAdress";
            this.cmb_MovieAdress.Size = new System.Drawing.Size(204, 39);
            this.cmb_MovieAdress.TabIndex = 29;
            this.cmb_MovieAdress.Text = "請選擇影城";
            this.cmb_MovieAdress.SelectedIndexChanged += new System.EventHandler(this.cmb_MovieAdress_SelectedIndexChanged);
            // 
            // DGV_Movie
            // 
            this.DGV_Movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Movie.Location = new System.Drawing.Point(38, 205);
            this.DGV_Movie.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.DGV_Movie.Name = "DGV_Movie";
            this.DGV_Movie.RowHeadersWidth = 62;
            this.DGV_Movie.RowTemplate.Height = 31;
            this.DGV_Movie.Size = new System.Drawing.Size(1079, 167);
            this.DGV_Movie.TabIndex = 28;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker2.Location = new System.Drawing.Point(493, 148);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(205, 39);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 148);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 39);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Image = global::Igo_Font.Properties.Resources.圖片38;
            this.label2.Location = new System.Drawing.Point(51, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 37);
            this.label2.TabIndex = 25;
            this.label2.Text = "日期區間";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(405, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "電影";
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 801);
            this.Controls.Add(this.label6);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Movie";
            this.Text = "Movie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shoppingcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_shop_car;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delet;
        private System.Windows.Forms.DataGridView dgv_shoppingcar;
        private System.Windows.Forms.Button btn_shop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_time;
        private System.Windows.Forms.ComboBox cmb_Count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Movie;
        private System.Windows.Forms.Button btn_seat;
        private System.Windows.Forms.ComboBox cmb_ticket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_MovieAdress;
        private System.Windows.Forms.DataGridView DGV_Movie;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}