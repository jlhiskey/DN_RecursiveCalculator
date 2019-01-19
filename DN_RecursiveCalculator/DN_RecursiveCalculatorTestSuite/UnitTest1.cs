using System;
using Xunit;
using DN_RecursiveCalculator;

namespace DN_RecursiveCalculatorTestSuite
{
    public class AddTestSuite
    {
        [Fact]
        public void TestingAddMethodOne()
        {
            Assert.Equal(4, Program.Add(2, 2));
        }

        [Fact]
        public void TestingAddMethodTwo()
        {
            Assert.Equal(3, Program.Add(1, 2));
        }

        [Fact]
        public void TestingAddMethodThree()
        {
            Assert.Equal(9, Program.Add(2, 7));
        }
    }

    public class SubtractTestSuite
    {
        [Fact]
        public void TestingSubtractMethodOne()
        {
            Assert.Equal(0, Program.Subtract(2, 2));
        }

        [Fact]
        public void TestingSubtractMethodTwo()
        {
            Assert.Equal(-1, Program.Subtract(1, 2));
        }

        [Fact]
        public void TestingSubtractMethodThree()
        {
            Assert.Equal(-5, Program.Subtract(2, 7));
        }
    }

    public class MultiplyTestSuite
    {
        [Fact]
        public void TestingMultiplyMethodOne()
        {
            Assert.Equal(4, Program.Multiply(2, 2));
        }

        [Fact]
        public void TestingMultiplyMethodTwo()
        {
            Assert.Equal(2, Program.Multiply(1, 2));
        }

        [Fact]
        public void TestingMultiplyMethodThree()
        {
            Assert.Equal(-7, Program.Multiply(-1, 7));
        }
    }

    public class DivideTestSuite
    {
        [Fact]
        public void TestingDivideMethodOne()
        {
            Assert.Equal(1, Program.Divide(2, 2));
        }

        [Fact]
        public void TestingDivideMethodTwo()
        {
            Assert.Equal(10, Program.Divide(20, 2));
        }

        [Fact]
        public void TestingDivideMethodThree()
        {
            Assert.Equal(3, Program.Divide(15, 5));
        }
    }

    public class NthRootTestSuite
    {
        [Fact]
        public void TestingNthRootMethodOne()
        {
            Assert.Equal(2, Program.NthRoot(4, 2));
        }

        [Fact]
        public void TestingNthRootMethodTwo()
        {
            Assert.Equal(3, Program.NthRoot(27, 3));
        }

        [Fact]
        public void TestingNthRootMethodThree()
        {
            Assert.Equal(4, Program.NthRoot(256, 4));
        }
    }
}
