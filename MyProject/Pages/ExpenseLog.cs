using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Threading;

namespace MyProject
{
   
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


       


        public void CreateNewExpenseEntry()
        {            
            _ELNew.Click();
            _ELEmpDD.Click();
          
            CustomMehtods.WaitAndClick(_ELEmp);
            _ELDateField.Click();
            _ELDateSel.Click();

            _ELProjectDD.Click();           
            CustomMehtods.WaitAndClick(_ELProject);

            _ELExpDD.Click();
            CustomMehtods.WaitAndClick(_ELExp);
            
            _ELUnits.SendKeys("10");
            Thread.Sleep(5000);
            _ELCost.Clear();         

           
            _ELCost.SendKeys("22");
            
            _ELMore.Click();            
            _ELApproveChkbx.Click();
            
            CustomMehtods.WaitAndClick(_TESave);

        }
    }
}

