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
        private IWebDriver driver;

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
