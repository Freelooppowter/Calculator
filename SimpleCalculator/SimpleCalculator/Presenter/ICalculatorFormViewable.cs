using System.Collections.Generic;

namespace SimpleCalculator.Presentation
{
    public interface ICalculatorFormViewable
    {
        /// <summary>
        /// 四则运算第一个数值
        /// </summary>
        string NumOne { get; }

        /// <summary>
        /// 四则运算第二个数值
        /// </summary>
        string NumTwo { get; }

        /// <summary>
        /// 运算符(+、-、*、\)
        /// </summary>
        string Oper { get; }

        /// <summary>
        /// 运算结果
        /// </summary>
        string NumResult { set; }

        int SelectedOperatorIndex { set; }

        /// <summary>
        /// 错误信息显示
        /// </summary>
        /// <param name="errorMsg"></param>
        void ShowErrorMsg(string errorMsg);

        /// <summary>
        /// 运算符列表
        /// </summary>
        List<string> Operators { set; }

        void NumOneOnFocus();

        void NumTwoOnFocus();
    }
}
