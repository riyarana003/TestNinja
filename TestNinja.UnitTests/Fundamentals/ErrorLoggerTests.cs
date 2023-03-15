using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {

        [Test]
        public void Log_WhenCalled_ShouldSetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("error string");

            Assert.That(logger.LastError, Is.EqualTo("error string"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_WhenCalled_InvalidError_ThrowArgumrentNullException(string error)
        {
            var logger = new ErrorLogger();

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
            //Assert.That(() => logger.Log(error), Throws.TypeOf<ArgumentNullException>());

        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();

            //how can we verify this objects raises an event --
            //Before acting, we gonna subscribe to that event,
            //so if the Log method raises the event we will be notify

            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; }; //this lambda expression represent our eventHandler

            logger.Log("a");

            //Assert.That(id, Is.Not.EqualTo(Guid.Empty));
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }

        //[Test]
        //public void OnErrorLogged_WhenCalled_RaiseEvent()
        //{
        //    var logger = new ErrorLogger();

        //    logger.OnErrorLogged(Guid.NewGuid());

        //    Assert.That(true);
        //}
    }
}
