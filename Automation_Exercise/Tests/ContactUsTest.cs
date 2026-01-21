using Automation_Exercise.Core;
using Automation_Exercise.Pages;
using Automation_Exercise.TestData;
using NUnit.Framework;

namespace Automation_Exercise.Tests
{
    [TestFixture]
    [NonParallelizable]
    public class ContactUsTest : Base
    {
        [Test]
        public void Verify_User_Can_Send_Contact_Message()
        {
            // Arrange
            var header = new HeaderPage(driver);
            var contactPage = new ContactUsPage(driver);

            // Navigate
            header.ClickContactUs();

            // Act
            contactPage.FillContactForm(
                ContactUsTestData.Name,
                ContactUsTestData.Email,
                ContactUsTestData.Subject,
                ContactUsTestData.Message
            );

            contactPage.SubmitForm();
            contactPage.AcceptAlert();

            // Assert
            Assert.IsTrue(
                contactPage.IsMessageSentSuccessfully(),
                "Contact Us message was not sent successfully"
            );
        }
    }
}
