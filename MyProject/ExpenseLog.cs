﻿using System;
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


        public ExpenseLog()
        {
            PageFactory.InitElements(BasePage.driver, this);
        }

        [TestMethod]
        public void CreateNewExpenseEntry()
        {
            SetMethod_Ext.Clicks(_ExpenseLogTab);
            BasePage.driver.SwitchTo().Frame("f1");
            SetMethod_Ext.Clicks(_ELNew);
            SetMethod_Ext.Clicks(_ELEmpDD);
            Thread.Sleep(1500);
            SetMethod_Ext.Clicks(_ELEmp);
            SetMethod_Ext.Clicks(_ELDateField);
            SetMethod_Ext.Clicks(_ELDateSel);
            SetMethod_Ext.Clicks(_ELProjectDD);
            Thread.Sleep(1500);
            SetMethod_Ext.Clicks(_ELProject);
            SetMethod_Ext.Clicks(_ELExpDD);
            Thread.Sleep(1500);
            SetMethod_Ext.Clicks(_ELExp);
            
            _ELUnits.SendKeys("10");
            Thread.Sleep(5000);
            _ELCost.Clear();
            
         

            //IAlert alert = BasePage.driver.SwitchTo().Alert();
            //alert.Dismiss();
            _ELCost.SendKeys("22");
            
            SetMethod_Ext.Clicks(_ELMore);            
            SetMethod_Ext.Clicks(_ELApproveChkbx);
            Thread.Sleep(1500);
            SetMethod_Ext.Clicks(_TESave);

        }
    }
}

