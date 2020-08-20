using System;
using Xunit;
using CalcLib;

namespace Tests
{
    public class UnitTest1
    {
        RecursiveCalc x = new RecursiveCalc();

        [Fact]
        public void Test1()
        {
            Assert.Equal(720,x. FactorialRec(5,6));
        }
    }
}
