using SimpleCalculator.View;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SimpleCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            System.Globalization.CultureInfo currentCultureInfo = new System.Globalization.CultureInfo(System.Configuration.ConfigurationManager.AppSettings["DefaultLanguage"]);
            Thread.CurrentThread.CurrentCulture = currentCultureInfo;
            Thread.CurrentThread.CurrentUICulture = currentCultureInfo;

            CalculatorResultForm form2 = new CalculatorResultForm();
            form2.Location = new Point(Screen.PrimaryScreen.WorkingArea.Size.Width - form2.Width, 12);
            form2.Show();
            CalculatorRecordForm form3 = new CalculatorRecordForm();
            form3.Location = new Point(12, 12);
            form3.Show();
            Application.Run(new CalculatorForm());
        }
    }
}
