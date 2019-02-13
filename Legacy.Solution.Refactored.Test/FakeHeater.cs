using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Legacy__solution_refactored;

namespace Legacy.Solution.Refactored.Test
{
    public class FakeHeater : IHeater
    {
        public bool State;
        public int TurnOffCounter = 0;
        public int TurnOnCounter = 0;
        public bool RunSelfTest()
        {
            return true;
        }

        public void TurnOff()
        {
            State = false;
            TurnOffCounter++;

        }

        public void TurnOn()
        {
            State = true;
            TurnOnCounter++;
        }


    }
}
