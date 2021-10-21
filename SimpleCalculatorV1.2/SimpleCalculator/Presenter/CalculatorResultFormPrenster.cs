using SimpleCalculator.Model;

namespace SimpleCalculator.Presenter
{
    public class CalculatorResultFormPrenster
    {
        public CalculatorResultFormPrenster(ICalculatorResultFormViewable view)
        {
            _view = view;
            _model = CalculatorManager.GetInstance();
        }

        public void OnHandlerCreated()
        {
            Observe();
        }

        public void OnHandleDestroyed()
        {
            UnObserve();
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

        private readonly ICalculatorResultFormViewable _view;

        private readonly CalculatorManager _model;
    }
}
