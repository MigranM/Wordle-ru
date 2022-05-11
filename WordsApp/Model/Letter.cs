using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;


namespace WordsApp.Model
{
    public partial class Letter : ObservableObject
    {
        public Letter()
        {
            backGroundColor = Colors.Black;
        }

        [ObservableProperty]
        private char value;

        [ObservableProperty]
        private Color backGroundColor;

        [ObservableProperty]
        private Color fontColor;
    }
}
