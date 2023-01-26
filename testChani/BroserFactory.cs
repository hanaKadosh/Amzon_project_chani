using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testChani
{
    public class BroserFactory
    {
        private static string pathComputer = "C:\\Users\\Chani\\drivers";
        List<IWebDriver> listBrowser = new List<IWebDriver>();
        public static IWebDriver GetDriver(string browser)
        {
            IWebDriver driver;
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver(pathComputer);
                    break;
                case "Firefox":
                    driver = new FirefoxDriver(pathComputer);
                    break;
                case "Edge":
                    driver = new EdgeDriver(pathComputer);
                    break;
                default:
                    throw new ArgumentException("Invalid browser type");
            }
            return driver;
        }

        public static void CloseDriver(IWebDriver driver)
        {
            driver.Quit();
        }

    }
}
