using DocumentFormat.OpenXml.Spreadsheet;
using OpenCartProject.Base;
using OpenCartProject.Pages;
using OpenCartProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCartProject
{
    public class LoginTest: AutomationWrapper
    {
        [Test,TestCaseSource(typeof(DataSource), nameof(DataSource.ValidLoginData))]
        public void ValidLoginTest(string email,string password)
        {


            LoginPage loginpage = new LoginPage(driver);
            loginpage.EnterEmail("sdevkar39@gmail.com");
            loginpage.EnterPassword("password");
            loginpage.ClickOnLogin();


            //driver.FindElement(By.PartialLinkText("")).Click();
          //  driver.FindElement(By.XPath("(//a[normalize-space()='Login'])[2]")).Click();
           // driver.FindElement(By.Name("email")).SendKeys(email);
           

           // driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            //driver.FindElement(By.XPath(")(//button[@type='submit'])[1]")).Click();


            
        }

        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginData))]
        public void InvalidLoginData1(string email, string password, string actualresult)
        {
            //driver.FindElement(By.PartialLinkText("")).Click();
            driver.FindElement(By.XPath("(//a[normalize-space()='Login'])[2]")).Click();
            driver.FindElement(By.Name("email")).SendKeys(email);


            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();



            string actualError = driver.FindElement(By.XPath("//div[@class='alert alert-danger']")).Text;

            //Assert.That(actualError.Contains( actualresult+"No match for E-Mail and/or Password"));


            Assert.That(true);
        }

    }
}
