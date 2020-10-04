using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundServiceExceptions.Core
{
    public class TimeFileWorker : WorkerBase
    {
        private readonly TimeFileWorkerOptions workerOptions;
        private readonly ITimeService timeService;

        public TimeFileWorker(
            IOptions<TimeFileWorkerOptions> workerOptions,
            ITimeService timeService)
            : base(workerOptions.Value)
        {
            this.workerOptions = workerOptions.Value;
            this.timeService = timeService;
        }

        public override async Task DoWorkAsync()
        {
            Directory.CreateDirectory(workerOptions.OutputDirectory);

            var time = timeService.GetDateTime();

            var outFile = Path.Combine(
                workerOptions.OutputDirectory,
                $"{time:yyyy-MM-dd--HHmmss}.txt");

            File.WriteAllText(outFile, WorkerName);
        }
    }
}
