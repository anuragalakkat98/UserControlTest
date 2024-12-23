using Microsoft.UI.Xaml;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UserControlTest
{
    class TrackLegDirectionViewModel
    {
        // Canvas Width Property
        private double _canvasWidth = 100;
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

        // Visibility of polygons and rectangles
        // Which are not required, collapsed to match the design with default UIC view
        private Visibility _trackLegLeftUpElementsVisibility = Visibility.Collapsed;
        public Visibility TrackLegLeftUpElementsVisibility
        {
            get => _trackLegLeftUpElementsVisibility;
            set => SetProperty(ref _trackLegLeftUpElementsVisibility, value);
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
