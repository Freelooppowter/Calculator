using SimpleCalculator.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleCalculator.View
{
    public partial class CalculatorForm : Form, ICalculatorFormViewable
    {
        public CalculatorForm()
        {
            InitializeComponent();
            _presenter = new CalculatorFormPresenter(this);
        }

        #region ICalculatorFormViewable Members

        public List<string> Operators
        {
            set { operatorCombox.DataSource = value; }
        }
        public string FirstNumber
        {
            get
            {
                return firstNumberTextBox.Text.Trim();
            }
        }

        public string SecondNumber
        {
            get
            {
                return secondNumberTextBox.Text.Trim();
            }
        }

        public string Operator
        {
            get
            {
                return operatorCombox.Text;
            }
        }

        public string Result
        {
            set
            {
                ResultTextBox.Text = value;
            }
        }

        public int SelectedOperatorIndex
        {
            set
            {
                operatorCombox.SelectedIndex = value;
            }
        }

        public void ShowErrorMessage(string strErrorMessageg)
        {
            MessageBox.Show(strErrorMessageg, Properties.Resources.strErrorMessageType, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void FocusToFirstNumber()
        {
            firstNumberTextBox.Focus();
        }

        public void FocusToSecondNumber()
        {
            secondNumberTextBox.Focus();
        }

        #endregion

        #region Private Methods

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            _presenter.OnLoad();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            _presenter.Calculate();
        }
        #endregion

        private readonly CalculatorFormPresenter _presenter;
    }
}
