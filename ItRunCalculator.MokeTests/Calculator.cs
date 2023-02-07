namespace ItRunCalculator.MokeTests
{
    public class Calculator
    {
        private readonly INumberProvider _numberProvider;

        public Calculator(INumberProvider numberProvider)
        {
            _numberProvider = numberProvider;
        }

        public decimal Action(MathAction action)
        {
            decimal result = default;
            var number1 = _numberProvider.GetNumber1();
            var number2 = _numberProvider.GetNumber2();

            switch (action)
            {
                case MathAction.Jam:
                    result = number1 + number2;
                    if (result > 9999999999999999999)
                        throw new IndexOutOfRangeException();

                    break;
                case MathAction.Tarh:
                    result = number1 - number2;
                    if (result < -999999999999999999)
                        throw new IndexOutOfRangeException();
                    break;
                case MathAction.Zarb:
                    result = number1 * number2;
                    if (result < -999999999999999999 || result > 9999999999999999999)
                        throw new IndexOutOfRangeException();

                    break;
                case MathAction.Taqsim:
                    if (number2 == 0)
                        throw new ArgumentException();

                    result = number1 / number2;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(action), action, null);
            }

            return result;
        }
    }
}
