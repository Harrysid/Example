using System;
using System.Net;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumHelper;

namespace ExampleWebsiteTests
{
    [TestClass]
    public abstract class TestBase
    {

        //public ScreenShotRemoteWebDriver theWebDriver;
       // public IWebDriver theWebDriver;
        public IWebDriver theWebDriver;
        public ActionHelper actionHelper;
        public String runLocally = "False";
        public String browser = null;
        public String version = null;
        public String platform = null;
        public String internetExplorerDriverServerDirectory = "C:\\Selenium Grid\\";
        public String screenshotPath = "\\\\barney\\Development\\QA Team\\Automated Suites\\Selenium\\MSM Software\\Screenshots\\";
        //public String screenshotPath = "C:\\Screenshots\\";
        //String screenshotPath = "\\\\PC097\\Screenshots\\";
        TimeSpan implicitWait = new TimeSpan(0, 0, 60);
        
        public String ipAddress;

        public void closeWebDriver()
        {
            theWebDriver.Quit();
        }


        public void SetWebDriver(String browser, String version, String platform)
        {
            if (runLocally == "True")
            {
                SetLocalWebdriver(browser, version, platform);
            }
            else
            {
                SetRemoteWebdriver(browser, version, platform);
            }
            theWebDriver.Manage().Timeouts().ImplicitlyWait(implicitWait); 
            theWebDriver.Manage().Window.Maximize();
            getIPAddress();
        }

        private void getIPAddress()
        {
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress localIP in localIPs)
            {
                if (!localIP.IsIPv6LinkLocal)
                {
                    ipAddress = localIP.ToString();
                }
            }
            
        }

        public void SetRemoteWebdriver(String browser, String version, String platform)
        {
            DesiredCapabilities capability = null;

            switch (browser.ToLower())
            {
                case "internet explorer":
                    capability = DesiredCapabilities.InternetExplorer();
                    //InternetExplorerDriver IEDriver = new InternetExplorerDriver("C:\\Selenium Grid\\IEDriverServer.exe");
                    //capability = (DesiredCapabilities) IEDriver.Capabilities;
                    break;
                case "firefox":
                    capability = DesiredCapabilities.Firefox();
                    break;
            }
             capability.SetCapability("version", version);
             capability.SetCapability("platform", platform);
             capability.IsJavaScriptEnabled = true;

            theWebDriver = new ScreenShotRemoteWebDriver(new Uri("http://PC097:4444/wd/hub"), capability, TimeSpan.FromSeconds(900));            
        }

        public void SetLocalWebdriver(String browser, String version, String platform)
        {
            switch (browser.ToLower())
            {
                case "internet explorer":
                    theWebDriver = new InternetExplorerDriver(internetExplorerDriverServerDirectory);
                    break;
                case "firefox":
                    theWebDriver = new FirefoxDriver();
                    break;
            }         
        }

        public void getScreenshot(String browser, String version, String stringURL)
        {

            if (runLocally == "True")
            {
                getLocalScreenshot(browser, version, stringURL);
            }
            else
            {
                getRemoteScreenshot((ScreenShotRemoteWebDriver)theWebDriver, browser, version, stringURL);
            }           
        }


        private void getLocalScreenshot(String browser, String version, String stringURL)
        {
            Screenshot screenshot;
            // Take the screenshot            
            screenshot = ((ITakesScreenshot)theWebDriver).GetScreenshot();
            string ss = screenshot.AsBase64EncodedString;
            byte[] screenshotAsByteArray = screenshot.AsByteArray;

            // Save the screenshot
            screenshot.SaveAsFile(screenshotPath + browser + "_" + version + "_" + stringURL + ".jpeg", ImageFormat.Jpeg);
        }


        private void getRemoteScreenshot(ScreenShotRemoteWebDriver theWebDriver,
                String browser, String version, String stringURL)
        {
            Screenshot screenshot = theWebDriver.GetScreenshot();
            screenshot.SaveAsFile(screenshotPath + browser + "_" + version + "_" + stringURL + ".jpeg", ImageFormat.Jpeg);  
        } 

        //public bool IsTextPresent(string text)
        //{
        //    try
        //    {
        //        return theWebDriver.PageSource.Contains(text);
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        //public void GoToURL(String theURL)
        //{
        //    theWebDriver.Navigate().GoToUrl(theURL);
        //}

        //public void WaitForPageToLoad(String pageText)
        //{
        //    int i = 0;
        //    while (!theWebDriver.PageSource.ToLower().Contains(pageText.ToLower()) && i<60)
        //    {
        //        Thread.Sleep(1000);
        //        i++;
        //    }

        //    if (theWebDriver.PageSource.Contains(pageText))
        //    {
        //        //good, the page has been found
        //    }
        //    else
        //    {
        //        Assert.Fail("Page " + pageText + " did not load in time");
        //    }

        //}

        //public void closeRemoteWebdriver(ScreenShotRemoteWebDriver theWebdriver)
        //{
        //    if (theWebdriver != null)
        //    {
        //        theWebDriver.Quit();
        //    }
        //}
    }
}
