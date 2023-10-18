using Intern.PageObject;
using Intern.SetUP;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Intern.TestCase
{
    public class AddtoCart : SetUp
    {
        public AddtoCartPage addtoCartPage;
        public LogInPage logInPage;

        [Test]
        public void ProductAdd()
        {
            logInPage = new LogInPage(driver);
            driver.Navigate().GoToUrl(Constant.BaseUrl);
            logInPage.LogInSucces();

            addtoCartPage = new AddtoCartPage(driver);
            addtoCartPage.LogInAddtoCart();
        }
    }
}
