using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundServiceExceptions.Core
{
    public class TimeService : ITimeService
    {
        public DateTime GetDateTime() => DateTime.Now;
    }
}
