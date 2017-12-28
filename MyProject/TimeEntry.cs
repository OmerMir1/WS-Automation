using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace MyProject
{
    [TestClass]
    public class TimeEntry
    {
        [FindsBy(How = How.Id, Using = "tab_sheetview")]
        public IWebElement _TimeEntryTab { get; set; }

        [FindsBy(How = How.Id, Using = "lnkNew")]
        public IWebElement _TENew { get; set; }

        [FindsBy(How = How.Id, Using = "lstcmbEmp1")]
        public IWebElement _TEEmpDD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]")]
        public IWebElement _TEEmp { get; set; }

        [FindsBy(How = How.Id, Using = "txtTEDate")]
        public IWebElement _TEDateField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ui-datepicker-div']/table/tbody/tr[3]/td[5]/a")]
        public IWebElement _TEDateSel { get; set; }

        [FindsBy(How = How.Id, Using = "lstcmbEmp2")]
        public IWebElement _TEProjectDD { get; set; }
    
        [FindsBy(How = How.XPath, Using = ".//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]")]
        public IWebElement _TEProject { get; set; }    

        [FindsBy(How = How.Id, Using = "lstActivity")]
        public IWebElement _TEActDD { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]")]
        public IWebElement _TEAct { get; set; }

        [FindsBy(How = How.Id, Using = "txtaHours")]
        public IWebElement _TEAHours { get; set; }

        //[FindsBy(How = How.Id, Using = "chkBillable")]
        //public IWebElement _TEBillable { get; set; }
        

        [FindsBy(How = How.XPath, Using = ".//*[@id='lblMore']")]
        public IWebElement _TEMore { get; set; }

        [FindsBy(How = How.Id, Using = "chkApproved")]
        public IWebElement _TEApproveChkbx { get; set; }
        

        [FindsBy(How = How.Id, Using = "lnkSave")]
        public IWebElement _TESave { get; set; }




        [TestMethod]
        public void CreateNewTimeEntry()
        {

            CustomMehtods.Clicks(_TimeEntryTab);
            BasePage.driver.SwitchTo().Frame("f1");
            CustomMehtods.Clicks(_TENew);

            CustomMehtods.Clicks(_TEEmpDD);
            CustomMehtods.ElementToBeClickableAndClick(_TEEmp);            
           
            CustomMehtods.Clicks(_TEDateField);           
            CustomMehtods.Clicks(_TEDateSel);

            CustomMehtods.Clicks(_TEProjectDD);
            CustomMehtods.ElementToBeClickableAndClick(_TEProject);
            
            CustomMehtods.Clicks(_TEActDD);
            CustomMehtods.ElementToBeClickableAndClick(_TEAct);
            
            _TEAHours.SendKeys("10");
            IWebElement element = BasePage.driver.FindElement(By.Id("chkBillable"));
            if (!element.Selected)
            {
                element.Click();
            }

        
            CustomMehtods.Clicks(_TEMore);

            CustomMehtods.ElementToBeClickableAndClick(_TEApproveChkbx);

            CustomMehtods.ElementToBeClickableAndClick(_TESave);

            

        }
    }
}
