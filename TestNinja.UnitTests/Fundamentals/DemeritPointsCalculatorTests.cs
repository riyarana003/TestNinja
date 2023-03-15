using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsNegativeOrGreaterThan300_ThrowArgumentOutOfRangeException(int speed)
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();

            //Assert.Throws<ArgumentOutOfRangeException>(() => demeritPointsCalculator.CalculateDemeritPoints(speed));
            Assert.That(() => demeritPointsCalculator.CalculateDemeritPoints(speed), 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        //CalculateDemeritPoints_SpeedIsLessThanSpeedLimit_ReturnZero
        //public void CalculateDemeritPoints_SpeedIsZero_ReturnZero()
       

        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(66,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        //public void CalculateDemeritPoints_SpeedIsLessThanOrEqualToSpeedLimit_ReturnZero(int speed)
        public void CalculatorDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();

            var points = demeritPointsCalculator.CalculateDemeritPoints(speed);

            Assert.AreEqual(expectedResult, points);
        }
    }

}