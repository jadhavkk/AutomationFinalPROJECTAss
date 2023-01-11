using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCartProject.Pages
{
    public class RegisterPage
    {
        private By _registerPageLocator = By.XPath("(//a[text()='Register'])[2]");
        private By _usernameLocator = By.Name("username");
        private By _firstnameLocator = By.Name("firstname");
        private By _lastnameLocator = By.Name("lastname");
        private By _passwordLocator = By.Name("password");
        private By _emailLocator = By.Name("email");
        private By _countrynameLocator = By.Name("country_id");
        private By _registerPageLocator2 = By.XPath("//button[@type='submit']");
        private IWebDriver driver;

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickOnRegister()
        {

            driver.FindElement(_registerPageLocator).Click();
           

        }
        public void EnterUsername(string username)
        {


            driver.FindElement(_usernameLocator).SendKeys(username);

        }
        public void EnterFirstname(string firstname)
        {

            driver.FindElement(_firstnameLocator).SendKeys(firstname);

        }
        public void Enterlastname(string lastname)
        {

            driver.FindElement(_firstnameLocator).SendKeys(lastname);

        }
        public void EnterEmail(string email)
        {


            driver.FindElement(_emailLocator).SendKeys(email);

        }
        public void EnterCountryName(string countryname)
        {


            driver.FindElement(_countrynameLocator).SendKeys(countryname);

        }

        public void EnterPassword(string password)
        {

            driver.FindElement(_passwordLocator).SendKeys(password);

        }
        public void ClickOnRegister2()
        {

            driver.FindElement(_registerPageLocator2).Click();


        }

    }
}
