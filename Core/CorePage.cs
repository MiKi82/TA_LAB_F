using OpenQA.Selenium;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;

namespace Fraimwork.Core
{
    
        public abstract class CorePage
        {
        public IWebDriver Driver { get { return Browser.Driver; } }

        protected CorePage()
            {
                PageFactory.InitElements(Driver, this);
            }
        }
    
}
