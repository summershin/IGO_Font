
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.cmb_Payment = new System.Windows.Forms.ComboBox();
            this.btn_Leave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(510, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(428, 368);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 37);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "刪除此筆訂單";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(595, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(510, 328);
            this.dataGridView2.TabIndex = 2;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Price.Location = new System.Drawing.Point(822, 370);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(97, 35);
            this.lbl_Price.TabIndex = 3;
            this.lbl_Price.Text = "總價:";
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Location = new System.Drawing.Point(428, 411);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(94, 37);
            this.btn_CheckOut.TabIndex = 4;
            this.btn_CheckOut.Text = "結帳";
            this.btn_CheckOut.UseVisualStyleBackColor = true;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // cmb_Payment
            // 
            this.cmb_Payment.FormattingEnabled = true;
            this.cmb_Payment.Location = new System.Drawing.Point(286, 428);
            this.cmb_Payment.Name = "cmb_Payment";
            this.cmb_Payment.Size = new System.Drawing.Size(121, 20);
            this.cmb_Payment.TabIndex = 5;
            // 
            // btn_Leave
            // 
            this.btn_Leave.Location = new System.Drawing.Point(995, 545);
            this.btn_Leave.Name = "btn_Leave";
            this.btn_Leave.Size = new System.Drawing.Size(94, 37);
            this.btn_Leave.TabIndex = 6;
            this.btn_Leave.Text = "離開";
            this.btn_Leave.UseVisualStyleBackColor = true;
            this.btn_Leave.Click += new System.EventHandler(this.btn_Leave_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 594);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Leave);
            this.Controls.Add(this.cmb_Payment);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.ComboBox cmb_Payment;
        private System.Windows.Forms.Button btn_Leave;
    }
}