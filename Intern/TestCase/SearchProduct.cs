using Intern.PageObject;
using Intern.SetUP;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern.TestCase
{
    public class SearchProduct : SetUp
    {
        public SearchProductPage searchProductPage;
        #region SearchProductAddtoCart TestCase
        [Test]
        public void SearchProductAddtoCart()
        {
            searchProductPage = new SearchProductPage(driver);
            driver.Navigate().GoToUrl(Constant.otherUrl);
            searchProductPage.SearchProduct();
        }
        #endregion
    }
}
