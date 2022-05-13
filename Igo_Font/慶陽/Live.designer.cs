
namespace IGO_font
{
    partial class Live
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Live));
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_TicketType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_RoomType = new System.Windows.Forms.ComboBox();
            this.btn_BuyClear = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Minus = new System.Windows.Forms.TextBox();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_BuyTkNum = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.dgv_BuyList = new System.Windows.Forms.DataGridView();
            this.btn_AddBuyList = new System.Windows.Forms.Button();
            this.dgv_ProductList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Supplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_City = new System.Windows.Forms.ComboBox();
            this.btn_AllProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BuyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(53, 699);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "房型:";
            // 
            // cbx_TicketType
            // 
            this.cbx_TicketType.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_TicketType.FormattingEnabled = true;
            this.cbx_TicketType.Location = new System.Drawing.Point(120, 695);
            this.cbx_TicketType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_TicketType.Name = "cbx_TicketType";
            this.cbx_TicketType.Size = new System.Drawing.Size(106, 32);
            this.cbx_TicketType.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(331, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 26);
            this.label6.TabIndex = 41;
            this.label6.Text = "房間種類:";
            // 
            // cbx_RoomType
            // 
            this.cbx_RoomType.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_RoomType.FormattingEnabled = true;
            this.cbx_RoomType.Items.AddRange(new object[] {
            "精緻",
            "豪華",
            "尊爵",
            "總統"});
            this.cbx_RoomType.Location = new System.Drawing.Point(466, 85);
            this.cbx_RoomType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_RoomType.Name = "cbx_RoomType";
            this.cbx_RoomType.Size = new System.Drawing.Size(169, 35);
            this.cbx_RoomType.TabIndex = 40;
            // 
            // btn_BuyClear
            // 
            this.btn_BuyClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BuyClear.BackgroundImage")));
            this.btn_BuyClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_BuyClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_BuyClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_BuyClear.Location = new System.Drawing.Point(1175, 695);
            this.btn_BuyClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_BuyClear.Name = "btn_BuyClear";
            this.btn_BuyClear.Size = new System.Drawing.Size(119, 34);
            this.btn_BuyClear.TabIndex = 39;
            this.btn_BuyClear.Text = "清空購物清單";
            this.btn_BuyClear.UseVisualStyleBackColor = true;
            this.btn_BuyClear.Click += new System.EventHandler(this.BuyClear_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Remove.BackgroundImage")));
            this.btn_Remove.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Remove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Remove.Location = new System.Drawing.Point(958, 695);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(122, 34);
            this.btn_Remove.TabIndex = 38;
            this.btn_Remove.Text = "移除整筆訂單";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(599, 700);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "減少數量:";
            // 
            // txt_Minus
            // 
            this.txt_Minus.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Minus.Location = new System.Drawing.Point(712, 697);
            this.txt_Minus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Minus.Name = "txt_Minus";
            this.txt_Minus.Size = new System.Drawing.Size(71, 33);
            this.txt_Minus.TabIndex = 36;
            // 
            // btn_Minus
            // 
            this.btn_Minus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Minus.BackgroundImage")));
            this.btn_Minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Minus.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Minus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Minus.Location = new System.Drawing.Point(803, 696);
            this.btn_Minus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(100, 34);
            this.btn_Minus.TabIndex = 35;
            this.btn_Minus.Text = "減少數量";
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(230, 700);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "請輸入數量:";
            // 
            // txt_BuyTkNum
            // 
            this.txt_BuyTkNum.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_BuyTkNum.Location = new System.Drawing.Point(358, 695);
            this.txt_BuyTkNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_BuyTkNum.Name = "txt_BuyTkNum";
            this.txt_BuyTkNum.Size = new System.Drawing.Size(85, 33);
            this.txt_BuyTkNum.TabIndex = 33;
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = global::Igo_Font.Properties.Resources.圖片401;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Search.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Search.Location = new System.Drawing.Point(1319, 81);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(118, 37);
            this.btn_Search.TabIndex = 32;
            this.btn_Search.Text = "搜尋";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Order.BackgroundImage")));
            this.btn_Order.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Order.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Order.Location = new System.Drawing.Point(1319, 695);
            this.btn_Order.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(122, 34);
            this.btn_Order.TabIndex = 31;
            this.btn_Order.Text = "加入購物車";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // dgv_BuyList
            // 
            this.dgv_BuyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BuyList.Location = new System.Drawing.Point(750, 153);
            this.dgv_BuyList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_BuyList.Name = "dgv_BuyList";
            this.dgv_BuyList.RowHeadersWidth = 51;
            this.dgv_BuyList.RowTemplate.Height = 27;
            this.dgv_BuyList.Size = new System.Drawing.Size(691, 503);
            this.dgv_BuyList.TabIndex = 30;
            // 
            // btn_AddBuyList
            // 
            this.btn_AddBuyList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddBuyList.BackgroundImage")));
            this.btn_AddBuyList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AddBuyList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddBuyList.Location = new System.Drawing.Point(466, 695);
            this.btn_AddBuyList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddBuyList.Name = "btn_AddBuyList";
            this.btn_AddBuyList.Size = new System.Drawing.Size(117, 34);
            this.btn_AddBuyList.TabIndex = 29;
            this.btn_AddBuyList.Text = "加入購物清單";
            this.btn_AddBuyList.UseVisualStyleBackColor = true;
            this.btn_AddBuyList.Click += new System.EventHandler(this.btn_AddBuyList_Click);
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductList.Location = new System.Drawing.Point(24, 153);
            this.dgv_ProductList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.RowHeadersWidth = 51;
            this.dgv_ProductList.RowTemplate.Height = 27;
            this.dgv_ProductList.Size = new System.Drawing.Size(707, 503);
            this.dgv_ProductList.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(995, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "飯店:";
            // 
            // cbx_Supplier
            // 
            this.cbx_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Supplier.DropDownWidth = 200;
            this.cbx_Supplier.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_Supplier.FormattingEnabled = true;
            this.cbx_Supplier.Location = new System.Drawing.Point(1081, 87);
            this.cbx_Supplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_Supplier.Name = "cbx_Supplier";
            this.cbx_Supplier.Size = new System.Drawing.Size(192, 32);
            this.cbx_Supplier.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(745, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "縣市:";
            // 
            // cbx_City
            // 
            this.cbx_City.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_City.FormattingEnabled = true;
            this.cbx_City.Location = new System.Drawing.Point(831, 85);
            this.cbx_City.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_City.Name = "cbx_City";
            this.cbx_City.Size = new System.Drawing.Size(133, 34);
            this.cbx_City.TabIndex = 24;
            this.cbx_City.SelectedIndexChanged += new System.EventHandler(this.cbx_City_SelectedIndexChanged);
            // 
            // btn_AllProduct
            // 
            this.btn_AllProduct.BackgroundImage = global::Igo_Font.Properties.Resources.圖片401;
            this.btn_AllProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_AllProduct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_AllProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AllProduct.Location = new System.Drawing.Point(120, 77);
            this.btn_AllProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AllProduct.Name = "btn_AllProduct";
            this.btn_AllProduct.Size = new System.Drawing.Size(128, 46);
            this.btn_AllProduct.TabIndex = 23;
            this.btn_AllProduct.Text = "顯示所有飯店";
            this.btn_AllProduct.UseVisualStyleBackColor = true;
            this.btn_AllProduct.Click += new System.EventHandler(this.btn_AllProduct_Click);
            // 
            // Live
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Igo_Font.Properties.Resources.圖片38;
            this.ClientSize = new System.Drawing.Size(1484, 821);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_TicketType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_RoomType);
            this.Controls.Add(this.btn_BuyClear);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Minus);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_BuyTkNum);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.dgv_BuyList);
            this.Controls.Add(this.btn_AddBuyList);
            this.Controls.Add(this.dgv_ProductList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_Supplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_City);
            this.Controls.Add(this.btn_AllProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Live";
            this.Text = "Live";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BuyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_TicketType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_RoomType;
        private System.Windows.Forms.Button btn_BuyClear;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Minus;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_BuyTkNum;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.DataGridView dgv_BuyList;
        private System.Windows.Forms.Button btn_AddBuyList;
        private System.Windows.Forms.DataGridView dgv_ProductList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Supplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_City;
        private System.Windows.Forms.Button btn_AllProduct;
    }
}