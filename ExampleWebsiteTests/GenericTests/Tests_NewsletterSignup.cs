using System;
using System.Configuration;
using System.Threading;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using ExampleWebsiteTests.Application;
using SeleniumHelper;

namespace ExampleWebsiteTests.Tests
{
    [TestClass]
    public abstract class Tests_NewsletterSignup : TestBase
    {
        
      
        int waitTime = 10;
        
        private TestContext testContextInstance;
                
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        String URL = null;
        String pageName = null;
        String stringURL = null;

        String office;
        String name;
      //  String position;
      //  String organisation;
      //  String areaCode;
      //  String phoneNo;
        String emailAddress;
       // String dateToCall;
       // String timeToCall;
      //  String additionalInfo;
     //   bool optIn;
        String leadSource;
        String assertionText;

        [TestInitialize]
        public void Startup()
        {
            URL = ConfigurationManager.AppSettings["URL"];
            runLocally = ConfigurationManager.AppSettings["runLocally"];
            screenshotPath = ConfigurationManager.AppSettings["screenshotPath"];
            SetWebDriver(browser, version, platform);
            actionHelper = new ActionHelper(theWebDriver);
            WebDriverWait wait = new WebDriverWait(theWebDriver, TimeSpan.FromSeconds(waitTime));
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (theWebDriver != null)
            {
                closeWebDriver();
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_NewsletterSignup.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_NewsletterSignup.xml", "NewsletterSignup_Success", DataAccessMethod.Sequential)]
        public void NewsletterSignup_Success()
        {           
            parseTestData();            
            try
            {                
                 
                 actionHelper.GoToURL(URL);
                 
                 PageObject_NewsletterSignup pageObject_NewsletterSignup = new PageObject_NewsletterSignup(theWebDriver, actionHelper);
                 
                 actionHelper.WaitForPageToLoad(pageName);
                 pageObject_NewsletterSignup.fillForm(office, name, emailAddress, leadSource);
                 actionHelper.WaitForPageToLoad(assertionText);
                 Assert.IsTrue(actionHelper.IsTextPresent(assertionText));
                 getScreenshot("SUCCESS_" + browser, version, TestContext.TestName);
                 
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
                Assert.Fail("An unexpected exception occurred using: "+browser+" "+version);
            }
        }

        

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_NewsletterSignup.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_NewsletterSignup.xml", "NewsletterSignup_NoOffice", DataAccessMethod.Sequential)]
        public void NewsletterSignup_NoOffice()
        {
            parseTestData();
            try
            {
                
                actionHelper.GoToURL(URL);
                
                PageObject_NewsletterSignup pageObject_NewsletterSignup = new PageObject_NewsletterSignup(theWebDriver, actionHelper);
                
                actionHelper.WaitForPageToLoad(pageName);
                pageObject_NewsletterSignup.fillForm(office, name, emailAddress, leadSource);
                actionHelper.WaitForPageToLoad(assertionText);
                Assert.IsTrue(actionHelper.IsTextPresent(assertionText));
                getScreenshot("SUCCESS_" + browser, version, TestContext.TestName);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
                Assert.Fail("An unexpected exception occurred using: " + browser + " " + version +" on node: "+ipAddress);
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_NewsletterSignup.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_NewsletterSignup.xml", "NewsletterSignup_NoName", DataAccessMethod.Sequential)]
        public void NewsletterSignup_NoName()
        {
            parseTestData();
            try
            {
                
                actionHelper.GoToURL(URL);
                
                PageObject_NewsletterSignup pageObject_NewsletterSignup = new PageObject_NewsletterSignup(theWebDriver, actionHelper);
                
                actionHelper.WaitForPageToLoad(pageName);
                pageObject_NewsletterSignup.fillForm(office, name, emailAddress, leadSource);
                actionHelper.WaitForPageToLoad(assertionText);
                Assert.IsTrue(actionHelper.IsTextPresent(assertionText));
                getScreenshot("SUCCESS_" + browser, version, TestContext.TestName);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
                Assert.Fail("An unexpected exception occurred using: " + browser + " " + version +" on node: "+ipAddress);
            }
        }

       
        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_NewsletterSignup.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_NewsletterSignup.xml", "NewsletterSignup_NoEmail", DataAccessMethod.Sequential)]
        public void NewsletterSignup_NoEmail()
        {
            parseTestData();
            try
            {
                
                actionHelper.GoToURL(URL);
                
                PageObject_NewsletterSignup pageObject_NewsletterSignup = new PageObject_NewsletterSignup(theWebDriver, actionHelper);
                
                actionHelper.WaitForPageToLoad(pageName);
                pageObject_NewsletterSignup.fillForm(office, name, emailAddress, leadSource);
                actionHelper.WaitForPageToLoad(assertionText);
                Assert.IsTrue(actionHelper.IsTextPresent(assertionText));
                getScreenshot("SUCCESS_" + browser, version, TestContext.TestName);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
                Assert.Fail("An unexpected exception occurred using: " + browser + " " + version +" on node: "+ipAddress);
            }
        }

              
        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_NewsletterSignup.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_NewsletterSignup.xml", "NewsletterSignup_NoLead", DataAccessMethod.Sequential)]
        public void NewsletterSignup_NoLead()
        {
            parseTestData();
            try
            {
                
                actionHelper.GoToURL(URL);
                
                PageObject_NewsletterSignup pageObject_NewsletterSignup = new PageObject_NewsletterSignup(theWebDriver, actionHelper);
                
                actionHelper.WaitForPageToLoad(pageName);
                pageObject_NewsletterSignup.fillForm(office, name, emailAddress, leadSource);
                actionHelper.WaitForPageToLoad(assertionText);
                Assert.IsTrue(actionHelper.IsTextPresent(assertionText));
                getScreenshot("SUCCESS_" + browser, version, TestContext.TestName);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
                Assert.Fail("An unexpected exception occurred using: " + browser + " " + version +" on node: "+ipAddress);
            }
        }


        private void parseTestData()
        {
            URL = ConfigurationManager.AppSettings["URL"];

            URL = URL + TestContext.DataRow["URL"].ToString();
            stringURL = URL.Replace('.', '_');
            stringURL = URL.Substring(URL.LastIndexOf("/"));
            stringURL = stringURL.Replace('/', '_');
            stringURL = stringURL.Replace(':', '_');
            stringURL = stringURL.Trim();

            pageName = testContextInstance.DataRow["page_name"].ToString();
            office = testContextInstance.DataRow["select_office"].ToString();
            name = testContextInstance.DataRow["text_name"].ToString();
            emailAddress = testContextInstance.DataRow["text_email"].ToString();
            leadSource = testContextInstance.DataRow["select_leadSource"].ToString();
            assertionText = testContextInstance.DataRow["assertion"].ToString();
        }       
    }
}
