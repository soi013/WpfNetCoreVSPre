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

namespace WpfNetCoreVSPre
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] source = new int[] { 0, 10, 20, 30, 40, 50 };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSelectCenter_Click(object sender, RoutedEventArgs e)
        {
            tbSelected.Text = String.Join(' ', source[2..5]);
        }

        private void ButtonSelectLast_Click(object sender, RoutedEventArgs e)
        {
            tbSelected.Text = $"{source[^1]}";
        }
    }
}
