using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Legacy__solution_refactored;

namespace Legacy.Solution.Refactored.Test
{
    class FakeTempSensor : ITempSensor
    {
        public int gen;

        public int GetTemp()
        {
            return gen;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
