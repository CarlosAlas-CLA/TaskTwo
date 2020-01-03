using Microsoft.Extensions.Configuration;
using System.IO;

namespace TaskTwo.Services
{
    public class AppSettigns
    {
        public string ConnectionString { get; set; }
    }
    public class Settings
    {
        private static string settingsFilePath = @"C:\Users\carlo\Documents\TaskTwo\AppSetting.json";
        public static void settings(AppSettigns appSettigns)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile(settingsFilePath, optional: false, reloadOnChange: true);

            IConfigurationRoot conf = builder.Build();
            conf.GetSection("AppSettings").Bind(appSettigns);
        }
    }
}