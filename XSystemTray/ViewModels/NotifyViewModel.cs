using System.Windows.Forms;
using System.Windows.Input;
using XSystemTray.Commands;

namespace XSystemTray.ViewModels
{
    public class NotifyViewModel : ViewModelBase
    {
        public ICommand NotifyCommand { get; }

        public NotifyViewModel(NotifyIcon notifyIcon)
        {
            NotifyCommand = new NotifyCommand(notifyIcon);
        }
    }
}
