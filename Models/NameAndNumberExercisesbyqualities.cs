using System;
using System.Collections.Generic;
using System.Text;

namespace TestWPF.Models
{
    public static class NameAndNumberExercisesbyqualities
    {
        #region Force
        private static List<Name_Exercises> _ForceExercisesNameAndNumber = new List<Name_Exercises>()
        {
            new Name_Exercises() {Number="1",Name="Сгибание рагибание рук в упоре лежа" },
               new Name_Exercises() {Number="2",Name="Наклоны туловища вперед" },
               new Name_Exercises() {Number="4",Name= "Подтягивание на перекладине" },
               new Name_Exercises() {Number="5",Name= "Поднимание ног к перекладине" },
              new Name_Exercises() {Number= "6",Name= "Подъем переворотом на перекладине" },
               new Name_Exercises() {Number="7",Name= "Подъем силой на перекладине" },
                new Name_Exercises() {Number="8(1)",Name= "Жим штанги лежа,вес штанги 70 кг \n до 70 кг" },
                 new Name_Exercises() {Number="8(2)",Name= "Жим штанги лежа,вес штанги 70 кг \n свыше 70 кг" },
                 new Name_Exercises() {Number="9",Name = "Сгибание и разгибание рук в упоре на брусьях" },
                 new Name_Exercises() {Number="10",Name= "Угол в упоре на брусьях" },
                 new Name_Exercises() {Number="11(1)",Name= "Рывок гири, вес 24 кг \n до 70 кг" },
                 new Name_Exercises() {Number="11(2)",Name= "рывок гири, вес 24 кг \n свыше 70 кг" },
                 new Name_Exercises() {Number="12(1)",Name= "толчок двух гирь, вес 24 кг \n до 70 кг" },
                 new Name_Exercises() {Number="12(2)",Name= "толчок двух гирь, вес 24 кг \n свыше 70 кг" },
                 new Name_Exercises() {Number="13(1)",Name= "толчок двух гирь, вес 24 кг \n до 70 кг" },
                 new Name_Exercises() {Number="13(2)",Name= "толчок двух гирь, вес 24 кг \n свыше 70 кг" }
        };
       

        /// <summary>
        /// Название упражнений на СИЛУ. номер и название
        /// </summary>
        public static List<Name_Exercises> ForceExercisesNameAndNumber { get => _ForceExercisesNameAndNumber; }
        #endregion


        #region Speed
        private static Dictionary<string, string> _SpeedExercisesNameAndNumber = new Dictionary<string, string>()
        {
            {"40","Бег на 60 м" },
            {"41","Бег на 100 м" },
            {"42","Челночный бег 10 х 10 м" },
            {"43","Бег на 400 м" },
            {"57","Плавание на 100 м вольным стилем" },
            {"57(a)","Gлавание на 50 м вольным стилем" },
            {"58","Плавание на 100 м способом брасс" },
        };

        /// <summary>
        /// Название упражнений на БЫСТРОТУ. номер и название
        /// </summary>
        public static Dictionary<string, string> SpeedExercisesNameAndNumber { get => _SpeedExercisesNameAndNumber; }
        #endregion

        #region Endurance
        private static Dictionary<string, string> _EnduranceExercisesNameAndNumber = new Dictionary<string, string>()
        {
            {"45(1)","Бег на 1 км \n до 35 лет" },
            {"46(1)","Бег на 3 км \n до 35 лет" },
            {"45(2)","Бег на 1 км \n свыше 35 лет" },
            {"46(2)","Бег на 3 км \n свыше 35 лет" },

            {"47","Бег на 5 км" },
            {"48","Марш-бросок на 5 км"},
            {"49","Марш-бросок на 10 км" },
            {"53","Лыжная гонка на 5 км" },
        };

        /// <summary>
        /// Название упражнений на ВЫНОСЛИВОСТЬ. номер и название
        /// </summary>
        public static Dictionary<string, string> EnduranceExercisesNameAndNumber { get => _EnduranceExercisesNameAndNumber; }
        #endregion

    }
}
