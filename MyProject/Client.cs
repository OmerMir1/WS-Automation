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

        [FindsBy(How = How.Id, Using = "txtcClientManager")]
        public IWebElement _ClientManager { get; set; }

        
        [FindsBy(How = How.Id, Using = "lnkSave")]
        public IWebElement _ClientSave { get; set; }

        public Client()
        {
            PageFactory.InitElements(BasePage.driver, this);
        }
        [TestMethod]
        public void CreateNewClient(string e)
            
        {
            BasePage.driver.SwitchTo().DefaultContent();
            ListMenu.hoveronmenuitems();
            Thread.Sleep(800);            
            SetMethod_Ext.Clicks(_Client);
            BasePage.driver.SwitchTo().Frame("f1");
            SetMethod_Ext.Clicks(_ClientNew);
            SetMethod_Ext.EnterText(_ClientID, RandomGen.RandomG());
            Thread.Sleep(500);
            _ClientManager.SendKeys(e);
           
           
            SetMethod_Ext.Clicks(_ClientSave);
        }
    }
}
