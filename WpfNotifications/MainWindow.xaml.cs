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
using WpfNotifications.Models;

namespace WpfNotifications
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly IList<Car> _cars = new List<Car>();
        public MainWindow()
        {
            InitializeComponent();
            _cars.Add(new Car()
            {
                Id = 1,
                Color = "Blue",
                Make = "Chevy",
                PetName = "Kit"
            });
            _cars.Add(new Car()
            {
                Id = 2,
                Color = "Red",
                Make = "Ford",
                PetName = "Red Rider"
            });

            cboCars.ItemsSource = _cars;
        }
    }
}
