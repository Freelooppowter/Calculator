using SimpleCalculator.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleCalculator.View
{
    public partial class CalculatorRecordForm : Form, ICalculatorRecordFormViewable
    {
        public CalculatorRecordForm()
        {
            InitializeComponent();
            _presenter = new CalculatorRecordPresenter(this);
            this.HandleCreated += CalculatorRecordForm_HandleCreated;
            this.HandleDestroyed += CalculatorRecordForm_HandleDestroyed;
        }

        public int SelectedRowId
        {
            get
            {
                object currentRowData = calculatorRecordDataGridView.CurrentRow.DataBoundItem;
                if (currentRowData != null)
                {
                    CalculatorRecordItem calculator = currentRowData as CalculatorRecordItem;
                    if (calculator != null)
                        return calculator.Id;
                }
                return -1;
            }
        }

        public List<CalculatorRecordItem> CalculatorRecords
        {
            set
            {
                calculatorRecordDataGridView.DataSource = value;
            }
        }

        public void ShowMessage(string strMessage)
        {
            MessageBox.Show(strMessage);
        }

        private void CalculatorRecordForm_HandleCreated(object sender, EventArgs e)
        {
            _presenter.OnHandlerCreated();
        }

        private void CalculatorRecordForm_HandleDestroyed(object sender, EventArgs e)
        {
            _presenter.OnHandleDestroyed();
        }

        private void CalculatorRecordForm_Load(object sender, EventArgs e)
        {
            _presenter.OnLoad();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            _presenter.OnRefreshButtonClick();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _presenter.OnDeleteButtonClick();
        }

        private CalculatorRecordPresenter _presenter;
    }
}
