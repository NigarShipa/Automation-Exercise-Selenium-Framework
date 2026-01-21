using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Automation_Exercise.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }
        private By emailInput = By.Name("email");
        private By passwordInput = By.Name("password");
        private By loginBtn = By.XPath("//button[text()='Login']");

        public void Login(string email, string password)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(emailInput)).SendKeys(email);
            wait.Until(ExpectedConditions.ElementIsVisible(passwordInput)).SendKeys(password);
            wait.Until(ExpectedConditions.ElementToBeClickable(loginBtn)).Click();
        }
    }
}
