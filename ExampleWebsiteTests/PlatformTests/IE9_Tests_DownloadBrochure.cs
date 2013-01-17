using System;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;

namespace ExampleWebsiteTests.Tests
{
    [TestClass]
    public class IE9_Tests_DownloadBrochure : Tests_DownloadBrochure
    {
        public IE9_Tests_DownloadBrochure()
        {
            this.browser= "internet explorer";
            this.version = "9";
            //String platform = "WINDOWS";  
        }                    
    }
}
