using Intern.SetUP;
using OpenQA.Selenium;

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

        public IWebElement usernameFieldWebelement => driver.FindElement(usernameField);
        public IWebElement passwordFieldWebelement => driver.FindElement(passwordField);
        public IWebElement AdminFieldWebelement => driver.FindElement(AdminField);

        public By usernameField => By.XPath("//input[@type='text' and @name='username' and @id='username']");
        public By passwordField => By.XPath("//input[@type='password' and @name='password' and @id='password']");
        public By AdminField => By.XPath("//input[@type='radio' and @value='admin' and @id='usertype' and @name='radio' and @checked='checked']");
        public By varSelectField => By.XPath("/html/body/div[1]/div/div/div/div/form/div[5]/select");

        public void LogInSucces()
        {
            usernameFieldWebelement.SendKeys(Constant.Username);
            passwordFieldWebelement.SendKeys(Constant.Password);
            AdminFieldWebelement.Click();
        }

        // Other methods related to the LogIn page
    }
}
