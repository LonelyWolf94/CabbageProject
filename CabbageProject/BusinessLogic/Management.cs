using System;
using static CabbageProject.Data.Data;

namespace CabbageProject.BusinessLogic
{
    public class Management
    {
        public static void ChangePercOfDisc(double percentOfDiscount)
        {
            foreach(var product in Products)
            {
                product.PercentOfDiscount = percentOfDiscount;
            }
        }

        public static void ChangePercOfDiscForCategory(double percentOfDiscount, Category category)
        {
            foreach (var product in Products)
            {
                if (product.Category == (int)category)
                {
                    product.PercentOfDiscount = percentOfDiscount;
                }
            }
        }

        public static void ChangePercOfDisc(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    ChangePercOfDiscForCategory(0.15, Category.Vegetables);
                    ChangePercOfDiscForCategory(0.1, Category.Fruits);
                    break;
                default:
                    break;
            }
        }
    }
}
