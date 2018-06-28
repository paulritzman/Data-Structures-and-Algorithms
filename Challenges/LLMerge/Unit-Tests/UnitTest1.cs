using System;
using LLMerge;
using LLMerge.Classes;
using Xunit;

namespace Unit_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNewNode()
        {
            LinkedList ll = new LinkedList(new Node("5"));

            Node node2 = new Node("10");
            ll.AddNode(node2);

            Assert.Equal(ll.Head.Value, node2.Value);
        }

        [Fact]
        public void CanMergeLinkedLists()
        {
            // ll1 Nodes are ordered as: 10 --> 5
            LinkedList ll1 = new LinkedList(new Node("5"));
            Node node2 = new Node("10");
            ll1.AddNode(node2);

            // ll2 Nodes are ordered as: 11 --> 6
            LinkedList ll2 = new LinkedList(new Node("6"));
            Node node3 = new Node("11");
            ll2.AddNode(node3);

            // Shows that "11", the first Node in ll2, appears as the second Node in ll1 after merge
            Node mergedHead = ll1.MergeLists(ll1, ll2);
            Assert.Equal("11", mergedHead.Next.Value);
        }

        [Fact]
        public void CanIncreaseTotalLinkListLengthByMergingLists()
        {
            // ll1 Nodes are ordered as: 10 --> 5
            LinkedList ll1 = new LinkedList(new Node("5"));
            Node node2 = new Node("10");
            ll1.AddNode(node2);

            // ll2 Nodes are ordered as: 11 --> 6
            LinkedList ll2 = new LinkedList(new Node("6"));
            Node node3 = new Node("11");
            ll2.AddNode(node3);

            // Setup variables for use in while loop
            int expectedPreMergeCount = 2;
            int actualPreMergeCount = 0;
            ll1.Current = ll1.Head;

            // Iterage through Linked List - incrementing actualPreMergeCount to count number of Nodes
            while (ll1.Current != null)
            {
                ll1.Current = ll1.Current.Next;
                actualPreMergeCount++;
            }

            Assert.Equal(expectedPreMergeCount, actualPreMergeCount);

            // Merge and recount the number of Nodes
            ll1.MergeLists(ll1, ll2);

            // Setup variables for use in while loop
            int expectedPostMergeCount = 4; // 2 + 2
            int actualPostMergeCount = 0;
            ll1.Current = ll1.Head;

            // Iterage through Linked List - incrementing actualPostMergeCount to count number of Nodes
            while (ll1.Current != null)
            {
                ll1.Current = ll1.Current.Next;
                actualPostMergeCount++;
            }

            Assert.Equal(expectedPostMergeCount, actualPostMergeCount);
        }

    }
}
