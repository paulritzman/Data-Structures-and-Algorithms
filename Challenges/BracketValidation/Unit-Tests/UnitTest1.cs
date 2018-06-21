using System;
using Xunit;
using BracketValidation;

namespace Unit_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("")]
        [InlineData("Hello, World!")]
        [InlineData("12345")]
        public void CanReturnTrueIfNoBracketsAreEntered(string input)
        {
            Assert.True(Program.MultiBracketValidation(input));
        }

        [Theory]
        [InlineData("()")]
        [InlineData("{[()]}")]
        [InlineData("[Hello](W){{orld}}")]
        public void CanReturnTrueIfBracketsAreBalanced(string input)
        {
            Assert.True(Program.MultiBracketValidation(input));
        }

        [Theory]
        [InlineData("[")]
        [InlineData("{([})]")]
        [InlineData("[Hello}(W)[{orld}}")]
        public void CanReturnFalseIfBracketsAreNotBalanced(string input)
        {
            Assert.False(Program.MultiBracketValidation(input));
        }
    }
}
