using System;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace ExampleWebsiteTests.Tests
{
    [TestClass]
    public class IE7_Tests_ArrangeAmeeting : Tests_ArrangeAmeeting
    {
        public IE7_Tests_ArrangeAmeeting()
        {
            this.browser= "internet explorer";
            this.version = "7";
            //String platform = "WINDOWS";  
        }                    
    }
}
