using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace MyProject
{
    [TestClass]
    class ListMenu
    {
        [FindsBy(How = How.Id, Using = "ts_home")]
        public IWebElement _Home { get; set; }


        [FindsBy(How = How.Id, Using = "btnlist")]
        public IWebElement _List { get; set; }


        [FindsBy(How = How.Id, Using = "ts_time")]
        public IWebElement _Time { get; set; }



        [FindsBy(How = How.Id, Using = "ts_expense")]
        public IWebElement _Expense { get; set; }





        public ListMenu()
        {
            PageFactory.InitElements(BasePage.driver, this);
        }

        [TestMethod]
        public static void hoveronmenuitems()
        {
            ListMenu List = new ListMenu();
            Actions Hoover = new Actions(BasePage.driver);
            //Hoover.MoveToElement(List._Home).Build().Perform();
            //Thread.Sleep(1000);
           // Hoover.MoveToElement(List._List).Build().Perform();

           // Hoover.MoveToElement(List._Time).Build().Perform();
            //Thread.Sleep(1001);
           Hoover.MoveToElement(List._Expense).Build().Perform();
          //Thread.Sleep(1002);

        }

    }
}
