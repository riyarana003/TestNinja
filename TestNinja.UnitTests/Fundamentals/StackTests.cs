using NUnit.Framework;
using System.Collections;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_WhenObjectIsNull_ThrowsArgumentNullException() 
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidArgumentPassed_AddTheObjectToStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_IfEmptyStack_ReturnZero()
        {
            var stack = new Stack<string>();

            Assert.That(stack.Count,Is.EqualTo(0));
        }

        [Test]
        public void Pop_IfEmptyStack_ThrowsInvalidOperationException() 
        {
            var stack = new Stack<string>();

            Assert.That(()=> stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithFewObjects_ReturnObjectsOnTheTop()
        {
            //Arrange
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            //Act
            var result = stack.Pop();

            //Assert
            Assert.That(result, Is.EqualTo("c"));

        }


        [Test]
        public void Pop_StackWithFewObjects_RemoveObjectsOnTheTop()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(2));
            //Assert.That(stack.Pop(), Is.EqualTo("b"));
            //Assert.That(stack.Pop(), Is.Not.EqualTo("c"));
        }

        [Test]
        public void Peek_IsEmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithObjects_ReturnObjectsOnTopOfTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo("c"));
            //Assert.That(stack.Peek(), Is.EqualTo("c"));
        }

        [Test]
        public void Peek_StackWithObjects_DoesNotRemoveTheObjectOnTopOfTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            stack.Peek();
            Assert.That(stack.Count, Is.EqualTo(3));
        }
    }
}
