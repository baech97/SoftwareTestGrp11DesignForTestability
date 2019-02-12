using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Legacy__solution_refactored;

namespace Legacy.Solution.Refactored.Test
{
    public class FakeHeater : IHeater
    {
        public bool RunSelfTest()
        {
            return true;
        }

        public void TurnOff()
        {
            Console.WriteLine("Heater is turned off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Heater is turned on");
        }
    }
}
