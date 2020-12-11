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

        int hundredsCounter = 0;
        int secondsCounter = 0;
        int minutesCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            // TODO if the watchTimer is not running, start it and change the button text to "Stop"
            if (false)
            {

            }
            else // TODO if the WatchTimer is running, stop it and change the button text to "Start"
            {

            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // TODO if the watchTimer is not running reset all variables and labels to 0
            if (false)
            {

            }
        }

        private void watchTimer_Tick(object sender, EventArgs e)
        {

            //TODO add 1 to the hundreds counter


            // TODO - check to see if we have reached one second
            // Since the tick method runs every 10 ms, 
            // if the hundreds counter gets to 100 we 
            // have gotten to one second, 100 * 10 = 1000ms = 1s.
            if (false)
            {

            }

            // TODO When we get to 60 seconds reset the seconds counter
            // and add 1 to minutes
            if (false)
            {

            }

            //TODO display values to all time labels


        }
    }
}
