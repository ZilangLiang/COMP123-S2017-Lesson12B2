using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// version 0.3 - Added the clear method to reset calculator
/// </summary>
namespace COMP123_S2017_Lesson12B2
{
    public partial class CalculatorForm : Form
    {
        //private instance variables
        private bool _isDecimalClicked;


        //public properties +++++++++++++++++++++
        public bool IsDecimalClicked
        {
            get
            {
                return this._isDecimalClicked;
            }
            set
            {
                this._isDecimalClicked = value;
            }
        }

        //Consturctors ++++++++++++++++++++++++


        /// <summary>
        /// This is main constructor
        /// </summary>

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the event handle for the "FormClosing" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();// this closes the application
        }

        /// <summary>
        /// This is a share event handler for the Calculator Button
        /// Noting including the operator buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;//downcasting  //Button(sender)

            if((buttonClicked.Text == ".") && (!this.IsDecimalClicked))
            {
                return;
            }

            if (buttonClicked.Text == ".")
            {
                this.IsDecimalClicked = true;
            }
            if(ResultTextBox.Text == "0")
            {
                ResultTextBox.Text = buttonClicked.Text;
            }
            else
            {
                ResultTextBox.Text = buttonClicked.Text;
            }
            

            //Debug.WriteLine("Calculator Button Click");
        }

        /// <summary>
        /// this is the shared event handler for Operator Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button operatorButton = sender as Button;

            switch (operatorButton.Text)
            {
                case "C":
                    this._clear();
                    break;
            }
        }

        /// <summary>
        /// this method clears the calculator
        /// </summary>
        private void _clear()
        {
            this.IsDecimalClicked = false;
            this.ResultTextBox.Text = "0";
        }

        /// <summary>
        /// This is the event handler for the Form's "Load" evemt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this._clear(); 
        }
    }
}
