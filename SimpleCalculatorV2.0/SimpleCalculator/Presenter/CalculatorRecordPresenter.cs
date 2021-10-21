using SimpleCalculator.Domain;
using SimpleCalculator.Model;
using System.Collections.Generic;

namespace SimpleCalculator.Presenter
{
    public class CalculatorRecordPresenter
    {
        public CalculatorRecordPresenter(ICalculatorRecordFormViewable view)
        {
            _view = view;
            _model = CalculatorManager.GetInstance();
        }

        public void OnLoad()
        {
            _view.CalculatorRecords = QueryAllCalculatorRecord();
        }

        public void OnRefreshButtonClick()
        {
            _view.CalculatorRecords = QueryAllCalculatorRecord();
        }

        public void OnDeleteButtonClick()
        {
            bool isSuccess = _model.DeleteCalculatorRecord(_view.SelectedRowId);
            if (isSuccess)
            {
                _view.ShowMessage(Properties.Resources.strDeletedSuccessfully);
                OnRefreshButtonClick();
            }
            else
            {
                _view.ShowMessage(Properties.Resources.strDeleteFailed);
            }
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
            OnRefreshButtonClick();
        }

        private List<CalculatorRecordItem> QueryAllCalculatorRecord()
        {
            List<CalculatorRecord> calculatorRecords = _model.QueryAllCalculatorRecord();
            List<CalculatorRecordItem> calculatorRecordItems = new List<CalculatorRecordItem>();
            foreach (var record in calculatorRecords)
            {
                CalculatorRecordItem recordDTO = new CalculatorRecordItem();
                recordDTO.Id = record.Id;
                recordDTO.FirstNumber = record.FirstNumber;
                recordDTO.Operator = record.Operator;
                recordDTO.SecondNumber = record.SecondNumber;
                recordDTO.Result = record.Result;
                recordDTO.OperateDateTime = record.OperateDateTime.ToString("yyyy-MM-dd HH:mm:ss");

                calculatorRecordItems.Add(recordDTO);
            }
            return calculatorRecordItems;
        }

        private ICalculatorRecordFormViewable _view;

        private CalculatorManager _model;
    }
}
