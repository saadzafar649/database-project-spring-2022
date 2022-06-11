using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hendriz_app.Models
{
    public class Color
    {
        public string color;
        public int quantity;
    }
    public class Product
    {
        public int Id;
        public string category;
        public string name;
        public string title;
        public string description;
        public int price = 0;
        public string image;
        public List<Color> colors = new List<Color>();
        public List<Review> reviews = new List<Review>();
    }
}
