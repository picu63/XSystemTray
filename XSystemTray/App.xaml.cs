using System;
using System.Drawing;
using System.Windows;
using XSystemTray.Services;
using XSystemTray.ViewModels;
using Application = System.Windows.Application;
using Forms = System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace XSystemTray
{
    public partial class App : Application
    {
        private readonly Forms.NotifyIcon notifyIcon;

        public App()
        {
            notifyIcon = new Forms.NotifyIcon();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            IconExplorerService iconExplorerService = new IconExplorerService();
            iconExplorerService.AddExplorerNotifyIcon("Drive C", new System.Drawing.Icon("Resources/icon.ico"), "C:\\");
            iconExplorerService.AddExplorerNotifyIcon("Games", new System.Drawing.Icon("Resources/directory.ico"), "D:\\Games");

            base.OnStartup(e);
        }
    }
}
