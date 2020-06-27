using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace JpJamsBot
{
    public static class JpJamsTwitter
    {
        [FunctionName("JpJamsTwitter")]
        public static void Run([TimerTrigger("0 0 9 * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
