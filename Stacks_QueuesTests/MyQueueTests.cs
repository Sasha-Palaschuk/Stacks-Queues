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
    public class MyQueueTests
    {
        MyQueue<int> testQueue;
        int item1, item2;

        [TestInitialize]
        public void setupTests()
        {
            testQueue = new MyQueue<int>();
            item1 = 4;
            item2 = 9;
        }

        [TestMethod()]
        public void MyQueueTest()
        {
            //test if a queue is crated empty
            Assert.AreEqual(0, testQueue.Size());
        }

        [TestMethod()]
        public void ClearTest()
        {
            //clear an epty queue 
            testQueue.Clear();
            Assert.AreEqual(0, testQueue.Size());

            //clear a queue with 2 items in it
            testQueue.Enqueue(item1);
            testQueue.Enqueue(item2);
            Assert.AreEqual(3, testQueue.Size());
            testQueue.Clear();
            Assert.AreEqual(0, testQueue.Size());
        }

        [TestMethod()]
        public void DequeueTest()
        {
            //dequeue one item
            testQueue.Enqueue(item1);
            Assert.AreEqual(4, testQueue.Dequeue());

            //dequeue two items and check if queue is empty afterwords
            testQueue.Enqueue(item2);
            testQueue.Enqueue(item1);
            Assert.AreEqual(9, testQueue.Dequeue());
            Assert.AreEqual(4, testQueue.Dequeue());
            Assert.AreEqual(0, testQueue.Size());
        }

        //test if dequeue throws an exeption wen trieing to dequeue an empty queue
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void DequeueEmptyTest()
        {
            testQueue.Dequeue();
        }

        [TestMethod()]
        public void EnqueueTest()
        {
            //test if adding item to queue works
            testQueue.Enqueue(item1);
            Assert.AreEqual(1, testQueue.Size());
            Assert.AreEqual(4,testQueue.Front());

            //add another item and see if its at the back
            testQueue.Enqueue(item2);
            Assert.AreEqual(2, testQueue.Size());
            Assert.AreEqual(4, testQueue.Front());
        }

        [TestMethod()]
        public void FrontTest()
        {
            //add to queue and see if front works
            testQueue.Enqueue(item1);
            Assert.AreEqual(4, testQueue.Front());
            testQueue.Enqueue(item2);
            Assert.AreEqual(4, testQueue.Front());
            testQueue.Dequeue();
            Assert.AreEqual(9, testQueue.Front());

        }

        //test if dequeue throws an exeption wen trieing to check the front an empty queue
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void FrontEmptyTest()
        {
            testQueue.Front();
        }

        [TestMethod()]
        public void SizeTest()
        {
            //test if queue size is counting properly
            Assert.AreEqual(0, testQueue.Size());
            testQueue.Enqueue(item1);
            Assert.AreEqual(1, testQueue.Size());
            testQueue.Enqueue(item2);
            Assert.AreEqual(2, testQueue.Size());
            testQueue.Enqueue(item2);
            Assert.AreEqual(3, testQueue.Size());
            testQueue.Dequeue();
            Assert.AreEqual(2, testQueue.Size());
            testQueue.Clear();
            Assert.AreEqual(0, testQueue.Size());
        }
    }
}