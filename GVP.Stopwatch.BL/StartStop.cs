using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVP.Stopwatch.BL
{
    public class StartStop
    {



        //fields 

        private DateTime startTime;
        private DateTime stopTime;

        //flags
        bool running = false;
        bool cleared = true;

        public TimeSpan elapsetime;

        //properties 
        public string ElapsedTime
        {

            get
            {
                if (running && !cleared )
                {
                    return (DateTime.Now - startTime).ToString(@"hh\:mm\:ss");

                }
                else if(!running && cleared)
                {
                    return (stopTime - startTime).ToString(@"hh\:mm\:ss");
                }

               
                //TimeSpan elapsed = stopTime - startTime;
                return elapsetime.ToString(@"hh\:mm\:ss");
            }
        }

        //methods

        public void StartClock()
        {
            if (startTime != DateTime.MinValue && stopTime == DateTime.MinValue)
            {
                throw new StartException();
            }
            else if (cleared)
            {
                startTime = DateTime.Now;
                running = true;
                cleared = false;

            }
        }

        public void StopClock()
        {
            if (!running)
            {
                throw new StopException();
            }
            else if (!cleared && running)
            {
                stopTime = DateTime.Now;
                running = false;
                cleared = true;
            }
        
        }


        public void Reset()
        {
            startTime = DateTime.MinValue;
            stopTime = DateTime.MinValue;
        }

    }
}

