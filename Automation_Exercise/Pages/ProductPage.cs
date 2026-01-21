using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Automation_Exercise.Pages
{
    public class ProductPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        By productsHeader = By.XPath("//h2[text()='All Products']");
        By firstProductView = By.XPath("(//a[contains(text(),'View Product')])[1]");
        By searchBox = By.Id("search_product");
        By searchButton = By.Id("submit_search");
        By searchedProduct = By.XPath("//div[@class='productinfo text-center']");

        public void GoToProducts()
        {
            // DIRECT navigation
            driver.Navigate().GoToUrl("https://automationexercise.com/products");

            wait.Until(ExpectedConditions.UrlContains("/products"));
            wait.Until(ExpectedConditions.ElementIsVisible(productsHeader));
        }

        public void OpenFirstProduct()
        {
            IWebElement product =
                wait.Until(ExpectedConditions.ElementExists(firstProductView));

            ((IJavaScriptExecutor)driver)
                .ExecuteScript("arguments[0].scrollIntoView({block:'center'});", product);

            ((IJavaScriptExecutor)driver)
                .ExecuteScript("arguments[0].click();", product);
        }

        public void SearchProduct(string name)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(searchBox)).SendKeys(name);
            wait.Until(ExpectedConditions.ElementToBeClickable(searchButton)).Click();
        }

        public bool IsProductDisplayed()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(searchedProduct)).Displayed;
        }
    }
}
