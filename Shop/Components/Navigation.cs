using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Shop.Pages;

namespace Shop.Components
{
    public class Navigation
    {
        private static List<PageComponent> components = new List<PageComponent>();//храним историю
        public static MainWindow mainWindow;//получаем доступ ко всем элементам
        private static void Update(PageComponent pageComponent)//принимает компонент к-й мы хотим открыть
        {
            mainWindow.TitleTb.Text = pageComponent.Title;//записывает заголок
            mainWindow.MainFrame.Navigate(pageComponent.Page);//открываем страницу
        }
        public static void NextPage(PageComponent pageComponent)
        {
            components.Add(pageComponent);//добавление нового окна
            Update(pageComponent);
        }

    }
    public class PageComponent  //хранит заголовок и страницу
    {
        public string Title { get; set; }
        public Page Page { get; set; }
        public PageComponent(string title, Page page)
        {
            Page = page;
            Title = title;
        }
    }
}
