using Intern.SetUP;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using System.Threading;

namespace Intern.PageObject
{
    public class LogInPage
    {
        private IWebDriver driver;

        //SHTOHET KONSTRUKTOR ME PARAMETER DHE SHIKOJE KUR THIRRET KLASA SI THIRRET
        public LogInPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #region IWebElement 
        public IWebElement usernameFieldWebelement => driver.FindElement(usernameField);
        public IWebElement passwordFieldWebelement => driver.FindElement(passwordField);
        public IWebElement AdminFieldWebelement => driver.FindElement(AdminField);
        public IWebElement varSelectWebelement => driver.FindElement(varSelectField);
        public IWebElement checkbocwebelemnt => driver.FindElement(checkboxField);
        public IWebElement SingInwebelement => driver.FindElement(SingInField);
        public IWebElement AddtoCartWebelement => driver.FindElement(AddtoCartField);
        public IWebElement CheckoutWebelement => driver.FindElement(CheckoutField);
        public IWebElement checkout2Webelement => driver.FindElement(Checkout2Field);
        public IWebElement CountryFieldWebelement =>driver.FindElement(CountryField);
        public IWebElement AlbFieldWebelement => driver.FindElement(AlbField);
        public IWebElement check2FieldWebelement => driver.FindElement(check2Field);
        public IWebElement PurchaseFieldWebelement => driver.FindElement(PurchaseField);
        #endregion


        #region By Element
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

        #endregion

        #region LogInSucces

        public void LogInSucces()
        {
            usernameFieldWebelement.SendKeys(Constant.Username);
            passwordFieldWebelement.SendKeys(Constant.Password);
            AdminFieldWebelement.Click();
            SelectOptionFromVarSelectByValue("teach");
            checkbocwebelemnt.Click();
            SingInwebelement.Click();
            Thread.Sleep(5000);

        }
        #endregion

        #region VarSelectByValue

        public void SelectOptionFromVarSelectByValue(string value)
        {
            var select = new SelectElement(driver.FindElement(varSelectField));
            select.SelectByValue(value);
            Thread.Sleep(5000);
        }
        #endregion

        #region UsernameWrong  
        public void UsernameWrong()
        {
            usernameFieldWebelement.SendKeys("Username");
            passwordFieldWebelement.SendKeys(Constant.Password);
            AdminFieldWebelement.Click();
            SelectOptionFromVarSelectByValue("teach");
            checkbocwebelemnt.Click();
            SingInwebelement.Click();
        }
        #endregion

        #region PasswordWrong  
        public void PasswordWrong()
        {
            usernameFieldWebelement.SendKeys(Constant.Username);
            passwordFieldWebelement.SendKeys("lalalala");
            AdminFieldWebelement.Click();
            SelectOptionFromVarSelectByValue("teach");
            checkbocwebelemnt.Click();
            SingInwebelement.Click();
        }
        #endregion

        #region PasswordNull  
        public void PasswordNull()
        {
            usernameFieldWebelement.SendKeys(Constant.Username);
            passwordFieldWebelement.SendKeys("        ");
            AdminFieldWebelement.Click();
            SelectOptionFromVarSelectByValue("teach");
            checkbocwebelemnt.Click();
            SingInwebelement.Click();
        }
        #endregion

        #region PasswordNullUsernameNull
        public void PasswordNullUsernameNull()
        {
            usernameFieldWebelement.SendKeys("         ");
            passwordFieldWebelement.SendKeys("        ");
            AdminFieldWebelement.Click();
            SelectOptionFromVarSelectByValue("teach");
            checkbocwebelemnt.Click();
            SingInwebelement.Click();
        }
        #endregion
        // Other methods related to the LogIn page
    }
}
