using System;
using Xunit;
using CalcLib;

namespace Tests
{
    public class UnitTest1
    {
        RecursiveCalc x = new RecursiveCalc();

        // FACTORIAL

        [Fact]
        public void Test1Factorial()
        {
            Assert.Equal(1, x.FactorialRec(0, 1));
            Assert.Equal(120, x.FactorialRec(4, 5));
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(240, 5, 2)]
        public void Test2Factorial(int expected, int input, int ans)
        {
            RecursiveCalc x = new RecursiveCalc();
            Assert.Equal(expected, x.FactorialRec(input, ans));
        }

        // FIBONACCI

        [Fact]
        public void Test1Fib()
        {
            Assert.Equal(true, x.FibCheck(5));
            Assert.Equal(false, x.FibCheck(6));
        }

        [Theory]
        [InlineData(false, 1)]
        [InlineData(true, 5)]
        public void Test2Fib(Boolean expected, int num)
        {
            Assert.Equal(expected, x.FibCheck(num));
        }

        // PRIME NUMBER

        [Fact]
        public void Test1Prime() {
            Assert.Equal(false, x.PrimeCheckRec(1,0));  //DivideByZeroException
        }
        [Fact]
        public void Test2Prime() {
            Assert.Equal(true, x.PrimeCheckRec(5,2));  //5 is a Prime Number
        }
        [Theory]
        [InlineData(false, 6, 2)]
        [InlineData(true, 5, 2)]
        [InlineData(true, 2, 2)]
        public void Test3Prime(Boolean expected, int num, int divisor) {
            Assert.Equal(expected, x.PrimeCheckRec(num, divisor));
        }

        // FIBONACCI NUMBER

        /*[Fact]
        public void Test1Fibnum() {
            Assert.Equal(x.FibonacciRec(5));
        }*/
        [Theory]
        [InlineData (33, 0, 1, 2)]
        public void Test2Fibnum(int expected, int num1, int num2, int numFibs) {
            Assert.Equal(expected, x.FibonacciRec(num1, num2, numFibs));
        }
    }
}
