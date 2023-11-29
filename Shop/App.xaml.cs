using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Shop.Base;

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static HardwareShop_azaliyaEntities db = new HardwareShop_azaliyaEntities();
        public static MainWindow mainWindow;

        public static Product selectedProduct;
        public static bool IsAdmin = false;
    }
}
