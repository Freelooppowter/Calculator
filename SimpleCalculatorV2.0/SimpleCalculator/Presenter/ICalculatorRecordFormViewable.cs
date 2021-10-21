using System.Collections.Generic;

namespace SimpleCalculator.Presenter
{
    public interface ICalculatorRecordFormViewable
    {
        int SelectedRowId { get; }

        List<CalculatorRecordItem> CalculatorRecords { set; }

        void ShowMessage(string strMessage);
    }
}
