using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Date: August 8,2017
/// Desctiption: This is the SplashForm that appears for three seconds
/// and launches the calculator application
/// version 0.1 - Created the form
/// </summary>
namespace COMP123_S2017_Lesson12B2
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the "Tick" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WelcomePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
