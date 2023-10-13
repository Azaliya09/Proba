using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shop.Base
{
    public partial class Product
    {
        public decimal CostDiscount
        {
            get
            {
                if (Discount == 0)
                    return Cost;
                else
                    return Cost - (Cost * (decimal)Discount / 100);
            }
        }
        public Visibility CostVisibility
        {
            get
            {
                if (Discount == 0)
                    return Visibility.Collapsed;
                else
                    return Visibility.Visible;
            }
        }

        
    }
}
