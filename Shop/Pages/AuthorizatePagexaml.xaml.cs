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
    /// Логика взаимодействия для AuthorizatePagexaml.xaml
    /// </summary>
    public partial class AuthorizatePagexaml : Page
    {
        public AuthorizatePagexaml()
        {
            InitializeComponent();
        }

        private void VhodBtn_Click(object sender, RoutedEventArgs e)
        {
            App.mainWindow.MainFrame.Navigate(new ProductList());
        }
    }
}
