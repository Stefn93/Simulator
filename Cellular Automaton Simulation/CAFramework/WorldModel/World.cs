using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASimulation.CAFramework.WorldModel
{
    public interface World<T>
    {
        void nextState();
        Cell<T> getCell(Coordinates coord);
        void randomize();
        void reset();
        int getGeneration();
        void setGeneration(int generation);
        WorldDimension getDimension();
    }
}
