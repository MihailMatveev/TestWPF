using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TestWPF.Infastructure;
using TestWPF.ViewModes.Base;
using TestWPF.Views.Pages;

namespace TestWPF.ViewModes
{
    public class MainWindowViewModel:ViewModes.Base.ViewModelBase
    {




        private ViewModelBase basic;
        public ViewModelBase Basic
        {
            get =>basic;
            set
            {
                basic = value;
                Set(ref basic, value);
            }
        }

        #region Command
        #region Закрытие приложения
        public ICommand CloseApplicationCommand { get; set; }

        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecute(object p)=> Application.Current.Shutdown();
        #endregion


        #region отображение страницы
        public ICommand ShowHomeViewCommand  { get; set; }
        private bool CanShowHomeView(object arg)=>true;
        private void OnShowHomeView(object obj)
        {
            Basic=new BasicViewModel();
        }

        public ICommand ShowSettingsViewCommand { get; set; }
        private bool CanShowSettingsView(object arg) => true;
        private void OnShowSettingsView(object obj)
        {
            Basic = new PersonalDataViewModel();
        }

        #endregion
        #endregion


        private void InitialCommand()
        {
            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute);
            ShowHomeViewCommand  = new LamdaCommand(OnShowHomeView, CanShowHomeView);
            ShowSettingsViewCommand = new LamdaCommand(OnShowSettingsView, CanShowSettingsView);
            OnShowHomeView(null);
        }

       

        public MainWindowViewModel()
        {
            InitialCommand();
        }

    }
}
