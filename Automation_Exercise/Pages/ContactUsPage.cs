using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Automation_Exercise.Pages
{
    public class ContactUsPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        // Locators
        private By nameInput = By.Name("name");
        private By emailInput = By.Name("email");
        private By subjectInput = By.Name("subject");
        private By messageInput = By.Id("message");
        private By submitButton = By.XPath("//input[@name='submit']");
        private By successMessage = By.XPath("//div[@class='status alert alert-success']");

        // Actions
        public void FillContactForm(string name, string email, string subject, string message)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(nameInput)).SendKeys(name);
            driver.FindElement(emailInput).SendKeys(email);
            driver.FindElement(subjectInput).SendKeys(subject);
            driver.FindElement(messageInput).SendKeys(message);
        }

        public void SubmitForm()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(submitButton)).Click();
        }

        public void AcceptAlert()
        {
            WebDriverWait alertWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            alertWait.Until(ExpectedConditions.AlertIsPresent());
            driver.SwitchTo().Alert().Accept();
        }

        public bool IsMessageSentSuccessfully()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(successMessage)).Displayed;
        }
    }
}
