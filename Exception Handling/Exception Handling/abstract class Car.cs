using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    abstract class Car
    {
        protected double speed;

        public double GetSpeed()
        {
            return speed;
        }

        public abstract void Breke();
        public abstract void Accelerate();
    }
}
