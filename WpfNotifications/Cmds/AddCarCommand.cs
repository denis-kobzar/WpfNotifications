using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfNotifications.Models;

namespace WpfNotifications.Cmds
{
    internal class AddCarCommand : CommandBase
    {
        public override bool CanExecute(object? parameter) => parameter is ObservableCollection<Car>;

        public override void Execute(object? parameter)
        {
            if (parameter is not ObservableCollection<Car> cars)
            {
                return;
            }
            var id = cars.Last().Id + 1;
            cars.Add(new Car
            {
                Id = id,
                Color = "Yellow",
                Make = "VM",
                PetName = "Birdie"
            });
        }
    }
}
