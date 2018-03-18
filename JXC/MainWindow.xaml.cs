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

namespace JXC
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void kccx_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            kccx win = new kccx();
            win.Show();
            win.Focus();
        }

        private void bt_about_Click(object sender, RoutedEventArgs e)
        {
            about win = new about();
            win.Show();
        }
    }
}
