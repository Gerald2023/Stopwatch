
 using GVP.Stopwatch.BL;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace GV.StopWatch.UI
{
/*    using StopWatch = GVP.Stopwatch.BL.Stopwatch;
*/    public partial class Form1 : Form
    {
        private List<string> splitTimes = new List<string>();
        StartStop startStop = new StartStop();// initializing class
        public Form1()
        {
            InitializeComponent();
            lblDisplay.Text = "00:00:00";
            timer1.Enabled = false;

        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
           
                startStop.StartClock();
                timer1.Enabled = true;

             

            }
            catch (StartException startex)
            {

                MessageBox.Show(startex.Message);
            }
        }



        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                startStop.StopClock();
                timer1.Enabled = false;
                lblDisplay.Text = startStop.ElapsedTime;

            }
            catch (StopException stopex)
            {

                MessageBox.Show(stopex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDisplay.Text = startStop.ElapsedTime;
        }



        private void btnSplit_Click(object sender, EventArgs e)
        {
            //splitTimes.Add(startStop.ElapsedTime); // add split time to the list
            //lstSplitTimes.Items.Add(splitTimes.Last()); // display the latest split time in the listbox

            try
            {
                // Recording the split time
                startStop.RecordSplitTime(splitTimes);

                // Add the latest split time to the list box with a number
                int splitNumber = lstSplitTimes.Items.Count + 1;
                string splitTimeWithNumber = $"{splitNumber}. {splitTimes.Last()}";
                lstSplitTimes.Items.Add(splitTimeWithNumber);

            }
            catch (Exception)
            {

                MessageBox.Show("Please start the stopwatch to split time");

            }

        }        
        private void btnReset_Click(object sender, EventArgs e)
        {
            startStop.Reset();
            
            splitTimes.Clear();
            lstSplitTimes.Items.Clear();
            lblDisplay.Text = "00:00:00";
            
        }
    }
}