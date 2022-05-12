﻿
namespace IGO
{
    partial class OrderAndComment
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
            this.Gb_Button = new System.Windows.Forms.GroupBox();
            this.Rb_Month = new System.Windows.Forms.RadioButton();
            this.Rb_3Month = new System.Windows.Forms.RadioButton();
            this.Rb_CreditOrder = new System.Windows.Forms.RadioButton();
            this.Rb_Cancel = new System.Windows.Forms.RadioButton();
            this.Rb_All = new System.Windows.Forms.RadioButton();
            this.Gb_AfterQuery = new System.Windows.Forms.GroupBox();
            this.DGV_OrderDetail = new System.Windows.Forms.DataGridView();
            this.Tb_Comment = new System.Windows.Forms.TextBox();
            this.Lb_CommentProduct = new System.Windows.Forms.Label();
            this.Cb_Star = new System.Windows.Forms.ComboBox();
            this.Lb_5Star = new System.Windows.Forms.Label();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_Product = new System.Windows.Forms.ComboBox();
            this.Gb_Button.SuspendLayout();
            this.Gb_AfterQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb_Button
            // 
            this.Gb_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Gb_Button.Controls.Add(this.Rb_Month);
            this.Gb_Button.Controls.Add(this.Rb_3Month);
            this.Gb_Button.Controls.Add(this.Rb_CreditOrder);
            this.Gb_Button.Controls.Add(this.Rb_Cancel);
            this.Gb_Button.Controls.Add(this.Rb_All);
            this.Gb_Button.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gb_Button.Location = new System.Drawing.Point(68, 23);
            this.Gb_Button.Name = "Gb_Button";
            this.Gb_Button.Size = new System.Drawing.Size(954, 74);
            this.Gb_Button.TabIndex = 1;
            this.Gb_Button.TabStop = false;
            this.Gb_Button.Text = "訂單查詢";
            // 
            // Rb_Month
            // 
            this.Rb_Month.AutoSize = true;
            this.Rb_Month.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Rb_Month.Location = new System.Drawing.Point(172, 36);
            this.Rb_Month.Name = "Rb_Month";
            this.Rb_Month.Size = new System.Drawing.Size(120, 23);
            this.Rb_Month.TabIndex = 3;
            this.Rb_Month.TabStop = true;
            this.Rb_Month.Text = "一個月內訂單";
            this.Rb_Month.UseVisualStyleBackColor = true;
            this.Rb_Month.CheckedChanged += new System.EventHandler(this.Rb_Month_CheckedChanged);
            // 
            // Rb_3Month
            // 
            this.Rb_3Month.AutoSize = true;
            this.Rb_3Month.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Rb_3Month.Location = new System.Drawing.Point(611, 36);
            this.Rb_3Month.Name = "Rb_3Month";
            this.Rb_3Month.Size = new System.Drawing.Size(120, 23);
            this.Rb_3Month.TabIndex = 2;
            this.Rb_3Month.TabStop = true;
            this.Rb_3Month.Text = "三個月內訂單";
            this.Rb_3Month.UseVisualStyleBackColor = true;
            this.Rb_3Month.CheckedChanged += new System.EventHandler(this.Rb_6Month_CheckedChanged);
            // 
            // Rb_CreditOrder
            // 
            this.Rb_CreditOrder.AutoSize = true;
            this.Rb_CreditOrder.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Rb_CreditOrder.Location = new System.Drawing.Point(476, 36);
            this.Rb_CreditOrder.Name = "Rb_CreditOrder";
            this.Rb_CreditOrder.Size = new System.Drawing.Size(120, 23);
            this.Rb_CreditOrder.TabIndex = 2;
            this.Rb_CreditOrder.TabStop = true;
            this.Rb_CreditOrder.Text = "銀行轉帳訂單";
            this.Rb_CreditOrder.UseVisualStyleBackColor = true;
            this.Rb_CreditOrder.CheckedChanged += new System.EventHandler(this.Rb_CreditOrder_CheckedChanged);
            // 
            // Rb_Cancel
            // 
            this.Rb_Cancel.AutoSize = true;
            this.Rb_Cancel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Rb_Cancel.Location = new System.Drawing.Point(335, 36);
            this.Rb_Cancel.Name = "Rb_Cancel";
            this.Rb_Cancel.Size = new System.Drawing.Size(105, 23);
            this.Rb_Cancel.TabIndex = 1;
            this.Rb_Cancel.TabStop = true;
            this.Rb_Cancel.Text = "已取消訂單";
            this.Rb_Cancel.UseVisualStyleBackColor = true;
            this.Rb_Cancel.CheckedChanged += new System.EventHandler(this.Rb_Cancel_CheckedChanged);
            // 
            // Rb_All
            // 
            this.Rb_All.AutoSize = true;
            this.Rb_All.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Rb_All.Location = new System.Drawing.Point(46, 36);
            this.Rb_All.Name = "Rb_All";
            this.Rb_All.Size = new System.Drawing.Size(90, 23);
            this.Rb_All.TabIndex = 0;
            this.Rb_All.TabStop = true;
            this.Rb_All.Text = "全部訂單";
            this.Rb_All.UseVisualStyleBackColor = true;
            this.Rb_All.CheckedChanged += new System.EventHandler(this.Rb_All_CheckedChanged);
            // 
            // Gb_AfterQuery
            // 
            this.Gb_AfterQuery.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Gb_AfterQuery.Controls.Add(this.DGV_OrderDetail);
            this.Gb_AfterQuery.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gb_AfterQuery.ForeColor = System.Drawing.Color.Black;
            this.Gb_AfterQuery.Location = new System.Drawing.Point(68, 117);
            this.Gb_AfterQuery.Name = "Gb_AfterQuery";
            this.Gb_AfterQuery.Size = new System.Drawing.Size(954, 282);
            this.Gb_AfterQuery.TabIndex = 2;
            this.Gb_AfterQuery.TabStop = false;
            this.Gb_AfterQuery.Text = "訂單查詢結果";
            // 
            // DGV_OrderDetail
            // 
            this.DGV_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_OrderDetail.Location = new System.Drawing.Point(19, 26);
            this.DGV_OrderDetail.Name = "DGV_OrderDetail";
            this.DGV_OrderDetail.RowHeadersWidth = 51;
            this.DGV_OrderDetail.RowTemplate.Height = 27;
            this.DGV_OrderDetail.Size = new System.Drawing.Size(918, 232);
            this.DGV_OrderDetail.TabIndex = 0;
            // 
            // Tb_Comment
            // 
            this.Tb_Comment.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Tb_Comment.ForeColor = System.Drawing.Color.Black;
            this.Tb_Comment.Location = new System.Drawing.Point(68, 467);
            this.Tb_Comment.Multiline = true;
            this.Tb_Comment.Name = "Tb_Comment";
            this.Tb_Comment.Size = new System.Drawing.Size(969, 111);
            this.Tb_Comment.TabIndex = 3;
            // 
            // Lb_CommentProduct
            // 
            this.Lb_CommentProduct.AutoSize = true;
            this.Lb_CommentProduct.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_CommentProduct.ForeColor = System.Drawing.Color.Black;
            this.Lb_CommentProduct.Location = new System.Drawing.Point(74, 408);
            this.Lb_CommentProduct.Name = "Lb_CommentProduct";
            this.Lb_CommentProduct.Size = new System.Drawing.Size(43, 19);
            this.Lb_CommentProduct.TabIndex = 5;
            this.Lb_CommentProduct.Text = "產品:";
            // 
            // Cb_Star
            // 
            this.Cb_Star.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cb_Star.ForeColor = System.Drawing.Color.Black;
            this.Cb_Star.FormattingEnabled = true;
            this.Cb_Star.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.Cb_Star.Location = new System.Drawing.Point(583, 405);
            this.Cb_Star.Name = "Cb_Star";
            this.Cb_Star.Size = new System.Drawing.Size(133, 27);
            this.Cb_Star.TabIndex = 7;
            // 
            // Lb_5Star
            // 
            this.Lb_5Star.AutoSize = true;
            this.Lb_5Star.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb_5Star.ForeColor = System.Drawing.Color.Black;
            this.Lb_5Star.Location = new System.Drawing.Point(474, 413);
            this.Lb_5Star.Name = "Lb_5Star";
            this.Lb_5Star.Size = new System.Drawing.Size(103, 19);
            this.Lb_5Star.TabIndex = 8;
            this.Lb_5Star.Text = "產品評分輸入:";
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Submit.Location = new System.Drawing.Point(896, 422);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(126, 34);
            this.Btn_Submit.TabIndex = 9;
            this.Btn_Submit.Text = "提交";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "產品評論輸入:(限250字)";
            // 
            // Cb_Product
            // 
            this.Cb_Product.FormattingEnabled = true;
            this.Cb_Product.Location = new System.Drawing.Point(192, 404);
            this.Cb_Product.Name = "Cb_Product";
            this.Cb_Product.Size = new System.Drawing.Size(175, 23);
            this.Cb_Product.TabIndex = 12;
            // 
            // OrderAndComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1140, 643);
            this.Controls.Add(this.Cb_Product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Lb_5Star);
            this.Controls.Add(this.Cb_Star);
            this.Controls.Add(this.Lb_CommentProduct);
            this.Controls.Add(this.Tb_Comment);
            this.Controls.Add(this.Gb_AfterQuery);
            this.Controls.Add(this.Gb_Button);
            this.Name = "OrderAndComment";
            this.Text = "OrderAndComment";
            this.Load += new System.EventHandler(this.OrderAndComment_Load);
            this.Gb_Button.ResumeLayout(false);
            this.Gb_Button.PerformLayout();
            this.Gb_AfterQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Gb_Button;
        private System.Windows.Forms.GroupBox Gb_AfterQuery;
        private System.Windows.Forms.TextBox Tb_Comment;
        private System.Windows.Forms.Label Lb_CommentProduct;
        private System.Windows.Forms.ComboBox Cb_Star;
        private System.Windows.Forms.Label Lb_5Star;
        private System.Windows.Forms.RadioButton Rb_3Month;
        private System.Windows.Forms.RadioButton Rb_CreditOrder;
        private System.Windows.Forms.RadioButton Rb_Cancel;
        private System.Windows.Forms.RadioButton Rb_All;
        private System.Windows.Forms.DataGridView DGV_OrderDetail;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rb_Month;
        private System.Windows.Forms.ComboBox Cb_Product;
    }
}