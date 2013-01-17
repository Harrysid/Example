using System;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace ExampleWebsiteTests.Tests
{
    [TestClass]
    public class FF_Tests_ArrangeAmeeting : Tests_ArrangeAmeeting
    {
        public FF_Tests_ArrangeAmeeting()
        {
            this.browser= "firefox";
            this.version = "";
            //String platform = "WINDOWS";  
        }                    
    }
}
