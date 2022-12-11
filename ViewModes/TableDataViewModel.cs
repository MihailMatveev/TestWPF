using System;
using System.Collections.Generic;
using System.Text;
using TestWPF.Data;
using TestWPF.Models;

namespace TestWPF.ViewModes
{
    public class TableDataViewModel:ViewModes.Base.ViewModelBase
    {

        // List<Name_Exercises> name_Exercises = DateWork.SearchName_Exercises();

        //private List<BallResultExercises> number_1 = DateWork.SearchBallExercises("№1");
        //private List<BallResultExercises> number_2 = DateWork.SearchBallExercises("№2");
        //private List<BallResultExercises> number_4 = DateWork.SearchBallExercises("№4");
        //private List<BallResultExercises> number_5 = DateWork.SearchBallExercises("№5");
        //private List<BallResultExercises> number_6 = DateWork.SearchBallExercises("№6");
        //private List<BallResultExercises> number_7 = DateWork.SearchBallExercises("№7");
        //private List<BallResultExercises> number_8_1 = DateWork.SearchBallExercises("№8(1)");
        //private List<BallResultExercises> number_8_2 = DateWork.SearchBallExercises("№8(2)");
        //private List<BallResultExercises> number_9 = DateWork.SearchBallExercises("№9");
        //private List<BallResultExercises> number_10 = DateWork.SearchBallExercises("№10");
        //private List<BallResultExercises> number_11_1 = DateWork.SearchBallExercises("№11(1)");
        //private List<BallResultExercises> number_11_2 = DateWork.SearchBallExercises("№11(2)");
        //private List<BallResultExercises> number_12_1 = DateWork.SearchBallExercises("№12(1)");
        //private List<BallResultExercises> number_12_2 = DateWork.SearchBallExercises("№12(2)");
        //private List<BallResultExercises> number_13_1 = DateWork.SearchBallExercises("№13(1)");
        //private List<BallResultExercises> number_13_2 = DateWork.SearchBallExercises("№13(2)");

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
