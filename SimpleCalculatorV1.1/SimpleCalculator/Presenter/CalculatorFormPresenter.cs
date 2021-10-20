using SimpleCalculator.Model;

namespace SimpleCalculator.Presenter
{
    public class CalculatorFormPresenter
    {
        public CalculatorFormPresenter(ICalculatorFormViewable calculatorView)
        {
            _view = calculatorView;
            _view.Operators = CalculatorManager.Operators;
        }

        public void OnLoad()
        {
            _view.SelectedOperatorIndex = 0;
        }

        public void Calculate()
        {
            bool isSuccess;
            double doubleFirstNumber = 0;
            double doubleSecondNumber = 0;
            if (IsNumeric(_view.FirstNumber, out doubleFirstNumber))
            {
                if (IsNumeric(_view.SecondNumber, out doubleSecondNumber))
                {
                    double calResult = CalculatorManager.Calculate(doubleFirstNumber, doubleSecondNumber, _view.Operator, out isSuccess);
                    if (isSuccess)
                    {
                        _view.Result = calResult.ToString();
                    }
                    else
                    {
                        _view.Result = string.Empty;
                        _view.ShowErrorMessage(Properties.Resources.strDividedByZero);
                    }
                }
                else
                {
                    _view.FocusToSecondNumber();
                }
            }
            else
            {
                _view.FocusToFirstNumber();
            }
        }

        private bool IsNumeric(string strValue, out double doubleValue)
        {
            doubleValue = 0;
            if (string.IsNullOrEmpty(strValue))
            {
                _view.ShowErrorMessage(Properties.Resources.strValueIsEmpty);
                return false;
            }
            else
            {
                if (!double.TryParse(strValue, out doubleValue))
                {
                    _view.ShowErrorMessage(Properties.Resources.strValueIsInValid);
                    return false;
                }
                return true;
            }
        }

        private ICalculatorFormViewable _view;

    }
}
