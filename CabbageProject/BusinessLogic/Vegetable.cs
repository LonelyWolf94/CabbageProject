using System;
using System.Collections.Generic;
using System.Text;

namespace CabbageProject.BusinessLogic
{
    public class Vegetable : Product
    {
        public bool IsFresh { get; set; }

        public Vegetable()
        {
            Category = (int)BusinessLogic.Category.Vegetables;
        }
    }
}
