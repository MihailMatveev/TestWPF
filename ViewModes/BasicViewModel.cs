using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using TestWPF.Infastructure;

namespace TestWPF.ViewModes
{
    public class BasicViewModel:ViewModes.Base.ViewModelBase
    {
        public ICommand CloseApplicationCommand { get; set; }

        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecute(object p) => Application.Current.Shutdown();
        public BasicViewModel()
        {
            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute);
        }
    }
}
