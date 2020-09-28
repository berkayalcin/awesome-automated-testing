using Awesome_Automated_Test.Fundamentals;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        private HtmlFormatter _formatter;

        [SetUp]
        public void SetUp()
        {
            _formatter=new HtmlFormatter();
        }

        [Test]
        [TestCase("abc")]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement(string a)
        {

            var result = _formatter.FormatAsBold(a);

            // More general

            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            Assert.That(result, Does.Contain(a));
        }
    }
}