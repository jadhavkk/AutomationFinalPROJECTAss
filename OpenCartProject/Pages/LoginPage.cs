using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCartProject.Pages
{
    public class LoginPage
    {

        private By _usernameLocator = By.Name("email");
        private By _passwordLocator = By.Name("password");
        private By _loginPageLocator = By.XPath("//button[@type='submit']");
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            
        }
        public void EnterEmail(string email)
        {


            driver.FindElement(_usernameLocator).SendKeys(email);
            
        }
        public void EnterPassword(string password)
        {

            driver.FindElement(_passwordLocator).SendKeys(password);
            
        }

        public void ClickOnLogin()
        {

            driver.FindElement(_loginPageLocator).Click();
            
        }
    }
}
