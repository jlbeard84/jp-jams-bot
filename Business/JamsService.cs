using JpJamsBot.Models;
using Microsoft.Extensions.Options;

namespace JpJamsBot.Business
{
    public class JamsService : IJamsService
    {
        private readonly AzureSettings _settings;

        public JamsService(IOptions<AzureSettings> settings)
        {
            _settings = settings?.Value;
        }

        
    }
}