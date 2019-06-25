using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks_Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Queues.Tests
{
    [TestClass()]
    public class MyStackTests
    {
        // Declare a test Stack for integers based on the abstract class AStack
        AStack<int> intStack;

        [TestInitialize]
        public void SetupTest()
        {
            // Create a test Stack instance as the generic class MyStack that inherits from the abstract class 
            this.intStack = new MyStack<int>();
        }

        // Test Stack is created emtpy
        // Input: A newly created Stack for integers
        // Expectation: IsEmpty returns true the test Stack
        [TestMethod()]
        public void MyStackTest()
        {
            this.intStack = new MyStack<int>();
            Assert.IsTrue(intStack is MyStack<int>);
            Assert.IsTrue(intStack.IsEmpty());
        }

        // Test IsEmpty correctly determines if a Stack is empty
        // Input: An empty Stack, a Stack with an item pushed on
        // Expectation: IsEmpty returns true for a newly created stack,
        //              returns false after an item is pushed on the stack
        [TestMethod()]
        public void isEmptyTest()
        {
            Assert.IsTrue(intStack.IsEmpty());
            intStack.Push(2);
            Assert.IsFalse(intStack.IsEmpty());
        }

        // Test Pop for an empty Stack 
        // Input: An empty Stack
        // Expectation: Pop throws an exception if called for an empty stack with message "Cannot pop an emtpy Stack"
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        // For additonal marks create your own StackException that inherits from Exception and use the attribute below instead of the one above
        // [ExpectedException(typeof(StackException))]  
        public void PopTestEmpty()
        {
            intStack.Pop();
        }

        // Test Top for an empty Stack 
        // Input: An empty Stack
        // Expectation: Top throws an exception if called for an empty stack with message "Cannot read top element of an emtpy Stack"
        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void TopTestEmpty()
        {
            intStack.Top();
        }

        // Test Pop 
        // Input: A Stack with a single item pushed on 
        // Expectation: A pop that follows a push onto an empty Stack will return the item pushed and an empty Stack
        [TestMethod()]
        public void PopTest()
        {
            intStack.Push(2);
            Assert.AreEqual(2, intStack.Pop());
            Assert.IsTrue(intStack.IsEmpty());
        }

        // Test Push
        // Input: An Empty Stack
        // Expectation: Following a push to an empty stack the stack is not empty and contains the item pushed
        [TestMethod()]
        public void PushTest()
        {
            intStack.Push(2);
            Assert.IsFalse(intStack.IsEmpty());
            intStack.Push(3);
            Assert.AreEqual(3, intStack.Top());
            intStack.Pop();
            Assert.AreEqual(2, intStack.Top());
        }

        // Test Top
        // Input: An Empty Stack
        // Expectation: Top following a push to an empty stack will return the  valueof the item pushed,
        //              and a stack that still contains the item
        [TestMethod()]
        public void TopTest()
        {
            intStack.Push(2);
            Assert.AreEqual(2, intStack.Top());
            Assert.IsFalse(intStack.IsEmpty());
        }

        // Test LIFO behaviour
        // Input: Stack of two items created by first pushing 2 and then 3 onto an empty Stack
        // Expectation: A call to Pop for the input Stack will return 3 and a Stack that is not empty
        [TestMethod()]
        public void LIFOTest()
        {
            intStack.Push(2);
            intStack.Push(3);
            Assert.AreEqual(3, intStack.Pop());
            Assert.IsFalse(intStack.IsEmpty());
        }

    }
}
