using System;
using System.Collections.Generic;

namespace SimpleCalculator.Model
{
    /// <summary>
    /// 四则运算计算类
    /// </summary>
    public class CalculatorManager
    {
        public static CalculatorManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_synObject)
                {
                    if (_instance == null)
                    {
                        _instance = new CalculatorManager();
                    }
                }
            }
            return _instance;
        }

        public void Calculate(double firstNumber, double secondNumber, string strOperator, out bool isSuccess)
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

            if (isSuccess)
            {
                CalculateCompletedEventArgs eventArgs = new CalculateCompletedEventArgs { Result = doubleResult };
                FireCalculateCompletedEvent(eventArgs);
            }
        }

        public List<string> Operators = new List<string> { "+", "-", "*", "/" };

        public event EventHandler<CalculateCompletedEventArgs> CalculateCompletedEvent;

        private static CalculatorManager _instance = null;

        private static readonly object _synObject = new object();

        private void FireCalculateCompletedEvent(CalculateCompletedEventArgs eventArgs)
        {
            CalculateCompletedEvent?.Invoke(this, eventArgs);
        }

        private CalculatorManager() { }
    }

    public class CalculateCompletedEventArgs : EventArgs
    {
        public double Result { get; set; }
    }
}
