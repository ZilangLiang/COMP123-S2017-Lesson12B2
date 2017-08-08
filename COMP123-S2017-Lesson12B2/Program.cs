using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_Lesson12B2
{
    /*
     * Name: Zilang Liang
     * Date: August 3,2017
     * changed class to start Splash Form 
     */

    public static class Program
    {
        //FORM INSTANTIATION
        public static CalculatorForm calculatorForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            calculatorForm = new CalculatorForm();//instantiates object

            Application.Run(new SplashForm());
        }
    }
}
