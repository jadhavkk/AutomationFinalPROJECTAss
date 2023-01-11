using OpenCartProject.Base;
using OpenCartProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenCartProject.Pages.ForgetPage;

namespace OpenCartProject
{
    public class ForgotPasswordTest:AutomationWrapper
    {
        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.ForgotPasswordData1))]
        public void ForgotPassword(string email)
        {

            driver.FindElement(By.XPath("(//a[normalize-space()='Login'])[2]")).Click();

            ForgotPasswordPage Forgot = new ForgotPasswordPage(driver);
            Forgot.ClickOnForgotPassword();
            Forgot.EnterEmailAddress(email);
            Forgot.ClickONContinue();



            /*driver.FindElement(By.XPath("Forgot your password?")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='E-Mail Address']")).SendKeys(email);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();*/
        }


    }
}
