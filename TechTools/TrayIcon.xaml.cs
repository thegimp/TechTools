using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hardcodet.Wpf.TaskbarNotification;
using System.IO;
using System.Windows.Controls;

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

        private void MenuItem_FilesClick(object sender, System.Windows.RoutedEventArgs e)
        {
            GetTrayIconResource();
            var filename = (sender as MenuItem).Header;
            System.Diagnostics.Process.Start(filename.ToString());
        }

        private void ContextSubMenu_FilesOpened(object sender, System.Windows.RoutedEventArgs e)
        {
            GetTrayIconResource();
            MenuItem parent = sender as MenuItem;
            parent.Items.Clear();

            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.REG");
            foreach (string file in files)
            {
                MenuItem item = new MenuItem();
                item.Header = System.IO.Path.GetFileName(file);
                //item.Icon = TechTools.Properties.Resources.TrayIcon;
                item.Click += MenuItem_FilesClick;
                parent.Items.Add(item);
            }
        }

    }


}