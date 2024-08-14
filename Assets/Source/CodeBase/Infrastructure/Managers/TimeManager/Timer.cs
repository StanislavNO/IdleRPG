using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.CodeBase
{
    public abstract class Timer
    {
        public Timer()
        {
            
        }

        public float Time { get; protected set; }

        public abstract void Tick();
    }
}
