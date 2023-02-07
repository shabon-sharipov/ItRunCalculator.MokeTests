using ItRunCalculator.MokeTests;
using Moq;
using NUnit.Framework;

namespace CalculatorMoke.Tests
{
    public class CalculatorMokeTests_Taqsim
    {
        [Test]
        [Category("Tagsim")]
        [TestCase(2, 2, 1)]
        [TestCase(-6, -2, 3)]
        [TestCase(-6, -2, 3)]
        [TestCase(-3, 2, -1.5)]
        [TestCase(3, -2, -1.5)]
        [TestCase(0, 2, 0)]
        [TestCase(0, -2, 0)]
        public void Action_Test_Taqsim_With_AllCase(decimal first, decimal secend, decimal expected)
        {
            var numberProviderMock = new Mock<INumberProvider>();
            numberProviderMock.Setup(n => n.GetNumber1()).Returns(first);
            numberProviderMock.Setup(n => n.GetNumber2()).Returns(secend);
            var calculator = new Calculator(numberProviderMock.Object);
            var result = calculator.Action(MathAction.Taqsim);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Category("Tagsim")]
        [TestCase(0, 0)]
        [TestCase(2, 0)]
        [TestCase(-2, 0)]
        public void Action_Test_Taqsim_With_CaseException(decimal first, decimal secend)
        {
            var numberProviderMock = new Mock<INumberProvider>();
            numberProviderMock.Setup(n => n.GetNumber1()).Returns(first);
            numberProviderMock.Setup(n => n.GetNumber2()).Returns(secend);
            var calculator = new Calculator(numberProviderMock.Object);

            Assert.Throws<ArgumentException>(() => calculator.Action(MathAction.Taqsim));
        }

        //[Test]
        //[Category("Tagsim")]
        //public void Action_Test_Taqsim_With_FirstParametrPositive_SecendParametrZero()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(2);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(0);
        //    var calculator = new Calculator(numberProviderMock.Object);

        //    Assert.Throws<ArgumentException>(() => calculator.Action(MathAction.Taqsim));
        //}

        //[Test]
        //[Category("Tagsim")]
        //public void Action_Test_Taqsim_With_FirstParametrNegative_SecendParametrZero()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(-2);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(0);
        //    var calculator = new Calculator(numberProviderMock.Object);

        //    Assert.Throws<ArgumentException>(() => calculator.Action(MathAction.Taqsim));
        //}

        //[Test]
        //[Category("Tagsim")]
        //public void Action_Test_Taqsim_With_NegativeParametr()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(-6);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(-2);
        //    var calculator = new Calculator(numberProviderMock.Object);
        //    var result = calculator.Action(MathAction.Taqsim);

        //    Assert.That(result, Is.EqualTo(3));
        //}

        //[Test]
        //[Category("Tagsim")]
        //public void Action_Test_Taqsim_With_FirstParametrNegative_SecendParametrPositive()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(-3);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(2);
        //    var calculator = new Calculator(numberProviderMock.Object);
        //    var result = calculator.Action(MathAction.Taqsim);

        //    Assert.That(result, Is.EqualTo(-1.5));
        //}

        //[Test]
        //[Category("Tagsim")]
        //public void Action_Test_Taqsim_With_FirstParametrPositive_SecendParametrNegative()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(6);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(-2);
        //    var calculator = new Calculator(numberProviderMock.Object);
        //    var result = calculator.Action(MathAction.Taqsim);

        //    Assert.That(result, Is.EqualTo(-3));
        //}

        //[Test]
        //[Category("Tagsim")]
        //public void Action_Test_Taqsim_With_FirstParametrZero_SecendParametrPositive()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(0);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(2);
        //    var calculator = new Calculator(numberProviderMock.Object);
        //    var result = calculator.Action(MathAction.Taqsim);

        //    Assert.That(result, Is.EqualTo(0));
        //}

        //[Test]
        //[Category("Tagsim")]
        //public void Action_Test_Taqsim_With_FirstParametrZero_SecendParametrNegative()
        //{
        //    var numberProviderMock = new Mock<INumberProvider>();
        //    numberProviderMock.Setup(n => n.GetNumber1()).Returns(0);
        //    numberProviderMock.Setup(n => n.GetNumber2()).Returns(-2);
        //    var calculator = new Calculator(numberProviderMock.Object);
        //    var result = calculator.Action(MathAction.Taqsim);

        //    Assert.That(result, Is.EqualTo(0));
        //}
    }
}
