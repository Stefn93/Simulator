using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASimulation.CAFramework.WorldModel
{
    public class Coordinates2D : Coordinates
    {
        private int x;
        private int y;

        public Coordinates2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int[] getCoordinates()
        {
            return new int[] { x, y };
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
    }
}
