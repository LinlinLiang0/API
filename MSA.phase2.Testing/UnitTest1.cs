using MSA.phase2.AmazingAPI;
using MSA.Phase2.AmazingApi.Controllers;

namespace MSA.phase2.Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void checkSum()
        {
            // arrange
            DemonstrationController demo = new DemonstrationController();
            //act
            var testSum = demo.GetSum(4, 5);
            //assert
            Assert.That(testSum, Is.EqualTo(9));
        }
    }
}