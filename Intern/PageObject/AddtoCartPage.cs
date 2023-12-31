﻿using Intern.SetUP;
using NUnit.Framework;
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
    
        #region IWebElement
        public IWebElement AddtoCartWebelement => driver.FindElement(AddtoCartField);
        public IWebElement CheckoutWebelement => driver.FindElement(CheckoutField);
        public IWebElement checkout2Webelement => driver.FindElement(Checkout2Field);
        public IWebElement CountryFieldWebelement => driver.FindElement(CountryField);
        public IWebElement AlbFieldWebelement => driver.FindElement(AlbField);
        public IWebElement check2FieldWebelement => driver.FindElement(check2Field);
        public IWebElement PurchaseFieldWebelement => driver.FindElement(PurchaseField);
        public IWebElement succesMessageFieldWebelement => driver.FindElement(succesMessageField);
        #endregion

        #region By Element
        public By AddtoCartField => By.XPath("//button[@class='btn btn-info']");
        public By CheckoutField => By.XPath("//a[@class='nav-link btn btn-primary']");
        public By Checkout2Field => By.XPath("//button[contains(@class, 'btn-success')]");
        public By CountryField => By.CssSelector("#country");
        public By AlbField => By.XPath("//*[contains(text(), 'Albania')]");
        public By check2Field => By.XPath("//label[@for='checkbox2']");
        public By PurchaseField => By.XPath("//input[@class='btn btn-success btn-lg' and @type='submit' and @value='Purchase']");
        public By succesMessageField => By.XPath("//div[@class='alert alert-success alert-dismissible']");

        #endregion

        #region LogInAddtoCart
        public void LogInAddtoCart()
        {
            AddtoCartWebelement.Click();
            CheckoutWebelement.Click();
            checkout2Webelement.Click();
            CountryFieldWebelement.SendKeys("Albania");
            Thread.Sleep(10000);
            AlbFieldWebelement.Click();
            Thread.Sleep(3000);
            check2FieldWebelement.Click();
            PurchaseFieldWebelement.Click();

            string actualSuccessText = succesMessageFieldWebelement.Text;
            string expectedSuccessText = "×\r\nSuccess! Thank you! Your order will be delivered in next few weeks :-).";
           Assert.AreEqual(expectedSuccessText, actualSuccessText);
        }
        #endregion

    }
}