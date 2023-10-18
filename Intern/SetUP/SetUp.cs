using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;

namespace Intern.SetUP
{
    public class SetUp
    {
        protected IWebDriver driver;

        [SetUp]
        public void OneTimeSetUp()
        {
            string browserType = "Chrome"; // Change to "Edge" if needed
            driver = InitDriver(browserType);
        }

        public IWebDriver InitDriver(string browserType)
        {
            IWebDriver driver = null; // Initialize it to null

            if (browserType.Equals("Chrome", StringComparison.OrdinalIgnoreCase))
            {
                driver = new ChromeDriver();
            }
            else if (browserType.Equals("Edge", StringComparison.OrdinalIgnoreCase))
            {
                driver = new EdgeDriver();
            }
            else
            {
                throw new ArgumentException("Invalid browser type specified.");
            }

            return driver;
        }

        [TearDown]
        public void OneTimeTearDown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
