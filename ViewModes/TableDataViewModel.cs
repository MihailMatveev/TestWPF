using System;
using System.Collections.Generic;
using System.Text;
using TestWPF.Data;
using TestWPF.Models;

namespace TestWPF.ViewModes
{
    public class TableDataViewModel:ViewModes.Base.ViewModelBase
    {



        private List<BallResultExercises> _BallResultForce = DateWork.SearchBallExercises(ExercisesName.Force);
        public List<BallResultExercises> BallResultForce
        {
            get { return _BallResultForce; }
            set
            {
                Set(ref _BallResultForce, value);
            }
        }

       

    }
}
