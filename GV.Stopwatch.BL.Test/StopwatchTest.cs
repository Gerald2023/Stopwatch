

using System.Diagnostics;

namespace GV.Stopwatch.BL.Test
{
     using StartStop = GVP.Stopwatch.BL.StartStop;

    [TestClass]
    public class StopwatchTest
    {
        //hi

        [TestMethod]
        public void StartClockTest()
        {
            StartStop startStop = new StartStop();

            startStop.StartClock();

            //wait a second for the StartClock to run
            Thread.Sleep(1000);

            if (startStop.ElapsedTime == "00:00:00") Assert.Fail();



        }

        [TestMethod]

        public void StopClockTest()
        {
            //initiliazing variables
            DateTime dateTimeStart ;
            DateTime dateTimeStop;

            StartStop startStop = new StartStop();


            startStop.StartClock();
            dateTimeStart= DateTime.Now;
            Thread.Sleep(1000);


            startStop.StopClock();
            dateTimeStop = DateTime.Now;


            //comparing

            Assert.IsTrue(DateTime.Compare(dateTimeStart, dateTimeStop) != 0);









        }

    }
}