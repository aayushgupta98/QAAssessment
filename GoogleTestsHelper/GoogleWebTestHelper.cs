using OpenQA.Selenium;
using System;

namespace QAAssessment.GoogleTestsHelper
{
    /// <summary>
    /// Google Web application testing helper class
    /// </summary>
    public class GoogleWebTestHelper
    {
        protected IWebDriver driver;
        protected readonly TestInitialization browser;
        protected GooglePageObjects.GoogleHomePageObject googlePageObject;

        /// <summary>
        /// constructor to initialize instances
        /// </summary>
        public GoogleWebTestHelper()
        {
            browser = new TestInitialization();
        }

        /// <summary>
        /// Initializing browser
        /// </summary>
        [NUnit.Framework.OneTimeSetUp]
        public void start_Browser()
        {
            try
            {
                browser.Init_Browser();
                driver = browser.getDriver;
                googlePageObject = new GooglePageObjects.GoogleHomePageObject(driver);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine($"Exception occured - {e}");
            }
        }

        /// <summary>
        /// closing browser
        /// </summary>
        [NUnit.Framework.OneTimeTearDown]
        public void closeBrowser()
        {
            browser.Close();
        }
    }
}
