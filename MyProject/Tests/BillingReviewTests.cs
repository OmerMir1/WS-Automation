using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Tests
{
    [TestClass]
    public class BillingReviewTests
    {
        [TestMethod]
        public void CreateInvoice()
        {
            CustomMehtods.NewWebdriverAndGoToUrl();
            Pages.login.LogIn();


            CustomMehtods.Hoover(Pages.listmenu._Billing, Pages.billingreview.BRTab);
            Pages.billingreview.CreateNewInvoice();
        }
    }
}
