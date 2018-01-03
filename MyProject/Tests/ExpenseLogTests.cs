using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Tests
{
    [TestClass]
    public class ExpenseLogTests
    {
        [TestMethod]
        public void CreateExpenseEntry()
        {
            CustomMehtods.NewWebdriverAndGoToUrl();
            Pages.login.LogIn();

            CustomMehtods.Hoover(Pages.listmenu._Expense, Pages.expenseLog._ExpenseLogTab);
            Pages.expenseLog.CreateNewExpenseEntry();
        }
    }
}
