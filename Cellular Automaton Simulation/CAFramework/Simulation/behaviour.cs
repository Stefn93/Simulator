using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CASimulation.CAFramework.WorldModel;

namespace CASimulation.CAFramework.Simulation
{
    public interface Behaviour<CellType>
    {
        void calculateGrid(World<CellType> grid);
    }
}
