using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void CreateEmployee()
        {
            CustomMehtods.NewWebdriverAndGoToUrl();
            Pages.login.LogIn();
            CustomMehtods.Hoover(Pages.listmenu._List, Pages.employee._employee);
            Pages.employee.CreateNewEmp();
        }
    }
}
