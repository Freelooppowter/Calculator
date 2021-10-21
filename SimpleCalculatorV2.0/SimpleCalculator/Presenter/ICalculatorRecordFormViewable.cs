using SimpleCalculator.Domain;
using System.Collections.Generic;

namespace SimpleCalculator.Presenter
{
    public interface ICalculatorRecordFormViewable
    {
        int SelectedRowId { get; }
        List<CalculatorRecordDTO> CalculatorRecords { set; }

        void ShowMessage(string strMessage);
    }
}
