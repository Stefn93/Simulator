using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASimulation.CAFramework.WorldModel
{
    public class SimpleCell<T> : Cell<T>
    {
        private T value;
        private T revaluatedValue;

        public T getValue()
        {
            return value; ;
        }

        public void setValue(T value)
        {
            this.value = value;
        }

        public void confirmRevaluation()
        {
            if (!value.Equals(revaluatedValue))
            {
                revaluated = true;
                value = revaluatedValue;
                revaluatedValue = default(T);
            }
        }

        public void revaluateCell(T value)
        {

            revaluated = false;
            this.revaluatedValue = value;
        }

        public bool isRevaluated()
        {
            return revaluated;
        }

        private bool revaluated = false;
    }
}
