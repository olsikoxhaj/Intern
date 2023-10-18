using Intern.SetUP;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Intern.PageObject
{
    public class AddtoCartPage
    {
        private IWebDriver driver;
        public AddtoCartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement usernameFieldWebelement => driver.FindElement(usernameField);
        public IWebElement passwordFieldWebelement => driver.FindElement(passwordField);
        public IWebElement AdminFieldWebelement => driver.FindElement(AdminField);
        public IWebElement varSelectWebelement => driver.FindElement(varSelectField);
        public IWebElement checkbocwebelemnt => driver.FindElement(checkboxField);
        public IWebElement SingInwebelement => driver.FindElement(SingInField);
        public IWebElement AddtoCartWebelement => driver.FindElement(AddtoCartField);
        public IWebElement CheckoutWebelement => driver.FindElement(CheckoutField);
        public IWebElement checkout2Webelement => driver.FindElement(Checkout2Field);
        public IWebElement CountryFieldWebelement => driver.FindElement(CountryField);
        public IWebElement AlbFieldWebelement => driver.FindElement(AlbField);
        public IWebElement check2FieldWebelement => driver.FindElement(check2Field);
        public IWebElement PurchaseFieldWebelement => driver.FindElement(PurchaseField);


        public By usernameField => By.XPath("//input[@type='text' and @name='username' and @id='username']");
        public By passwordField => By.XPath("//input[@type='password' and @name='password' and @id='password']");
        public By AdminField => By.XPath("//input[@type='radio' and @value='admin' and @id='usertype' and @name='radio' and @checked='checked']");
        public By varSelectField => By.XPath("/html/body/div[1]/div/div/div/div/form/div[5]/select");
        public By checkboxField => By.CssSelector("#terms");
        public By SingInField => By.CssSelector("#signInBtn");
        public By AddtoCartField => By.XPath("//button[@class='btn btn-info']");
        public By CheckoutField => By.XPath("//a[@class='nav-link btn btn-primary']");
        public By Checkout2Field => By.XPath("//button[contains(@class, 'btn-success')]");
        public By CountryField => By.CssSelector("#country");
        public By AlbField => By.XPath("//*[contains(text(), 'Albania')]");
        public By check2Field => By.XPath("//label[@for='checkbox2']");
        public By PurchaseField => By.XPath("//input[@class='btn btn-success btn-lg' and @type='submit' and @value='Purchase']");
        public void LogInAddtoCart()
        {
            usernameFieldWebelement.SendKeys(Constant.Username);
            passwordFieldWebelement.SendKeys(Constant.Password);
            AdminFieldWebelement.Click();
            checkbocwebelemnt.Click();
            SelectOptionFromVarSelectByValue("teach");
            SingInwebelement.Click();
            Thread.Sleep(3000);
            AddtoCartWebelement.Click();
            CheckoutWebelement.Click();
            checkout2Webelement.Click();
            CountryFieldWebelement.SendKeys("Albania");
            Thread.Sleep(10000);
            AlbFieldWebelement.Click();
            Thread.Sleep(3000);
            check2FieldWebelement.Click();
            PurchaseFieldWebelement.Click();
        }
        public void SelectOptionFromVarSelectByValue(string value)
        {
            var select = new SelectElement(driver.FindElement(varSelectField));
            select.SelectByValue(value);
            Thread.Sleep(5000);
        }
    }
}