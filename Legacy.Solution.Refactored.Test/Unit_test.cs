using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Legacy__solution_refactored;
using NUnit;
using NUnit.Framework;

namespace Legacy.Solution.Refactored.Test
{
    [TestFixture]
    public class Unit_test
    {
        private Legacy__solution_refactored.ECS _uut;
        private IHeater _heater;
        private ITempSensor _tempSensor;

        [SetUp]
        public void SetUp()
        {
            _heater = new FakeHeater();
            _tempSensor = new FakeTempSensor();
            _uut = new Legacy__solution_refactored.ECS(28, _tempSensor, _heater);
        }

    }
}
