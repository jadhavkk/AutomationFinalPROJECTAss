using OpenCartProject.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCartProject
{
    public class ResourcesTest : AutomationWrapper
    {
        public void AddResourcesTest()
        {

            driver.FindElement(By.XPath("//a[text()='Resources ']")).Click();
            driver.FindElement(By.XPath("((//a[text()='OpenCart Books'])[1]")).Click();

            


        }
    }
}
