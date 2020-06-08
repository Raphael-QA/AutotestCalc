using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSelenium
{
    [TestFixture]
    class Test
    {
        IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
           
        }
        [TestCase("1", "2", "3", "4", "5", "6", "7", "8", "9", "123456789")]
        [TestCase("-", "(", "*", ")", "/", ")", "+", "dot", "0", "-(*)/)+.0")]

        public void TestClickOnSomeButoon(string IdButton, string IdButton1, string IdButton2, string IdButton3, string IdButton4, string IdButton5, string IdButton6, string IdButton7, string IdButton8, string expected)
        {
            driver.Navigate().GoToUrl("file:///C:/Users/User/source/repos/HelloSelenium/refactored/index.html");
            driver.FindElement(By.Id(IdButton)).Click();
            driver.FindElement(By.Id(IdButton1)).Click();
            driver.FindElement(By.Id(IdButton2)).Click();
            driver.FindElement(By.Id(IdButton3)).Click();
            driver.FindElement(By.Id(IdButton4)).Click();
            driver.FindElement(By.Id(IdButton5)).Click();
            driver.FindElement(By.Id(IdButton6)).Click();
            driver.FindElement(By.Id(IdButton7)).Click();
            driver.FindElement(By.Id(IdButton8)).Click();
            IWebElement text = driver.FindElement(By.Id("15"));
            string actual = text.GetAttribute("value");
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1", "+", "3", "clean", "")]
        [TestCase("1", "+", "3", "back", "1+")]
        public void TestCleanBack(string IdButton, string IdButton1, string IdButton2, string IdButton3, string expected)
        {
            driver.Navigate().GoToUrl("file:///C:/Users/User/source/repos/HelloSelenium/refactored/index.html");
            driver.FindElement(By.Id(IdButton)).Click();
            driver.FindElement(By.Id(IdButton1)).Click();
            driver.FindElement(By.Id(IdButton2)).Click();
            driver.FindElement(By.Id(IdButton3)).Click();

            IWebElement text = driver.FindElement(By.Id("15"));
            string actual = text.GetAttribute("value");
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1", "1", "+", "2", "2", "equal", "33")]
        [TestCase("1", "2", "-", "3", "4", "equal", "-22")]
        [TestCase("1", "2", "*", "3", "4", "equal", "408")]
        [TestCase("9", "9", "/", "1", "1", "equal", "9")]
        [TestCase("-", "9", "+", "-", "7", "equal", "-16")]

        public void TestPlusMinusMultDiv(string IdButton, string IdButton1, string IdButton2, string IdButton3, string IdButton4, string IdButton5, string expected)
        {
            driver.Navigate().GoToUrl("file:///C:/Users/User/source/repos/HelloSelenium/refactored/index.html");
            driver.FindElement(By.Id(IdButton)).Click();
            driver.FindElement(By.Id(IdButton1)).Click();
            driver.FindElement(By.Id(IdButton2)).Click();
            driver.FindElement(By.Id(IdButton3)).Click();
            driver.FindElement(By.Id(IdButton4)).Click();
            driver.FindElement(By.Id(IdButton5)).Click();


            IWebElement text = driver.FindElement(By.Id("15"));
            string actual = text.GetAttribute("value");
            Assert.AreEqual(expected, actual);
        }
        [TestCase("(", "2", "+", "2", ")", "*", "2", "equal", "8")]
        [TestCase("(", "2", "+", "2", ")", "/", "2", "equal", "2")]

        public void TestBreacket(string IdButton, string IdButton1, string IdButton2, string IdButton3, string IdButton4, string IdButton5, string IdButton6, string IdButton7, string expected)
        {
            driver.Navigate().GoToUrl("file:///C:/Users/User/source/repos/HelloSelenium/refactored/index.html");
            driver.FindElement(By.Id(IdButton)).Click();
            driver.FindElement(By.Id(IdButton1)).Click();
            driver.FindElement(By.Id(IdButton2)).Click();
            driver.FindElement(By.Id(IdButton3)).Click();
            driver.FindElement(By.Id(IdButton4)).Click();
            driver.FindElement(By.Id(IdButton5)).Click();
            driver.FindElement(By.Id(IdButton6)).Click();
            driver.FindElement(By.Id(IdButton7)).Click();


            IWebElement text = driver.FindElement(By.Id("15"));
            string actual = text.GetAttribute("value");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestFull()
        {
            driver.Navigate().GoToUrl("file:///C:/Users/User/source/repos/HelloSelenium/refactored/index.html");
            driver.FindElement(By.Id("1")).Click();
            driver.FindElement(By.Id("+")).Click();
            driver.FindElement(By.Id("2")).Click();
            driver.FindElement(By.Id("*")).Click();
            driver.FindElement(By.Id("(")).Click();
            driver.FindElement(By.Id("3")).Click();
            driver.FindElement(By.Id("+")).Click();
            driver.FindElement(By.Id("4")).Click();
            driver.FindElement(By.Id("/")).Click();
            driver.FindElement(By.Id("2")).Click();
            driver.FindElement(By.Id("-")).Click();
            driver.FindElement(By.Id("(")).Click();
            driver.FindElement(By.Id("1")).Click();
            driver.FindElement(By.Id("+")).Click();
            driver.FindElement(By.Id("2")).Click();
            driver.FindElement(By.Id(")")).Click();
            driver.FindElement(By.Id(")")).Click();
            driver.FindElement(By.Id("*")).Click();
            driver.FindElement(By.Id("2")).Click();
            driver.FindElement(By.Id("+")).Click();
            driver.FindElement(By.Id("1")).Click();
            driver.FindElement(By.Id("equal")).Click();
            string expected = "10";
            IWebElement text = driver.FindElement(By.Id("15"));
            string actual = text.GetAttribute("value");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDivZero()
        {
            driver.Navigate().GoToUrl("file:///C:/Users/User/source/repos/HelloSelenium/refactored/index.html");
            driver.FindElement(By.Id("1")).Click();
            driver.FindElement(By.Id("1")).Click();
            driver.FindElement(By.Id("/")).Click();
            driver.FindElement(By.Id("0")).Click();
            driver.FindElement(By.Id("equal")).Click();
            string expected = "Infinity";
            IWebElement text = driver.FindElement(By.Id("15"));
            string actual = text.GetAttribute("value");
            Assert.AreEqual(expected, actual);
        }





        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }

    }
}
