using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVP.Stopwatch.BL
{
    public class StartException: Exception
    {
        
/*        public DateTime StartTime { get; }
*/
        public StartException( )
            : base("The clock is already running and cannot be started again.")
        { }
        

    }
}
