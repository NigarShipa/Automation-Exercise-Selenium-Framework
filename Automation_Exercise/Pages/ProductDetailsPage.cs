using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Automation_Exercise.Pages
{
    public class ProductDetailsPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public ProductDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        private By productName =
            By.CssSelector(".product-information h2");

        private By addToCartBtn =
            By.CssSelector("button.btn.btn-default.cart");

        private By viewCartBtn =
            By.XPath("//u[text()='View Cart']");

        private void SafeClick(By locator)
        {
            var element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            try
            {
                element.Click();
            }
            catch
            {
                ((IJavaScriptExecutor)driver)
                    .ExecuteScript("arguments[0].click();", element);
            }
        }

        public string GetProductName()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(productName)).Text;
        }

        public void AddProductToCartAndGoToCart()
        {
            SafeClick(addToCartBtn);
            SafeClick(viewCartBtn);
        }
    }
}
