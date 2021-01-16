using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace GreenCityTests
{
    public class GrenCityTests
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            driver = new ChromeDriver(option);
            driver.Navigate().GoToUrl("https://ita-social-projects.github.io/GreenCityClient/#/");
        }

        [Test]
        public void sighInBtnTest()
        {
            IWebElement signInBtn = driver.FindElement(By.XPath("//a[@role='sign in']"));
            signInBtn.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement welcomeTitle = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[contains(text(),' Welcome back!')]")));
            string expected = "Welcome back!";
            Assert.AreEqual(expected, welcomeTitle.Text);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
