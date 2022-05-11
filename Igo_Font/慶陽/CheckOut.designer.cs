
namespace IGO_font
{
    partial class CheckOut
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Order = new System.Windows.Forms.Button();
            this.cbx_PayType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Order
            // 
            this.btn_Order.Location = new System.Drawing.Point(1001, 371);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(81, 37);
            this.btn_Order.TabIndex = 1;
            this.btn_Order.Text = "結帳";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // cbx_PayType
            // 
            this.cbx_PayType.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_PayType.FormattingEnabled = true;
            this.cbx_PayType.Location = new System.Drawing.Point(878, 375);
            this.cbx_PayType.Name = "cbx_PayType";
            this.cbx_PayType.Size = new System.Drawing.Size(117, 28);
            this.cbx_PayType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(773, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "付款方式:";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(603, 371);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(124, 37);
            this.btn_Remove.TabIndex = 5;
            this.btn_Remove.Text = "移除一筆訂單";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(56, 471);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(1032, 107);
            this.dataGridView2.TabIndex = 8;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 600);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_PayType);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.ComboBox cbx_PayType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}