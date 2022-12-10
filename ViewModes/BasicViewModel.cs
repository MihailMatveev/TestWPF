using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using TestWPF.Data;
using TestWPF.Infastructure;
using TestWPF.Models;

namespace TestWPF.ViewModes
{
    public class BasicViewModel:ViewModes.Base.ViewModelBase
    {
        private List<Name_Exercises> _Force =NameAndNumberExercisesbyqualities.ForceExercisesNameAndNumber;

        public List<Name_Exercises> Force
        {
            get { return _Force; }
            set
            {
                Set(ref _Force, value);
            } 
               
        }

        private List<Name_Exercises> _Speed = NameAndNumberExercisesbyqualities.SpeedExercisesNameAndNumber;

        public List<Name_Exercises> Speed
        {
            get { return _Speed; }
            set
            {
                Set(ref _Speed, value);
            }

        }

        private List<Name_Exercises> _Endurance = NameAndNumberExercisesbyqualities.EnduranceExercisesNameAndNumber;

        public List<Name_Exercises> Endurance
        {
            get { return _Endurance; }
            set
            {
                Set(ref _Endurance, value);
            }

        }

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
                Speed_Ball = DateWork.SearchBall(speed_result);
            }
        }

        private string endurance_result;
        public string Endurance_result
        {
            get { return endurance_result; }
            set
            {
                Set(ref endurance_result, value);
                Endurance_Ball = DateWork.SearchBall(endurance_result);
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

        #region Commands
        public ICommand CloseApplicationCommand { get; set; }

        private void OnCloseApplicationCommandExecute(object p) => Application.Current.Shutdown();
        #endregion
       
        public BasicViewModel()
        {
            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecute);
        }
    }
}
