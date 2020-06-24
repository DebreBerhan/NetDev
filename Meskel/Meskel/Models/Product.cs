using System;
using System.Collections.Generic;

namespace Meskel.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string PpImage { get; set; }
        public double Price { get; set; }
    }
}
