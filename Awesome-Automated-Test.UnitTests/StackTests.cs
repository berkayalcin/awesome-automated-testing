using Awesome_Automated_Test.Fundamentals;
using NUnit.Framework;

namespace Awesome_Automated_Test.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<string>();
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void Push_ArgIsNull_ThrowsArgumentNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        [TestCase("A")]
        public void Push_ValidArg_AddTheObjectToTheStack(string input)
        {
            _stack.Push(input);

            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithAFewObjects_ReturnsObjectOnTheTop()
        {
            _stack.Push("A");
            _stack.Push("B");
            _stack.Push("C");

            var item = _stack.Pop();

            Assert.That(item, Is.EqualTo("C"));
        }

        [Test]
        public void Pop_StackWithAFewObjects_RemoveObjectOnTheTop()
        {
            _stack.Push("A");
            _stack.Push("B");
            _stack.Push("C");

            _stack.Pop();

            Assert.That(_stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_EmptyStack_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithObjects_ReturnsOnTopOfTheStack()
        {
            _stack.Push("A");
            _stack.Push("B");
            _stack.Push("C");

            var item = _stack.Peek();

            Assert.That(item, Is.EqualTo("C"));
        }

        [Test]
        public void Peek_StackWithObjects_DoesNotRemoveTheObjectOnTopOfTheStack()
        {
            _stack.Push("A");
            _stack.Push("B");
            _stack.Push("C");

            var item = _stack.Peek();

            Assert.That(_stack.Count, Is.EqualTo(3));
        }
    }
}