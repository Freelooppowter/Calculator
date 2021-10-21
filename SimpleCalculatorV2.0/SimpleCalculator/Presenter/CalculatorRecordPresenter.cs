using SimpleCalculator.DataAccess;
using SimpleCalculator.Model;
using System.Collections.Generic;
using SimpleCalculator.Domain;

namespace SimpleCalculator.Presenter
{
    public class CalculatorRecordPresenter
    {
        public CalculatorRecordPresenter(ICalculatorRecordFormViewable view)
        {
            _view = view;
            _model = CalculatorManager.GetInstance();
        }

        public void OnRefreshButtonClick()
        {
            List<CalculatorRecord> calculatorRecords = _model.QueryAllCalculatorRecord();
            List<CalculatorRecordDTO> calculatorRecordDTOS = new List<CalculatorRecordDTO>();
            foreach (var record in calculatorRecords)
            {
                CalculatorRecordDTO recordDTO = new CalculatorRecordDTO();
                recordDTO.Id = record.Id;
                recordDTO.FirstNumber = record.FirstNumber;
                recordDTO.Operator = record.Operator;
                recordDTO.SecondNumber = record.SecondNumber;
                recordDTO.Result = record.Result;
                recordDTO.OperateDateTime = record.OperateDateTime.ToString("yyyy-MM-dd HH:mm:ss");

                calculatorRecordDTOS.Add(recordDTO);
            }
            _view.CalculatorRecords = calculatorRecordDTOS;
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

        private ICalculatorRecordFormViewable _view;

        private CalculatorManager _model;
    }
}
