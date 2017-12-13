using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject
{
    class Project
    {
        [FindsBy(How = How.Id, Using = "tab_project")]
        public IWebElement _ProjectTab { get; set; }

        [FindsBy(How = How.Id, Using = "lnkNew")]
        public IWebElement _ProjectNew { get; set; }

        [FindsBy(How = How.Id, Using = "txtCode")]
        public IWebElement _ProjectCode { get; set; }

        [FindsBy(How = How.Id, Using = "txtName")]
        public IWebElement _ProjectName { get; set; }

        [FindsBy(How = How.Id, Using = "txtClientAjax")]
        public IWebElement _ClientOfProject { get; set; }

        [FindsBy(How = How.Id, Using = "txtMangr")]
        public IWebElement _ProjectManager { get; set; }

        [FindsBy(How = How.Id, Using = "cmbContractType")]
        public IWebElement _ProjectContractType { get; set; }

        [FindsBy(How = How.Id, Using = "txtContractAmt")]
        public IWebElement _ProjectContractAmt { get; set; }

        [FindsBy(How = How.Id, Using = "lnkSave")]
        public IWebElement _ProjectSave { get; set; }


        public Project()
        {
            PageFactory.InitElements(BasePage.driver, this);
        }

        public void CreateNewProject(string cl, string mgr)

        {
            BasePage.driver.SwitchTo().DefaultContent();
            ListMenu.hoveronmenuitems();
            Thread.Sleep(2000);

            SetMethod_Ext.Clicks(_ProjectTab);
            BasePage.driver.SwitchTo().Frame("f1");
            SetMethod_Ext.Clicks(_ProjectNew);
            SetMethod_Ext.EnterText(_ProjectCode, RandomGen.RandomG());
            SetMethod_Ext.EnterText(_ProjectName, RandomGen.RandomG());
            _ClientOfProject.SendKeys(cl);
            _ProjectManager.SendKeys(mgr);

            SelectElement Manager = new SelectElement(_ProjectContractType);
            Manager.SelectByText("Fixed");

            
           
            //_ProjectContractAmt.Clear();
            _ProjectContractAmt.Click();
            //SetMethod_Ext.EnterText(_ProjectContractAmt, RandomGen.RandomG());
            _ProjectContractAmt.SendKeys("1000");
            SetMethod_Ext.Clicks(_ProjectSave);
        }
    }
}