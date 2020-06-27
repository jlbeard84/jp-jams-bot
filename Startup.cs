using JpJamsBot.Business;
using JpJamsBot.Models;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(JpJamsBot.Startup))]

namespace JpJamsBot
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services
                .AddOptions<AzureSettings>()
                .Configure<IConfiguration>((settings, configuration) => 
                {
                    configuration
                        .GetSection(nameof(AzureSettings))
                        .Bind(settings);
                });

            builder.Services.AddScoped<IJamsService, JamsService>();
        }
    }
}