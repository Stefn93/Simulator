﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GridExample.Utils
{
    class GridCell : UserControl
    {
        private Rectangle rectangle;
        private object property;
        private int x;
        private int y;

        public GridCell()
        {
            rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 10;
            rectangle.Fill = new SolidColorBrush(Color.FromRgb(190,190,190));
            rectangle.Stroke = new SolidColorBrush((Colors.Transparent));
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

        public void setProp(object property)
        {
            this.property = property;
        }

        public object getProp()
        {
            return property;
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
