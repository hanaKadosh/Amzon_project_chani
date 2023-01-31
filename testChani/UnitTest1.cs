using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace testChani
{
    public class Tests
    {
        Dictionary<string, string> myDictionary = new Dictionary<string, string>()
            {
                {"Price_Lower_Then", "100"},
                {"Price_Hiegher_OR_Equal_Then", "10"},
                {"Free_Shipping", "true"}
            };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //use in factory
            IWebDriver broser = BroserFactory.GetDriver("Chrome");
            Amazon amazon = new Amazon(broser);
            amazon.Pages.PageHome.Search.Text = "mouse";
            amazon.Pages.PageHome.Search.Click();
            var items=amazon.Pages.Results.GetResultBy(myDictionary);
           // Assert.AreEqual( );
        }

    }
}