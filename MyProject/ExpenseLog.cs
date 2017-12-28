using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Threading;

namespace MyProject
{
    [TestClass]
    public class ExpenseLog
    {
        
        [FindsBy(How = How.Id, Using = "tab_expenselog")]
        public IWebElement _ExpenseLogTab { get; set; }

        [FindsBy(How = How.Id, Using = "lnkNew")]
        public IWebElement _ELNew { get; set; }

        [FindsBy(How = How.Id, Using = "lstcmbEmp1")]
        public IWebElement _ELEmpDD { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]")]
        public IWebElement _ELEmp { get; set; }

        [FindsBy(How = How.Id, Using = "txtNewDate")]
        public IWebElement _ELDateField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ui-datepicker-div']/table/tbody/tr[3]/td[5]/a")]
        public IWebElement _ELDateSel { get; set; }

        [FindsBy(How = How.Id, Using = "lstcmbEmp2")]
        public IWebElement _ELProjectDD { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]")]
        public IWebElement _ELProject { get; set; }

        [FindsBy(How = How.Id, Using = "lstExpense")]
        public IWebElement _ELExpDD { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]")]
        public IWebElement _ELExp { get; set; }

        [FindsBy(How = How.Id, Using = "txtUnits")]
        public IWebElement _ELUnits { get; set; }

        [FindsBy(How = How.Id, Using = "txtForeignCost")]
        public IWebElement _ELCost { get; set; }

        [FindsBy(How = How.Id, Using = "lblMore")]
        public IWebElement _ELMore { get; set; }


        [FindsBy(How = How.Id, Using = "chkApproved")]
        public IWebElement _ELApproveChkbx { get; set; }


        [FindsBy(How = How.Id, Using = "lnkSave")]
        public IWebElement _TESave { get; set; }


       

        [TestMethod]
        public void CreateNewExpenseEntry()
        {
            CustomMehtods.Clicks(_ExpenseLogTab);
            BasePage.driver.SwitchTo().Frame("f1");
            CustomMehtods.Clicks(_ELNew);
            CustomMehtods.Clicks(_ELEmpDD);
            Thread.Sleep(1500);
            CustomMehtods.Clicks(_ELEmp);
            CustomMehtods.Clicks(_ELDateField);
            CustomMehtods.Clicks(_ELDateSel);
            CustomMehtods.Clicks(_ELProjectDD);
            Thread.Sleep(1500);
            CustomMehtods.Clicks(_ELProject);
            CustomMehtods.Clicks(_ELExpDD);
            Thread.Sleep(1500);
            CustomMehtods.Clicks(_ELExp);
            
            _ELUnits.SendKeys("10");
            Thread.Sleep(5000);
            _ELCost.Clear();
            
         

            //IAlert alert = BasePage.driver.SwitchTo().Alert();
            //alert.Dismiss();
            _ELCost.SendKeys("22");
            
            CustomMehtods.Clicks(_ELMore);            
            CustomMehtods.Clicks(_ELApproveChkbx);
            Thread.Sleep(1500);
            CustomMehtods.Clicks(_TESave);

        }
    }
}

