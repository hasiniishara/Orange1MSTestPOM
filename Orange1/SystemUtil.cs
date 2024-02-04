using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.Extensions.Configuration;

namespace Orange1MSTestPOM
{
    public static class SystemUtil
    {
        private static IWebDriver driver;
        private static IConfigurationRoot configuration;


        static SystemUtil()
        {
            // Set up configuration
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            configuration = builder.Build();
        }

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            return driver;
        }

        public static void OpenSystem()
        {
            GetDriver().Navigate().GoToUrl("https://devmini-trials711.orangehrmlive.com/");
        }

        public static string GetUsername(string userKey)
        {
            return configuration[$"{userKey}:Username"];
        }

        public static string GetPassword(string userKey)
        {
            return configuration[$"{userKey}:Password"];
        }


        public static void CloseDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}