using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orange1
{
    public static class SystemUtil
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if(driver == null)
            {
                driver = new ChromeDriver();
            }
            return driver;
        }

        public static void OpenSystem()
        {
            GetDriver().Navigate().GoToUrl("https://devmini-trials711.orangehrmlive.com/");
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
