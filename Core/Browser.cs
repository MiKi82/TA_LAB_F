using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Fraimwork.Core
{
    public static class Browser
    {
        private static IWebDriver _driver = null;

        public static IWebDriver Driver
        {
            // Если driver равен null (??), то создать новый Driver
            get
            {
                _driver = _driver ?? DriverRuner.Run(DriverRuner.browser_Chrome); // browser_... can be changed
                return _driver;
            }
            
        }


        public static void CloseDriver()
        {
            if (_driver != null)
            {
                _driver.Dispose();
                _driver = null;
            }
        }

        public static object ExecuteScript(string jsCode)
        {
            return (Driver as IJavaScriptExecutor).ExecuteScript(jsCode);
        }

        public static Screenshot TakeScreenshot()
        {
            return Driver.TakeScreenshot();
        }


        static readonly Finalizer finalizer = new Finalizer();
        sealed class Finalizer
        {
            ~Finalizer()
            {
                CloseDriver();
            }
        }

    }
}
