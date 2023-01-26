using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testChani
{
    public class Search_Bar
    {
        private IWebDriver driver;
     
        public Search_Bar(IWebDriver driver) { 
            this.driver = driver;
        
        }
        public void Click() {
           
          driver.FindElement(By.Id("nav-search-submit-button")).Click();
          
        }
        public string Text {
            get 
            {
                var w = driver.FindElement(By.Id("nav-search-submit-button"));
                return w.Text;
            }
            set 
            { 
                driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys(value); 
            } 
        }
    }
}
