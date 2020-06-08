
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
           IWebDriver driver = new ChromeDriver();
             driver.Manage().Window.Maximize();
             driver.Navigate().GoToUrl("file:///C:/Users/User/Desktop/refactored/index.html");
            IWebElement searchInput = driver.FindElement(By.Id("minus")) ;
            searchInput.Click();
           // searchInput.SendKeys("Рафаэль");
           // searchInput.SendKeys(Keys.Tab);
          //  searchInput.SendKeys(Keys.Enter);
            // driver.FindElement(By.Name("btnK")).Click();
          //  driver.Quit();
        }
    }
}
