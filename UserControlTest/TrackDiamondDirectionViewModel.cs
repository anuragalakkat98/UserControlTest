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
    class TrackDiamondDirectionViewModel
    {
        // Canvas Width Property
        private double _canvasWidth = 100;
        public double CanvasWidth
        {
            get => _canvasWidth;
            set => SetProperty(ref _canvasWidth, value);
        }

        // Canvas Height Property
        private double _canvasHeight = 200;
        public double CanvasHeight
        {
            get => _canvasHeight;
            set => SetProperty(ref _canvasHeight, value);
        }

        // Visibility of below controls
        // Track Diamond Down-Up
        // Track Diamond Down-Down
        private Visibility _trackDiamondDownControlsVisibility = Visibility.Visible;
        public Visibility TrackDiamondDownControlsVisibility
        {
            get => _trackDiamondDownControlsVisibility;
            set => SetProperty(ref _trackDiamondDownControlsVisibility, value);
        }

        // Visibility of the 4 polygons around the track for below controls
        // Track Diamond Down-Up
        // Track Diamond Down-Down
        private Visibility _trackDiamondDownElementVisibility = Visibility.Collapsed;
        public Visibility TrackDiamondDownElementVisibility
        {
            get => _trackDiamondDownElementVisibility;
            set => SetProperty(ref _trackDiamondDownElementVisibility, value);
        }

        // Visibility of below controls
        // Track Diamond Up-Up
        // Track Diamond Up-Down
        private Visibility _trackDiamondUpControlsVisibility = Visibility.Collapsed;
        public Visibility TrackDiamondUpControlsVisibility
        {
            get => _trackDiamondUpControlsVisibility;
            set => SetProperty(ref _trackDiamondUpControlsVisibility, value);
        }

        // Visibility of the 4 polygons around the track for below controls
        // Track Diamond Up-Up
        // Track Diamond Up-Down
        private Visibility _trackDiamondUpElementVisibility = Visibility.Collapsed;
        public Visibility TrackDiamondUpElementVisibility
        {
            get => _trackDiamondUpElementVisibility;
            set => SetProperty(ref _trackDiamondUpElementVisibility, value);
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
