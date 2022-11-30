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




        private Page basic;
        public Page Basic
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
        public ICommand ShowHomeView { get; set; }
        private bool CanShowHomeView(object arg)=>true;
        private void OnShowHaomeView(object obj)
        {
            basic=new BasicView();
        }

        public ICommand ShowSettingsView { get; set; }
        private bool CanShowSettingsView(object arg) => true;
        private void OnShowSettingsView(object obj)
        {
            basic = new PersonalDataView();
        }

        #endregion
        #endregion


        private void InitialCommand()
        {
            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute);
            ShowHomeView = new LamdaCommand(OnShowHaomeView, CanShowHomeView);
            ShowSettingsView = new LamdaCommand(OnShowSettingsView, CanShowSettingsView);
            OnShowHaomeView(null);
        }

       

        public MainWindowViewModel()
        {
            InitialCommand();
        }

    }
}
