using Igo_Font;
using System;
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

            var q = dbcontext.Temps.Where(n => n.CustomerID==1);

            ProductClass.items.Clear();

            foreach(var q1 in q)
            {
                prod item = new prod();
                if (q1.ProductID != null && q1.SeatID == null)
                {
                    item.productID = (int)q1.ProductID;
                    item.quentity = (int)q1.Quantity;
                    item.ticket = q1.TicketType.TicketName;
                    item.price = (decimal)q1.TotalPrice;
                    item.customerID = (int)q1.CustomerID;
                    item.subcategoryID = (int)q1.SubCategoryID;
                }
                else if (q1.ProductID != null && q1.SeatID != null)
                {
                    item.productID = (int)q1.ProductID;
                    item.quentity = (int)q1.Quantity;
                    item.ticket = q1.TicketType.TicketName;
                    item.price = (decimal)q1.TotalPrice;
                    item.customerID = (int)q1.CustomerID;
                    item.subcategoryID = (int)q1.SubCategoryID;
                    item.seatID = (int)q1.SeatID;
                }
                ProductClass.additem(item);
            }
            
            ProductClass.showdata(pro, ProductClass.items);
            dataGridView1.DataSource = pro.ToList();

            var q2 = dbcontext.Payments.Select(n => n.PayType);
            foreach(string s in q2)
            {
                cbx_PayType.Items.Add(s);
            }
            
        }

        List<object> pro = new List<object>();
        IGOEntities dbcontext = new IGOEntities();
        

        private void btn_Order_Click(object sender, EventArgs e)
        {
            if (cbx_PayType.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇付款方式!");
                return;
            }
            decimal total = 0;
            for(int i = 0; i < ProductClass.items.Count; i++)
            {
                total += ProductClass.items[i].price;
            }

            var inserorder = new Order
            {
                CustomerID = 1,
                OrderDate = DateTime.Now,
                PayTypeID = dbcontext.Payments.Where(n => n.PayType == cbx_PayType.Text).Select(n => n.PayTypeID).First(),
                ShipperID = 1,
                ShippedDate = DateTime.Now.AddDays(3),
                StatusID = 1,
                TotalPrice = total
            };

            dbcontext.Orders.Add(inserorder);
            dbcontext.SaveChanges();

            for(int i = 0; i < ProductClass.items.Count; i++)
            {
                var inserorderdetail = new OrderDetail
                {
                    OrderID = dbcontext.Orders.AsEnumerable().Last().OrderID,
                    ProductID = ProductClass.items[i].productID,
                    TicketID = dbcontext.TicketTypes.AsEnumerable().Where(n=>n.TicketName==ProductClass.items[i].ticket).Select(n=>n.TicketID).First(),
                    Quantity = ProductClass.items[i].quentity
                };

                dbcontext.OrderDetails.Add(inserorderdetail);
                dbcontext.SaveChanges();
            }

            MessageBox.Show("訂單已成立!");

            var q = dbcontext.Temps.Where(n => n.CustomerID == 1);

            foreach(var item in q)
            {
                dbcontext.Temps.Remove(item);
            }
            dbcontext.SaveChanges();

            var q1 = dbcontext.Temps.Where(n => n.CustomerID == 1);
            dataGridView2.DataSource = q1.ToList();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            ProductClass.remove(dataGridView1.CurrentRow.Index);
            ProductClass.showdata(pro, ProductClass.items);
            dataGridView1.DataSource = pro.ToList();
        }
    }
}
