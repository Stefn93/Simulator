using CASimulation.CAFramework.WorldModel;
using Simulation.CellGUI;

namespace CASimulation.CAFramework.GUI
{
    public interface WorldGUI
    {
        CellGraphic getCell(Coordinates coord);
    }
}