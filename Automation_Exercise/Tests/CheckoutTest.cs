using Automation_Exercise.Core;
using Automation_Exercise.Pages;
using Automation_Exercise.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Tests
{
    [TestFixture]
    [NonParallelizable]
    public class CheckoutTest : Base
    {
        [Test]
        public void Verify_User_Can_Place_Order_Successfully()
        {
            var header = new HeaderPage(driver);
            var loginPage = new LoginPage(driver);
            var productPage = new ProductPage(driver);
            var productDetailsPage = new ProductDetailsPage(driver);
            var cartPage = new CartPage(driver);
            var checkoutPage = new CheckoutPage(driver);

            //Login needed
            header.ClickSignupLogin();
            loginPage.Login(LoginTestData.ExistingEmail, LoginTestData.Password);

            // Add Product
            productPage.GoToProducts();
            productPage.OpenFirstProduct();
            productDetailsPage.AddProductToCartAndGoToCart();

            // Checkout
            checkoutPage.ProceedToCheckout();
            checkoutPage.AddComment(CheckoutTestData.Comment);
            checkoutPage.PlaceOder();

            // Payment
            checkoutPage.EnterPaymentDetails(
                CheckoutTestData.CardName,
                CheckoutTestData.CardNumber,
                CheckoutTestData.CVC,
                CheckoutTestData.ExpiryMonth,
                CheckoutTestData.ExpiryYear);

            checkoutPage.ConfirmPayment();
            // Assertion
            Assert.IsTrue(checkoutPage.IsOrderPlacedSuccessfully(), "Order was not placed successfully");

        }
    }
}
