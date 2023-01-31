using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace testChani
{
    public class Results
    {
        private IWebDriver driver;
        public Results(IWebDriver driver)
        {
            this.driver = driver;

        }

        public List<Item> GetResultBy(Dictionary<string, string> dictionary)
        {
            List<Item> response = new List<Item>();
         
            string Xpath = "//div[@data-component-type='s-search-result' ";
            foreach (KeyValuePair<string, string> item in dictionary)
            {
                switch (item.Key)
                {
                    case "Price_Lower_Then":
                        Xpath += "and descendant::span[@class='a-offscreen' and translate(text(),'$,','')<" + dictionary[item.Key] + " and parent::span[not(contains(@data-a-strike,'true'))]]";
                        break;
                    case "Price_Hiegher_OR_Equal_Then":

                        Xpath += "and descendant::span[@class='a-offscreen' and translate(text(),'$,','')>=" + dictionary[item.Key]+" and parent::span[not(contains(@data-a-strike,'true'))]]";
                        break;
                    case "Free_Shipping":
                        if (item.Value == "false")
                        {
                            Xpath += " and descendant::span[@class='a-color-base a-text-bold'  and contains not(text(),'FREE')]";
                        }
                        else
                            Xpath += " and descendant::span[@class='a-color-base a-text-bold'  and contains (text(),'FREE')]";
                        break;
                        
                    default:
                        Console.WriteLine("Key not found in the dictionary");
                        break;
                }
            }
            Xpath += "]";
           
            List<IWebElement> elements = driver.FindElements(By.XPath(Xpath)).ToList();

            foreach (IWebElement webelement in elements)
            {
                
                string title = webelement.FindElement(By.XPath(".//span[@class='a-size-medium a-color-base a-text-normal']")).Text;
                string price = webelement.FindElement(By.XPath(".//span[@class= 'a-price-whole']")).Text + '.' + webelement.FindElement(By.XPath("//span[@class='a-price-fraction']")).Text + '$';
                string url = webelement.FindElement(By.XPath(".//a[@class='a-link-normal s-underline-text s-underline-link-text s-link-style a-text-normal']")).GetAttribute("href");
                Console.WriteLine(webelement.Text);
               
                Item temp = new Item(title, url, price);
                Console.WriteLine(webelement.ToString());
                response.Add(temp);
            }

            return response;
        }

    }
}

//$x("//parent::div[span[contains(@class, 'a-price') and concat(descendant::span[@class='a-price-whole']//text() ,'.',descendant::span[@class='a-price-fraction']//text()) < 99.99]]//following-sibling::div[contains(text(),'משלוח בחינם')]")
