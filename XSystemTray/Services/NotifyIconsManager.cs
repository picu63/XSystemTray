using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace XSystemTray.Services
{
    public class IconExplorerService
    {
        public IDictionary<NotifyIcon, Window> IconWindowAssociation { get; } = new Dictionary<NotifyIcon, Window>();

        public void AddExplorerNotifyIcon(string name, Icon icon, string path)
        {
            var notifyIcon = new NotifyIcon
            {
                Icon = icon,
                Visible = true,
                Text = name
            };
            notifyIcon.Click += NotifyIconOnClick;
            IconWindowAssociation.Add(notifyIcon, new ExplorerWindow(path));
        }

        private void NotifyIconOnClick(object? sender, EventArgs e)
        {
            var window = IconWindowAssociation[(NotifyIcon)sender];
            if (window.IsVisible)
                window.Hide();
            else
                window.Show();
        }
    }
}
