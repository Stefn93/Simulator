using GridExample.Utils;
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

namespace GridExample
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (grid.griglia.Children.GetType() == typeof(GridCell))
            {
                (grid.griglia).Background = new SolidColorBrush(Colors.Beige);
            }
            //(grid.griglia.Children as GridCell).Background = new SolidColorBrush(Colors.Chocolate);
        }
    }
}
