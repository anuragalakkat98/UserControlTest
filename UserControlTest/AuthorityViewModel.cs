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
    public class AuthorityViewModel
    {
        // Visibility of the entire user control "Authority Area E1"
        private Visibility _authorityAreaE1Visibility = Visibility.Collapsed;
        public Visibility AuthorityAreaE1Visibility
        {
            get => _authorityAreaE1Visibility;
            set => SetProperty(ref _authorityAreaE1Visibility, value);
        }

        // Visibility of the entire user control "Authority Set Area"
        private Visibility _authoritySetAreaVisibility = Visibility.Collapsed;
        public Visibility AuthoritySetAreaVisibility
        {
            get => _authoritySetAreaVisibility;
            set => SetProperty(ref _authoritySetAreaVisibility, value);
        }

        // Visibility of the entire user control "Authority Status"
        private Visibility _authorityStatusVisibility = Visibility.Collapsed;
        public Visibility AuthorityStatusVisibility
        {
            get => _authorityStatusVisibility;
            set => SetProperty(ref _authorityStatusVisibility, value);
        }

        // Visibility of the entire user control "System stop"
        private Visibility _systemStopVisibility = Visibility.Collapsed;
        public Visibility SystemStopVisibility
        {
            get => _systemStopVisibility;
            set => SetProperty(ref _systemStopVisibility, value);
        }

        // Visibility of the entire user control "ARS Button"
        private Visibility _arsButtonVisibility = Visibility.Collapsed;
        public Visibility ArsButtonVisibility
        {
            get => _arsButtonVisibility;
            set => SetProperty(ref _arsButtonVisibility, value);
        }

        // Visibility of the entire user control "TSR Confirmation"
        private Visibility _tsrConfirmationVisibility = Visibility.Collapsed;
        public Visibility TsrConfirmationVisibility
        {
            get => _tsrConfirmationVisibility;
            set => SetProperty(ref _tsrConfirmationVisibility, value);
        }

        // Visibility of the entire user control "Low Adhersion"
        private Visibility _lowAdhersionVisibility = Visibility.Collapsed;
        public Visibility LowAdhersionVisibility
        {
            get => _lowAdhersionVisibility;
            set => SetProperty(ref _lowAdhersionVisibility, value);
        }

        // Visibility of the entire user control "FEPHS Button"
        private Visibility _fephsVisibility = Visibility.Visible;
        public Visibility FephsVisibility
        {
            get => _fephsVisibility;
            set => SetProperty(ref _fephsVisibility, value);
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
