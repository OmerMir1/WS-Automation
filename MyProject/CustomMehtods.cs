using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MyProject
{
    public class CustomMehtods
    {

        public static void EnterText(IWebElement element, int value)    //Custom mehtods start, using a keyword this can turn these custom mthods in to extesnion methods of Iwebelemt wherein u can call the method as say _employeeFN.entertext instead of sendkeys.
        {
            element.SendKeys(value.ToString());
        }


        public static void Clicks(IWebElement element)
        {
            element.Click();
        }

        public static void SelectFromDD(IWebElement element)    //Custom mehtods start, using a keyword this can turn these custom mthods in to extesnion methods of Iwebelemt wherein u can call the method as say _employeeFN.entertext instead of sendkeys.
        {
            SelectElement Sel = new SelectElement(element);
            Sel.SelectByIndex(4);
        }

        public static void Hoover(IWebElement hoveron, IWebElement elementtoclick)
        {
            BasePage.driver.SwitchTo().DefaultContent();
            Actions Hov = new Actions(BasePage.driver);
            Hov.MoveToElement(hoveron).Build().Perform();
            Thread.Sleep(1500);
            elementtoclick.Click();
        }


        public static void Hoover(IWebElement hovero)
        {

            Actions Hov = new Actions(BasePage.driver);
            Hov.MoveToElement(hovero).Build().Perform();
            Thread.Sleep(3000);

        }

        public static bool ElementExists(By by)
        {
            WebDriverWait wait = new WebDriverWait(BasePage.driver, TimeSpan.FromMinutes(1));
            IWebElement exists = wait.Until(ExpectedConditions.ElementExists(by));
            if (exists == null)
            {
                return false;
            }
            else
            { return true; };

        }

        public static bool ElementVisible(By by)
        {
            WebDriverWait wait = new WebDriverWait(BasePage.driver, TimeSpan.FromMinutes(1));
            IWebElement Visible = wait.Until(ExpectedConditions.ElementIsVisible(by));
            if (Visible == null)
            {
                return false;
            }
            else
            { return true; };

        }


        public static bool ElementToBeSelected(By by)
        {
            WebDriverWait wait = new WebDriverWait(BasePage.driver, TimeSpan.FromMinutes(1));
            bool elementToBeSelected = wait.Until(ExpectedConditions.ElementToBeSelected(by));
            return elementToBeSelected;
        }

        public static void ElementToBeClickableAndClick(IWebElement e)
        {
            WebDriverWait w = new WebDriverWait(BasePage.driver, TimeSpan.FromMinutes(1));
            w.Until(ExpectedConditions.ElementToBeClickable(e));
            e.Click();
        }


        //public static void WaitForPageLoad()
        //{
        //    WebDriverWait w = new WebDriverWait(BasePage.driver, TimeSpan.FromMinutes(1));
        //    w.Until(fe =>
        //        {
        //            return (bool)((IJavaScriptExecutor)fe).ExecuteScript("return document.readyState").Equals("complete");
        //        });
        //}

        //public static void WaitForPageAjax()
        //{
        //    WebDriverWait w = new WebDriverWait(BasePage.driver, TimeSpan.FromMinutes(1));
        //      w.Until(fe =>
        //      {
        //                return (bool)((IJavaScriptExecutor)fe).ExecuteScript("return jQuery.active == 0").Equals("complete");
        //           });
            
       // }
    }
}
