using DocumentFormat.OpenXml.Spreadsheet;
using OpenCartProject.Base;
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
        public void ValidLoginData1(string email,string password)
        {
            //driver.FindElement(By.PartialLinkText("")).Click();
            driver.FindElement(By.XPath("(//a[normalize-space()='Login'])[2]")).Click();
            driver.FindElement(By.Name("email")).SendKeys(email);
           

            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            //driver.FindElement(By.XPath(")(//button[@type='submit'])[1]")).Click();


            
        }

        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginData))]
        public void InvalidLoginData1(string email, string password)
        {
            //driver.FindElement(By.PartialLinkText("")).Click();
            driver.FindElement(By.XPath("(//a[normalize-space()='Login'])[2]")).Click();
            driver.FindElement(By.Name("email")).SendKeys(email);


            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            //driver.FindElement(By.XPath(")(//button[@type='submit'])[1]")).Click();



        }


    }
}
