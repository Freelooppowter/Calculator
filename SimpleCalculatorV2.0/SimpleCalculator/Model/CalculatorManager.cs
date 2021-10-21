using SimpleCalculator.DataAccess;
using SimpleCalculator.Domain;
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
                try
                {
                    CalculatorRecord calculator = new CalculatorRecord();
                    calculator.FirstNumber = firstNumber;
                    calculator.SecondNumber = secondNumber;
                    calculator.Operator = strOperator;
                    calculator.Result = doubleResult;
                    calculator.OperateDateTime = DateTime.Now;

                    _repository.SaveCalculator(calculator);
                }
                catch (Exception ex) { throw ex; }

                CalculateCompletedEventArgs eventArgs = new CalculateCompletedEventArgs { Result = doubleResult };
                FireCalculateCompletedEvent(eventArgs);
            }
        }

        public List<string> Operators = new List<string> { "+", "-", "*", "/" };

        public List<CalculatorRecord> QueryAllCalculatorRecord()
        {
            return _repository.QueryAllCalculatorRecord();
        }

        public bool DeleteCalculatorRecord(int Id)
        {
            return _repository.DeleteCalculator(Id);
        }

        public event EventHandler<CalculateCompletedEventArgs> CalculateCompletedEvent;

        private static CalculatorManager _instance = null;

        private static readonly object _synObject = new object();

        private void FireCalculateCompletedEvent(CalculateCompletedEventArgs eventArgs)
        {
            CalculateCompletedEvent?.Invoke(this, eventArgs);
        }

        private CalculatorManager() { }

        private CalculatorRepository _repository = new CalculatorRepository();
    }

    public class CalculateCompletedEventArgs : EventArgs
    {
        public double Result { get; set; }
    }
}
