using System;
using JpJamsBot.Base;
using JpJamsBot.Business;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace JpJamsBot
{
    public class JpJamsTwitter : FunctionBase
    {
        private readonly IJamsService _jamsService;

        public JpJamsTwitter(
            IJamsService jamsService)
        {
            _jamsService = jamsService;
            _jamsService.SetSettings(Settings);
        }

        [FunctionName("JpJamsTwitter")]
        public void Run([TimerTrigger("0 0 9 * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
