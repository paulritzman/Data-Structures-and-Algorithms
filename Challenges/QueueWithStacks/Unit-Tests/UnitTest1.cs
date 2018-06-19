using System;
using QueueWithStacks;
using QueueWithStacks.Classes;
using Xunit;

namespace Unit_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanPeekAtFrontOfQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(new Node("111"));

            Node frontNodeInQueue = queue.Peek();

            Assert.Equal("111", frontNodeInQueue.Value);
        }

        [Fact]
        public void CanDequeueNodeFromQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(new Node("111"));

            Node dequeuedNode = queue.Dequeue();

            Assert.Equal("111", dequeuedNode.Value);
        }

        [Theory]
        [InlineData("222")]
        [InlineData("333")]
        [InlineData("444")]
        public void CanEnqueueNodeIntoQueue(string newNodeValue)
        {
            Queue queue = new Queue();

            queue.Enqueue(new Node(newNodeValue));

            Assert.Equal(newNodeValue, queue.Rear.Value);
        }

    }
}
