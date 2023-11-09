using Microsoft.Win32;
using Shop.Base;
using Shop.Components;
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

namespace Shop.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Product product;
        public AddEditPage(Product _product)
        {
            InitializeComponent();
            product = _product;
            this.DataContext = product;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (product.Id == 0)
            {
                Product newService = App.db.Product.Add(product);
                if (App.db.Product.Any(x => x.Title == product.Title))
                    error.AppendLine("Товар с таким именем уже существует! ");

            }

            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (product.Id == 0)
            {
                App.db.Product.Add(product);
            }
            App.db.SaveChanges();
            MessageBox.Show("Сохранено!");
            Navigation.NextPage(new PageComponent("Список товаров", new Filter()));
        }

        private void EditImageBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg"
            };
            openFile.ShowDialog();
            if (openFile.FileName != null)
            {
                product.MainImage = File.ReadAllBytes(openFile.FileName);
                ImageImg.Source = new BitmapImage(new Uri(openFile.FileName));
            }

        }
    }
}
