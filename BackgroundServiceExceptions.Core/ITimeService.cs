using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundServiceExceptions.Core
{
    public interface ITimeService
    {
        public DateTime GetDateTime();
    }
}
