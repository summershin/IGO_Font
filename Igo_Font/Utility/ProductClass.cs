using Igo_Font;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGO_font
{
    
    static class ProductClass
    {
        public static List<prod> items = new List<prod>();

        public static void clear()
        {
            items.Clear();
        }
        public static void additem(prod pro)
        {
            items.Add(pro);
        }
        public static void remove(int index)
        {
            items.RemoveAt(index);
        }
        public static int count()
        {
            return items.Count();
        }
        public static bool contains(int a, string ticket)
        {
            for(int i = 0; i < items.Count; i++)
            {
                if (items[i].productID == a&&items[i].ticket == ticket)
                {
                    return true;
                }
            }
            return false;
        }
        public static int indexof(int a)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].productID == a)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void showdata(List<object> pro,List<prod> items)
        {
            pro.Clear();
            IGOEntities dbcontext = new IGOEntities();
            for (int i = 0; i < ProductClass.count(); i++)
            {
                var q = dbcontext.Products.AsEnumerable().Where(n => n.ProductID == items[i].productID).Select(n => new
                {
                    產品編號 = n.ProductID,
                    房間種類 = n.ProductName,
                    訂購數量 = items[i].quentity,
                    房型 = items[i].ticket,
                    入住日期 = n.StartTime.Value.ToString("d"),
                    退房日期 = n.EndTime.Value.ToString("d"),
                    n.Introduction,
                    價格 = dbcontext.TicketAndProducts.AsEnumerable().Where(s => s.ProductID == items[i].productID && s.TicketType.TicketName == items[i].ticket).Select(x => x.Price).First().Value.ToString()
                });

                pro.Add(q.FirstOrDefault());

            }

        }
    }


    class prod
    {
        public int productID { get; set; }
        public int quentity { get; set; }
        public string ticket { get; set; }
        public decimal price { get; set; }
        public int customerID { get; set; }
        public int subcategoryID { get; set; }
        public int seatID { get; set; }
        public int TempOrder { get; set; }
    }

    
}
