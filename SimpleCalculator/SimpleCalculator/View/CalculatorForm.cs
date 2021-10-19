using SimpleCalculator.Presentation;
using SimpleCalculator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class CalculatorForm : Form, ICalculatorFormViewable
    {
        public CalculatorForm()
        {
            InitializeComponent();
            _calculatorPresentation = new CalculatorPresentater(this);
        }

        #region ICalculatorFormViewable Members

        public List<string> Operators
        {
            set { cmb_Operator.DataSource = value; }
        }
        public string NumOne
        {
            get
            {
                return txt_NumOne.Text.Trim();
            }
        }

        public string NumTwo
        {
            get
            {
                return txt_NumTwo.Text.Trim();
            }
        }

        public string Oper
        {
            get
            {
                return cmb_Operator.Text;
            }
        }

        public string NumResult
        {
            set
            {
                txt_Result.Text = value;
            }
        }

        public int SelectedOperatorIndex
        {
            set
            {
                cmb_Operator.SelectedIndex = value;
            }
        }

        public void ShowErrorMsg(string errorMsg)
        {
            MessageBox.Show(errorMsg, resourceManager.GetString("ErrorMsgType"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void NumOneOnFocus()
        {
            txt_NumOne.Focus();
        }

        public void NumTwoOnFocus()
        {
            txt_NumTwo.Focus();
        }

        #endregion

        #region Private Methods

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            _calculatorPresentation.OnLoad();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            _calculatorPresentation.Calculate();

            //txt_Result.Text = string.Empty;
            //if (isValid())
            //{
            //    //该段代码逻辑分别放到 IView和Presentat里
            //    double numOne = double.Parse(txt_NumOne.Text.Trim());
            //    double numTwo = double.Parse(txt_NumTwo.Text.Trim());
            //    double numResult = 0;
            //    switch (cmb_Operator.Text)
            //    {
            //        case "+":
            //            numResult = numOne + numTwo;
            //            break;
            //        case "-":
            //            numResult = numOne - numTwo;
            //            break;
            //        case "*":
            //            numResult = numOne * numTwo;
            //            break;
            //        case "/":
            //            numResult = numOne / numTwo;
            //            break;
            //    }
            //    txt_Result.Text = numResult.ToString();
            //}
        }

        private void cmb_languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            ComponentResourceManager resources = new ComponentResourceManager(typeof(CalculatorForm));
            resources.ApplyResources(btn_Calc, "btn_Calc");
            resources.ApplyResources(lbl_lang, "lbl_lang");
            resources.ApplyResources(this, "$this");
        }

        #endregion

        private readonly CalculatorPresentater _calculatorPresentation;

        private ResourceManager resourceManager = new ResourceManager(Resources.ResourceManager.BaseName, Assembly.GetExecutingAssembly());
    }
}
