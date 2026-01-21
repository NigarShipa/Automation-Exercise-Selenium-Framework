using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Automation_Exercise.Pages
{
    public class SignupPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public SignupPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        // STEP 1
        public IWebElement Name => wait.Until(ExpectedConditions.ElementIsVisible(By.Name("name")));
        public IWebElement Email => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-qa='signup-email']")));
        public IWebElement SignupButton => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[text()='Signup']")));

        // STEP 2
        public IWebElement TitleMrs => wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("id_gender2")));
        public IWebElement Password => wait.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
        public SelectElement Day => new SelectElement(wait.Until(ExpectedConditions.ElementIsVisible(By.Id("days"))));
        public SelectElement Month => new SelectElement(wait.Until(ExpectedConditions.ElementIsVisible(By.Id("months"))));
        public SelectElement Year => new SelectElement(wait.Until(ExpectedConditions.ElementIsVisible(By.Id("years"))));
        public IWebElement FirstName => wait.Until(ExpectedConditions.ElementIsVisible(By.Id("first_name")));
        public IWebElement LastName => wait.Until(ExpectedConditions.ElementIsVisible(By.Id("last_name")));
        public IWebElement Address => wait.Until(ExpectedConditions.ElementIsVisible(By.Id("address1")));
        public IWebElement State => wait.Until(ExpectedConditions.ElementIsVisible(By.Id("state")));
        public IWebElement City => wait.Until(ExpectedConditions.ElementIsVisible(By.Id("city")));
        public IWebElement Zipcode => wait.Until(ExpectedConditions.ElementIsVisible(By.Id("zipcode")));
        public IWebElement Mobile => wait.Until(ExpectedConditions.ElementIsVisible(By.Id("mobile_number")));
        public IWebElement CreateAccountButton => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[text()='Create Account']")));
        public IWebElement AccountCreatedMsg => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//b[text()='Account Created!']")));

        // Select country from dropdown
        public void SelectCountry(string country)
        {
            var select = new SelectElement(wait.Until(ExpectedConditions.ElementIsVisible(By.Id("country"))));
            select.SelectByText(country);
        }
    }
}
