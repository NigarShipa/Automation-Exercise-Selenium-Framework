using Automation_Exercise.Core;
using Automation_Exercise.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Tests
{
    [TestFixture]
    [NonParallelizable]
    public class CartTest : Base
    {
        [Test]
        public void Verify_User_Can_Add_To_Cart()
        {
            var productPage = new ProductPage(driver);
            var productDetails = new ProductDetailsPage(driver);
            var cartPage = new CartPage(driver);
            productPage.GoToProducts();
            productPage.OpenFirstProduct();
            productDetails.AddProductToCartAndGoToCart();
            Assert.IsTrue(cartPage.IsProductInCart(), "Product not added to cart");
        }
        [Test]
        public void Verify_User_Can_Remove_Product_From_Cart()
        {
            var productPage = new ProductPage(driver);
            var productDetails = new ProductDetailsPage(driver);
            var cartPage = new CartPage(driver);
            productPage.GoToProducts();
            productPage.OpenFirstProduct();
            productDetails.AddProductToCartAndGoToCart();

            cartPage.RemoveProduct();

            Assert.IsTrue(cartPage.IsCartEmpty(), "Cart is not empty after removing product");
        }
    }


}

