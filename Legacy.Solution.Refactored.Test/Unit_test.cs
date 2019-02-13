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
        private FakeHeater _heater;
        private FakeTempSensor _tempSensor;

        [SetUp]
        public void SetUp()
        {
            _heater = new FakeHeater();
            _tempSensor = new FakeTempSensor();
           _uut = new Legacy__solution_refactored.ECS(28, _tempSensor, _heater);
        }

        [Test]

        public void Default_CurTemp_Is_0()
        {
            Assert.That(_uut.GetCurTemp(), Is.EqualTo(0));
        }

        [Test]

        public void CurTemp_Is_20()
        {
            _tempSensor.Temp = 20;
            Assert.That(_uut.GetCurTemp(),Is.EqualTo(20));
        }

        [Test]
        public void Heater_Is_Turned_On()
        {
            _tempSensor.Temp = 20;
            _uut.Regulate();
            Assert.That(_heater.State, Is.True);
        }

        [Test]
        public void Heater_Is_Turned_Off()
        {
            _tempSensor.Temp = 30;
            _uut.Regulate();
            Assert.That(_heater.State, Is.False);
        }

        [Test]
        public void Heater_TurnOnCounter_Is_3()
        {
            _tempSensor.Temp = 20;
            _uut.Regulate();
            _uut.Regulate();
            _uut.Regulate();

            Assert.That(_heater.TurnOnCounter, Is.EqualTo(3));
        }

        [Test]
        public void Heater_TurnOnCounter_Is_1()
        {
            _tempSensor.Temp = 20;
            _uut.Regulate();

            _tempSensor.Temp = 30;
            _uut.Regulate();

            _tempSensor.Temp = 40;
            _uut.Regulate();

            Assert.That(_heater.TurnOnCounter, Is.EqualTo(1));
        }

        [Test]
        public void Heater_TurnOffCounter_Is_2()
        {
            _tempSensor.Temp = 20;
            _uut.Regulate();

            _tempSensor.Temp = 30;
            _uut.Regulate();

            _tempSensor.Temp = 40;
            _uut.Regulate();

            Assert.That(_heater.TurnOffCounter, Is.EqualTo(2));
        }

        [Test]
        public void Regulate_threshold_is_15()
        {
            _uut.SetThreshold(15);
            _tempSensor.Temp = 20;
            _uut.Regulate();

            Assert.That(_heater.State, Is.False);
        }
    }
}
