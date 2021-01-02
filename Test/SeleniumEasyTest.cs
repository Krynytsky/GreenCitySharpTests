using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumEasyTest
{
    public class SeleniumEasyTest
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/";
        }

        [Test]
        public void sloganTest()
        {
            IWebElement slogan = driver.FindElement(By.CssSelector("#site-slogan > .slogan"));
            string expected = "Free selenium tutorials for beginners and experts";
            Assert.AreEqual(expected, slogan.Text);
        }

        [Test]
        public void invalidSearchTest()
        {
            IWebElement search = driver.FindElement(By.Id("edit-search-block-form--2"));
            IWebElement searchIcon = driver.FindElement(By.ClassName("glyphicon-search"));
            search.Click();
            search.Clear();
            search.SendKeys("c#");
            searchIcon.Click();
            IWebElement noSuchResult = driver.FindElement(By.XPath("//h2[.='Your search yielded no results']"));
            string expectedText = "Your search yielded no results";
            Assert.AreEqual(expectedText, noSuchResult.Text);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
