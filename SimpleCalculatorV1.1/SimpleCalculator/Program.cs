using System;
using System.Windows.Forms;
using SimpleCalculator.View;
using System.Threading;

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

            System.Globalization.CultureInfo currentCultureInfo=new System.Globalization.CultureInfo(System.Configuration.ConfigurationManager.AppSettings["DefaultLanguage"]);
            Thread.CurrentThread.CurrentCulture = currentCultureInfo;
            Thread.CurrentThread.CurrentUICulture = currentCultureInfo;

            Application.Run(new CalculatorForm());
        }
    }
}
