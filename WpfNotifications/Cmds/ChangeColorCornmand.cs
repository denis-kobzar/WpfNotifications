using System;
using WpfNotifications.Models;
using System.Windows.Input;

namespace WpfNotifications.Cmds
{
    internal class ChangeColorCornmand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object? parameter) => (parameter as Car) != null;

        public void Execute(object? parameter)
        {
            ((Car)parameter).Color = "Pink";
        }
    }
}
