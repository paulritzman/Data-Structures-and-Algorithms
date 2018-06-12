using System;
using LinkedLists;
using LinkedLists.Classes;
using static LinkedLists.Program;
using Xunit;

namespace Unit_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNode()
        {
            LinkedList ll = new LinkedList(new Node("5"));
        }
    }
}
