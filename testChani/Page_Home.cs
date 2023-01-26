using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testChani
{
    public class Page_Home
    {
        private Search_Bar search;
        private Results results_;
        private IWebDriver driver;

        public Page_Home(IWebDriver driver)
        {
            this.driver = driver;
        }
        public Search_Bar Search {

            get
            {
                if (search == null)
                {
                    search = new Search_Bar(driver);
                }
                return search;
            }
        } 
        public Results Results_
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
