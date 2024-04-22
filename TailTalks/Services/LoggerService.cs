using Microsoft.Extensions.DependencyInjection;
using TailTalks.Logging;

namespace TailTalks.Services
{
    public static class LoggerService
    {
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}
