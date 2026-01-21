using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Automation_Exercise.Pages
{
    public class CartPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        // Locators
        private By cartRows =
            By.XPath("//table[@id='cart_info_table']//tbody/tr");

        private By deleteBtn =
            By.ClassName("cart_quantity_delete");

        private By emptyCartText =
            By.XPath("//b[text()='Cart is empty!']");

        // Valid boolean wait
        public bool IsProductInCart()
        {
            return wait.Until(d =>
                d.FindElements(cartRows).Count > 0
            );
        }

        public void RemoveProduct()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(deleteBtn)).Click();
        }

        public bool IsCartEmpty()
        {
            return wait.Until(
                ExpectedConditions.ElementIsVisible(emptyCartText)
            ).Displayed;
        }
    }
}
