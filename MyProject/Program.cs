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
            
            ListMenu list = new ListMenu();
            list.hoveronmenuitems();
            Thread.Sleep(800);

            Employee empl = new Employee();
            empl.empclick();



            BasePage.driver.Quit();
        }
    }
}

