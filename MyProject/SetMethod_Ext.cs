using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace MyProject
{
    public static class SetMethod_Ext
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


        public static void Hoover(IWebElement hoveron)
        {
            BasePage.driver.SwitchTo().DefaultContent();
            Actions Hov = new Actions(BasePage.driver);
            Hov.MoveToElement(hoveron).Build().Perform();
            
        }



    }
}
