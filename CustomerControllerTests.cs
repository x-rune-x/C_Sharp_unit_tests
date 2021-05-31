using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestsMe
{
    [TestFixture]
    class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFoundObject()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnOkObject()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
