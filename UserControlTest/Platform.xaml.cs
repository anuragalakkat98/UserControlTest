using Microsoft.UI.Xaml.Controls;

namespace UserControlTest
{
    public sealed partial class Platform : UserControl
    {
        public Platform()
        {
            this.InitializeComponent();
            this.DataContext = new PlatformViewModel();
        }
    }
}


