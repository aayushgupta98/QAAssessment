using QAAssessment.GooglePageObjects;

namespace QAAssessment.GoogleTestsHelper
{
        /// <summary>
        /// class for providing methods to be tested in Google Home Page
        /// </summary>
        public class GoogleHomePage : GoogleWebTestHelper
        {
            /// <summary>
            /// searching in home page search bar
            /// </summary>
            /// <param name="keyword"></param>
            /// <param name="pageObject"></param>
            public void Search(string keyword, GoogleHomePageObject pageObject)
            {
                var element = pageObject.searchBar;
                element.SendKeys(keyword);
                element.Submit();
            }
        }
}
