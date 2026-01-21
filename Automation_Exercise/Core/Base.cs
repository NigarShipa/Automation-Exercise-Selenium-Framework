using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation_Exercise.Core
{
    public class Base
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArgument("--disable-notifications");
            options.AddArgument("--disable-infobars");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-popup-blocking");

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://automationexercise.com");

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            RemoveAds();
        }

        protected void RemoveAds()
        {
            try
            {
                ((IJavaScriptExecutor)driver).ExecuteScript(@"
                    document.querySelectorAll(
                        'iframe[src*=""doubleclick""], 
                         iframe[id^=""aswift""],
                         iframe[src*=""ads""],
                         .fc-consent-root,
                         .fc-dialog'
                    ).forEach(e => e.remove());
                ");
            }
            catch { }
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
        }
    }
}
