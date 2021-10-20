using System.Collections.Generic;

namespace SimpleCalculator.Model
{
    /// <summary>
    /// 四则运算计算类
    /// </summary>
    public class CalculatorManager
    {
        public static List<string> Operators = new List<string> { "+", "-", "*", "/" };

        public static double Calculate(double firstNumber, double secondNumber, string strOperator, out bool isSuccess)
        {
            double doubleResult = 0;
            isSuccess = true;
            switch (strOperator)
            {
                case "+":
                    doubleResult = firstNumber + secondNumber;
                    break;
                case "-":
                    doubleResult = firstNumber - secondNumber;
                    break;
                case "*":
                    doubleResult = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        isSuccess = false;
                    }
                    else
                    {
                        doubleResult = firstNumber / secondNumber;
                    }
                    break;
            }
            return doubleResult;
        }
    }
}
