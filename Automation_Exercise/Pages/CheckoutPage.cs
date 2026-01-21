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
    public class CheckoutPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }
        //Locator
        private By proceedToCheckoutBtn = By.XPath("//a[text()='Proceed To Checkout']");
        private By placeOrderBtn = By.XPath("//a[text()='Place Order']");
        private By commentBox = By.Name("message");
        private By nameOncard = By.Name("name_on_card");
        private By cardNumber = By.Name("card_number");
        private By cvc = By.Name("cvc");
        private By expiryMonth = By.Name("expiry_month");
        private By expiryYear = By.Name("expiry_year");
        private By payAndConfirmBtn = By.XPath("//button[text()='Pay and Confirm Order']");
        private By orderSuccessMsg = By.XPath("//p[contains(text(),'Congratulations')]");

        //Actions
        public void ProceedToCheckout()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(proceedToCheckoutBtn)).Click();
        }
        public void AddComment(string comment)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(commentBox)).SendKeys(comment);
        }
        public void PlaceOder()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(placeOrderBtn)).Click();
        }
        public void EnterPaymentDetails(string cardName, string cardNo, string cvcCode, string month, string year)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(nameOncard)).SendKeys(cardName);
            driver.FindElement(cardNumber).SendKeys(cardNo);
            driver.FindElement(cvc).SendKeys(cvcCode);
            driver.FindElement(expiryMonth).SendKeys(month);
            driver.FindElement(expiryYear).SendKeys(year);

        }
        public void ConfirmPayment()
        {
            var btn = wait.Until(ExpectedConditions.ElementToBeClickable(payAndConfirmBtn));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", btn);
            btn.Click();
        }
        public bool IsOrderPlacedSuccessfully()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(orderSuccessMsg)).Displayed;
        }


    }




}
