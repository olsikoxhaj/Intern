using Intern.SetUP;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern.PageObject
{
    
    public class LogInPage : SetUp 
    {
        public By usernameField => By.XPath("//input[@type='text' and @name='username' and @id='username']");
        public By passwordField => By.XPath("//input[@type='password' and @name='password' and @id='password']");
        public By AdminField => By.XPath("//input[@type='radio' and @value='admin' and @id='usertype' and @name='radio' and @checked='checked']");
        public By varSelectField => By.XPath("/html/body/div[1]/div/div/div/div/form/div[5]/select");

        public IWebElement usernameFieldWebelement => driver.FindElement(usernameField);
        public IWebElement passwordFieldWebelement => driver.FindElement(passwordField);
        public IWebElement AdminFieldWebelement => driver.FindElement(AdminField);

        public void LogInSucces()
        {
            usernameFieldWebelement.SendKeys(Constant.Username);
            passwordFieldWebelement.SendKeys(Constant.Password);
            AdminFieldWebelement.Click();
        }
        //krijohen skenare t tjera
    }
}
