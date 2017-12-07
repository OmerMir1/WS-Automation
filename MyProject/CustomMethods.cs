using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;

namespace MyProject
{
    [TestClass]
    public static  class CustomMethods
    {
        [Test]
        public static void PageLoad()
        {

            WebDriverWait Wait = new WebDriverWait(BasePage.driver, TimeSpan.FromSeconds(500));
             Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("lnkSave")));

        }
	
	public static void EnterText(this IWebElement element, string text)
        {
            
            element.Click();
            
        }
    }
}
