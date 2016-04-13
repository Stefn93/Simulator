using CASimulation.CAFramework.WorldModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASimulation.CAFramework.GUI
{
    public interface Drawer<T>
    {
        void draw(WorldGUI gui, World<T> world);
    }
}
