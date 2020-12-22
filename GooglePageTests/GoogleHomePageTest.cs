using NUnit.Framework;
using QAAssessment.GoogleTestsHelper;
using System.Collections.Generic;

namespace QAAssessment.GooglePageTests
{
    /// <summary>
    /// class for testing google home page
    /// </summary>
    public class GoogleHomePageTest : GoogleWebTestHelper
    {
        /// <summary>
        /// creating instance for Google Home Page
        /// </summary>
        public GoogleHomePage googleHomePage;

        /// <summary>
        /// getting data for testing from csv file
        /// </summary>
        public static List<TestCaseData> TestCases = DataAccess.DataAccess.TestCases;

        /// <summary>
        /// testing for google search on home page
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [TestCaseSource("TestCases")]
        public bool Test_GoogleSearch(string keyword, string expectedTitle)
        {
            // arrange
            googleHomePage = new GoogleHomePage();
            browser.Goto("https://www.google.com/");

            // act
            googleHomePage.Search(keyword, googlePageObject);

            // assert
            Assert.AreEqual(expectedTitle, driver.Title);
            return expectedTitle == driver.Title;
        }
    }
}
