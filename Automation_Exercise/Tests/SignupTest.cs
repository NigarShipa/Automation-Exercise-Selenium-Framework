using Automation_Exercise.Core;
using Automation_Exercise.Pages;
using Automation_Exercise.TestData;
using NUnit.Framework;

namespace Automation_Exercise.Tests
{
    [TestFixture]
    [NonParallelizable]
    public class SignupTest : Base
    {
        [Test]
        public void Verify_User_Can_Signup_Successfully()
        {
            var header = new HeaderPage(driver);
            header.ClickSignupLogin();

            var signup = new SignupPage(driver);

            // STEP 1
            signup.Name.SendKeys(SignupTestData.Name);
            signup.Email.SendKeys(SignupTestData.Email);
            signup.SignupButton.Click();

            // STEP 2
            signup.TitleMrs.Click();
            signup.Password.SendKeys(SignupTestData.Password);

            signup.Day.SelectByValue(SignupTestData.Day);
            signup.Month.SelectByValue(SignupTestData.Month);
            signup.Year.SelectByValue(SignupTestData.Year);

            signup.FirstName.SendKeys(SignupTestData.FirstName);
            signup.LastName.SendKeys(SignupTestData.LastName);
            signup.Address.SendKeys(SignupTestData.Address);
            signup.SelectCountry(SignupTestData.Country);
            signup.State.SendKeys(SignupTestData.State);
            signup.City.SendKeys(SignupTestData.City);
            signup.Zipcode.SendKeys(SignupTestData.Zipcode);
            signup.Mobile.SendKeys(SignupTestData.Mobile);

            signup.CreateAccountButton.Click();

            Assert.IsTrue(signup.AccountCreatedMsg.Displayed, "Account was not created successfully.");
        }
    }
}
