using System.Collections.Generic;

namespace SimpleCalculator.Domain
{
    /// <summary>
    /// 四则运算计算类
    /// </summary>
    public class CalculatorManager
    {
        public static List<string> Operators = new List<string> { "+", "-", "*", "/" };

        public static double Calculate(double numOne, double numTwo, string oper, out bool isSuccess)
        {
            double numResult = 0;
            isSuccess = true;
            switch (oper)
            {
                case "+":
                    numResult = numOne + numTwo;
                    break;
                case "-":
                    numResult = numOne - numTwo;
                    break;
                case "*":
                    numResult = numOne * numTwo;
                    break;
                case "/":
                    if (numTwo == 0)
                    {
                        isSuccess = false;
                    }
                    else
                    {
                        numResult = numOne / numTwo;
                    }
                    break;
            }
            return numResult;
        }
    }
}
