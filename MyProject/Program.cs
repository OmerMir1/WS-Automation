using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace MyProject
{
    [TestClass]
    class Program
    {
        [SetUp]
        static void Main(string[] args)
        {
            BasePage.driver = new ChromeDriver();
            BasePage.driver.Navigate().GoToUrl("http://demo.billquick.com");
            Login element = new Login();
            element.LogIn();


            ListMenu Li = new ListMenu();


            Employee empl = new Employee();
            SetMethod_Ext.Hoover(Li._List, empl._employee);
            empl.CreateNewEmp();
            ////string EID = empl._employeeID.GetAttribute("Value");  Get the Emp ID property value to pass that on to cleint and project.


            Client Cli = new Client();
            SetMethod_Ext.Hoover(Li._List, Cli._Client);
            Cli.CreateNewClient();

            //// Cli.CreateNewClient(EID);          Fucntion call to Create a client with Emp ID passed for cleint manager
            ////string CLID = Cli._ClientID.GetAttribute("value");

            Project Pro = new Project();
            SetMethod_Ext.Hoover(Li._List, Pro._ProjectTab);
            Pro.CreateNewProject();
            //Pro.CreateNewProject(CLID, EID);    Get the Client ID property value to pass that on to Project.

            TimeEntry TE = new TimeEntry();
            SetMethod_Ext.Hoover(Li._Time, TE._TimeEntryTab);
            TE.CreateNewTimeEntry();

            ExpenseLog EL = new ExpenseLog();
            SetMethod_Ext.Hoover(Li._Expense, EL._ExpenseLogTab);
            EL.CreateNewExpenseEntry();


            BillingReview BR = new BillingReview();
            SetMethod_Ext.Hoover(Li._Billing, BR.BRTab);
            BR.CreateNewInvoice();

            BasePage.driver.Quit();
        }
    }
}

