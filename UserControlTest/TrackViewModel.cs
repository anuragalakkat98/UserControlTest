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
    class TrackViewModel : INotifyPropertyChanged
    {
        // Width Property
        private double _controlWidth = 700;
        public double ControlWidth
        {
            get => _controlWidth;
            set => SetProperty(ref _controlWidth, value);
        }

        // Height Property
        private double _controlHeight = 400;
        public double ControlHeight
        {
            get => _controlHeight;
            set => SetProperty(ref _controlHeight, value);
        }

        // Visibility for Top Rectangle
        private Visibility _topRectangleVisibility = Visibility.Collapsed;
        public Visibility TopRectangleVisibility
        {
            get => _topRectangleVisibility;
            set => SetProperty(ref _topRectangleVisibility, value);
        }

        // Visibility for Bottom Rectangle
        private Visibility _bottomRectangleVisibility = Visibility.Collapsed;
        public Visibility BottomRectangleVisibility
        {
            get => _bottomRectangleVisibility;
            set => SetProperty(ref _bottomRectangleVisibility, value);
        }

        // Visibility for Arrows and Center Grid
        private Visibility _centerGridVisibility = Visibility.Collapsed;
        public Visibility CenterGridVisibility
        {
            get => _centerGridVisibility;
            set => SetProperty(ref _centerGridVisibility, value);
        }

        // Visibility for the lines inside the Rectangle
        private Visibility _lineVisibility = Visibility.Collapsed;
        public Visibility LineVisibility
        {
            get => _lineVisibility;
            set => SetProperty(ref _lineVisibility, value);
        }

        // Visibility for the X inside the Rectangle
        private Visibility _xSymbolVisibility = Visibility.Collapsed;
        public Visibility XSymbolVisibility
        {
            get => _xSymbolVisibility;
            set => SetProperty(ref _xSymbolVisibility, value);
        }

        // Visibility for the bottom Arrows
        private Visibility _bottomArrowsVisibility = Visibility.Collapsed;
        public Visibility BottomArrowsVisibility
        {
            get => _bottomArrowsVisibility;
            set => SetProperty(ref _bottomArrowsVisibility, value);
        }

        // Visibility for the TrackRectangleVisibility
        private Visibility _trackRectangleVisibility = Visibility.Collapsed;
        public Visibility TrackRectangleVisibility
        {
            get => _trackRectangleVisibility;
            set => SetProperty(ref _trackRectangleVisibility, value);
        }

        // Visibility for the TrackDiamondCenterUp
        private Visibility _trackDiamondCenterUpVisibility = Visibility.Collapsed;
        public Visibility TrackDiamondCenterUpVisibility
        {
            get => _trackDiamondCenterUpVisibility;
            set => SetProperty(ref _trackDiamondCenterUpVisibility, value);
        }

        // Visibility for the TrackDiamondCenterDown
        private Visibility _trackDiamondCenterDownVisibility = Visibility.Collapsed;
        public Visibility TrackDiamondCenterDownVisibility
        {
            get => _trackDiamondCenterDownVisibility;
            set => SetProperty(ref _trackDiamondCenterDownVisibility, value);
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
