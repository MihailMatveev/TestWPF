using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using TestWPF.Data;
using TestWPF.Infastructure;

namespace TestWPF.ViewModes
{
    public class BasicViewModel:ViewModes.Base.ViewModelBase
    {
        #region Fields
        #region result

        private string force_result;
        public string Force_result
        {
            get { return force_result; }
            set
            {
                Set(ref force_result, value);
                Force_Ball = DateWork.SearchBall(force_result);
            }
        }

        private string speed_result;
        public string Speed_result
        {
            get { return speed_result; }
            set
            {
                Set(ref speed_result, value);
            }
        }

        private string endurance_result;
        public string Endurance_result
        {
            get { return endurance_result; }
            set
            {
                Set(ref endurance_result, value);
            }
        }

        #endregion
        #region Ball

        private string force_ball;
        public string Force_Ball
        {
            get { return force_ball; }
            set
            {
                Set(ref force_ball, value);
                Sum_Ball += Convert.ToInt32(value);
            }

        }

        private string speed_ball;
        public string Speed_Ball
        {
            get { return speed_ball; }
            set
            {
                Set(ref speed_ball, value);
                Sum_Ball+=Convert.ToInt32(value);
            }
        }

        private string endurance_ball;
        public string Endurance_Ball
        {
            get { return endurance_ball; }
            set
            {
                Set(ref endurance_ball, value);
                Sum_Ball += Convert.ToInt32(value);
            }
        }


        private int sum_ball;
        public int Sum_Ball
        {
            get { return sum_ball; }
            set => Set(ref sum_ball, value);
        }

        #endregion
        #endregion

        #region Command
        public ICommand CloseApplicationCommand { get; set; }

        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecute(object p) => Application.Current.Shutdown();
        #endregion
       
        public BasicViewModel()
        {
            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute);

        }
    }
}
