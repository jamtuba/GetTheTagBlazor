using Microsoft.Extensions.Configuration;

namespace GetTheTagBlazor.Client.Helpers
{
    public class ConfigService : IConfigService
    {
        private readonly IConfiguration _configuration;

        public ConfigService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetUrl(string head, string part)
        {
            return _configuration.GetSection(head)[part];
        }
    }
}
