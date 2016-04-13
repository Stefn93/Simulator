using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CASimulation.CAFramework.WorldModel;

namespace CASimulation.CAFramework.Simulation
{
    abstract class SimulationThread<CellType>
    {
        protected World<CellType> world;
        protected Behaviour<CellType> behaviour;
        protected Thread thread;

        public SimulationThread(World<CellType> world, Behaviour<CellType> behaviour)  {
            this.world = world;
            this.behaviour = behaviour;
        }

        protected void incrementGeneration()
        {
            world.setGeneration(world.getGeneration() + 1);
            world.nextState();
        }

        public World<CellType> getWorld()
        {
            return world;
        }

        public abstract void Run();

        public void start()
        {
            thread = new Thread(Run);
            thread.Start();
        }
    }
}
