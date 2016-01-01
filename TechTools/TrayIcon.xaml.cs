using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hardcodet.Wpf.TaskbarNotification;

// http://www.codeproject.com/Articles/36468/WPF-NotifyIcon
// https://www.iconfinder.com/iconsets/technology-and-hardware-2

namespace TechTools
{
    public partial class TrayIcon
    {
        public TaskbarIcon tb;

        private void GetTrayIconResource()
        {
            tb = (TaskbarIcon)App.Current.FindResource("MyNotifyIcon");
        }

        private void MenuItem_CloseClick(object sender, System.Windows.RoutedEventArgs e)
        {
            App.Current.Shutdown();    
        }

        private void MenuItem_OneClick(object sender, System.Windows.RoutedEventArgs e)
        {
            GetTrayIconResource();
            tb.ShowBalloonTip("One", "You picked one", BalloonIcon.Info);
        }

        private void MenuItem_TwoClick(object sender, System.Windows.RoutedEventArgs e)
        {
            GetTrayIconResource();
            tb.ShowBalloonTip("Two", "You picked two", BalloonIcon.Info);
        }


    }


}