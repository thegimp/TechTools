using Hardcodet.Wpf.TaskbarNotification;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TechTools
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private TaskbarIcon tb;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            tb = (TaskbarIcon)FindResource("MyNotifyIcon");                       
            tb.Icon = TechTools.Properties.Resources.TrayIcon;
        }

        protected override void OnExit(ExitEventArgs e)
        {
            tb.Visibility = Visibility.Hidden;
            tb.Dispose(); //the icon would clean up automatically, but this is cleaner
            base.OnExit(e);
        }

    }
}
