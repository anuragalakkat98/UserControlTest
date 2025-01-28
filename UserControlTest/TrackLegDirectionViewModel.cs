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

        // Visibility of polygons and rectangles "Track_Leg_Left_Up"
        // Which are not required, collapsed to match the design with default UIC view
        private Visibility _trackLegLeftUpElementsVisibility = Visibility.Visible;
        public Visibility TrackLegLeftUpElementsVisibility
        {
            get => _trackLegLeftUpElementsVisibility;
            set => SetProperty(ref _trackLegLeftUpElementsVisibility, value);
        }



        // Visibility of polygons and rectangles for "Track_Leg_Left_Down"
        // Which are not required, collapsed to match the design with default UIC view
        private Visibility _trackLegLeftDownElementsVisibility = Visibility.Collapsed;
        public Visibility TrackLegLeftDownElementsVisibility
        {
            get => _trackLegLeftDownElementsVisibility;
            set => SetProperty(ref _trackLegLeftDownElementsVisibility, value);
        }




        // TRACK LEG RIGHT UP: Visibility of entire user control
        // Which are not required, collapsed to match the design with default UIC view
        private Visibility _trackLegRightUpVisibility = Visibility.Collapsed;
        public Visibility TrackLegRightUpVisibility
        {
            get => _trackLegRightUpVisibility;
            set => SetProperty(ref _trackLegRightUpVisibility, value);
        }

        // TRACK LEG RIGHT UP: Visibility of polygons and rectangles
        // Which are not required, collapsed to match the design with default UIC view
        private Visibility _trackLegRightUpElementsVisibility = Visibility.Collapsed;
        public Visibility TrackLegRightUpElementsVisibility
        {
            get => _trackLegRightUpElementsVisibility;
            set => SetProperty(ref _trackLegRightUpElementsVisibility, value);
        }



        // TRACK LEG RIGHT DOWN: Visibility of entire user control
        // Which are not required, collapsed to match the design with default UIC view
        private Visibility _trackLegRightDownVisibility = Visibility.Visible;
        public Visibility TrackLegRightDownVisibility
        {
            get => _trackLegRightDownVisibility;
            set => SetProperty(ref _trackLegRightDownVisibility, value);
        }

        // TRACK LEG RIGHT DOWN: Visibility of polygons and rectangles
        // Which are not required, collapsed to match the design with default UIC view
        private Visibility _trackLegRightDownElementsVisibility = Visibility.Collapsed;
        public Visibility TrackLegRightDownElementsVisibility
        {
            get => _trackLegRightDownElementsVisibility;
            set => SetProperty(ref _trackLegRightDownElementsVisibility, value);
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
