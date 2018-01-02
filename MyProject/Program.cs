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
        [TestMethod]
        [Test]
        static void Main(string[] args)
        {
            BasePage.driver = new ChromeDriver();
            BasePage.driver.Navigate().GoToUrl("http://demo.billquick.com");

            Pages.login.LogIn();

            CustomMehtods.Hoover(Pages.listmenu._List, Pages.employee._employee );
            Pages.employee.CreateNewEmp();
            //////string EID = empl._employeeID.GetAttribute("Value");  Get the Emp ID property value to pass that on to cleint and project.


            CustomMehtods.Hoover(Pages.listmenu._List, Pages.client._Client);
            Pages.client.CreateNewClient();
            //////// Cli.CreateNewClient(EID);          Fucntion call to Create a client with Emp ID passed for cleint manager
            ////////string CLID = Cli._ClientID.GetAttribute("value");



            CustomMehtods.Hoover(Pages.listmenu._List, Pages.project._ProjectTab);
            Pages.project.CreateNewProject();
            ////Pro.CreateNewProject(CLID, EID);    Get the Client ID property value to pass that on to Project.


            CustomMehtods.Hoover(Pages.listmenu._Time, Pages.timeentry._TimeEntryTab);
            Pages.timeentry.CreateNewTimeEntry();


           CustomMehtods.Hoover(Pages.listmenu._Expense, Pages.expenseLog._ExpenseLogTab);
           Pages.expenseLog.CreateNewExpenseEntry();


           CustomMehtods.Hoover(Pages.listmenu._Billing, Pages.billingreview.BRTab);
           Pages.billingreview.CreateNewInvoice();


            BasePage.driver.Quit();
        }
    }
}

