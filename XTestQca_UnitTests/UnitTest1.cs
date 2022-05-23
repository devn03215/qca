using qca;
using System;
using Xunit;

namespace XTestQca_UnitTests
{
    public class OperationTests
    {
        [Fact]
        public void TestMultiplyOperation_OnPresetExpression_ReturnsValue()
        {
            var fraction = new Fraction();

            var result = fraction.TestAddOperation(Fraction.MathExpression("? 1/2 * 3_3/4"));

            Assert.Equal("= 1_7/8", result);
        }

        [Fact]
        public void TestDivideOperation_OnPresetExpression_ReturnsValue()
        {
            var fraction = new Fraction();

            var result = fraction.TestAddOperation(Fraction.MathExpression("? 12 / 1/2"));

            Assert.Equal("= 6", result);
        }

        [Fact]
        public void TestAddOperation_OnPresetExpression_ReturnsValue()
        {
            var fraction = new Fraction();

            var result = fraction.TestAddOperation(Fraction.MathExpression("? 1/2 + 3/4"));

            Assert.Equal("= 1_1/4", result);
        }

        [Fact]
        public void TestSubtractOperation_OnPresetExpression_ReturnsValue()
        {
            var fraction = new Fraction();

            var result = fraction.TestAddOperation(Fraction.MathExpression("? 1_1/2 - 3/8"));

            Assert.Equal("= 1_1/8", result);
        }
    }
}
