using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hendriz_app.Models
{
    public class ProductCard
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public int stars { get; set; } = 0;
        public int price { get; set; } = 0;
        public int reviewCount { get; set; } = 0;
        public int watchcount { get; set; }
        public string category { get; set; }
    }
}
