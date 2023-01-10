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
   
        public class UserTest : AutomationWrapper
        {

            [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.ValidRegisterData))]
        public void AddUserTest(string username, string firstname, string lastname, string email, string country, string password)
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
            driver.FindElement(By.XPath("//button[@type='submit'][2]")).Click();
            




      
























            }
        }
    }