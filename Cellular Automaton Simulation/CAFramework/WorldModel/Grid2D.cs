using CASimulation.CAFramework.Simulation;
using CASimulation.CAFramework.WorldModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASimulation.CAFramework.WorldModel
{
    public abstract class Grid2D<T> : World<T>
    {
        private Cell<T>[,] grid;
        protected GridDimension dimensions = new GridDimension();
        private Behaviour<T> behaviour;
        private int generation;


        public Grid2D(int height, int lenght, Behaviour<T> behaviour) {
            dimensions.setHeight(height);
            dimensions.setLength(lenght);
            this.behaviour = behaviour;
            this.grid = new Cell<T>[height, lenght];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < lenght; x++)
                {
                    grid[y, x] = createNewCell();
                }
            }
        }


        public Cell<T> getCell(Coordinates coord)
        {
            Coordinates2D c = (Coordinates2D) coord;
            int x = c.getX();
            int y = c.getY();
            if (x < 0 || y < 0 || x >= dimensions.getLength() || y >= dimensions.getHeight())
                return null;
            return grid[c.getX(), c.getY()];
        }
       
        public WorldDimension getDimension()
        {
            return dimensions;
        }

        public int getGeneration()
        {
            return generation;
        }

        public void nextState()
        {
            behaviour.calculateGrid(this);   
        }

        public void setGeneration(int generation)
        {
            this.generation = generation;
        }

        public abstract Cell<T> createNewCell();
        public abstract void randomize();
        public abstract void reset();
    }
}
