using CASimulation.CAFramework.WorldModel;
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

namespace Simulation.CellGUI
{
    /// <summary>
    /// Logica di interazione per GridCell.xaml
    /// </summary>
    public partial class GridCell : UserControl
    {
        private Rectangle rectangle;
        private int x;
        private int y;

        public GridCell()
        {
            InitializeComponent();
            rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 10;
            rectangle.Fill = new SolidColorBrush(Color.FromRgb(190, 190, 190));
            rectangle.Stroke = new SolidColorBrush(Colors.Transparent);
            rectangle.StrokeThickness = 2;
            rectangle.RadiusX = 2;
            rectangle.RadiusY = 2;
        }

        public int getX()
        {
            return x;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public int getY()
        {
            return y;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public Rectangle getRectangle()
        {
            return rectangle;
        }

        public void setRectangle(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }

    }
}
