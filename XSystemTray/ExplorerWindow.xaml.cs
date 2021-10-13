using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XSystemTray
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ExplorerWindow : Window
    {
        public ExplorerWindow()
        {
            InitializeComponent();
            this.Top = SystemParameters.WorkArea.Height - Application.Current.MainWindow.Height;
            this.Left = SystemParameters.WorkArea.Width - Application.Current.MainWindow.Width;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
