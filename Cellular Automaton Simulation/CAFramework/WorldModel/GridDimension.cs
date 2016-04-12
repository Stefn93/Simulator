using CASimulation.CAFramework.WorldModel;

namespace CASimulation.CAFramework.WorldModel
{
    public class GridDimension : WorldDimension
    {
        private int cellSize;
        private int gridSize;
        private int halfGridSize;

        public int getCellSize()
        {
            return cellSize;
        }

        public int getGridSize()
        {
            return gridSize;
        }

        public int getHalfGridSize()
        {
            return halfGridSize;
        }

        public void setGridSize(int gridSize)
        {
            this.gridSize = gridSize;
            cellSize = gridSize - 1;
            halfGridSize = gridSize / 2;

            if (gridSize < 3)
            {
                cellSize = gridSize;
            }
            if (gridSize < 1)
            {
                this.gridSize = 1;
            }
            if (halfGridSize < 1)
            {
                halfGridSize = 1;
            }
        }
    }
}