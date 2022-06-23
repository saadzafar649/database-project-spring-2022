using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hendriz_app.Models
{
    public class Review
    {
        public string name { get; set; }
        public string review { get; set; }
        public int stars { get; set; }
        public string timestamp { get; set; }
    }
}
