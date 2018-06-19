using System;
using Stack_and_Queue;
using Stack_and_Queue.Classes;
using Xunit;

namespace Unit_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanPeekAtTopOfStack()
        {
            Stack stack = new Stack(new Node("zzz"));

            Node topNodeInStack = stack.Peek();

            Assert.Equal("zzz", topNodeInStack.Value);
        }

        [Fact]
        public void CanPeekAtFrontOfQueue()
        {
            Queue queue = new Queue(new Node("111"));

            Node frontNodeInQueue = queue.Peek();

            Assert.Equal("111", frontNodeInQueue.Value);
        }

        [Fact]
        public void CanDequeueNodeFromQueue()
        {
            Queue queue = new Queue(new Node("111"));

            Node formerFrontNode = queue.Front;

            Node dequeuedNode = queue.Dequeue();

            Assert.Equal(formerFrontNode, dequeuedNode);
        }
        
        [Theory]
        [InlineData("yyy")]
        [InlineData("xxx")]
        [InlineData("www")]
        public void CanPushNodeOntoStack(string newNodeValue)
        {
            Stack stack = new Stack(new Node("zzz"));

            stack.Push(new Node(newNodeValue));
            
            Assert.Equal(newNodeValue, stack.Top.Value);
        }

        [Theory]
        [InlineData("yyy")]
        [InlineData("xxx")]
        [InlineData("www")]
        public void CanPopNodeOffOfStack(string newNodeValue)
        {
            Stack stack = new Stack(new Node("zzz"));

            stack.Push(new Node(newNodeValue));

            Node poppedNode = stack.Pop();

            Assert.Equal(newNodeValue, poppedNode.Value);
        }

        [Theory]
        [InlineData("222")]
        [InlineData("333")]
        [InlineData("444")]
        public void CanEnqueueNodeIntoQueue(string newNodeValue)
        {
            Queue queue = new Queue(new Node("111"));

            queue.Enqueue(new Node(newNodeValue));

            Assert.Equal(newNodeValue, queue.Rear.Value);
        }
    }
}
