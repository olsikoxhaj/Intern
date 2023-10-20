using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Intern.PageObject
{
    public class SearchProductPage 
    {
        private IWebDriver driver;

        public SearchProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        #region IWebElement

        public IWebElement searchFieldWebelement => driver.FindElement(searchFiled);
        public IWebElement AddToCartFieldWebelement => driver.FindElement(AddToCartField);
        public IWebElement MyCartFieldWebelemend => driver.FindElement(MyCartField);
        public IWebElement ProccedFieldWebelement => driver.FindElement(ProccedField);
        public IWebElement PlaceOrderFieldWebelement => driver.FindElement(PlaceOrderFiled);
        public IWebElement dropdownFieldWebelemend => driver.FindElement(dropdownField);
        public IWebElement check3FieldWebelement => driver.FindElement(check3Field);
        public IWebElement Procced2FieldWebelement => driver.FindElement(Procced2Field);
        public IWebElement succesMessageFieldWebelement => driver.FindElement(succesMessageField);
        #endregion

        #region By Element  
        public By searchFiled => By.XPath("//input[@type='search' and @placeholder='Search for Vegetables and Fruits' and @class='search-keyword']");
        public By AddToCartField => By.XPath("//button[text()='ADD TO CART' and @type='button']");
        public By MyCartField => By.XPath("//a[@class='cart-icon']");
        public By ProccedField => By.XPath("//button[@type='button' and text()='PROCEED TO CHECKOUT']"); 
        public By PlaceOrderFiled => By.XPath("//button[text()='Place Order']");
        public By dropdownField => By.XPath("//select[@style='width: 200px;']");
        public By check3Field => By.XPath("//input[@type='checkbox' and @class='chkAgree']");
        public By Procced2Field => By.XPath("//button[text()='Proceed']");
        public By succesMessageField => By.XPath("//span[@style='color:green;font-size:25px']");

        #endregion

        #region SearchProduct
        public void SearchProduct()
        {
            searchFieldWebelement.SendKeys("Brocolli - 1 Kg");
            AddToCartFieldWebelement.Click();
            MyCartFieldWebelemend.Click();
            ProccedFieldWebelement.Click();
            Thread.Sleep(3000);
            PlaceOrderFieldWebelement.Click();
            Thread.Sleep(3000);
            SelectOptionFromVarSelectByValue("Albania");
            Thread.Sleep(5000);
            check3FieldWebelement.Click();
            Thread.Sleep(2000);
            Procced2FieldWebelement.Click();
            Thread.Sleep(3000);

            string actualSuccessText = succesMessageFieldWebelement.Text;
            string expectedSuccessText = "Thank you, your order has been placed successfully\r\nYou'll be redirected to Home page shortly!!";
            Assert.AreEqual(expectedSuccessText, actualSuccessText);

        }
        #endregion

        #region VarSelectByValue
        public void SelectOptionFromVarSelectByValue(string value)
        {
            var selectElement = new SelectElement(driver.FindElement(dropdownField));
            selectElement.SelectByValue(value);
            Thread.Sleep(5000);
        }
        #endregion
    }

}
