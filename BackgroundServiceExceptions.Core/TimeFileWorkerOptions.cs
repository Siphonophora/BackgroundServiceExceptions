using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundServiceExceptions.Core
{
    public class TimeFileWorkerOptions : IWorkerOptions
    {
        /// <inheritdoc/>
        public int RepeatIntervalSeconds { get; set; }

        /// <summary>
        /// Output directory for the <see cref="TimeFileWorker"/>.
        /// </summary>
        public string OutputDirectory { get; set; }
    }
}
