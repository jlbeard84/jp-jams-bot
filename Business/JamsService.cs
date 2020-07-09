using JpJamsBot.Models;

namespace JpJamsBot.Business
{
    public class JamsService : IJamsService
    {
        private AzureSettings _settings = new AzureSettings();

        public void SetSettings(AzureSettings settings)
        {
            _settings = settings;
        }
    }
}