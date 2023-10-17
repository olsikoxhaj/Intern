using Intern.PageObject;
using Intern.SetUP;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Intern.TestCase
{
    public class LogIn : SetUp
    {
        public LogInPage logInPage;

        [Test]
        public void LogInOnly()
        {
            logInPage = new LogInPage(driver);
            driver.Navigate().GoToUrl(Constant.BaseUrl);
            logInPage.LogInSucces();
            // Your test code 
        }
        [Test]
        public void LogInUsernameWrong()
        {
            driver.Navigate().GoToUrl(Constant.BaseUrl);
            logInPage.LogInSucces();
            // Your test code 
        }
        [Test]
        public void LogInPasswWrong()
        {
            driver.Navigate().GoToUrl(Constant.BaseUrl);
            logInPage.LogInSucces();
            // Your test code 
        }

        [Test]
        public void TestLoginAddToCart()
        {
            logInPage.LogInSucces();
            // Your test code 
        }
    }
}
