using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QAAssessment
{
    /// <summary>
    /// class for initializing and closing webdriver 
    /// </summary>
    public class TestInitialization
    {
        /// <summary>
        /// webdriver instance
        /// </summary>
        IWebDriver webDriver;

        /// <summary>
        /// initializing webdriver and browser
        /// </summary>
        public void Init_Browser()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }

        /// <summary>
        /// going to specified url
        /// </summary>
        /// <param name="url"></param>
        public void Goto(string url)
        {
            webDriver.Url = url;
        }

        /// <summary>
        /// closing webdriver instance
        /// </summary>
        public void Close()
        {
            webDriver.Quit();
        }

        /// <summary>
        /// returning webdriver instance
        /// </summary>
        public IWebDriver getDriver
        {
            get { return webDriver; }
        }
    }
}
