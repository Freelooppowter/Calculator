using System.Collections.Generic;

namespace SimpleCalculator.Presenter
{
    public interface ICalculatorFormViewable
    {
        /// <summary>
        /// 四则运算第一个数值
        /// </summary>
        string FirstNumber { get; }

        /// <summary>
        /// 四则运算第二个数值
        /// </summary>
        string SecondNumber { get; }

        /// <summary>
        /// 运算符(+、-、*、\)
        /// </summary>
        string Operator { get; }

        /// <summary>
        /// 运算结果
        /// </summary>
        string Result { set; }

        int SelectedOperatorIndex { set; }

        /// <summary>
        /// 错误信息显示
        /// </summary>
        /// <param name="errorMsg"></param>
        void ShowErrorMessage(string errorMsg);

        /// <summary>
        /// 运算符列表
        /// </summary>
        List<string> Operators { set; }

        void FocusToFirstNumber();

        void FocusToSecondNumber();
    }
}
