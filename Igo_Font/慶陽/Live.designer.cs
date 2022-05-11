
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
            this.btn_AllProduct = new System.Windows.Forms.Button();
            this.cbx_City = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Supplier = new System.Windows.Forms.ComboBox();
            this.dgv_ProductList = new System.Windows.Forms.DataGridView();
            this.btn_AddBuyList = new System.Windows.Forms.Button();
            this.dgv_BuyList = new System.Windows.Forms.DataGridView();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_BuyTkNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Minus = new System.Windows.Forms.TextBox();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_BuyClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_RoomType = new System.Windows.Forms.ComboBox();
            this.cbx_TicketType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BuyList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AllProduct
            // 
            this.btn_AllProduct.Location = new System.Drawing.Point(71, 43);
            this.btn_AllProduct.Name = "btn_AllProduct";
            this.btn_AllProduct.Size = new System.Drawing.Size(119, 42);
            this.btn_AllProduct.TabIndex = 0;
            this.btn_AllProduct.Text = "顯示所有飯店";
            this.btn_AllProduct.UseVisualStyleBackColor = true;
            this.btn_AllProduct.Click += new System.EventHandler(this.btn_AllProduct_Click);
            // 
            // cbx_City
            // 
            this.cbx_City.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_City.FormattingEnabled = true;
            this.cbx_City.Location = new System.Drawing.Point(610, 50);
            this.cbx_City.Name = "cbx_City";
            this.cbx_City.Size = new System.Drawing.Size(112, 28);
            this.cbx_City.TabIndex = 1;
            this.cbx_City.SelectedIndexChanged += new System.EventHandler(this.cbx_City_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(545, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "縣市:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(802, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "飯店:";
            // 
            // cbx_Supplier
            // 
            this.cbx_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Supplier.DropDownWidth = 200;
            this.cbx_Supplier.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_Supplier.FormattingEnabled = true;
            this.cbx_Supplier.Location = new System.Drawing.Point(867, 50);
            this.cbx_Supplier.Name = "cbx_Supplier";
            this.cbx_Supplier.Size = new System.Drawing.Size(160, 28);
            this.cbx_Supplier.TabIndex = 3;
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductList.Location = new System.Drawing.Point(57, 136);
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.RowHeadersWidth = 51;
            this.dgv_ProductList.RowTemplate.Height = 27;
            this.dgv_ProductList.Size = new System.Drawing.Size(568, 385);
            this.dgv_ProductList.TabIndex = 7;
            // 
            // btn_AddBuyList
            // 
            this.btn_AddBuyList.Location = new System.Drawing.Point(505, 545);
            this.btn_AddBuyList.Name = "btn_AddBuyList";
            this.btn_AddBuyList.Size = new System.Drawing.Size(119, 42);
            this.btn_AddBuyList.TabIndex = 8;
            this.btn_AddBuyList.Text = "加入購物車";
            this.btn_AddBuyList.UseVisualStyleBackColor = true;
            this.btn_AddBuyList.Click += new System.EventHandler(this.btn_AddBuyList_Click);
            // 
            // dgv_BuyList
            // 
            this.dgv_BuyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BuyList.Location = new System.Drawing.Point(693, 136);
            this.dgv_BuyList.Name = "dgv_BuyList";
            this.dgv_BuyList.RowHeadersWidth = 51;
            this.dgv_BuyList.RowTemplate.Height = 27;
            this.dgv_BuyList.Size = new System.Drawing.Size(568, 385);
            this.dgv_BuyList.TabIndex = 9;
            // 
            // btn_Order
            // 
            this.btn_Order.Location = new System.Drawing.Point(1127, 545);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(119, 42);
            this.btn_Order.TabIndex = 10;
            this.btn_Order.Text = "加入購物車";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(1088, 43);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(119, 42);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "搜尋";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_BuyTkNum
            // 
            this.txt_BuyTkNum.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_BuyTkNum.Location = new System.Drawing.Point(400, 552);
            this.txt_BuyTkNum.Name = "txt_BuyTkNum";
            this.txt_BuyTkNum.Size = new System.Drawing.Size(81, 31);
            this.txt_BuyTkNum.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(275, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "請輸入數量:";
            // 
            // txt_Minus
            // 
            this.txt_Minus.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Minus.Location = new System.Drawing.Point(780, 552);
            this.txt_Minus.Name = "txt_Minus";
            this.txt_Minus.Size = new System.Drawing.Size(81, 31);
            this.txt_Minus.TabIndex = 15;
            // 
            // btn_Minus
            // 
            this.btn_Minus.Location = new System.Drawing.Point(867, 545);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(96, 42);
            this.btn_Minus.TabIndex = 14;
            this.btn_Minus.Text = "減少數量";
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(675, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "減少數量:";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(973, 545);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(138, 42);
            this.btn_Remove.TabIndex = 17;
            this.btn_Remove.Text = "移除整筆訂單";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_BuyClear
            // 
            this.btn_BuyClear.Location = new System.Drawing.Point(973, 593);
            this.btn_BuyClear.Name = "btn_BuyClear";
            this.btn_BuyClear.Size = new System.Drawing.Size(138, 42);
            this.btn_BuyClear.TabIndex = 18;
            this.btn_BuyClear.Text = "清空購物清單";
            this.btn_BuyClear.UseVisualStyleBackColor = true;
            this.btn_BuyClear.Click += new System.EventHandler(this.BuyClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(249, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "房間種類:";
            // 
            // cbx_RoomType
            // 
            this.cbx_RoomType.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_RoomType.FormattingEnabled = true;
            this.cbx_RoomType.Items.AddRange(new object[] {
            "精緻",
            "豪華",
            "尊爵",
            "總統"});
            this.cbx_RoomType.Location = new System.Drawing.Point(363, 50);
            this.cbx_RoomType.Name = "cbx_RoomType";
            this.cbx_RoomType.Size = new System.Drawing.Size(112, 28);
            this.cbx_RoomType.TabIndex = 19;
            // 
            // cbx_TicketType
            // 
            this.cbx_TicketType.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_TicketType.FormattingEnabled = true;
            this.cbx_TicketType.Location = new System.Drawing.Point(144, 552);
            this.cbx_TicketType.Name = "cbx_TicketType";
            this.cbx_TicketType.Size = new System.Drawing.Size(111, 28);
            this.cbx_TicketType.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(79, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "房型:";
            // 
            // Live
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 672);
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
            this.Name = "Live";
            this.Text = "Live";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BuyList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AllProduct;
        private System.Windows.Forms.ComboBox cbx_City;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Supplier;
        private System.Windows.Forms.DataGridView dgv_ProductList;
        private System.Windows.Forms.Button btn_AddBuyList;
        private System.Windows.Forms.DataGridView dgv_BuyList;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_BuyTkNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Minus;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_BuyClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_RoomType;
        private System.Windows.Forms.ComboBox cbx_TicketType;
        private System.Windows.Forms.Label label3;
    }
}