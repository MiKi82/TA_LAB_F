using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace Fraimwork.Core
{
    public class DriverRuner
    {
        public const string browser_Firefox = "Firefox";
        public const string browser_Chrome = "Chrome";
        public const string browser_InternetExplorer = "InternetExplorer";
        public const string browser_Opera = "Opera";
        public const string browser_Safari = "Safari";


        public static IWebDriver Run(string browserName)
        {
            IWebDriver driver = null;

            driver = StartDriver(browserName);
            return driver;

        }
        private static IWebDriver StartDriver(string browserName)
        {
            switch (browserName)
            {

                case browser_Firefox:
                    return new FirefoxDriver();
                case browser_Chrome:
                    return new ChromeDriver();
                case browser_InternetExplorer:
                    return new InternetExplorerDriver();
                case browser_Safari:
                    return new SafariDriver();
                default:
                    throw new ArgumentException(string.Format(@"<{0}> was not recognized as supported browser. This parameter is case sensitive", browserName));
                                                
            }
        }


    }


}
