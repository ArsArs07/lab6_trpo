using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(5, 6);
            Assert.Equal(8, result);
        }
    }
}
