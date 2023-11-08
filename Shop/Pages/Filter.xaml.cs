using Shop.Base;
using Shop.Components;
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


namespace Shop.Pages
{
    /// <summary>
    /// Логика взаимодействия для Filter.xaml
    /// </summary>
    public partial class Filter : Page
    {

        public Filter()
        {
            InitializeComponent();
            Refresh();
        }
        private void Refresh()
        {

            IEnumerable<Product> productSortList = App.db.Product;
            if (SortCb.SelectedIndex > 0)
            {
                if (SortCb.SelectedIndex == 1)
                {
                    productSortList = productSortList.OrderBy(x => x.CostDiscount);
                }
                else
                {
                    productSortList = productSortList.OrderByDescending(x => x.CostDiscount);
                }

            }
            if (DiscountFilterCb.SelectedIndex != 0)
            {
                if (DiscountFilterCb.SelectedIndex == 1)
                    productSortList = productSortList.Where(x => x.Discount >= 0 && x.Discount < 5);
                if (DiscountFilterCb.SelectedIndex == 2)
                    productSortList = productSortList.Where(x => x.Discount >= 5 && x.Discount < 15);
                if (DiscountFilterCb.SelectedIndex == 3)
                    productSortList = productSortList.Where(x => x.Discount >= 15 && x.Discount < 30);
                if (DiscountFilterCb.SelectedIndex == 4)
                    productSortList = productSortList.Where(x => x.Discount >= 30 && x.Discount < 70);
                if (DiscountFilterCb.SelectedIndex == 5)
                    productSortList = productSortList.Where(x => x.Discount >= 70 && x.Discount < 100);
            }
            if (SearchTb.Text != null)
            {
                productSortList = productSortList.Where(x => x.Title.ToLower().Contains(SearchTb.Text.ToLower()) || x.Description.ToLower().Contains(SearchTb.Text.ToLower()));
            }
            ProductsWp.Children.Clear();
            foreach (var product in productSortList)
                ProductsWp.Children.Add(new ProductUserControl(product));
              
        }
        private void SortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void DiscountFilterCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new PageComponent("Добавление товара", new AddEditPage(new Product())));

        }
    }
}
