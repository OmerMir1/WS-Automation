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

            ListMenu.hoveronmenuitems();
            Thread.Sleep(800);

            Employee empl = new Employee();

            empl.CreateNewEmp();
            string EID = empl._employeeID.GetAttribute("Value");



            Client Cli = new Client();
            Cli.CreateNewClient(EID);
            string CLID = Cli._ClientID.GetAttribute("value");


            Project Pro = new Project();
            Pro.CreateNewProject(CLID, EID);
           


            BasePage.driver.Quit();
        }
    }
}

