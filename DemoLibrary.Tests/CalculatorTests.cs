using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4,3,7)]
        [InlineData(12.5, 12.5, 25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValueShouldCalculate(double x, double y, double expected)
        {
            //arrange
            //double expect = 5;

            //act
            double actual = Calculator.Add(x, y);

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]
        [InlineData(12.5, 12.5, 25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Divide_SimpleValueShouldCalculate(double x, double y, double expected)
        {
            //arrange
            //double expect = 5;

            //act
            double actual = Calculator.Divide(x, y);

            //assert
            Assert.Equal(expected, actual);
        }



    }
}
