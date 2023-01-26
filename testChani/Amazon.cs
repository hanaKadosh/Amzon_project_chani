using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testChani
{
    public class Amazon
    {
        private Pages pages;
        private   IWebDriver driver;
        public Amazon(IWebDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("https://www.amazon.com/?language=en_US&currency=USD");
        }
          
        public Pages Pages {
            get
            {
                if (pages == null)
                {
                    pages = new Pages(this.driver);
                }
                return pages;
            }
        }


    }
}
