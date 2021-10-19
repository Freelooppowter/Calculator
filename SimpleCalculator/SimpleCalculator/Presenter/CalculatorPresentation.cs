using SimpleCalculator.Domain;
using System.Reflection;
using System.Resources;

namespace SimpleCalculator.Presentation
{
    public class CalculatorPresentater
    {
        public CalculatorPresentater(ICalculatorFormViewable calculatorView)
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
            double numOne = 0;
            double numTwo = 0;
            if (isNumericValue(_view.NumOne, out numOne))
            {
                if (isNumericValue(_view.NumTwo, out numTwo))
                {
                    double calResult = CalculatorManager.Calculate(numOne, numTwo, _view.Oper, out isSuccess);
                    if (isSuccess)
                    {
                        _view.NumResult = calResult.ToString();
                    }
                    else
                    {
                        _view.NumResult = string.Empty;
                        _view.ShowErrorMsg(resourceManager.GetString("DivisorIsZero"));
                    }
                }
                else
                {
                    _view.NumTwoOnFocus();
                }
            }
            else
            {
                _view.NumOneOnFocus();
            }
        }

        private bool isNumericValue(string strNum, out double num)
        {
            num = 0;
            if (string.IsNullOrEmpty(strNum))
            {
                _view.ShowErrorMsg(resourceManager.GetString("ValueIsEmpty"));
                return false;
            }
            else
            {
                if (!double.TryParse(strNum, out num))
                {
                    _view.ShowErrorMsg(resourceManager.GetString("ValueIsInValid"));
                    return false;
                }
                return true;
            }
        }

        private ICalculatorFormViewable _view;

        private ResourceManager resourceManager = new ResourceManager(Properties.Resources.ResourceManager.BaseName, Assembly.GetExecutingAssembly());
    }
}
