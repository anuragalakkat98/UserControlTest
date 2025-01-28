using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UserControlTest
{
    class IntruderViewModel
    {

        // Canvas Width Property
        private double _canvasWidth = 100;
        public double CanvasWidth
        {
            get => _canvasWidth;
            set => SetProperty(ref _canvasWidth, value);
        }

        // Canvas Height Property
        private double _canvasHeight = 360;
        public double CanvasHeight
        {
            get => _canvasHeight;
            set => SetProperty(ref _canvasHeight, value);
        }

        // Visibility of the outer rectangle
        private Visibility _outerRectangleVisibility = Visibility.Collapsed;
        public Visibility OuterRectangleVisibility
        {
            get => _outerRectangleVisibility;
            set => SetProperty(ref _outerRectangleVisibility, value);
        }

        // Visibility of the white color filled inside the shape
        private Visibility _colorFillVisibility = Visibility.Visible;
        public Visibility ColorFillVisibility
        {
            get => _colorFillVisibility;
            set => SetProperty(ref _colorFillVisibility, value);
        }





        public event PropertyChangedEventHandler PropertyChanged;
        protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
