using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject
{
    
    public class Login
    {
        [FindsBy(How = How.Id, Using = "txtID")]
        public IWebElement _username { get; set; }

        [FindsBy(How = How.Id, Using = "txtPW")]
        public IWebElement _password { get; set; }


        [FindsBy(How = How.Id, Using = "cmdOK")]
        public IWebElement _login { get; set; }


       
    
        public void LogIn()
        {
            _username.Clear();
            _password.Clear();
            Thread.Sleep(20);
            _username.SendKeys("CJ");
            _password.SendKeys("CJ");

            _login.Click();

        }
    }
}
