using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Tests
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public void CreateClient()
        {
            CustomMehtods.NewWebdriverAndGoToUrl();
            Pages.login.LogIn();

            CustomMehtods.Hoover(Pages.listmenu._List, Pages.client._Client);
            Pages.client.CreateNewClient();
        }
    }
}
