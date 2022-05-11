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
    public partial class Live : Form
    {
        public Live()
        {
            InitializeComponent();

            var q = dbcontext.Products.Where(n=>n.SubCategoryID ==1).Select(n => n.City.City1);

            foreach (var item in q.Distinct())
            {
                cbx_City.Items.Add(item);
            }
            var q1 = dbcontext.TicketTypes.Where(n => n.SubcategoryID ==1).Select(n=>n.TicketName);
            foreach (var item in q1)
            {
                cbx_TicketType.Items.Add(item);
            }

            LoadProduct();
        }
        IGOEntities dbcontext = new IGOEntities();

        void LoadProduct()
        {

            var q = dbcontext.Products.AsEnumerable().Where(n=>n.SubCategoryID == 1).Select(n => new
            {
                產品編號 = n.ProductID,
                n.ProductName,
                n.Address,
                n.City.City1,
                n.Supplier.CompanyName,
                剩餘數量 = n.Quantity,
                入住日期 = n.StartTime.Value.ToString("d"),
                退房日期 = n.EndTime.Value.ToString("d"),
                n.Introduction
            });
            dgv_ProductList.DataSource = q.ToList();
        }

        private void btn_AllProduct_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void cbx_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = dbcontext.Products.Where(n => n.City.City1 == cbx_City.Text&&n.SubCategoryID==1).Select(n => n.Supplier.CompanyName);
            cbx_Supplier.Items.Clear();
            foreach (var item in q.Distinct())
            {
                cbx_Supplier.Items.Add(item);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int roomtype = cbx_RoomType.SelectedIndex,
                city = cbx_City.SelectedIndex,
                supplier = cbx_Supplier.SelectedIndex;

            var q = dbcontext.Products.AsEnumerable().Where(n=>n.SubCategoryID==1).Select(n => new
            {
                產品編號 = n.ProductID,
                n.ProductName,
                n.Address,
                n.City.City1,
                n.Supplier.CompanyName,
                剩餘數量 = n.Quantity,
                入住日期 = n.StartTime.Value.ToString("d"),
                退房日期 = n.EndTime.Value.ToString("d"),
                n.Introduction
            });


            if (roomtype != -1 && city != -1 && supplier != -1)
            {
                dgv_ProductList.DataSource = q.Where(n => n.ProductName == cbx_RoomType.SelectedItem.ToString() && n.City1 == cbx_City.SelectedItem.ToString() && n.CompanyName == cbx_Supplier.SelectedItem.ToString()).ToList();
            }
            else if (roomtype != -1 && city != -1)
            {
                dgv_ProductList.DataSource = q.Where(n => n.ProductName == cbx_RoomType.SelectedItem.ToString() && n.City1 == cbx_City.SelectedItem.ToString()).ToList();
            }
            else if (roomtype == -1 && city != -1 && supplier != -1)
            {
                dgv_ProductList.DataSource = q.Where(n => n.City1 == cbx_City.SelectedItem.ToString() && n.CompanyName == cbx_Supplier.SelectedItem.ToString()).ToList();
            }
            else if (roomtype != -1)
            {
                dgv_ProductList.DataSource = q.Where(n => n.ProductName == cbx_RoomType.SelectedItem.ToString()).ToList();
            }
            else if (city != -1)
            {
                dgv_ProductList.DataSource = q.Where(n => n.City1 == cbx_City.SelectedItem.ToString()).ToList();
            }
            else
            {
                MessageBox.Show("請選擇篩選條件");
            }

        }
        List<object> pro = new List<object>();
        //List<int> proID = new List<int>();
        //List<int> Quentity = new List<int>();
        

        private void btn_AddBuyList_Click(object sender, EventArgs e)
        {

            prod proditem = new prod();

            int quentity = Convert.ToInt32(dgv_ProductList.CurrentRow.Cells[5].Value);
            int buytknum = 0;
            bool a = int.TryParse(txt_BuyTkNum.Text, out buytknum);
            int proid = Convert.ToInt32(dgv_ProductList.CurrentRow.Cells[0].Value);
            if (!a)
            {
                MessageBox.Show("請輸入數量");
                return;
            }
            else if (cbx_TicketType.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇房型");
                return;
            }
            else if (ProductClass.contains(proid,cbx_TicketType.SelectedItem.ToString()))
            {
                
                ProductClass.items[ProductClass.indexof(proid)].quentity += buytknum;
                if (ProductClass.items[ProductClass.indexof(proid)].quentity > quentity)
                {
                    ProductClass.items[ProductClass.indexof(proid)].quentity -= buytknum;
                    MessageBox.Show("空房不足");
                    return;
                }
            }
            else
            {
                if (buytknum > quentity)
                {
                    MessageBox.Show("空房不足");
                    return;
                }
                proditem.productID = proid;
                proditem.quentity = buytknum;
                proditem.ticket = dbcontext.TicketTypes.Where(n => n.TicketName == cbx_TicketType.SelectedItem.ToString()).Select(n=>n.TicketName).First();
                proditem.price = dbcontext.TicketAndProducts.Where(n => n.TicketType.TicketName == proditem.ticket && n.ProductID == proid).Select(n => n.Price).FirstOrDefault().Value;
                ProductClass.additem(proditem);
            }

            ProductClass.showdata(pro,ProductClass.items);
            //pro.Clear();
            //for (int i = 0; i < ProductClass.count(); i++)
            //{
            //    var q = dbcontext.Products.AsEnumerable().Where(n => n.ProductID == ProductClass.items[i].productID).Select(n => new
            //    {
            //        產品編號 = n.ProductID,
            //        房間種類 = n.ProductName,
            //        訂購數量 = ProductClass.items[i].quentity,
            //        房型 = ProductClass.items[i].ticket,
            //        入住日期 = n.StartTime.Value.ToString("d"),
            //        退房日期 = n.EndTime.Value.ToString("d"),
            //        n.Introduction,
            //        價格 = dbcontext.TicketAndProducts.AsEnumerable().Where(s => s.ProductID == ProductClass.items[i].productID && s.TicketType.TicketName == ProductClass.items[i].ticket).Select(x => x.Price).First().Value.ToString()
            //    });
            //    pro.Add(q.First());

            //}

            dgv_BuyList.DataSource = pro.ToList();

            //int quentity = Convert.ToInt32(dgv_ProductList.CurrentRow.Cells[5].Value);
            //int buytknum = 0;
            //bool a = int.TryParse(txt_BuyTkNum.Text, out buytknum);
            //int proid = Convert.ToInt32(dgv_ProductList.CurrentRow.Cells[0].Value);
            //if (!a)
            //{
            //    MessageBox.Show("請輸入數量");
            //    return;
            //}
            ////else if (cbx_RoomType.SelectedIndex==-1)
            ////{
            ////    MessageBox.Show("請選擇房型");
            ////    return;
            ////}
            //else if (proID22222.Contains(proid))
            //{

            //    Quentity11111[proID22222.IndexOf(proid)] += buytknum;
            //    if (Quentity11111[proID22222.IndexOf(proid)] > quentity)
            //    {
            //        Quentity11111[proID22222.IndexOf(proid)] -= buytknum;
            //        MessageBox.Show("空房不足");
            //        return;
            //    }
            //}
            //else
            //{
            //    if (buytknum > quentity)
            //    {
            //        MessageBox.Show("空房不足");
            //        return;
            //    }

            //    proID22222.Add(proid);
            //    Quentity11111.Add(buytknum);
            //}

            //pro.Clear();
            //for (int i = 0; i < proID22222.Count; i++)
            //{
            //    var q = dbcontext.Products.AsEnumerable().Where(n => n.ProductID == proID22222[i]).Select(n => new
            //    {
            //        產品編號 = n.ProductID,
            //        n.ProductName,
            //        n.Address,
            //        n.City.City1,
            //        n.Supplier.CompanyName,
            //        訂購數量 = Quentity11111[i],
            //        房型 = cbx_RoomType.SelectedItem,
            //        入住日期 = n.StartTime.Value.ToString("d"),
            //        退房日期 = n.EndTime.Value.ToString("d"),
            //        n.Introduction,
            //        價格 = dbcontext.TicketAndProducts.AsEnumerable().Where(s => s.ProductID == proID22222[i] && s.TicketID == 1).Select(x => x.Price).First().Value.ToString()
            //    });
            //    pro.Add(q.First());

            //}

            //dgv_BuyList.DataSource = pro.ToList();

        }

        private void Minus_Click(object sender, EventArgs e)
        {
            int quentity = Convert.ToInt32(dgv_BuyList.CurrentRow.Cells[2].Value);
            int minus = 0;
            bool a = int.TryParse(txt_Minus.Text, out minus);
            int proid = Convert.ToInt32(dgv_ProductList.CurrentRow.Cells[0].Value);
            if (!a)
            {
                MessageBox.Show("請輸入數量");
                return;
            }
            if (quentity - minus <= 0 && ProductClass.count() > 0)
            {
                ProductClass.remove(dgv_BuyList.CurrentCellAddress.Y);
            }
            else
            {
                ProductClass.items[dgv_BuyList.CurrentCellAddress.Y].quentity = quentity - minus;
            }

            if (ProductClass.count() == 0)
            {
                dgv_BuyList.DataSource = null;
                pro.Clear();
                MessageBox.Show("購物車已清空!");
                return;
            }

            ProductClass.showdata(pro,ProductClass.items);
            //pro.Clear();

            //for (int i = 0; i < ProductClass.count(); i++)
            //{
            //    var q = dbcontext.Products.AsEnumerable().Where(n => n.ProductID == ProductClass.items[i].productID).Select(n => new
            //    {
            //        產品編號 = n.ProductID,
            //        房間種類 = n.ProductName,
            //        訂購數量 = ProductClass.items[i].quentity,
            //        房型 = ProductClass.items[i].ticket,
            //        入住日期 = n.StartTime.Value.ToString("d"),
            //        退房日期 = n.EndTime.Value.ToString("d"),
            //        n.Introduction,
            //        價格 = dbcontext.TicketAndProducts.AsEnumerable().Where(s => s.ProductID == ProductClass.items[i].productID && s.TicketType.TicketName == ProductClass.items[i].ticket).Select(x => x.Price).First().Value.ToString()
            //    });

            //    pro.Add(q.FirstOrDefault());

            //}
            dgv_BuyList.DataSource = pro.ToList();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

            ProductClass.remove(dgv_BuyList.CurrentCellAddress.Y);

            if (ProductClass.count() == 0)
            {
                dgv_BuyList.DataSource = null;
                pro.Clear();
                MessageBox.Show("購物車已清空!");
                return;
            }
            ProductClass.showdata(pro,ProductClass.items);

            //pro.Clear();

            //    for (int i = 0; i < ProductClass.count(); i++)
            //{
            //    var q = dbcontext.Products.AsEnumerable().Where(n => n.ProductID == ProductClass.items[i].productID).Select(n => new
            //    {
            //        產品編號 = n.ProductID,
            //        房間種類 = n.ProductName,
            //        訂購數量 = ProductClass.items[i].quentity,
            //        房型 = ProductClass.items[i].ticket,
            //        入住日期 = n.StartTime.Value.ToString("d"),
            //        退房日期 = n.EndTime.Value.ToString("d"),
            //        n.Introduction,
            //        價格 = dbcontext.TicketAndProducts.AsEnumerable().Where(s => s.ProductID == ProductClass.items[i].productID && s.TicketType.TicketName == ProductClass.items[i].ticket).Select(x => x.Price).First().Value.ToString()
            //    });

            //    pro.Add(q.FirstOrDefault());
        //}
        
             dgv_BuyList.DataSource = pro.ToList();
        }

        private void BuyClear_Click(object sender, EventArgs e)
        {
            ProductClass.clear();
            pro.Clear();
            dgv_BuyList.DataSource = null;
            MessageBox.Show("購物車已清空!");
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            //if(dgv_BuyList.DataSource == null)
            //{
            //    MessageBox.Show("請先選擇商品!");
            //    return;
            //}
            for(int i = 0; i < ProductClass.items.Count; i++)
            {
                var insert = new Temp
                {
                    ProductID = ProductClass.items[i].productID,
                    CustomerID = 1,
                    SubCategoryID = 1,
                    TicketID = dbcontext.TicketTypes.AsEnumerable().Where(n => n.TicketName == ProductClass.items[i].ticket).Select(n => n.TicketID).FirstOrDefault(),
                    Quantity = ProductClass.items[i].quentity,
                    TotalPrice = ProductClass.items[i].price,
                };
                dbcontext.Temps.Add(insert);
                dbcontext.SaveChanges();

            }

            CheckOut f = new CheckOut();
            f.Show();
            
        }
    }
}
