using System;
using System.Threading.Tasks;
using JpJamsBot.Base;
using JpJamsBot.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace JpJamsBot
{
    public class JpJamsTwitter
    {
        private readonly IJamsService _jamsService;

        public JpJamsTwitter(
            IJamsService jamsService)
        {
            _jamsService = jamsService;
        }

        [FunctionName("JpJamsTwitter")]
        public async Task Run(
            //[TimerTrigger("0 0 9 * * *")]TimerInfo myTimer, 
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
