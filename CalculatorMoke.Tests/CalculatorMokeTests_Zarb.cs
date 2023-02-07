using ItRunCalculator.MokeTests;
using Moq;
using NUnit.Framework;

namespace CalculatorMoke.Tests
{
    public class CalculatorMokeTests_Zarb
    {
        [Test]
        [Category("Zarb")]
        [TestCase(5, 3, 15)]
        [TestCase(-2, -3, 6)]
        [TestCase(-2, 8, -16)]
        [TestCase(2, -8, -16)]
        [TestCase(0, 0, 0)]
        [TestCase(2, 0, 0)]
        [TestCase(0, 2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, -2, 0)]
        public void Action_Zarb_Test_With_With_AllCase(decimal first, decimal secend, decimal expected)
        {
            var numberProviderMock = new Mock<INumberProvider>();
            numberProviderMock.Setup(n => n.GetNumber1()).Returns(first);
            numberProviderMock.Setup(n => n.GetNumber2()).Returns(secend);
            var culculator = new Calculator(numberProviderMock.Object);
            var result = culculator.Action(MathAction.Zarb);

            Assert.That(result, Is.EqualTo(expected));
        }

        //[Test]
        //[Category("Zarb")]
        //public void Action_Zarb_Test_With_ParametrsNegative()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(-2);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(-3);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Zarb);

        //    Assert.That(result, Is.EqualTo(6));
        //}

        //[Test]
        //[Category("Zarb")]
        //public void Action_Zarb_Test_With_FirstParametrNegative__SecendParametrPositive()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(-2);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(8);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Zarb);

        //    Assert.That(result, Is.EqualTo(-16));
        //}

        //[Test]
        //[Category("Zarb")]
        //public void Action_Zarb_Test_With_FirstParametrPositive_SecendParametrNegative()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(2);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(-3);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Zarb);

        //    Assert.That(result, Is.EqualTo(-6));
        //}

        //[Test]
        //[Category("Zarb")]
        //public void Action_Zarb_Test_With_ParametrsZero()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(0);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(0);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Zarb);

        //    Assert.That(result, Is.EqualTo(0));
        //}

        //[Test]
        //[Category("Zarb")]
        //public void Action_Zarb_Test_With_FirstParametrZero_SecendParametrPositive()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(0);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(3);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Zarb);

        //    Assert.That(result, Is.EqualTo(0));
        //}

        //[Test]
        //[Category("Zarb")]
        //public void Action_Zarb_Test_With_FirstParametrPositive_SecendParametrZero()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(2);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(0);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Zarb);

        //    Assert.That(result, Is.EqualTo(0));
        //}

        //[Test]
        //[Category("Zarb")]
        //public void Action_Zarb_Test_With_FirstParametrZero_SecendParametrNegative()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(0);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(-3);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Zarb);

        //    Assert.That(result, Is.EqualTo(0));
        //}

        //[Test]
        //[Category("Zarb")]
        //public void Action_Zarb_Test_With_FirstParametrNegative_SecendParametrZero()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(-2);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(0);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Zarb);

        //    Assert.That(result, Is.EqualTo(0));
        //}

        [Test]
        [Category("Zarb")]
        public void Action_Zarb_Test_With_MinAndMaxDipazonDecimal()
        {
            var numberProviderMock = new Mock<INumberProvider>();
            numberProviderMock.Setup(n => n.GetNumber1()).Returns(9999999999.999999999m);
            numberProviderMock.Setup(n => n.GetNumber2()).Returns(1000000001);
            var culculator = new Calculator(numberProviderMock.Object);

            Assert.Throws<IndexOutOfRangeException>(() => culculator.Action(MathAction.Zarb));
        }
    }
}
