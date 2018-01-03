using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace MyProject
{

    class BasePage
    {
        public static IWebDriver driver { get; set; }        

    }



   static class RandomGen
    {
        public static int RandomG()
        {
            Random rd = new Random();
            int randomint = rd.Next(100000);
            return randomint;            
        }
    }
}
