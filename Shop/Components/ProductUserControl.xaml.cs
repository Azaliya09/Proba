using System;
using System.Collections.Generic;
using System.IO;
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
using Shop.Pages;

namespace Shop.Components
{
    /// <summary>
    /// Логика взаимодействия для ProductUserControl.xaml
    /// </summary>
    public partial class ProductUserControl : UserControl
    {
        private Product product;
       List<Product> productSortList = new List<Product>();
        public ProductUserControl(Product _product)
        {
            InitializeComponent();
            this.product = _product;
            if (App.IsAdmin == false)
            {
                EditBtn.Visibility = Visibility.Hidden;
                DeleteBtn.Visibility = Visibility.Hidden;
            }
            if (product.MainImage != null)
                ImageImg.Source = GetImage(product.MainImage);

            if(product.Discount != 0)
                BorderRec.Visibility = Visibility.Visible;
            TitleTb.Text = product.Title;
            EvolutionTb.Text = product.OverideFeedback;
            CostTb.Text = product.CostDiscount.ToString("N0") + " ₽ ";//новая цена со скидкой
            CostTimeTb.Visibility = product.CostVisibility;
            CostTimeTb.Text = product.Cost.ToString("N0");//старая цена
            App.selectedProduct = this.product;
        }
        private ImageSource GetImage(byte[] mainImage)
        {
            MemoryStream stream = new MemoryStream(mainImage);
            BitmapImage img = new BitmapImage()
            img.BeginInit();
            img.StreamSource = stream;
            img.EndInit();
            return img;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new PageComponent("Редактирование товара", new AddEditPage(product)));
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (product.Feedback.Count != 0)
            {
                MessageBox.Show("Удаление запрещено!!");
            }
            else
            {
                App.db.Product.Remove(product);
                App.db.SaveChanges();
                Navigation.NextPage(new PageComponent("Список товаров", new Filter()));

            }
        }
        private void BuyBtn_Click(object sender, RoutedEventArgs e)
        {
            productSortList.Add(product);
            MessageBox.Show("Товар добавлен в корзину!!");
        }
    }
}
