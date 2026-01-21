using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }
        //Locator
        private By slider = By.Id("slider-carousel");

        //Action
        public bool isSliderVisible()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(slider)).Displayed;
        }

    }
}
