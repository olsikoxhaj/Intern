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
        }
        [Test]
        public void LogInUsernameWrong()
        { 
            logInPage= new LogInPage(driver);
            driver.Navigate().GoToUrl(Constant.BaseUrl);
            logInPage.UsernameWrong();
        }
        [Test]
        public void LogInPasswWrong()
        {
           logInPage = new LogInPage(driver);
            driver.Navigate().GoToUrl(Constant.BaseUrl);
            logInPage.PasswordWrong();
        }

        [Test]
        public void PasswordNull()
        {
            logInPage = new LogInPage(driver);
            driver.Navigate().GoToUrl(Constant.BaseUrl);
            logInPage.PasswordNull();
        }
        [Test]
        public void PasswordnullUsernameNull()
        {
            logInPage = new LogInPage(driver);
            driver.Navigate().GoToUrl(Constant.BaseUrl);
            logInPage.PasswordNullUsernameNull();
        }
    }
}
