using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testChani
{
    public class Pages
    {
        private Page_Home pageHome;
        private Search_Bar searchBar;
        private Results results_;
        private IWebDriver driver;
        public Pages(IWebDriver driver)
        {
            this.driver = driver;
        }
        public Page_Home PageHome
        {
            get
            {
                if (pageHome == null)
                {
                    pageHome = new Page_Home(driver);
                }
                return pageHome;
            }

        }

        public Search_Bar SearchBar
        {
            get
            {
                if (searchBar == null)
                {
                    searchBar = new Search_Bar(driver);
                }
                return searchBar;
            }

        }
        public Results Results
        {
            get
            {
                if (results_ == null)
                {
                    results_ = new Results(driver);
                }
                return results_;
            }
        }
    }
}
