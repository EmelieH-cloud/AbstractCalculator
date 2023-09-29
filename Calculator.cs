namespace AbstractCalculator
{

    internal class Calculator
    {
        public Calculator() { }

        public void Calculate(string nbr1, string nbr2, string op)
        {
            bool IsNumber1 = ValidateInput(nbr1);
            bool IsNumber2 = ValidateInput(nbr2);
            int calcResult;

            if (IsNumber1 && IsNumber2)
            {
                int number1 = ConversionResult(nbr1);
                int number2 = ConversionResult(nbr2);

                if (op.Equals("add", StringComparison.OrdinalIgnoreCase))
                {
                    op = "+";
                    calcResult = Add(number1, number2);
                    DisplayResult(number1, number2, op, calcResult);

                }
                else if (op.Equals("multiply", StringComparison.OrdinalIgnoreCase))
                {
                    op = "x";
                    calcResult = Multiply(number1, number2);
                    DisplayResult(number1, number2, op, calcResult);
                }
                else if (op.Equals("divide", StringComparison.OrdinalIgnoreCase))
                {
                    op = "/";
                    calcResult = Divide(number1, number2);
                    DisplayResult(number1, number2, op, calcResult);
                }
                else if (op.Equals("subtract", StringComparison.OrdinalIgnoreCase))
                {
                    op = "-";
                    calcResult = Subtract(number1, number2);
                    DisplayResult(number1, number2, op, calcResult);
                }

            }
            else if (!IsNumber1 || !IsNumber2)
            {
                Console.WriteLine("Conversion failed, please input two numbers.");
            }

        }

        private void DisplayResult(int a, int b, string op, int sum)
        {
            string display = ($"{a} {op} {b} = {sum}");
            Console.WriteLine(display);
        }


        private int Add(int nbr1, int nbr2)
        {
            int sum = nbr1 + nbr2;
            return sum;
        }
        private int Subtract(int nbr1, int nbr2)
        {
            int sum = nbr1 - nbr2;
            return sum;
        }

        private int Divide(int nbr1, int nbr2)
        {
            int sum = nbr1 / nbr2;
            return sum;
        }
        private int Multiply(int nbr1, int nbr2)
        {
            int sum = nbr1 * nbr2;
            return sum;
        }
        private bool ValidateInput(string input)
        {
            int int_conversion;
            bool result = int.TryParse(input, out int_conversion);
            return result;
        }

        private int ConversionResult(string number)
        {
            int n = int.Parse(number);
            return n;
        }

    }
}
