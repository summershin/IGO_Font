using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Diagnostics;
//using System.Data.Services.Client;
using IGO_font;
using System.Collections;
using Igo_Font;

namespace IGO_font
{


    public partial class Movie : Form
    {
        List<num1> apple = new List<num1>();

        public Movie()
        {
            InitializeComponent();
            var q = (from o in dbContext.Products
                     where o.Address.Contains("影城")&& o.SubCategoryID ==3
                     orderby o.Address
                     select o.Address).Distinct();
            foreach (string n in q)
            {
                this.cmb_MovieAdress.Items.Add(n);
            }
            //===================================
            //var q1 = from o in dbContext.TicketTypes
            //         select o.TicketName;
            //foreach (string n in q1)
            //{
            //    this.cmb_ticket.Items.Add(n);
            //}
            //=======================================


        }

        IGOEntities dbContext = new IGOEntities();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public List<string> checkedSeats = new List<string>();
        public List<string> aaaa = new List<string>();
        private void btn_seat_Click(object sender, EventArgs e)
        {
            if (cmb_ticket.Text != "請選擇票種")
            {
                if (cmb_Count.Text != "請選擇數量")
                {
                    int limit = Convert.ToInt32(this.cmb_Count.SelectedItem.ToString());

                    MovieSeat reservation = new MovieSeat(limit, checkedSeats);
                    if (reservation.ShowDialog() == DialogResult.OK)
                    {
                        var results = reservation.CheckedSeats;
                        aaaa = results;
                        this.checkedSeats.AddRange(results);
                    }
                }
                else
                {
                    MessageBox.Show("請選擇數量");
                }
            }
            else
            {
                MessageBox.Show("請選擇票種");
            }
        }

        private void cmb_MovieAdress_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmb_Movie.Items.Clear();
            this.cmb_Movie.Text=("請選擇電影");
            var q = (from o in dbContext.Products
                     where o.Address == this.cmb_MovieAdress.Text
                     select o.ProductName).Distinct();
            foreach (string n in q)
            {
                this.cmb_Movie.Items.Add(n);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_time_Click(object sender, EventArgs e)
        {
            if (cmb_MovieAdress.Text != "請選擇影城")
            {
                if (cmb_Movie.Text != "請選擇電影")
                {
                    var q = from o in dbContext.Products
                            where o.StartTime >= dateTimePicker1.Value && o.EndTime <= dateTimePicker2.Value && o.ProductName == cmb_Movie.Text
                            select new
                            {
                                場次 = o.ProductID,
                                電影 = o.ProductName,
                                開始時間 = o.StartTime,
                                結束時間 = o.EndTime,
                                總量 = o.Quantity
                            };
                    this.DGV_Movie.DataSource = q.ToList();
                }
                else
                {
                    MessageBox.Show("請選擇電影");
                }
            }
            else
            {
                MessageBox.Show("請選擇影城");
            }

        }

        private void btn_shopping_Click_1(object sender, EventArgs e)
        {




        }

        private void DGV_Movie_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_Count_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        ArrayList list = new ArrayList();

        private void btn_shop_Click(object sender, EventArgs e)
        {
            int op;
            if (DGV_Movie != null)
            {
                if (cmb_ticket.Text == "全票" || cmb_ticket.Text == "優待票")
                {
                    if (int.TryParse(cmb_Count.Text, out op))
                    {



                        int ticket = 0;
                        num1 x = new num1();
                        int c = (int)DGV_Movie.CurrentRow.Cells[4].Value;
                        string s ="";
                        foreach(var p in aaaa)
                        {
                            s += p.ToString() + ",";
                        }

                        //=========================================
                        var q = from p in dbContext.Products.AsEnumerable()
                                where p.ProductID.ToString() == this.DGV_Movie.CurrentRow.Cells[0].Value.ToString()
                                select new
                                {
                                    場次 = p.ProductID,
                                    電影 = p.ProductName,
                                    票種 = cmb_ticket.Text,
                                    張數 = cmb_Count.Text,
                                    座位 = s
                                };
                        var qq = from p in dbContext.Products.AsEnumerable()
                                 where p.ProductID.ToString() == this.DGV_Movie.CurrentRow.Cells[0].Value.ToString()
                                 select p.SubCategoryID;

                        x.ProductID = q.ToList()[0].場次;
                        x.Productname = q.ToList()[0].電影;
                        x.ticket = int.Parse(q.ToList()[0].張數);
                        x.seat = q.ToList()[0].座位;
                        x.subcategory = (int)qq.ToList()[0];
                        if (q.ToList()[0].票種 == "全票")
                        {
                            x.tickettype = 9;
                            x.price = 340 * int.Parse(q.ToList()[0].張數);
                        }
                        else
                        {
                            x.tickettype = 10;
                            x.price = 320 * int.Parse(q.ToList()[0].張數);
                        }
                        apple.Add(x);
                        for (int p = 0; p < apple.Count; p++)
                        {
                            if (apple[p].Productname == (this.DGV_Movie.CurrentRow.Cells[1].Value).ToString()
                                && apple[p].ProductID == (int)DGV_Movie.CurrentRow.Cells[0].Value)
                            {
                                ticket += apple[p].ticket;
                            }
                        }
                        if (c >= ticket)
                        {
                            foreach (var i in q)
                            {
                                list.Add(i);
                            }
                            this.dgv_shoppingcar.DataSource = null;
                            this.dgv_shoppingcar.DataSource = list;
                        }
                        else
                        {
                            MessageBox.Show("超過庫存量");
                            apple.RemoveAt(apple.Count - 1);
                        }
                    
                    }
                }



            else
                {
                    MessageBox.Show("請選擇票種");
                }

            }
            else
            { MessageBox.Show("請選擇電影票"); }
        }

    


        private void btn_delet_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {
                this.apple.RemoveAt(dgv_shoppingcar.CurrentRow.Index);
                this.list.RemoveAt(dgv_shoppingcar.CurrentRow.Index);
                this.dgv_shoppingcar.DataSource = null;
                this.dgv_shoppingcar.DataSource = list;
                }
            }
        

        private void btn_clear_Click(object sender, EventArgs e)
        {
            list.Clear();
            apple.Clear();
            this.dgv_shoppingcar.DataSource = null;
        }

        private void btn_shop_car_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string s = (r.Next(1, 1000) * r.Next(1, 1000)).ToString();
            Temp temp = new Temp();
            for (int i = 0; i < apple.Count; i++)
            {
                temp.ProductID = apple[i].ProductID;
                temp.Quantity = apple[i].ticket;
                temp.TicketID = apple[i].tickettype;
                temp.TotalPrice = apple[i].price;
                temp.Seats = apple[i].seat;
                temp.SubCategoryID = apple[i].subcategory;
                temp.CustomerID = customer.customerID;
                
            }
            temp.TempOrder = s;
            
            this.dbContext.Temps.Add(temp);
            this.dbContext.SaveChanges();
            MessageBox.Show("加入購物車成功");

        }
    }
    public static class MovieShop
    {
        public static int ProductID;

    }

    public class num1
    {
        public int ProductID { get; set; }
        public string Productname { get; set; }
        public int ticket { get; set; }
        public int tickettype { get; set; }
        public string seat { get; set; }
        public int price { get; set; }

        public int subcategory { get; set; }
    }

}
