using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Legacy__solution_refactored;

namespace Legacy.Solution.Refactored.Test
{
    public class FakeTempSensor : ITempSensor
    {
        public int Temp { get; set; }
        public bool SelfTest { get; set; }

        public FakeTempSensor()
        {
            Temp = 0;
        }
        
        public int GetTemp()
        {
            return Temp;
        }

        public bool RunSelfTest()
        {
            return SelfTest;
        }
    }
}
