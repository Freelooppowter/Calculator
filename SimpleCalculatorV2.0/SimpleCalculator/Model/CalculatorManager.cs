using System;
using System.Collections.Generic;
using SimpleCalculator.DataAccess;
using System.Linq;

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
                    using (CalculatingContext dbContext = new CalculatingContext())
                    {
                        CalculatorRecord calculator = new CalculatorRecord();
                        calculator.FirstNumber = firstNumber;
                        calculator.SecondNumber = secondNumber;
                        calculator.Operator = strOperator;
                        calculator.Result = doubleResult;
                        calculator.OperateDateTime = DateTime.Now;

                        dbContext.CalculatorRecords.Add(calculator);
                        dbContext.SaveChanges();
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }

                CalculateCompletedEventArgs eventArgs = new CalculateCompletedEventArgs { Result = doubleResult };
                FireCalculateCompletedEvent(eventArgs);
            }
        }

        public List<string> Operators = new List<string> { "+", "-", "*", "/" };

        public List<CalculatorRecord> QueryAllCalculatorRecord()
        {
            using (CalculatingContext db = new CalculatingContext())
            {
                var query = from record in db.CalculatorRecords orderby record.Id select record;
                return query.ToList();
            }
        }

        public bool DeleteCalculatorRecord(int Id)
        {
            using (CalculatingContext db = new CalculatingContext())
            {
                CalculatorRecord calculatorRecord = db.CalculatorRecords.Find(Id);
                if (calculatorRecord != null)
                {
                    db.CalculatorRecords.Remove(calculatorRecord);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

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
