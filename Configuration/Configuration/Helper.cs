using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Configuration
{
    public class Helper
    {
        public static IConfigurationRoot GetConfigurationRoot(string configFile)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(configFile);

            return builder.Build();
        }


    }
}
