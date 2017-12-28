using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MyProject
{
    [TestClass]
    public class Client
    {
        [FindsBy(How = How.Id, Using = "tab_client")]
        public IWebElement _Client { get; set; }

        [FindsBy(How = How.Id, Using = "lnkNew")]
        public IWebElement _ClientNew { get; set; }

        [FindsBy(How = How.Id, Using = "txtCliID")]
        public IWebElement _ClientID { get; set; }

        [FindsBy(How = How.Id, Using = "imgListCli")]
        public IWebElement _ClientMgrDD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='divFullList']/div/table/tbody/tr[5]/td[2]")]
        public IWebElement _ClientManagerRow { get; set; }

        [FindsBy(How = How.Id, Using = "lnkSave")]
        public IWebElement _ClientSave { get; set; }

       
        [TestMethod]
        public void CreateNewClient()

        {
            
            CustomMehtods.Clicks(_Client);
            BasePage.driver.SwitchTo().Frame("f1");
            CustomMehtods.Clicks(_ClientNew);
            CustomMehtods.EnterText(_ClientID, RandomGen.RandomG());
            _ClientMgrDD.Click();
            Thread.Sleep(3000);
            _ClientManagerRow.Click();

            IAlert alert = BasePage.driver.SwitchTo().Alert();     //Hanldes the Browser alert
            alert.Accept();

            CustomMehtods.Clicks(_ClientSave);
        }
    }
}
//public void CreateNewClient(string e)

//{
//    BasePage.driver.SwitchTo().DefaultContent();
//    ListMenu.hoveronmenuitems();
//    Thread.Sleep(800);
//    SetMethod_Ext.Clicks(_Client);
//    BasePage.driver.SwitchTo().Frame("f1");
//    SetMethod_Ext.Clicks(_ClientNew);
//    SetMethod_Ext.EnterText(_ClientID, RandomGen.RandomG());
//    Thread.Sleep(500);
//    _ClientManager.SendKeys(e);


//    SetMethod_Ext.Clicks(_ClientSave);
//}