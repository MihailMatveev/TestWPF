using System.Windows;
using System.Windows.Input;
using TestWPF.Infastructure;

namespace TestWPF.ViewModes
{
    public class MainWindowViewModel:ViewModes.Base.ViewModelBase
    { 


        #region Command
        public ICommand CloseApplicationCommand { get; set; }

        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecute(object p)=> Application.Current.Shutdown();   
        #endregion


        private void InitialCommand()
        {
             CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute);
        }


       public MainWindowViewModel()
        {
            InitialCommand();
        }

    }
}
