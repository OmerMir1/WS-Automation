using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyProject
{
    
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
            _employeenew.Click();
            CustomMehtods.EnterText(_employeeID, RandomGen.RandomG());           
            CustomMehtods.EnterText(_employeeFN, RandomGen.RandomG());
            CustomMehtods.EnterText(_employeeLN, RandomGen.RandomG());
            _RateTab.Click();
            CustomMehtods.EnterText(_employeeBR, RandomGen.RandomG());
            CustomMehtods.EnterText(_employeeCR, RandomGen.RandomG());
            _employeeSave.Click();    

        }
        }
    }
