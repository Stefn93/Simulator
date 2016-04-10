using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GridExample.Utils
{
    class GridCell : Border
    {
        private object property;
        private int x;
        private int y;

        public GridCell()
        {
            this.Width = 10;
            this.Height = 10;
            this.BorderBrush = new SolidColorBrush((Colors.AntiqueWhite));
            this.Background = new SolidColorBrush((Colors.Black));
            this.BorderThickness = new Thickness(0.8);
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

        public void setProp(object property)
        {
            this.property = property;
        }

        public object getProp()
        {
            return property;
        }
        
    }
}
