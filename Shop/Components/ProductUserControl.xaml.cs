using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Shop.Base;

namespace Shop.Components
{
    /// <summary>
    /// Логика взаимодействия для ProductUserControl.xaml
    /// </summary>
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl(Product product)
        {
            InitializeComponent();

            TitleTb.Text = product.Title;
            RaitingTb.Text = product.Discount.ToString();
            CostTb.Text = product.CostDiscount.ToString("N0") + " ₽ ";
            CostTimeTb.Visibility = product.CostVisibility;
            CostTimeTb.Text = product.Cost.ToString("N0");
            
        }
    }
}
