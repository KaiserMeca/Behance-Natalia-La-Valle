using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Behance_Natalia_La_Valle.ViewModel
{
    
    public class ClassView : INotifyPropertyChanged
    {
        public void MoveRectangle(Button button)
        {
            if (button.Name == "BtnLanzamientos")
            {
                ValueCanvasRight = 232;
            }
            if (button.Name == "BtnHablemos")
            {
                ValueCanvasRight = 122;
            }
            if (button.Name == "BtnPortfolio")
            {
                ValueCanvasRight = 348;
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChange(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public double valueCanvasRight;
        public double ValueCanvasRight
        {
            get
            {
                return valueCanvasRight;
            }
            set
            {
                valueCanvasRight = value;
                OnPropertyChange("Move");
            }
        }
        public double Move
        {
            get { return valueCanvasRight; }
        }
    }
}
