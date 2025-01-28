using Microsoft.UI.Xaml;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Windows.System;

namespace UserControlTest
{
    class LevelCrossingViewModel
    {
        // Canvas Width Property
        private double _canvasWidth = 150;
        public double CanvasWidth
        {
            get => _canvasWidth;
            set => SetProperty(ref _canvasWidth, value);
        }

        // Canvas Height Property
        private double _canvasHeight = 120;
        public double CanvasHeight
        {
            get => _canvasHeight;
            set => SetProperty(ref _canvasHeight, value);
        }

        // Visibility of the entire user control "Level Crossing Pedestrian Crossing on Track"
        private Visibility _pedestrianCrossingOnTrackVisibility = Visibility.Collapsed;
        public Visibility PedestrianCrossingOnTrackVisibility
        {
            get => _pedestrianCrossingOnTrackVisibility;
            set => SetProperty(ref _pedestrianCrossingOnTrackVisibility, value);
        }

        // Visibility of the entire user control "Level Crossing Road Crossing On Track"
        private Visibility _roadCrossingOnTrackVisibility = Visibility.Collapsed;
        public Visibility RoadCrossingOnTrackVisibility
        {
            get => _roadCrossingOnTrackVisibility;
            set => SetProperty(ref _roadCrossingOnTrackVisibility, value);
        }

        //Visibility of the entire user control "Level Crossing Pedestrian Crossing Head"
        private Visibility _pedestrianCrossingHeadVisibility = Visibility.Collapsed;
        public Visibility PedestrianCrossingHeadVisibility
        {
            get => _pedestrianCrossingHeadVisibility;
            set => SetProperty(ref _pedestrianCrossingHeadVisibility, value);
        }

        //Visibility of the entire user control "Level Crossing Pedestrian Crossing Tail"
        private Visibility _pedestrianCrossingTailVisibility = Visibility.Collapsed;
        public Visibility PedestrianCrossingTailVisibility
        {
            get => _pedestrianCrossingTailVisibility;
            set => SetProperty(ref _pedestrianCrossingTailVisibility, value);
        }

        //Visibility of the entire user control "Level Crossing Head"
        private Visibility _levelCrossingHeadVisibility = Visibility.Collapsed;
        public Visibility LevelCrossingHeadVisibility
        {
            get => _levelCrossingHeadVisibility;
            set => SetProperty(ref _levelCrossingHeadVisibility, value);
        }

        //Visibility of the entire user control "Level Crossing Body"
        private Visibility _levelCrossingBodyVisibility = Visibility.Collapsed;
        public Visibility LevelCrossingBodyVisibility
        {
            get => _levelCrossingBodyVisibility;
            set => SetProperty(ref _levelCrossingBodyVisibility, value);
        }

        //Visibility of the entire user control "Level Crossing Tail"
        private Visibility _levelCrossingTailVisibility = Visibility.Collapsed;
        public Visibility LevelCrossingTailVisibility
        {
            get => _levelCrossingTailVisibility;
            set => SetProperty(ref _levelCrossingTailVisibility, value);
        }

        //Visibility of the entire user control "Level Crossing Pedestrian Crossing Body"
        private Visibility _levelCrossingPedestrianCrossingBodyVisibility = Visibility.Collapsed;
        public Visibility LevelCrossingPedestrianCrossingBodyVisibility
        {
            get => _levelCrossingPedestrianCrossingBodyVisibility;
            set => SetProperty(ref _levelCrossingPedestrianCrossingBodyVisibility, value);
        }

        //Visibility of the element of user control "Level Crossing Pedestrian Crossing Body"
        private Visibility _levelCrossingPedestrianCrossingBodyElementVisibility = Visibility.Collapsed;
        public Visibility LevelCrossingPedestrianCrossingBodyElementVisibility
        {
            get => _levelCrossingPedestrianCrossingBodyElementVisibility;
            set => SetProperty(ref _levelCrossingPedestrianCrossingBodyElementVisibility, value);
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
