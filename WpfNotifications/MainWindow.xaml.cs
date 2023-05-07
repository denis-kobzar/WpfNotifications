using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfNotifications.Cmds;
using System.Windows.Input;

namespace WpfNotifications
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IList<Car> _cars = new ObservableCollection<Car>();
        private ICommand _changeColorCommand = null;
        private ICommand _addCarCommand = null;

        public ICommand ChangeColorCmd => _changeColorCommand ??= new ChangeColorCornmand();
        public ICommand AddCarCmd => _addCarCommand ??= new AddCarCommand();

        public MainWindow()
        {
            InitializeComponent();
            _cars.Add(new Car()
            {
                Id = 1,
                Color = "Blue",
                Make = "Chevy",
                PetName = "Kit",
                IsChanged = false
            });
            _cars.Add(new Car()
            {
                Id = 2,
                Color = "Red",
                Make = "Ford",
                PetName = "Red Rider",
                IsChanged = false
            });

            cboCars.ItemsSource = _cars;
        }

        

        private void btnAddCar_Click(object sender, RoutedEventArgs e)
        {
            var id = _cars.Last() == null ? 1 : _cars.Last().Id + 1;
            _cars.Add(new Car
            {
                Id = id,
                Color = "Yellow",
                Make = "VM",
                PetName = "Birdie"
            });
        }
    }
}
