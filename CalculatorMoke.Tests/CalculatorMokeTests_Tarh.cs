using ItRunCalculator.MokeTests;
using Moq;
using NUnit.Framework;

namespace CalculatorMoke.Tests
{
    public class CalculatorMokeTests_Tarh
    {
        [Test]
        [Category("Tarh")]
        [TestCase(2, 2, 0)]
        [TestCase(-2, -2, 0)]
        [TestCase(-2, 2, -4)]
        [TestCase(2, -2, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 4, -4)]
        [TestCase(4, 0, 4)]
        [TestCase(0, -3, 3)]
        [TestCase(-3, 0, -3)]
        public void Action_Tarh_Test_With_AllCase(decimal first, decimal secend, decimal expected)
        {
            var numberProviderMock = new Mock<INumberProvider>();
            numberProviderMock.Setup(n => n.GetNumber1()).Returns(first);
            numberProviderMock.Setup(n => n.GetNumber2()).Returns(secend);
            var culculator = new Calculator(numberProviderMock.Object);
            var result = culculator.Action(MathAction.Tarh);
            Assert.That(result, Is.EqualTo(expected));
        }


        [Test]
        [Category("Tarh")]
        public void Action_Tarh_Test_MinDipazonDecimal()
        {
            var numberProviderMock = new Mock<INumberProvider>();
            numberProviderMock.Setup(n => n.GetNumber1()).Returns(-999999999999999999);
            numberProviderMock.Setup(n => n.GetNumber2()).Returns(1);
            var culculator = new Calculator(numberProviderMock.Object);
            Assert.Throws<IndexOutOfRangeException>(() => culculator.Action(MathAction.Tarh));
        }

        //[Test]
        //[Category("Tarh")]
        //public void Action_Tarh_Test_NegativeParametr()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(-2);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(-2);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Tarh);
        //    Assert.That(result, Is.EqualTo(0));
        //}

        //[Test]
        //[Category("Tarh")]
        //public void Action_Tarh_Test_FirstParametrNegative_SecendParametrPositive()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(-2);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(2);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Tarh);
        //    Assert.That(result, Is.EqualTo(-4));
        //}

        //[Test]
        //[Category("Tarh")]
        //public void Action_Tarh_Test_FirstParametrPositive_SecendParametrNegative()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(2);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(-2);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Tarh);
        //    Assert.That(result, Is.EqualTo(4));
        //}

        //[Test]
        //[Category("Tarh")]
        //public void Action_Tarh_Test_ZeroParametr()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(0);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(0);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Tarh);
        //    Assert.That(result, Is.EqualTo(0));
        //}

        //[Test]
        //[Category("Tarh")]
        //public void Action_Tarh_Test_FirstParametrZero_SecendParametrPositive()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(0);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(4);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Tarh);
        //    Assert.That(result, Is.EqualTo(-4));
        //}

        //[Test]
        //[Category("Tarh")]
        //public void Action_Tarh_Test_FirstParametrPositive_SecendParametrZero()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(4);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(0);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Tarh);
        //    Assert.That(result, Is.EqualTo(4));
        //}

        //[Test]
        //[Category("Tarh")]
        //public void Action_Tarh_Test_FirstParametrZero_SecendParametrNegative()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(0);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(-3);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Tarh);
        //    Assert.That(result, Is.EqualTo(3));
        //}

        //[Test]
        //[Category("Tarh")]
        //public void Action_Tarh_Test_FirstParametrNegative_SecendParametrZero()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(-3);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(0);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Tarh);
        //    Assert.That(result, Is.EqualTo(-3));
        //}
    }
}
