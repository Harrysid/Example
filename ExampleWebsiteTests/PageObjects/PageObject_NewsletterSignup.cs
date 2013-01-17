using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumHelper;

namespace ExampleWebsiteTests.Application
{
    public class PageObject_NewsletterSignup : Page_NewsletterSignup
    {
        ActionHelper actionHelper;
        public PageObject_NewsletterSignup(IWebDriver theDriver, ActionHelper theActionHelper)
        {
            //PageFactory.InitElements(theDriver, this);
            actionHelper = theActionHelper; 
        }

        public void fillForm(String office, String name, String emailAddress, String leadSource)
        {

            actionHelper.SetDropDownValue(select_office_locator, office);
            actionHelper.SetTextFieldValue(text_name_locator, name);
            actionHelper.SetTextFieldValue(text_email_locator, emailAddress);
            actionHelper.SetDropDownValue(select_leadsource_locator, leadSource);
            actionHelper.ClickWebElement(submit_submitmyrequest_locator);
        }
    }
}

