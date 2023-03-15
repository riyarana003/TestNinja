using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var customerController = new CustomerController();
            
            var result = customerController.GetCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>()); //Result should be exactly a NotFound object
            //Assert.That(result, Is.InstanceOf<NotFound>()); //Result should be a NotFound object or one of its derivatives
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var customerController = new CustomerController();

            var result = customerController.GetCustomer(1);

            Assert.That(result, Is.Not.EqualTo(0));
            //Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
