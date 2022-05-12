using Igo_Font;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGO_font
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        List<MyCart> myCarts = new List<MyCart>();
        int Price = 0;
        int TicketCount = 0;
        int count = 0;
        

        IGOEntities dbcontext = new IGOEntities();
        
        
        Product p = new Product();
        private void CheckOut_Load(object sender, EventArgs e)
        {
            
            var payment = from p in dbcontext.Payments
                          select p.PayType;
            foreach (string item in payment)
            {
                cmb_Payment.Items.Add(item);
            }
            cmb_Payment.SelectedIndex = 0;

            try
            {

                var qq = (from p in dbcontext.Temps
                          where p.SubCategoryID == 1 && p.CustomerID == customer.customerID
                          select new { p.TempOrder, p.ProductID, 產品 = p.Product.Supplier.CompanyName }).Distinct();

                for (int i = 0; i < qq.ToList().Count; i++)
                {
                    MyCart myCart = new MyCart();
                    myCart.TempOrder = qq.ToList()[i].TempOrder;
                    myCart.ProductID = qq.ToList()[i].ProductID;
                    myCart.ProductName = qq.ToList()[i].產品;


                    myCarts.Add(myCart);
                    count += 1;
                }

                var q4 = (from p in dbcontext.Temps
                          where p.SubCategoryID != 1 && p.CustomerID == customer.customerID
                          select new { p.TempOrder, p.ProductID, 產品 = p.Product.ProductName }).Distinct();


                for (int j = 0; j < q4.ToList().Count; j++)
                {
                    MyCart myCart = new MyCart();
                    myCart.TempOrder = q4.ToList()[j].TempOrder;
                    myCart.ProductID = q4.ToList()[j].ProductID;
                    myCart.ProductName = q4.ToList()[j].產品;
                    myCarts.Add(myCart);
                }


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = myCarts;

                if (dataGridView1.RowCount>0)
                {
                    var q5 = from p in dbcontext.Temps.AsEnumerable()
                             where p.TempOrder == dataGridView1.CurrentRow.Cells[0].Value.ToString()
                             select new
                             {
                                 訂單編號 = p.TempOrder,
                                 產品編號 = p.ProductID,
                                 產品名稱 = p.Product.ProductName,
                                 票種 = p.TicketType.TicketName,
                                 票數 = p.Quantity,
                                 票價 = p.TotalPrice


                             };

                    for (int i = 0; i < q5.ToList().Count; i++)
                    {
                        Price += (int)q5.ToList()[i].票價;

                    }
                    lbl_Price.Text = $"總價:{Price:C2}";

                    var q6 = from p in dbcontext.Temps.AsEnumerable()
                             where p.TempOrder == dataGridView1.CurrentRow.Cells[0].Value.ToString()
                             select new
                             {
                                 訂單編號 = p.TempOrder,
                                 產品編號 = p.ProductID,
                                 產品名稱 = p.Product.ProductName,
                                 票種 = p.TicketType.TicketName,
                                 票數 = p.Quantity,
                                 票價 = p.TotalPrice,
                                 座位 = p.Seats

                             };




                    dataGridView2.DataSource = q6.ToList();

                }


            }
            catch(Exception ex) {
                MessageBox.Show("購物車沒有資料");
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var q3 = from t in dbcontext.Temps.AsEnumerable()
                     where t.TempOrder == (string)dataGridView1.CurrentRow.Cells[0].Value
                     select t;
            
            if (q3 != null)
            {
                foreach (var item in q3)
                {
                    dbcontext.Temps.Remove(item);
                }
                
                dbcontext.SaveChanges();
                var q4 = (from p in dbcontext.Temps
                          where p.CustomerID == customer.customerID
                          select new { p.TempOrder, p.ProductID, p.Product.ProductName }).Distinct();

                dataGridView1.DataSource = q4.ToList();
                dataGridView2.DataSource = null;

            }
            else
            {

                MessageBox.Show("裡面沒有資料");
            }
        }

     

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TicketCount = 0;
            Price = 0;
            var q5 = from p in dbcontext.Temps.AsEnumerable()
                     where p.TempOrder == dataGridView1.CurrentRow.Cells[0].Value.ToString()
                     select new
                     {
                         訂單編號 = p.TempOrder,
                         產品編號 = p.ProductID,
                         產品名稱 = p.Product.ProductName,
                         票種 = p.TicketType.TicketName,
                         票數 = p.Quantity,
                         票價 = p.TotalPrice,
                         

                     };
            
            for (int i = 0; i < q5.ToList().Count; i++)
            {
                Price += (int)q5.ToList()[i].票價;
                TicketCount += (int)q5.ToList()[i].票數;
            }
           
            lbl_Price.Text = $"總價:{Price:C2}";

            var q6 = from p in dbcontext.Temps.AsEnumerable()
                     where p.TempOrder == dataGridView1.CurrentRow.Cells[0].Value.ToString()
                     select new
                     {
                         訂單編號 = p.TempOrder,
                         產品編號 = p.ProductID,
                         產品名稱 = p.Product.ProductName,
                         票種 = p.TicketType.TicketName,
                         票數 = p.Quantity,
                         票價 = p.TotalPrice,
                         座位 = p.Seats

                     };




            dataGridView2.DataSource = q6.ToList();
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            var q3 = from t in dbcontext.Temps.AsEnumerable()
                     where t.TempOrder == (string)dataGridView1.CurrentRow.Cells[0].Value
                     select t;

            Order od = new Order();
            //結帳 order資料庫新增
            od.CustomerID = customer.customerID;
            od.OrderDate = DateTime.Now;
            od.PayTypeID = cmb_Payment.SelectedIndex + 1;
            od.TotalPrice = Price;
            dbcontext.Orders.Add(od);
            dbcontext.SaveChanges();

          
            foreach (var item in q3)
            {

                OrderDetail ods = new OrderDetail();
                ods.OrderID = dbcontext.Orders.AsEnumerable().Last().OrderID;
                ods.ProductID = item.ProductID;
                ods.TicketID = item.TicketID;
                ods.Quantity = item.Quantity;
                ods.Price = item.TotalPrice;
                dbcontext.OrderDetails.Add(ods);

                if (item.Seats != null)
                {
                    string[] seats = item.Seats.Split(',');
                    for(int s = 0; s < seats.Length-1; s++)
                    {
                        Seat addseat = new Seat();
                        addseat.OrderDetailID = dbcontext.OrderDetails.AsEnumerable().Last().OrderDetailsID;
                        addseat.ProductID = item.ProductID;
                        addseat.SeatName = seats[s];
                        dbcontext.Seats.Add(addseat);
                    }

                }
                
            }
            dbcontext.SaveChanges();


            if (q3 != null)
            {
                foreach (var item in q3)
                {
                    dbcontext.Temps.Remove(item);
                }

                dbcontext.SaveChanges();
                
                
                var q4 = (from p in dbcontext.Temps
                          where p.CustomerID == customer.customerID
                          select new { p.TempOrder, p.ProductID, p.Product.ProductName }).Distinct();


                //orderdetail 資料庫新增
               






                //重新載入
                var q6 = from p in dbcontext.Temps.AsEnumerable()
                         where p.TempOrder == dataGridView1.CurrentRow.Cells[0].Value.ToString()
                         select new
                         {
                             訂單編號 = p.TempOrder,
                             產品編號 = p.ProductID,
                             產品名稱 = p.Product.ProductName,
                             票種 = p.TicketType.TicketName,
                             票數 = p.Quantity,
                             票價 = p.TotalPrice,
                             總票價 = Price

                         };
                           dataGridView2.DataSource = q6.ToList();
                //修改product 的數量
                var ProductChange = (from p in dbcontext.Products.AsEnumerable()
                                    where p.ProductName == dataGridView1.CurrentRow.Cells[2].Value.ToString()
                                    select p).FirstOrDefault();
                
                ProductChange.Quantity = ProductChange.Quantity - TicketCount;
                dbcontext.SaveChanges();
                
                dataGridView1.DataSource = q4.ToList();
                dataGridView2.DataSource = null;

               

            }
            else
            {

                MessageBox.Show("裡面沒有資料");
            }
        }

        private void btn_Leave_Click(object sender, EventArgs e)
        {
            
            this.Close();
           
            
           
            
        }
    }


    public class MyCart
    {
        public string TempOrder { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        

    }
}

