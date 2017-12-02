using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public static class SetMethod_Ext
    {

        public static void EnterText(IWebElement element, string value)    //Custom mehtods start, using a keyword this can turn these custom mthods in to extesnion methods of Iwebelemt wherein u can call the method as say _employeeFN.entertext instead of sendkeys.
        {
            element.SendKeys(value);
        }


        public static void Clicks(IWebElement element)
        {
            element.Click();
        }

        public static void SwitchToFrame()
        {
            BasePage.driver.SwitchTo().Frame("f1");
        }                                                              //Custom mehtods end
    }
}
