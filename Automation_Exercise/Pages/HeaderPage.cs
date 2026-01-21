using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Automation_Exercise.Pages
{
    public class HeaderPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public HeaderPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        private By signupLoginLink = By.LinkText("Signup / Login");
        private By logoutLink = By.LinkText("Logout");
        private By contactUsLink = By.LinkText("Contact us");


        // Click Signup / Login
        public void ClickSignupLogin()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(signupLoginLink)).Click();
        }
        public void ClickContactUs()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(contactUsLink)).Click();
        }

        // Check if Logout is visible
        public bool IsLogoutVisible()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(logoutLink)).Displayed;
        }

        // Click Logout
        public void ClickLogout()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(logoutLink)).Click();
        }
    }
}
