using OpenCartProject.Base;
using OpenCartProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCartProject
{
   
        public class RegisterTest : AutomationWrapper
        {

        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.ValidRegisterData))]
        public void AddRegisterTest(string username, string firstname, string lastname, string email, string country, string password)
        {

            driver.FindElement(By.XPath("(//a[text()='Register'])[2]")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys(username);
            driver.FindElement(By.XPath("//input[@placeholder='First Name']")).SendKeys(firstname);
            driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).SendKeys(lastname);
            driver.FindElement(By.XPath("//input[@placeholder='E-Mail']")).SendKeys(email);

            SelectElement select = new SelectElement(driver.FindElement(By.Name("country_id")));
            select.SelectByText(country);

            driver.FindElement(By.Name("password")).SendKeys(password);
            Thread.Sleep(10000);
            driver.FindElement(By.CssSelector("[type=\"submit\"]")).Click();



        }
        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidRegisterData))]
        public void AddRegisterTest2(string username, string firstname, string lastname, string email, string country, string password)
        {

            driver.FindElement(By.XPath("(//a[text()='Register'])[2]")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys(username);
            driver.FindElement(By.XPath("//input[@placeholder='First Name']")).SendKeys(firstname);
            driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).SendKeys(lastname);
            driver.FindElement(By.XPath("//input[@placeholder='E-Mail']")).SendKeys(email);

            SelectElement select = new SelectElement(driver.FindElement(By.Name("country_id")));
            select.SelectByText(country);

            driver.FindElement(By.Name("password")).SendKeys(password);
            Thread.Sleep(10000);
            driver.FindElement(By.CssSelector("[type=\"submit\"]")).Click();































        }
    }
    }