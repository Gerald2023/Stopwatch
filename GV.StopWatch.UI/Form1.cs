
 using GVP.Stopwatch.BL;

namespace GV.StopWatch.UI
{
/*    using StopWatch = GVP.Stopwatch.BL.Stopwatch;
*/    public partial class Form1 : Form
    {

        StartStop startStop = new StartStop();// initializing class
        public Form1()
        {
            InitializeComponent();
            //stopWatch.Reset();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            startStop.Reset();
            lblDisplay.Text = "00:00:00";
        }
    }
}