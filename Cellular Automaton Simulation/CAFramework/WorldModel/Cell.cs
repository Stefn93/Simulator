using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASimulation.CAFramework.WorldModel
{
    public interface Cell<CellType>
    {
        CellType getValue();
        void setValue(CellType value);
        void revaluateCell(CellType value);
        void confirmRevaluation();
        bool isRevaluated();
    }
}
