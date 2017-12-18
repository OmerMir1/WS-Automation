using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace MyProject
{
         [TestClass]    
         public class Project
        {
            [FindsBy(How = How.Id, Using = "tab_project")]
            public IWebElement _ProjectTab { get; set; }

            [FindsBy(How = How.Id, Using = "lnkNew")]
            public IWebElement _ProjectNew { get; set; }

            [FindsBy(How = How.Id, Using = "txtCode")]
            public IWebElement _ProjectCode { get; set; }

            [FindsBy(How = How.Id, Using = "txtName")]
            public IWebElement _ProjectName { get; set; }

            [FindsBy(How = How.Id, Using = "imgLstClient")]
            public IWebElement _ProjectClientDD { get; set; }

            [FindsBy(How = How.XPath, Using = "//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]")]
            public IWebElement _ProjectClient { get; set; }

            [FindsBy(How = How.Id, Using = "imgList")]
            public IWebElement _ProjectManagerDD { get; set; }

            [FindsBy(How = How.XPath, Using = "//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]")]
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

            [TestMethod]
            public void CreateNewProject()
            {
                SetMethod_Ext.Clicks(_ProjectTab);
                BasePage.driver.SwitchTo().Frame("f1");
                SetMethod_Ext.Clicks(_ProjectNew);
                SetMethod_Ext.EnterText(_ProjectCode, RandomGen.RandomG());
                SetMethod_Ext.EnterText(_ProjectName, RandomGen.RandomG());
                _ProjectClientDD.Click();
                Thread.Sleep(2000);
                _ProjectClient.Click();
                _ProjectManagerDD.Click();
                Thread.Sleep(2000);
                _ProjectManager.Click();

                SelectElement Manager = new SelectElement(_ProjectContractType);
                Manager.SelectByText("Fixed");

                _ProjectContractAmt.Click();
                _ProjectContractAmt.SendKeys("1000");
                SetMethod_Ext.Clicks(_ProjectSave);
            }
        }
    }








// This is a method wherein cleint ID and Manager ID are passed as parameters.

//public void CreateNewProject(string cl, string mgr)

//{
//    BasePage.driver.SwitchTo().DefaultContent();
//    ListMenu.hoveronmenuitems();
//    Thread.Sleep(2000);

//    SetMethod_Ext.Clicks(_ProjectTab);
//    BasePage.driver.SwitchTo().Frame("f1");
//    SetMethod_Ext.Clicks(_ProjectNew);
//    SetMethod_Ext.EnterText(_ProjectCode, RandomGen.RandomG());
//    SetMethod_Ext.EnterText(_ProjectName, RandomGen.RandomG());
//    _ClientOfProject.SendKeys(cl);
//    _ProjectManager.SendKeys(mgr);

//    SelectElement Manager = new SelectElement(_ProjectContractType);
//    Manager.SelectByText("Fixed");



//    //_ProjectContractAmt.Clear();
//    _ProjectContractAmt.Click();
//    //SetMethod_Ext.EnterText(_ProjectContractAmt, RandomGen.RandomG());
//    _ProjectContractAmt.SendKeys("1000");
//    SetMethod_Ext.Clicks(_ProjectSave);
//}