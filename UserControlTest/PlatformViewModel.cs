using Microsoft.UI.Xaml;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UserControlTest
{
    class PlatformViewModel : INotifyPropertyChanged
    {
        private string _platformUpLabelText = "No.1";
        public string PlatformUpLabelText
        {
            get => _platformUpLabelText;
            set => SetProperty(ref _platformUpLabelText, value);
        }

        private string _platformDownLabelText = "No.2";
        public string PlatformDownLabelText
        {
            get => _platformDownLabelText;
            set => SetProperty(ref _platformDownLabelText, value);
        }

        private Visibility _platformUpVisibility = Visibility.Collapsed;
        public Visibility PlatformUpVisibility
        {
            get => _platformUpVisibility;
            set => SetProperty(ref _platformUpVisibility, value);
        }

        private Visibility _platformDownVisibility = Visibility.Visible;
        public Visibility PlatformDownVisibility
        {
            get => _platformDownVisibility;
            set => SetProperty(ref _platformDownVisibility, value);
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
