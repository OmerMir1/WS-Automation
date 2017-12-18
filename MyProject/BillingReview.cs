using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Linq;

namespace MyProject
{
    [TestClass]
    public class BillingReview
    {
        
        [FindsBy(How = How.Id, Using = "tab_billingreview")]
        public IWebElement BRTab { get; set; }

        [FindsBy(How = How.Id, Using = "cmbViewBy")]
        public IWebElement BRViewBy { get; set; }

        [FindsBy(How = How.Id, Using = "lnkListIDFrom")]
        public IWebElement BRProjectFDD { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]")]
        public IWebElement BRProjectSelect { get; set; }

        [FindsBy(How = How.Id, Using = "lnkListIDTo")]
        public IWebElement BRProjectTDD { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='divFullList']/div/table/tbody/tr[5]/td[2]")]
        public IWebElement BRProjectSelectSecond { get; set; }

        [FindsBy(How = How.Id, Using = "cmbPeriod")]
        public IWebElement BRAsOf { get; set; }

        [FindsBy(How = How.Id, Using = "lnkRefresh")]
        public IWebElement BRRefresh { get; set; }

        [FindsBy(How = How.Id, Using = "gridBR_ctl02_lnkGridOptions")]
        public IWebElement BRDetailsOption { get; set; }

        [FindsBy(How = How.Id, Using = "gridBR_ctl02_lnkWUD")]
        public IWebElement BRWUDWindowClick { get; set; }

        [FindsBy(How = How.Id, Using = "grdWUD_ctl02_chkSelectAll")]
        public IWebElement BRSelectAllToApplyWUD { get; set; }

        [FindsBy(How = How.Id, Using = "txtWUDPercentage")]
        public IWebElement BREnterWUD { get; set; }

        [FindsBy(How = How.Id, Using = "lnkUpdate")]
        public IWebElement BRWUDUpdate { get; set; }

        [FindsBy(How = How.Id, Using = "lnkClose")]
        public IWebElement BRCloseWUDWindow { get; set; }

        [FindsBy(How = How.Id, Using = "gridBR_ctl02_chkBill")]
        public IWebElement BRBillChkBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='lnkProcessOption']/i")]
        public IWebElement BRClickOnProcess { get; set; }

        [FindsBy(How = How.Id, Using = "lnkProcess")]
        public IWebElement BRProcessAsFinal { get; set; }


        public BillingReview()
        {
            PageFactory.InitElements(BasePage.driver, this);
        }


        [TestMethod]
        public void CreateNewInvoice()
        {
            SetMethod_Ext.Clicks(BRTab);
            BasePage.driver.SwitchTo().Frame("f1");           
            SelectElement ViewBy = new SelectElement(BRViewBy);
            ViewBy.SelectByIndex(1);
            SetMethod_Ext.Clicks(BRProjectFDD);
            Thread.Sleep(1500);
            SetMethod_Ext.Clicks(BRProjectSelect);
            SetMethod_Ext.Clicks(BRProjectTDD);
            Thread.Sleep(1500);
            SetMethod_Ext.Clicks(BRProjectSelectSecond);
            Thread.Sleep(500);
            SelectElement Period = new SelectElement(BRAsOf);
            Period.SelectByValue("All");     

            SetMethod_Ext.Clicks(BRRefresh);
            Thread.Sleep(1501);
            var CW = BasePage.driver.CurrentWindowHandle;
            foreach(string window in BasePage.driver.WindowHandles)
            {
                BasePage.driver.SwitchTo().Window(window);
                BasePage.driver.FindElement(By.Id("conformationFalseButton")).Click();
            }
            Thread.Sleep(1001);
            BasePage.driver.SwitchTo().Window(CW);
            BasePage.driver.SwitchTo().Frame("f1");            
            SetMethod_Ext.Clicks(BRDetailsOption);
            SetMethod_Ext.Clicks(BRWUDWindowClick);
            Thread.Sleep(900);
            foreach (string window in BasePage.driver.WindowHandles)
            {
                BasePage.driver.SwitchTo().Window(window);
            }
           
            SetMethod_Ext.Clicks(BRSelectAllToApplyWUD);
            BREnterWUD.SendKeys("50");
            SetMethod_Ext.Clicks(BRWUDUpdate);
            SetMethod_Ext.Clicks(BRCloseWUDWindow);
            Thread.Sleep(1001);
            BasePage.driver.SwitchTo().Window(CW);
            BasePage.driver.SwitchTo().Frame("f1");
            SetMethod_Ext.Clicks(BRBillChkBox);
           
            SetMethod_Ext.Clicks(BRClickOnProcess);
            
            SetMethod_Ext.Clicks(BRProcessAsFinal);

        }
    }
}
