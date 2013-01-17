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
    public abstract class Tests_ArrangeAmeeting : TestBase
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

        String meetingDate;
        String myOffice;
        String office;
        String name;
        String position;
        String organisation;
        String areaCode;
        String phoneNo;
        String emailAddress;
        String additionalInfo;
        bool optIn;
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

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_ArrangeAmeeting.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_ArrangeAmeeting.xml", "ArrangeAmeeting_Success", DataAccessMethod.Sequential)]
        public void ArrangeAmeeting_Success()
        {
            parseTestData();            
            try
            {                
                 
                 actionHelper.GoToURL(URL);
                 
                 PageObject_ArrangeAmeeting pageObject_ArrangeAmeeting = new PageObject_ArrangeAmeeting(theWebDriver, actionHelper);
                 
                 actionHelper.WaitForPageToLoad(pageName);
                 pageObject_ArrangeAmeeting.fillForm(meetingDate, myOffice, office, name, position, organisation, areaCode,
                    phoneNo, emailAddress, additionalInfo, optIn, leadSource);
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

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_ArrangeAmeeting.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_ArrangeAmeeting.xml", "ArrangeAmeeting_NoDate", DataAccessMethod.Sequential)]
        public void ArrangeAmeeting_NoDate()
        {
            parseTestData();
            try
            {                
                actionHelper.GoToURL(URL);                
                PageObject_ArrangeAmeeting pageObject_ArrangeAmeeting = new PageObject_ArrangeAmeeting(theWebDriver, actionHelper);
                actionHelper.WaitForPageToLoad(pageName);
                pageObject_ArrangeAmeeting.fillForm(meetingDate, myOffice, office, name, position, organisation, areaCode,
                   phoneNo, emailAddress, additionalInfo, optIn, leadSource);
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


        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_ArrangeAmeeting.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_ArrangeAmeeting.xml", "ArrangeAmeeting_NoOffice", DataAccessMethod.Sequential)]
        public void ArrangeAmeeting_NoOffice()
        {
            parseTestData();
            try
            {
                
                actionHelper.GoToURL(URL);
                
                PageObject_ArrangeAmeeting pageObject_ArrangeAmeeting = new PageObject_ArrangeAmeeting(theWebDriver, actionHelper);
                
                actionHelper.WaitForPageToLoad(pageName);
                pageObject_ArrangeAmeeting.fillForm(meetingDate, myOffice, office, name, position, organisation, areaCode,
                   phoneNo, emailAddress, additionalInfo, optIn, leadSource);
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

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_ArrangeAmeeting.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_ArrangeAmeeting.xml", "ArrangeAmeeting_NoName", DataAccessMethod.Sequential)]
        public void ArrangeAmeeting_NoName()
        {
            parseTestData();
            try
            {
                
                actionHelper.GoToURL(URL);
                
                PageObject_ArrangeAmeeting pageObject_ArrangeAmeeting = new PageObject_ArrangeAmeeting(theWebDriver, actionHelper);
                
                actionHelper.WaitForPageToLoad(pageName);
                pageObject_ArrangeAmeeting.fillForm(meetingDate, myOffice, office, name, position, organisation, areaCode,
                   phoneNo, emailAddress, additionalInfo, optIn, leadSource);
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


        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_ArrangeAmeeting.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_ArrangeAmeeting.xml", "ArrangeAmeeting_NoTelephone", DataAccessMethod.Sequential)]
        public void ArrangeAmeeting_NoTelephone()
        {
            parseTestData();
            try
            {
                
                actionHelper.GoToURL(URL);
                
                PageObject_ArrangeAmeeting pageObject_ArrangeAmeeting = new PageObject_ArrangeAmeeting(theWebDriver, actionHelper);
                
                actionHelper.WaitForPageToLoad(pageName);
                pageObject_ArrangeAmeeting.fillForm(meetingDate, myOffice, office, name, position, organisation, areaCode,
                   phoneNo, emailAddress, additionalInfo, optIn, leadSource);
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


        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_ArrangeAmeeting.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_ArrangeAmeeting.xml", "ArrangeAmeeting_NoEmail", DataAccessMethod.Sequential)]
        public void ArrangeAmeeting_NoEmail()
        {
            parseTestData();
            try
            {
                
                actionHelper.GoToURL(URL);
                
                PageObject_ArrangeAmeeting pageObject_ArrangeAmeeting = new PageObject_ArrangeAmeeting(theWebDriver, actionHelper);
                
                actionHelper.WaitForPageToLoad(pageName);
                pageObject_ArrangeAmeeting.fillForm(meetingDate, myOffice, office, name, position, organisation, areaCode,
                   phoneNo, emailAddress, additionalInfo, optIn, leadSource);
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


        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_ArrangeAmeeting.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_ArrangeAmeeting.xml", "ArrangeAmeeting_NoLead", DataAccessMethod.Sequential)]
        public void ArrangeAmeeting_NoLead()
        {
            parseTestData();
            try
            {
                
                actionHelper.GoToURL(URL);
                
                PageObject_ArrangeAmeeting pageObject_ArrangeAmeeting = new PageObject_ArrangeAmeeting(theWebDriver, actionHelper);
                
                actionHelper.WaitForPageToLoad(pageName);
                pageObject_ArrangeAmeeting.fillForm(meetingDate, myOffice, office, name, position, organisation, areaCode,
                   phoneNo, emailAddress, additionalInfo, optIn, leadSource);
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
            meetingDate = testContextInstance.DataRow["text_date"].ToString();
            //Gets next valid Monday (does not ignore BankHolidays!!!) if a date has been specified.

            if (meetingDate.Length > 0) {
                meetingDate = DataGenerator.getDate_NextMonday();
            }

            myOffice = testContextInstance.DataRow["radio_myOffice"].ToString();
            office = testContextInstance.DataRow["select_office"].ToString();
            name = testContextInstance.DataRow["text_name"].ToString();
            position = testContextInstance.DataRow["text_position"].ToString();
            organisation = testContextInstance.DataRow["text_organisation"].ToString();
            areaCode = testContextInstance.DataRow["text_areaCode"].ToString();
            phoneNo = testContextInstance.DataRow["text_telephoneNumber"].ToString();
            emailAddress = testContextInstance.DataRow["text_email"].ToString();
            additionalInfo = testContextInstance.DataRow["textArea_additionalInformation"].ToString();
            optIn = testContextInstance.DataRow["checkbox_emailOptIn"].ToString().Contains("true");
            leadSource = testContextInstance.DataRow["select_leadSource"].ToString();
            assertionText = testContextInstance.DataRow["assertion"].ToString();
        }       
    }
}
