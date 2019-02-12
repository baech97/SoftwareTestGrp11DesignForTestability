using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legacy__solution_refactored
{
    public interface IHeater
    {
        void TurnOff();
        void TurnOn();
        bool RunSelfTest();

    }
}
