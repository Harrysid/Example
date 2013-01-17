using System;
using System.Configuration;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using SeleniumHelper;

namespace ExampleWebsiteTests.Tests
{
    [TestClass]
    public abstract class Tests_StaticPages : TestBase
    {
        
        
        int waitTime = 1;
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        String URL = null;
        String pageName = null;
        String stringURL = null;

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



        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest1", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            try
            {
                parseTestData();                
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                              
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

      

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest2", DataAccessMethod.Sequential)]
        public void TestMethod2()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest3", DataAccessMethod.Sequential)]
        public void TestMethod3()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest4", DataAccessMethod.Sequential)]
        public void TestMethod4()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest5", DataAccessMethod.Sequential)]
        public void TestMethod5()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest6", DataAccessMethod.Sequential)]
        public void TestMethod6()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest7", DataAccessMethod.Sequential)]
        public void TestMethod7()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest8", DataAccessMethod.Sequential)]
        public void TestMethod8()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest9", DataAccessMethod.Sequential)]
        public void TestMethod9()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest10", DataAccessMethod.Sequential)]
        public void TestMethod10()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }


        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest11", DataAccessMethod.Sequential)]
        public void TestMethod11()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }


        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest12", DataAccessMethod.Sequential)]
        public void TestMethod12()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest13", DataAccessMethod.Sequential)]
        public void TestMethod13()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest14", DataAccessMethod.Sequential)]
        public void TestMethod14()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest15", DataAccessMethod.Sequential)]
        public void TestMethod15()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest16", DataAccessMethod.Sequential)]
        public void TestMethod16()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest17", DataAccessMethod.Sequential)]
        public void TestMethod17()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest18", DataAccessMethod.Sequential)]
        public void TestMethod18()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest19", DataAccessMethod.Sequential)]
        public void TestMethod19()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest20", DataAccessMethod.Sequential)]
        public void TestMethod20()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest21", DataAccessMethod.Sequential)]
        public void TestMethod21()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest22", DataAccessMethod.Sequential)]
        public void TestMethod22()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest23", DataAccessMethod.Sequential)]
        public void TestMethod23()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest24", DataAccessMethod.Sequential)]
        public void TestMethod24()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest25", DataAccessMethod.Sequential)]
        public void TestMethod25()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest26", DataAccessMethod.Sequential)]
        public void TestMethod26()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest27", DataAccessMethod.Sequential)]
        public void TestMethod27()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest28", DataAccessMethod.Sequential)]
        public void TestMethod28()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest29", DataAccessMethod.Sequential)]
        public void TestMethod29()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest30", DataAccessMethod.Sequential)]
        public void TestMethod30()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest31", DataAccessMethod.Sequential)]
        public void TestMethod31()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest32", DataAccessMethod.Sequential)]
        public void TestMethod32()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest33", DataAccessMethod.Sequential)]
        public void TestMethod33()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest34", DataAccessMethod.Sequential)]
        public void TestMethod34()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest35", DataAccessMethod.Sequential)]
        public void TestMethod35()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest36", DataAccessMethod.Sequential)]
        public void TestMethod36()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest37", DataAccessMethod.Sequential)]
        public void TestMethod37()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest38", DataAccessMethod.Sequential)]
        public void TestMethod38()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest39", DataAccessMethod.Sequential)]
        public void TestMethod39()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest40", DataAccessMethod.Sequential)]
        public void TestMethod40()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest41", DataAccessMethod.Sequential)]
        public void TestMethod41()
      {
          try
          {
              parseTestData();
              actionHelper.GoToURL(URL);
              
              getScreenshot(browser, version, stringURL);
              
          }
          catch (Exception)
          {
              getScreenshot("ERROR_" + browser, version, TestContext.TestName);
              
          }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest42", DataAccessMethod.Sequential)]
        public void TestMethod42()
       {
           try
           {
               parseTestData();
               actionHelper.GoToURL(URL);
               
               getScreenshot(browser, version, stringURL);
               
           }
           catch (Exception)
           {
               getScreenshot("ERROR_" + browser, version, TestContext.TestName);
               
           }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest43", DataAccessMethod.Sequential)]
        public void TestMethod43()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest44", DataAccessMethod.Sequential)]
        public void TestMethod44()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest45", DataAccessMethod.Sequential)]
        public void TestMethod45()
       {
           try
           {
               parseTestData();
               actionHelper.GoToURL(URL);
               
               getScreenshot(browser, version, stringURL);
               
           }
           catch (Exception)
           {
               getScreenshot("ERROR_" + browser, version, TestContext.TestName);
               
           }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest46", DataAccessMethod.Sequential)]
        public void TestMethod46()
       {
           try
           {
               parseTestData();
               actionHelper.GoToURL(URL);
               
               getScreenshot(browser, version, stringURL);
               
           }
           catch (Exception)
           {
               getScreenshot("ERROR_" + browser, version, TestContext.TestName);
               
           }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest47", DataAccessMethod.Sequential)]
        public void TestMethod47()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest48", DataAccessMethod.Sequential)]
        public void TestMethod48()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest49", DataAccessMethod.Sequential)]
        public void TestMethod49()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest50", DataAccessMethod.Sequential)]
        public void TestMethod50()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest51", DataAccessMethod.Sequential)]
        public void TestMethod51()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest52", DataAccessMethod.Sequential)]
        public void TestMethod52()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest53", DataAccessMethod.Sequential)]
        public void TestMethod53()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest54", DataAccessMethod.Sequential)]
        public void TestMethod54()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest55", DataAccessMethod.Sequential)]
        public void TestMethod55()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest56", DataAccessMethod.Sequential)]
        public void TestMethod56()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest57", DataAccessMethod.Sequential)]
        public void TestMethod57()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest58", DataAccessMethod.Sequential)]
        public void TestMethod58()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest59", DataAccessMethod.Sequential)]
        public void TestMethod59()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest60", DataAccessMethod.Sequential)]
        public void TestMethod60()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest61", DataAccessMethod.Sequential)]
        public void TestMethod61()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest62", DataAccessMethod.Sequential)]
        public void TestMethod62()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest63", DataAccessMethod.Sequential)]
        public void TestMethod63()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest64", DataAccessMethod.Sequential)]
        public void TestMethod64()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest65", DataAccessMethod.Sequential)]
        public void TestMethod65()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest66", DataAccessMethod.Sequential)]
        public void TestMethod66()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest67", DataAccessMethod.Sequential)]
        public void TestMethod67()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest68", DataAccessMethod.Sequential)]
        public void TestMethod68()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest69", DataAccessMethod.Sequential)]
        public void TestMethod69()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest70", DataAccessMethod.Sequential)]
        public void TestMethod70()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest71", DataAccessMethod.Sequential)]
        public void TestMethod71()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest72", DataAccessMethod.Sequential)]
        public void TestMethod72()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest73", DataAccessMethod.Sequential)]
        public void TestMethod73()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest74", DataAccessMethod.Sequential)]
        public void TestMethod74()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest75", DataAccessMethod.Sequential)]
        public void TestMethod75()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest76", DataAccessMethod.Sequential)]
        public void TestMethod76()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest77", DataAccessMethod.Sequential)]
        public void TestMethod77()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest78", DataAccessMethod.Sequential)]
        public void TestMethod78()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest79", DataAccessMethod.Sequential)]
        public void TestMethod79()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest80", DataAccessMethod.Sequential)]
        public void TestMethod80()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest81", DataAccessMethod.Sequential)]
        public void TestMethod81()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest82", DataAccessMethod.Sequential)]
        public void TestMethod82()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest83", DataAccessMethod.Sequential)]
        public void TestMethod83()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest84", DataAccessMethod.Sequential)]
        public void TestMethod84()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest85", DataAccessMethod.Sequential)]
        public void TestMethod85()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest86", DataAccessMethod.Sequential)]
        public void TestMethod86()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest87", DataAccessMethod.Sequential)]
        public void TestMethod87()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest88", DataAccessMethod.Sequential)]
        public void TestMethod88()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        [DeploymentItem("MSMCorporateWebsiteTests\\TestData\\TestData_StaticPages.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestData\\TestData_StaticPages.xml", "UnitTest89", DataAccessMethod.Sequential)]
        public void TestMethod89()
        {
            try
            {
                parseTestData();
                actionHelper.GoToURL(URL);
                
                getScreenshot(browser, version, stringURL);
                
            }
            catch (Exception)
            {
                getScreenshot("ERROR_" + browser, version, TestContext.TestName);
                
            }
        }

        private void parseTestData()
        {
           // browser = testContextInstance.DataRow["Browser"].ToString();
           // version = testContextInstance.DataRow["Version"].ToString();
           // platform = testContextInstance.DataRow["Platform"].ToString();
            pageName = testContextInstance.DataRow["Name"].ToString();
            URL = URL + TestContext.DataRow["URL"].ToString();
            stringURL = URL.Replace('.', '_');
            stringURL = URL.Substring(URL.LastIndexOf("/"));
            stringURL = stringURL.Replace('/', '_');
            stringURL = stringURL.Replace(':', '_');
            stringURL = stringURL.Trim();
        }
    }
}
