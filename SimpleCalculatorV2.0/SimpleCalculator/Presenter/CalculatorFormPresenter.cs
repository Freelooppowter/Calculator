using SimpleCalculator.Model;

namespace SimpleCalculator.Presenter
{
    public class CalculatorFormPresenter
    {
        public CalculatorFormPresenter(ICalculatorFormViewable view)
        {
            _view = view;
            _model = CalculatorManager.GetInstance();
            _view.Operators = _model.Operators;
        }

        public void OnHandlerCreated()
        {
            Observe();
        }

        public void OnHandleDestroyed()
        {
            UnObserve();
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
                    try
                    {
                        _model.Calculate(doubleFirstNumber, doubleSecondNumber, _view.Operator, out isSuccess);
                        if (!isSuccess)
                        {
                            _view.Result = string.Empty;
                            _view.ShowErrorMessage(Properties.Resources.strDividedByZero);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        _view.ShowErrorMessage(ex.Message);
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

        private void Observe()
        {
            _model.CalculateCompletedEvent += _model_CalculateCompletedEvent;
        }

        private void UnObserve()
        {
            _model.CalculateCompletedEvent -= _model_CalculateCompletedEvent;
        }

        private void _model_CalculateCompletedEvent(object sender, CalculateCompletedEventArgs e)
        {
            _view.Result = e.Result.ToString();
        }

        private readonly ICalculatorFormViewable _view;

        private readonly CalculatorManager _model;
    }
}
