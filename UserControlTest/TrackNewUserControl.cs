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
    class TrackNewUserControl
    {
        // Visibility of the user control "TRACK BERTH DOWN"
        private Visibility _trackBerthDownVisibility = Visibility.Collapsed;
        public Visibility TrackBerthDownVisibility
        {
            get => _trackBerthDownVisibility;
            set => SetProperty(ref _trackBerthDownVisibility, value);
        }

        // Visibility of the user control "TRACK BERTH UP"
        private Visibility _trackBerthUpVisibility = Visibility.Collapsed;
        public Visibility TrackBerthUpVisibility
        {
            get => _trackBerthUpVisibility;
            set => SetProperty(ref _trackBerthUpVisibility, value);
        }

        // Visibility of the user control "TRACK DIAMOND LEFT"
        private Visibility _trackDiamondLeftVisibility = Visibility.Collapsed;
        public Visibility TrackDiamondLeftVisibility
        {
            get => _trackDiamondLeftVisibility;
            set => SetProperty(ref _trackDiamondLeftVisibility, value);
        }

        // Visibility of the user control "TRACK DIAMOND RIGHT"
        private Visibility _trackDiamondRightVisibility = Visibility.Collapsed;
        public Visibility TrackDiamondRightVisibility
        {
            get => _trackDiamondRightVisibility;
            set => SetProperty(ref _trackDiamondRightVisibility, value);
        }

        // Visibility of the user control "TRACK DIAMOND CENTER DOWN"
        private Visibility _trackDiamondCenterDownVisibility = Visibility.Collapsed;
        public Visibility TrackDiamondCenterDownVisibility
        {
            get => _trackDiamondCenterDownVisibility;
            set => SetProperty(ref _trackDiamondCenterDownVisibility, value);
        }

        // Visibility of the user control "TRACK DIAMOND CENTER UP"
        private Visibility _trackDiamondCenterUpVisibility = Visibility.Collapsed;
        public Visibility TrackDiamondCenterUpVisibility
        {
            get => _trackDiamondCenterUpVisibility;
            set => SetProperty(ref _trackDiamondCenterUpVisibility, value);
        }

        // Visibility of below controls
        // Track Diamond Down-Up
        // Track Diamond Down-Down
        private Visibility _trackDiamondDownControlsVisibility = Visibility.Collapsed;
        public Visibility TrackDiamondDownControlsVisibility
        {
            get => _trackDiamondDownControlsVisibility;
            set => SetProperty(ref _trackDiamondDownControlsVisibility, value);
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

        // Visibility of the user control "TRACK LEG LEFT UP"
        private Visibility _trackLegLeftUpVisibility = Visibility.Collapsed;
        public Visibility TrackLegLeftUpVisibility
        {
            get => _trackLegLeftUpVisibility;
            set => SetProperty(ref _trackLegLeftUpVisibility, value);
        }

        // Visibility of the user control "TRACK LEG LEFT DOWN"
        private Visibility _trackLegLeftDownVisibility = Visibility.Collapsed;
        public Visibility TrackLegLeftDownVisibility
        {
            get => _trackLegLeftDownVisibility;
            set => SetProperty(ref _trackLegLeftDownVisibility, value);
        }

        // Visibility of the user control "TRACK LEG RIGHT UP"
        private Visibility _trackLegRightUpVisibility = Visibility.Collapsed;
        public Visibility TrackLegRightUpVisibility
        {
            get => _trackLegRightUpVisibility;
            set => SetProperty(ref _trackLegRightUpVisibility, value);
        }

        // Visibility of the user control "TRACK LEG RIGHT DOWN"
        private Visibility _trackLegRightDownVisibility = Visibility.Collapsed;
        public Visibility TrackLegRightDownVisibility
        {
            get => _trackLegRightDownVisibility;
            set => SetProperty(ref _trackLegRightDownVisibility, value);
        }

        // Visibility of the user control "TRACK BERTH DOWN NO OVERLAP"
        private Visibility _trackBerthDownNoOverlapVisibility = Visibility.Collapsed;
        public Visibility TrackBerthDownNoOverlapVisibility
        {
            get => _trackBerthDownNoOverlapVisibility;
            set => SetProperty(ref _trackBerthDownNoOverlapVisibility, value);
        }

        // Visibility of the user control "TRACK BERTH DOWN NO ROUTE"
        private Visibility _trackBerthDownNoRouteVisibility = Visibility.Collapsed;
        public Visibility TrackBerthDownNoRouteVisibility
        {
            get => _trackBerthDownNoRouteVisibility;
            set => SetProperty(ref _trackBerthDownNoRouteVisibility, value);
        }

        // Visibility of the user control "TRACK BERTH UP NO OVERLAP"
        private Visibility _trackBerthUpNoOverlapVisibility = Visibility.Collapsed;
        public Visibility TrackBerthUpNoOverlapVisibility
        {
            get => _trackBerthUpNoOverlapVisibility;
            set => SetProperty(ref _trackBerthUpNoOverlapVisibility, value);
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
