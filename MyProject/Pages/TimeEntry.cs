using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace MyProject
{

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

        [FindsBy(How = How.XPath, Using = ".//*[@id='divFullList']/div/table/tbody/tr[5]/td[2]")]
        public IWebElement _TEAct { get; set; }   

        [FindsBy(How = How.Id, Using = "txtaHours")]
        public IWebElement _TEAHours { get; set; }

        [FindsBy(How = How.Id, Using = "chkBillable")]
        public IWebElement _TEBillable { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='lblMore']")]
        public IWebElement _TEMore { get; set; }

        [FindsBy(How = How.Id, Using = "chkApproved")]
        public IWebElement _TEApproveChkbx { get; set; }
        

        [FindsBy(How = How.Id, Using = "lnkSave")]
        public IWebElement _TESave { get; set; }




        
        public void CreateNewTimeEntry()
        {
                    
            _TENew.Click();

            _TEEmpDD.Click();
            CustomMehtods.WaitAndClick(_TEEmp);            
           
            _TEDateField.Click();           
            _TEDateSel.Click();

            _TEProjectDD.Click();
            CustomMehtods.WaitAndClick(_TEProject);
            
            _TEActDD.Click();
            CustomMehtods.WaitAndClick(_TEAct);
            
            _TEAHours.SendKeys("10");
            
            if (!_TEBillable.Selected)
            {
                _TEBillable.Click();
            }

        
            _TEMore.Click();

            CustomMehtods.WaitAndClick(_TEApproveChkbx);

            CustomMehtods.WaitAndClick(_TESave);

            IAlert alert = BasePage.driver.SwitchTo().Alert();     //Hanldes the Browser alert
            alert.Accept();



        }
    }
}
