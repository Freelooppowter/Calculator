using SimpleCalculator.Presenter;
using System.Windows.Forms;

namespace SimpleCalculator.View
{
    public partial class CalculatorResultForm : Form, ICalculatorResultFormViewable
    {
        public CalculatorResultForm()
        {
            InitializeComponent();
            _presenter = new CalculatorResultFormPrenster(this);
            this.HandleCreated += CalculatorResultForm_HandleCreated;
            this.HandleDestroyed += CalculatorResultForm_HandleDestroyed;
        }

        #region ICalculateActionable Members

        public string Result { set { resultLabel.Text = value; } }

        #endregion

        private void CalculatorResultForm_HandleCreated(object sender, System.EventArgs e)
        {
            _presenter.OnHandlerCreated();
        }
        private void CalculatorResultForm_HandleDestroyed(object sender, System.EventArgs e)
        {
            _presenter.OnHandleDestroyed();
        }

        private readonly CalculatorResultFormPrenster _presenter;
    }
}
