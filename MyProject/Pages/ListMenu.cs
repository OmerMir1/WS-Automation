using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace MyProject
{
   
    public class ListMenu
    {
        [FindsBy(How = How.Id, Using = "ts_home")]
        public IWebElement _Home { get; set; }

        [FindsBy(How = How.Id, Using = "btnlist")]
        public IWebElement _List { get; set; }

        [FindsBy(How = How.Id, Using = "ts_time")]
        public IWebElement _Time { get; set; }

        [FindsBy(How = How.Id, Using = "ts_expense")]
        public IWebElement _Expense { get; set; }

        [FindsBy(How = How.Id, Using = "btnbilling")]
        public IWebElement _Billing { get; set; }


       
    }
}