using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Tests
{
    [TestClass]
    public class TimeEntryTests
    {
        [TestMethod]
        public void CreateTimeEntry()
        {
            CustomMehtods.NewWebdriverAndGoToUrl();
            Pages.login.LogIn();


            CustomMehtods.Hoover(Pages.listmenu._Time, Pages.timeentry._TimeEntryTab);
            Pages.timeentry.CreateNewTimeEntry();
        }
    }
}
