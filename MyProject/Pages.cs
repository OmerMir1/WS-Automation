using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;

namespace MyProject
{
    [TestClass]
    public class Pages
    {
        [TestMethod]
        public static T InitiandReturnPageObject<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BasePage.driver, page);
            return page;
        }


        public static ListMenu listmenu
        {
            get { return InitiandReturnPageObject<ListMenu>(); }
        }

        public static Login login                                                                        
        {
            get{return InitiandReturnPageObject<Login>(); }
        }

        public static Employee employee
        {
            get { return InitiandReturnPageObject<Employee>(); }
        }

        public static Client client
        {
            get { return InitiandReturnPageObject<Client>(); }
        }

        public static Project project
        {
            get { return InitiandReturnPageObject<Project>(); }
        }

        public static TimeEntry timeentry
        {
            get { return InitiandReturnPageObject<TimeEntry>(); }
        }


        public static ExpenseLog expenseLog
        {
            get { return InitiandReturnPageObject<ExpenseLog>(); }
        }

        public static BillingReview billingreview
        {
            get { return InitiandReturnPageObject<BillingReview>(); }
        }

       

    }
}
