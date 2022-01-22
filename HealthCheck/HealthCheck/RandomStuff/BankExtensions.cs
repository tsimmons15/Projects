using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCheck.RandomStuff
{
    public static class BankExtensions
    {
        /// <summary>
        /// An example of querying Configurations in a strongly-typed way instead of the standard IConfigurations method
        /// </summary>
        /// <param name="service">The class this method extends</param>
        /// <param name="configuration">The IConfiguration object that holds the appsettings.json file</param>
        /// <returns></returns>
        public static IServiceCollection AddBank(this IServiceCollection service, IConfiguration configuration)
        {
            // Get the data section we're interested in
            var section = configuration.GetSection("Bank");
            // The settings class 
            var settings = new BankSettings();

            // Fill the settings class using the JSON read into the section
            new ConfigureFromConfigurationOptions<BankSettings>(section).Configure(settings);

            // Register the new object as a Singleton for use at future times
            service.AddSingleton(new Bank(settings));

            return service;
        }
    }
}
