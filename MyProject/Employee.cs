using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyProject
{
    [TestClass]
    public class Employee
    
        {
           [FindsBy(How = How.Id, Using = "tab_employee")]
            public IWebElement _employee { get; set; }

            [FindsBy(How = How.Id, Using = "lnkNew")]
            public IWebElement _employeenew { get; set; }

            [FindsBy(How = How.Id, Using = "txtEmpID")]
            public IWebElement _employeeID { get; set; }

            [FindsBy(How = How.Id, Using = "txtEmpFName")]
            public IWebElement _employeeFN { get; set; }


            [FindsBy(How = How.Id, Using = "txtEmpLName")]
            public IWebElement _employeeLN { get; set; }


            [FindsBy(How = How.Id, Using = "btnEmpRate")]
            public IWebElement _RateTab { get; set; }



            [FindsBy(How = How.Id, Using = "txtEmpBR")]
            public IWebElement _employeeBR { get; set; }


            [FindsBy(How = How.Id, Using = "txtEmpCR")]
            public IWebElement _employeeCR { get; set; }


            [FindsBy(How = How.Id, Using = "lnkSave")]
            public IWebElement _employeeSave { get; set; }


         

           
            public void CreateNewEmp()
            {

            
            CustomMehtods.Clicks(_employeenew);

            CustomMehtods.EnterText(_employeeID, RandomGen.RandomG());
           
            CustomMehtods.EnterText(_employeeFN, RandomGen.RandomG());
            CustomMehtods.EnterText(_employeeLN, RandomGen.RandomG());
            CustomMehtods.Clicks(_RateTab);
            CustomMehtods.EnterText(_employeeBR, RandomGen.RandomG());
            CustomMehtods.EnterText(_employeeCR, RandomGen.RandomG());
            CustomMehtods.Clicks(_employeeSave);                  








            //    _employee.Click();
            //    BasePage.driver.SwitchTo().Frame("f1");
            //    _employeenew.Click();

            //_employeeID.EnterText("2");
            //    _employeeFN.SendKeys("Omer");
            //    _employeeLN.SendKeys("Mir");
            //    _RateTab.Click();

            //_employeeBR.SendKeys("10");
            //    _employeeCR.SendKeys("5");
            //_employeeSave.Click();

        }
        }
    }
