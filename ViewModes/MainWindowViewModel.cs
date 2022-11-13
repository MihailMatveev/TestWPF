using FontAwesome.Sharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TestWPF.Infastructure;
using ICommand = System.Windows.Input.ICommand;

namespace TestWPF.ViewModes
{
    public class MainWindowViewModel:ViewModes.Base.ViewModelBase
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

    

        public MainWindowViewModel(Action<object> execute)
        {
            this.execute = execute;
            this.canExecute = null;
        }


        public MainWindowViewModel(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

       


        private string _caption;
        private IconChar _icon;

        public IconChar Icon { get { return _icon; } set => Set(ref _icon, value); }
        public string Caption { get { return _caption; } set => Set(ref _caption, value); }



    }
}
