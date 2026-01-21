using Automation_Exercise.Core;
using Automation_Exercise.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Tests
{
    public class HomeTests : Base
    {
        [Test]
        public void Verify_Home_page_Loads()
        {
            var homePage = new HomePage(driver);
            Assert.IsTrue(homePage.isSliderVisible(), "Home page slider not visible");

        }
    }
}
