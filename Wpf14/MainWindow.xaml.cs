using System.Collections.ObjectModel;
using System.Windows;

namespace Wpf14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Бананы",
                ProdPrice = 70,
                ProdImage = "D:/Учеба_BIM/Wpf14/Wpf14/Wpf14/Data/bananas.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Кокосы",
                ProdPrice = 130,
                ProdImage = "D:/Учеба_BIM/Wpf14/Wpf14/Wpf14/Data/cocoses.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Ананасы",
                ProdPrice = 300,
                ProdImage = "D:/Учеба_BIM/Wpf14/Wpf14/Wpf14/Data/ananases.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Пылесос",
                ProdPrice = 6000,
                ProdImage = "D:/Учеба_BIM/Wpf14/Wpf14/Wpf14/Data/pulesos.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Утюг",
                ProdPrice = 3200,
                ProdImage = "D:/Учеба_BIM/Wpf14/Wpf14/Wpf14/Data/utug.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Стиральная машина",
                ProdPrice = 38000,
                ProdImage = "D:/Учеба_BIM/Wpf14/Wpf14/Wpf14/Data/stiralka.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}
