using System;
using System.Threading;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumHelper
{
    public class ActionHelper
    {

        IWebDriver theWebdriver;
        IWebElement activeElement;
        WebDriverWait wait;
        double waitTime = 20;

        public ActionHelper(IWebDriver passedInWebdriver)
        {
            theWebdriver = passedInWebdriver;
            wait = new WebDriverWait(passedInWebdriver, TimeSpan.FromSeconds(waitTime));
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException), typeof(InvalidOperationException), typeof(NoSuchElementException));            
        }

        public void SetCheckboxValue(String locator, bool value)
        {
            WaitForElementToLoad(locator);
            activeElement = theWebdriver.FindElement(By.Id(locator));
            try
            {                
                if (activeElement.Selected == value)
                {
                    //Do nothing as state is correct.
                }

                else
                {
                    while (!activeElement.Enabled)
                    {
                        Thread.Sleep(100);
                    }
                    activeElement.Click();
                }
            }
            catch (StaleElementReferenceException e)
            {
                SetCheckboxValue(locator, value);
            }
        }

        public void ClickWebElement(String locator)
        {
            WaitForElementToLoad(locator);
            try
            {
                activeElement = theWebdriver.FindElement(By.Id(locator));
                while (!activeElement.Enabled)
                {
                    Thread.Sleep(100);
                }
                activeElement.Click();
            }
            catch (StaleElementReferenceException e)
            {
                ClickWebElement(locator);
            }
            catch (System.InvalidOperationException e)
            {
                ClickWebElement(locator);
            }
            //catch (OpenQA.Selenium.InvalidElementStateException e)
            //{
            //    ClickWebElement(locator);
            //}
        }

        public void SetTextFieldValue(String locator, String textValue)
        {
            
            WaitForElementToLoad(locator);

            try
            {
                if (textValue.Length>0)
                {
                    ClickWebElement(locator);
                    activeElement = theWebdriver.FindElement(By.Id(locator));
                    while (!activeElement.Enabled)
                    {
                        Thread.Sleep(100);
                    }
                    activeElement.SendKeys(textValue); 
                }
            }
            catch (StaleElementReferenceException e)
            {
                SetTextFieldValue(locator, textValue);
            }
        }

        public void SetDropDownValue(String locator, String textValue)
        {            
            WaitForElementToLoad(locator);            

            try
            {
                if (textValue.Length > 0)
                {                    
                    ClickWebElement(locator);
                    activeElement = theWebdriver.FindElement(By.Id(locator));
                    while (!activeElement.Enabled)
                    {
                        Thread.Sleep(100);
                    }
                    activeElement.SendKeys(textValue);
                    activeElement.SendKeys(Keys.Enter);
                    Thread.Sleep(1000);
                }
            }
            catch (StaleElementReferenceException e)
            {               
               SetDropDownValue(locator, textValue);
            }        
            
        }



        public string getOptionStringFromDdl(IWebElement webElement, int option)
        {
            SelectElement theSelectBox = new SelectElement(activeElement);
            IList<IWebElement> options = theSelectBox.Options;

            string optionString = null;

            for (int i = 0; i <= option; i++)
            {
                optionString = options[i].GetAttribute("value");
            }


            System.Diagnostics.Debug.WriteLine("Option Text: " + optionString);
            return optionString;
        }

        public int getOptionCountFromDdl(IWebElement webElement)
        {
            activeElement = webElement;
            SelectElement theSelectBox = new SelectElement(activeElement);
            IList<IWebElement> options = theSelectBox.Options;
            System.Diagnostics.Debug.WriteLine("Option Count: " + options.Count);
            return options.Count;
        }

        public void WaitForElementToLoad(String locator)
        {
                Thread.Sleep(500);

                activeElement = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator)));
                //activeElement = wait.Until<IWebElement>((theWebdriver) =>
                //{
                //    return theWebdriver.FindElement(By.Id(locator));
                //});
                //wait.Until(d=> activeElement.Enabled);
                //Thread.Sleep(100);            
        }

        public void WaitForPageToLoad(String pageText)
        {
            int i = 0;
            while (!theWebdriver.PageSource.ToLower().Contains(pageText.ToLower()) && i < 60)
            {
                Thread.Sleep(1000);
                i++;
            }
            Thread.Sleep(1000);

            //if we have reached the timeout then fail!
            if (i >= 60)
            {
                Assert.Fail("Page " + pageText + " did not load in time");
            }
        }

        public bool IsTextPresent(string text)
        {
            try
            {
                return theWebdriver.PageSource.Contains(text);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void GoToURL(String theURL)
        {
            theWebdriver.Navigate().GoToUrl(theURL);
        }
        //public void SetCheckboxValue(IWebElement webElement, bool value)
        //{
        //    activeElement = webElement;
        //    WaitForElementToLoad(activeElement);
        //    try
        //    {
        //        if (activeElement.Selected == value)
        //        {
        //            //Do nothing as state is correct.
        //        }

        //        else
        //        {
        //            activeElement.Click();
        //        }
        //    }
        //    catch (StaleElementReferenceException e)
        //    {
        //        String locator = activeElement.GetAttribute("id");
        //        activeElement = theWebdriver.FindElement(By.Id(locator));
        //        SetCheckboxValue(activeElement, value);
        //    }
        //}

        //public void ClickWebElement(IWebElement webElement)
        //{
        //    activeElement = webElement;
        //    WaitForElementToLoad(activeElement);
        //    try
        //    {
        //        activeElement.Click();
        //    }
        //    catch (StaleElementReferenceException e)
        //    {
        //        String locator = activeElement.GetAttribute("id");
        //        activeElement = theWebdriver.FindElement(By.Id(locator));
        //        ClickWebElement(activeElement);
        //    }
        //}

        //public void SetTextFieldValue(IWebElement webElement, String textValue)
        //{
        //    activeElement = webElement;
        //    WaitForElementToLoad(activeElement);

        //    try {
        //             ClickWebElement(activeElement);
        //             activeElement.SendKeys(textValue);
        //    }
        //    catch (StaleElementReferenceException e)
        //    {
        //        String locator = activeElement.GetAttribute("id");
        //        activeElement = theWebdriver.FindElement(By.Id(locator));
        //        SetTextFieldValue(activeElement, textValue);
        //    }
        //}

        //public void SetDropDownValue(IWebElement webElement, String textValue)
        //{
        //    activeElement = webElement;
        //    WaitForElementToLoad(activeElement);
        //    ClickWebElement(activeElement);

        //    try {
        //         activeElement.SendKeys(textValue);
        //         activeElement.SendKeys(Keys.Enter);
        //    }
        //    catch (StaleElementReferenceException e)
        //    {
        //        String locator = activeElement.GetAttribute("id");
        //        activeElement = theWebdriver.FindElement(By.Id(locator));
        //        SetDropDownValue(activeElement, textValue);
        //    }
        //   // Thread.Sleep(250);
        //    //SelectElement selectElement = new SelectElement(activeElement);
        //    //selectElement.SelectByText(textValue);
        //}

        

        //public string getOptionStringFromDdl(IWebElement webElement, int option)
        //{
        //    activeElement = webElement;
        //    SelectElement theSelectBox = new SelectElement(activeElement);
        //    IList<IWebElement> options = theSelectBox.Options;
            
        //    string optionString = null;

        //    for (int i = 0; i <= option; i++)
        //    {
        //        optionString = options[i].GetAttribute("value");
        //    }


        //    System.Diagnostics.Debug.WriteLine("Option Text: " + optionString);
        //    return optionString;
        //}

        //public int getOptionCountFromDdl(IWebElement webElement)
        //{
        //    activeElement = webElement;
        //    SelectElement theSelectBox = new SelectElement(activeElement);
        //    IList<IWebElement> options = theSelectBox.Options;
        //    System.Diagnostics.Debug.WriteLine("Option Count: " + options.Count);
        //    return options.Count;
        //}

        //public void WaitForElementToLoad(IWebElement webElement)
        //{
        //    try
        //    {
                
        //        Thread.Sleep(200);
        //        //wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator)));
        //        wait.Until(x => webElement.Displayed);
        //        //Thread.Sleep(100);
        //        // activeElement = theWebdriver.FindElement(By.Id(locator));
        //        //activeElement = wait.Until<IWebElement>((theWebdriver) =>
        //        //{
        //        //    return theWebdriver.FindElement(By.Id(locator));
        //        //});
        //        Thread.Sleep(100);
        //    }
        //    catch (StaleElementReferenceException e)
        //    {

        //        String locator = webElement.GetAttribute("id");
        //        activeElement = theWebdriver.FindElement(By.Id(locator));
        //        WaitForElementToLoad(activeElement);
        //    }      
        //}

        

    }
}
