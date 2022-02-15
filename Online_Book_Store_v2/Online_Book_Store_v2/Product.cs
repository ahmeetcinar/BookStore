using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Online_Book_Store_v2
{
    /// <summary>
    /// ürünlerin bilgilerini tutan base class.
    /// </summary>
    public abstract class Product
    {
        public String name;
        public double price;
        public int ProductID;
        public string Category;
        public Image image;
        public double Sale;
        public double discountedPrice;
        public abstract void ShowProperties();
    }
}
