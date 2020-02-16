using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace Fraimwork.Core
{
    
    public static class Extentions
    {
      
        public static readonly int DefaultTimeOutMilliseconds = 1000;

       
        public static IWebElement WaitUntilVisible(this IWebElement element, TimeSpan timeOut)
        {
            return Wait.UntilVisible(element, timeOut);
        }

   
        public static IWebElement WaitUntilVisible(this IWebElement element, int timeOutMilliseconds)
        {
            return Wait.UntilVisible(element, TimeSpan.FromMilliseconds(timeOutMilliseconds));
        }

     

        public static IWebElement WaitUntilVisible(this IWebElement element)
        {
            return Wait.UntilVisible(element, TimeSpan.FromMilliseconds(DefaultTimeOutMilliseconds));
        }

     
        public static string GetElementText(this IWebElement element)
        {
            string result = "";
            string tag = element.TagName.ToLower();

            switch (tag)
            {
                case "input":
                    result = element.GetAttribute("value");
                    break;
                case "select":
                    result = new SelectElement(element).SelectedOption.Text;
                    break;
                default:
                    result = element.Text;
                    break;
            }
            return result;
        }

        public static bool IsDisplayedSafe(this IWebElement element)
        {
            bool result = false;
            try
            {
                result = element.Displayed;
            }
            catch (Exception e)
            {

                // Empty; Ignored
            }
            return result;

        }
    }
}
