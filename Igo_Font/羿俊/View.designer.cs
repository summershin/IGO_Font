
namespace IGO_font
{
    partial class View
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_FullPrice = new System.Windows.Forms.TextBox();
            this.txt_HalfPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_City = new System.Windows.Forms.ComboBox();
            this.Check_Date = new System.Windows.Forms.CheckBox();
            this.Check_City = new System.Windows.Forms.CheckBox();
            this.btn_EnterCart = new System.Windows.Forms.Button();
            this.btn_AddCart = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "縣市:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(400, 172);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(189, 74);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(86, 27);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "查詢";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(61, 48);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "日期:";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(413, 231);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(90, 31);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "加入購物清單";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 319);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(399, 148);
            this.dataGridView2.TabIndex = 7;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(413, 319);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(90, 31);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "刪除這一筆";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(413, 364);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(90, 31);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "清除購物清單";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "全票:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "優待票:";
            // 
            // txt_FullPrice
            // 
            this.txt_FullPrice.Location = new System.Drawing.Point(461, 160);
            this.txt_FullPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_FullPrice.Name = "txt_FullPrice";
            this.txt_FullPrice.Size = new System.Drawing.Size(76, 22);
            this.txt_FullPrice.TabIndex = 12;
            this.txt_FullPrice.Text = "請輸入數量";
            // 
            // txt_HalfPrice
            // 
            this.txt_HalfPrice.Location = new System.Drawing.Point(461, 199);
            this.txt_HalfPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HalfPrice.Name = "txt_HalfPrice";
            this.txt_HalfPrice.Size = new System.Drawing.Size(76, 22);
            this.txt_HalfPrice.TabIndex = 13;
            this.txt_HalfPrice.Text = "請輸入數量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "張";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "張";
            // 
            // cmb_City
            // 
            this.cmb_City.FormattingEnabled = true;
            this.cmb_City.Location = new System.Drawing.Point(61, 23);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.Size = new System.Drawing.Size(121, 20);
            this.cmb_City.TabIndex = 17;
            // 
            // Check_Date
            // 
            this.Check_Date.AutoSize = true;
            this.Check_Date.Location = new System.Drawing.Point(100, 87);
            this.Check_Date.Name = "Check_Date";
            this.Check_Date.Size = new System.Drawing.Size(84, 16);
            this.Check_Date.TabIndex = 18;
            this.Check_Date.Text = "依日期查詢";
            this.Check_Date.UseVisualStyleBackColor = true;
            // 
            // Check_City
            // 
            this.Check_City.AutoSize = true;
            this.Check_City.Location = new System.Drawing.Point(10, 87);
            this.Check_City.Name = "Check_City";
            this.Check_City.Size = new System.Drawing.Size(72, 16);
            this.Check_City.TabIndex = 19;
            this.Check_City.Text = "縣市查詢";
            this.Check_City.UseVisualStyleBackColor = true;
            // 
            // btn_EnterCart
            // 
            this.btn_EnterCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EnterCart.Location = new System.Drawing.Point(413, 435);
            this.btn_EnterCart.Name = "btn_EnterCart";
            this.btn_EnterCart.Size = new System.Drawing.Size(90, 30);
            this.btn_EnterCart.TabIndex = 20;
            this.btn_EnterCart.Text = "進入購物車";
            this.btn_EnterCart.UseVisualStyleBackColor = true;
            this.btn_EnterCart.Click += new System.EventHandler(this.btn_EnterCart_Click);
            // 
            // btn_AddCart
            // 
            this.btn_AddCart.Location = new System.Drawing.Point(413, 399);
            this.btn_AddCart.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddCart.Name = "btn_AddCart";
            this.btn_AddCart.Size = new System.Drawing.Size(90, 31);
            this.btn_AddCart.TabIndex = 21;
            this.btn_AddCart.Text = "加入購物車";
            this.btn_AddCart.UseVisualStyleBackColor = true;
            this.btn_AddCart.Click += new System.EventHandler(this.btn_AddCart_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(703, 434);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(90, 31);
            this.btn_Exit.TabIndex = 22;
            this.btn_Exit.Text = "離開頁面";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.Location = new System.Drawing.Point(279, 74);
            this.btn_ShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(88, 27);
            this.btn_ShowAll.TabIndex = 23;
            this.btn_ShowAll.Text = "顯示所有行程";
            this.btn_ShowAll.UseVisualStyleBackColor = true;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 477);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_AddCart);
            this.Controls.Add(this.btn_EnterCart);
            this.Controls.Add(this.Check_City);
            this.Controls.Add(this.Check_Date);
            this.Controls.Add(this.cmb_City);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_HalfPrice);
            this.Controls.Add(this.txt_FullPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "View";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_FullPrice;
        private System.Windows.Forms.TextBox txt_HalfPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_City;
        private System.Windows.Forms.CheckBox Check_Date;
        private System.Windows.Forms.CheckBox Check_City;
        private System.Windows.Forms.Button btn_EnterCart;
        private System.Windows.Forms.Button btn_AddCart;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_ShowAll;
    }
}

