using Microsoft.UI.Xaml;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UserControlTest
{
    class SingleTrainViewModel
    {
        // Canvas Width Property
        private double _canvasWidth = 600;
        public double CanvasWidth
        {
            get => _canvasWidth;
            set => SetProperty(ref _canvasWidth, value);
        }

        // Canvas Height Property
        private double _canvasHeight = 400;
        public double CanvasHeight
        {
            get => _canvasHeight;
            set => SetProperty(ref _canvasHeight, value);
        }

        //Visibility of the right bigger circle
        private Visibility _rightBiggerCircleElementVisibility = Visibility.Collapsed;
        public Visibility RightBiggerCircleElementVisibility
        {
            get => _rightBiggerCircleElementVisibility;
            set => SetProperty(ref _rightBiggerCircleElementVisibility, value);
        }

        //Visibility of the left bigger circle
        private Visibility _leftBiggerCircleElementVisibility = Visibility.Collapsed;
        public Visibility LeftBiggerCircleElementVisibility
        {
            get => _leftBiggerCircleElementVisibility;
            set => SetProperty(ref _leftBiggerCircleElementVisibility, value);
        }

        //Visibility of the right bottom smaller circle
        private Visibility _rightBottomSmallerCircleElementVisibility = Visibility.Collapsed;
        public Visibility RightBottomSmallerCircleElementVisibility
        {
            get => _rightBottomSmallerCircleElementVisibility;
            set => SetProperty(ref _rightBottomSmallerCircleElementVisibility, value);
        }

        //Visibility of the left bottom smaller circle
        private Visibility _leftBottomSmallerCircleElementVisibility = Visibility.Collapsed;
        public Visibility LeftBottomSmallerCircleElementVisibility
        {
            get => _leftBottomSmallerCircleElementVisibility;
            set => SetProperty(ref _leftBottomSmallerCircleElementVisibility, value);
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
