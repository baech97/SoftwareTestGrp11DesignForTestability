using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Legacy__solution_refactored;
using NUnit.Framework;
using NSubstitute;

namespace Legacy.Solution.Substitute.Test
{
    [TestFixture]
    public class Unit_tests
    {
        private ECS _uut;
        private IHeater _heater;
        private ITempSensor _tempSensor;

        [SetUp]
        public void SetUp()
        {
            _heater = NSubstitute.Substitute.For<IHeater>();
            _tempSensor = NSubstitute.Substitute.For<ITempSensor>();

            _uut = new ECS(25, _tempSensor, _heater);
        }

        [Test]
        public void CurTemp_Is_20()
        {
            _tempSensor.GetTemp().Returns(20);
            Assert.That(_tempSensor.GetTemp(), Is.EqualTo(20));
        }

        [Test]
        public void Heater_Is_Turned_on()
        {
            _tempSensor.GetTemp().Returns(20);
            _uut.Regulate();
            _heater.Received(1).TurnOn();
        }

        [Test]
        public void Heater_Is_Turned_off()
        {
            _tempSensor.GetTemp().Returns(30);
            _uut.Regulate();
            _heater.Received(1).TurnOff();
        }

        [Test]
        public void Heater_Is_Turned_on_two_times()
        {
            _tempSensor.GetTemp().Returns(20);
            _uut.Regulate();
            _tempSensor.GetTemp().Returns(30);
            _uut.Regulate();
            _tempSensor.GetTemp().Returns(20);
            _uut.Regulate();
            _heater.Received(2).TurnOn();
        }

        [Test]
        public void Heater_Is_Turned_off_one_tim()
        {
            _tempSensor.GetTemp().Returns(20);
            _uut.Regulate();
            _tempSensor.GetTemp().Returns(30);
            _uut.Regulate();
            _tempSensor.GetTemp().Returns(20);
            _uut.Regulate();
            _heater.Received(1).TurnOff();
        }
    }
}
