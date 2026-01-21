using System;

namespace Automation_Exercise.TestData
{
    public static class SignupTestData
    {
        public static string Name => "Nigar";
        public static string Email => $"nigar{Guid.NewGuid().ToString().Substring(0, 8)}@mail.com"; // Unique email each run
        public static string Password => "Nigar123";
        public static string FirstName => "Nigar";
        public static string LastName => "Sultana";
        public static string Address => "22 Test Address";
        public static string Country => "India";
        public static string State => "Kulalampur";
        public static string City => "KL";
        public static string Zipcode => "110001";
        public static string Mobile => "01712346678";

        // DOB
        public static string Day => "10";
        public static string Month => "5";
        public static string Year => "1996";
    }
}
