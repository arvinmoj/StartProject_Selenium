using System;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {

            // Open Google Chrome
            IWebDriver driver = new ChromeDriver();
            //Enter URl for Go website
            driver.Navigate().GoToUrl("https://google.com");
            //Sleep
            Thread.Sleep(10);
            //Click Element Driver
            driver.FindElement(By.Name("q")).SendKeys("Arvinmoj" + Keys.Enter);
            //Function Finde Element 
            IWebElement element = driver.FindElement(By.XPath(""));
            //Element Enter text 
            element.SendKeys("");
            //Click Element  
            element.Click();
            //Press Key
            element.SendKeys(OpenQA.Selenium.Keys.Enter);
            //Mouse Hover Action
            Actions actions = new Actions(driver);
            //Find Element
            IWebElement target = driver.FindElement(By.XPath(""));
            //Mouse hover Move To Element
            actions.MoveToElement(target).Perform();
            //Find Element
            IWebElement slider = driver.FindElement(By.XPath(""));
            //Retrieve WebElemnt 'slider' to perform mouse hover
            actions.MoveToElement(slider, 50, 0).Perform();
            // Storing URL in String variable
            String PageURL = driver.Url;
            // Printing URL on Console
            Console.WriteLine("URL of the page is : " + PageURL);
            // Storing Page Source in String variable
            String PageSource = driver.PageSource;
            // Printing Page Source on console
            Console.WriteLine("Page Source of the page is : " + PageSource);
            // Storing Page Source length in Int variable
            int PageSourceLength = driver.PageSource.Length;
            // Printing Page SOurce length on console
            Console.WriteLine("Length of the Page Source is : " + PageSourceLength);
            
        }
    }
}
