using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hendriz_app.Models
{
    public class CartItem
    {
        public int ItemId;
        public int productId;
        public string name;
        public int price = 0;
        public int discount = 0;
        public string image = "";
        public int quantity = 0;
        public string color;
    }
}
