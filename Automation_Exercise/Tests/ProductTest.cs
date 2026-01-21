using Automation_Exercise.Core;
using Automation_Exercise.Pages;
using NUnit.Framework;

namespace Automation_Exercise.Tests
{
    [TestFixture]
    [NonParallelizable]
    public class ProductTest : Base
    {
        [Test]
        public void Verify_User_Can_View_Product_Details()
        {
            var productPage = new ProductPage(driver);
            var detailsPage = new ProductDetailsPage(driver);

            productPage.GoToProducts();
            productPage.OpenFirstProduct();

            Assert.IsTrue(detailsPage.GetProductName().Length > 0);
        }

        [Test]
        public void Verify_Product_Search_Functionality()
        {
            var productsPage = new ProductPage(driver);

            productsPage.GoToProducts();
            productsPage.SearchProduct("Blue Top");

            Assert.IsTrue(productsPage.IsProductDisplayed());
        }
    }
}
