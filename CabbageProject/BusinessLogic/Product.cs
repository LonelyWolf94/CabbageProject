using System;
using System.Collections.Generic;
using System.Text;

namespace CabbageProject.BusinessLogic
{
    public class Product
    {
        public string Name { get; set; }
        public int Category { get; set; }
        public double PercentOfDiscount { get; set; } = 1.0;
        public double Price { get; set; }
    }
}
