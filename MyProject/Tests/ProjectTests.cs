using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Tests
{
    [TestClass]
    public class ProjectTests
    {
        [TestMethod]
        public void CreateProject()
        {
            CustomMehtods.NewWebdriverAndGoToUrl();
            Pages.login.LogIn();

            CustomMehtods.Hoover(Pages.listmenu._List, Pages.project._ProjectTab);
            Pages.project.CreateNewProject();

            BasePage.driver.Quit();
        }
    }
}
