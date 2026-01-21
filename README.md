# Automation Exercise Selenium Framework

This project is an end-to-end **UI automation testing framework** developed for the **Automation Exercise** website using **Selenium WebDriver with C#**.  
The framework follows the **Page Object Model (POM)** design pattern and covers major user flows from signup to checkout.

---

##  Tech Stack

- **Programming Language:** C#
- **Automation Tool:** Selenium WebDriver
- **Test Framework:** NUnit
- **Design Pattern:** Page Object Model (POM)
- **Browser:** Google Chrome

---

##  Project Structure

Automation_Exercise
?
??? Core
? ??? Base.cs # WebDriver setup, teardown, common configurations
?
??? Pages
? ??? HeaderPage.cs
? ??? HomePage.cs
? ??? LoginPage.cs
? ??? SignupPage.cs
? ??? ProductPage.cs
? ??? ProductDetailsPage.cs
? ??? CartPage.cs
? ??? CheckoutPage.cs
? ??? ContactUsPage.cs
?
??? Tests
? ??? SignupTest.cs
? ??? LoginTest.cs
? ??? CartTest.cs
? ??? CheckoutTest.cs
? ??? ContactUsTest.cs
?
??? TestData
? ??? SignupTestData.cs
? ??? LoginTestData.cs
? ??? CheckoutTestData.cs
?
??? README.md

---

## ? Automated Modules

The following modules have been automated and validated:

- Signup
- Login & Logout
- Product Listing & Product Details
- Search Product
- Add to Cart
- Remove from Cart
- Checkout & Place Order
- Contact Us


