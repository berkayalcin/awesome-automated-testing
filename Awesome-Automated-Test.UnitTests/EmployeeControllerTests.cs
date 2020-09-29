using AutoFixture;
using Awesome_Automated_Test.Mocking.Employee;
using Moq;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests
{
    [TestFixture]
    public class EmployeeControllerTests
    {
        private Mock<EmployeeStorage> _employeeStorage;
        private EmployeeController _sut;
        private IFixture _fixture;

        [SetUp]
        public void SetUp()
        {
            _fixture = new Fixture();
            _employeeStorage = new Mock<EmployeeStorage>();
            _sut = new EmployeeController(_employeeStorage.Object);
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void DeleteEmployee_WhenCalled_DeleteTheEmployeeFromDb()
        {
            var id = _fixture.Create<int>();
            _sut.DeleteEmployee(id);

            _employeeStorage.Verify(s => s.DeleteEmployee(id));
        }
    }
}