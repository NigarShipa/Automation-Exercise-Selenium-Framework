using Automation_Exercise.Core;
using Automation_Exercise.Pages;
using Automation_Exercise.TestData;
using NUnit.Framework;

namespace Automation_Exercise.Tests
{
    [TestFixture]
    [NonParallelizable]
    public class LoginTest : Base
    {
        [Test]
        public void Verify_Login()
        {
            var header = new HeaderPage(driver);
            header.ClickSignupLogin(); // safe wait click

            var login = new LoginPage(driver);
            login.Login(LoginTestData.ExistingEmail, LoginTestData.Password); // from TestData

            Assert.IsTrue(header.IsLogoutVisible(), "Login failed"); // safe wait check

            header.ClickLogout(); // safe wait click
        }
    }
}
