using Intern.PageObject;
using Intern.SetUP;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Intern.TestCase
{
    public class AddtoCart : SetUp
    {
        public AddtoCartPage addtoCart;
        public LogInPage logIn;

        [Test]
        public void LogInAddtoCart()
        {
            addtoCart = new AddtoCartPage (driver);
            driver.Navigate().GoToUrl(Constant.BaseUrl);
            addtoCart.LogInAddtoCart();
        }
    }
}
