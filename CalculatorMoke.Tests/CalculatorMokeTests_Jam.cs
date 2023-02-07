using Castle.Components.DictionaryAdapter;
using ItRunCalculator.MokeTests;
using Moq;
using NUnit.Framework;

namespace CalculatorMoke.Tests
{
    public class CalculatorMokeTests_Jam
    {
        [Test]
        [Category("Jam")]
        [TestCase(1, 2, 3)]
        [TestCase(-2, -2, -4)]
        [TestCase(-2, 2, 0)]
        [TestCase(2, -2, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 4, 4)]
        [TestCase(4, 0, 4)]
        [TestCase(0, -3, -3)]
        [TestCase(-3, 0, -3)]
        public void Action_Jam_Test_With_AllCase(decimal first, decimal secend, decimal expected)
        {
            var numberProviderMock = new Mock<INumberProvider>();
            numberProviderMock.Setup(n => n.GetNumber1()).Returns(first);
            numberProviderMock.Setup(n => n.GetNumber2()).Returns(secend);
            var culculator = new Calculator(numberProviderMock.Object);
            var result = culculator.Action(MathAction.Jam);
            Assert.That(result, Is.EqualTo(expected));
        }

        //[Test]
        //[Category("Jam")]
        //public void Action_Jam_Test_NegativeParametr()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(-2);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(-2);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Jam);
        //    Assert.That(result, Is.EqualTo(-4));
        //}

        //[Test]
        //[Category("Jam")]
        //public void Action_Jam_Test_FirstParametrNegative_SecendParametrPositive()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(-2);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(2);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Jam);
        //    Assert.That(result, Is.EqualTo(0));
        //}

        //[Test]
        //[Category("Jam")]
        //public void Action_Jam_Test_FirstParametrPositive_SecendParametrNegative()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(2);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(-2);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Jam);
        //    Assert.That(result, Is.EqualTo(0));
        //}

        //[Test]
        //[Category("Jam")]
        //public void Action_Jam_Test_ZeroParametr()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(0);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(0);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Jam);
        //    Assert.That(result, Is.EqualTo(0));
        //}

        //[Test]
        //[Category("Jam")]
        //public void Action_Jam_Test_FirstParametrZero_SecendParametrPositive()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(0);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(4);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Jam);
        //    Assert.That(result, Is.EqualTo(4));
        //}

        //[Test]
        //[Category("Jam")]
        //public void Action_Jam_Test_FirstParametrPositive_SecendParametrZero()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(4);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(0);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Jam);
        //    Assert.That(result, Is.EqualTo(4));
        //}

        //[Test]
        //[Category("Jam")]
        //public void Action_Jam_Test_FirstParametrZero_SecendParametrNegative()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(0);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(-3);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Jam);
        //    Assert.That(result, Is.EqualTo(-3));
        //}

        //[Test]
        //[Category("Jam")]
        //public void Action_Jam_Test_FirstParametrNegative_SecendParametrZero()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(-3);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(0);
        //    var culculator = new Calculator(numberProviderMock.Object);
        //    var result = culculator.Action(MathAction.Jam);
        //    Assert.That(result, Is.EqualTo(-3));
        //}

        [Test]
        [Category("Jam")]
        public void Action_Jam_Test_With_MaxDipazonDecimal()
        {
            var numberProviderMock = new Mock<INumberProvider>();
            numberProviderMock.Setup(n => n.GetNumber1()).Returns(9999999999999999999);
            numberProviderMock.Setup(n => n.GetNumber2()).Returns(1);
            var culculator = new Calculator(numberProviderMock.Object);

            Assert.Throws<IndexOutOfRangeException>(() => culculator.Action(MathAction.Jam));
        }
    }
}
