using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.TestData
{
    public static class ContactUsTestData
    {
        public static string Name = " Nigar";
        public static string Email = "nigar" + System.Guid.NewGuid() + "@gmail.com";
        public static string Subject = "Test Contact Form";
        public static string Message = "This is an automated test message.";
    }
}
