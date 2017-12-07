using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatchApp
{
    public partial class Form1 : Form
    {
        /// (true) is used to do the initial learning with the students
        /// where we start a timer, add to a timer, and change colours
        /// (false) used for the timer code   
        Boolean learning = true;

        // used for learning section
        int counter = 0;

        // used for timer

        int hundredsCounter = 0;
        int secondsCounter = 0;
        int minutesCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {   
            if (learning == true)
            {
                //TODO set timer interval to 500 and enable it
            }
            else if (learning == false)
            {
                //TODO set timer interval to 10

                //TODO if timer is not enabled, enable it and set button message to "Stop"
                if (false)
                {

                }
                //TODO else disable timer and set button message to "Start"
                else
                {

                }
            }
        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            if (learning == true)
            {
                //TODO add to counter and display value to label

                //TODO alternate between 3 colours for colourLabel
                if (false)
                {

                }
                else if (false)
                {

                }
                else
                {

                }

            }
            else if (learning == false)
            {
                //TODO add to hundreds counter

                //TODO adjust seconds counter and label if it is time
                if (false)
                {

                }

                //TODO adjust minutes counter and label if it is time
                if (false)
                {

                }

                //TODO display values to all time labels

            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // if timer not enabled reset all counters and labels
            if (false)
            {

            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
