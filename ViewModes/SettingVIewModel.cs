using System;
using System.Collections.Generic;
using System.Text;
using TestWPF.Data;
using TestWPF.Models;

namespace TestWPF.ViewModes
{
    public class SettingVIewModel:ViewModes.Base.ViewModelBase
    {
        private List<CategoryMillitary> category;

        public List<CategoryMillitary> Category
        {
            get { return category; }
            set
            {
                Set(ref category, value);
            }
        }

        public SettingVIewModel()
        {
            
        }
    }
}
