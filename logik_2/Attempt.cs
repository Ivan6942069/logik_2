using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logik_2
{
    public class Attempt
    {
        public Pin[] Pins { get; internal set; }

        public Attempt()
        {
            Pins = new Pin[4];
        }

        public List<bool> Evaluate(Pin[] pattern)
        {
            List<bool> result = new List<bool>();
            bool[] flag = new bool[4];
            int i = 0;
            
            return new List<bool>();
        }
    }
}
