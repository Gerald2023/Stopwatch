using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVP.Stopwatch.BL
{
    public class StopException: Exception
    {


        public StopException()
            : base("The clock has not been started yet")
        {
  
        }
    }
}
