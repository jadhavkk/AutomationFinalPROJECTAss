using OpenCartProject.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCartProject
{
    public class ResourcesTest : AutomationWrapper
    {
        [Test]
        public void AddResourcesTest()
        {

            driver.FindElement(By.XPath("//a[text()='Resources ']")).Click();
           driver.FindElement(By.XPath("//a[normalize-space()='OpenCart Books']")).Click();


          string header=  driver.FindElement(By.XPath("(//h4[normalize-space()='Categories'])[2]")).Text;
            Assert.That(header.Contains("Categories"));

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1000)", driver.FindElement(By.XPath("//a[text()='OpenCart Theme and Module Development']")));


            driver.FindElement(By.XPath("//*[@id=\"documentation\"]/div[3]/div/div[2]/div[3]/div[4]/p[2]/a")).Click();



            

           



        }
    }
}
//*[@id="icp-nav-flyout"]/span/span[2]/div