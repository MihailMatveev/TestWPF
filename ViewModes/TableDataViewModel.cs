using System;
using System.Collections.Generic;
using System.Text;
using TestWPF.Data;
using TestWPF.Models;

namespace TestWPF.ViewModes
{
    public class TableDataViewModel:ViewModes.Base.ViewModelBase
    {
        private List<BallResultExercises> _BallAndResultTableExercises;
        public List<BallResultExercises> BallAndResultTableExercises
        {
            get { return _BallAndResultTableExercises; }
            set
            {
                Set(ref _BallAndResultTableExercises, value);
            }
        }


        public TableDataViewModel()
        {
            _BallAndResultTableExercises=DateWork.SearchBallExercises();
        }
    }
}
