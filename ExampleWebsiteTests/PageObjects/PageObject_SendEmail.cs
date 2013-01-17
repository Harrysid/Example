using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumHelper;

namespace ExampleWebsiteTests.Application
{
    public class PageObject_SendEmail : Page_SendEmail        
    {
        ActionHelper actionHelper;

        public PageObject_SendEmail(IWebDriver theDriver, ActionHelper theActionHelper)
        {
            //PageFactory.InitElements(theDriver, this);
            actionHelper = theActionHelper; 
        }

        public void fillForm(String office, String name, String emailAddress, String enquiry, bool optIn, String leadSource)
        {

            actionHelper.SetDropDownValue(select_office_locator, office);
            actionHelper.SetTextFieldValue(text_name_locator, name);
            actionHelper.SetTextFieldValue(text_email_locator, emailAddress);
            actionHelper.SetTextFieldValue(textarea_enquiry_locator, enquiry);
            actionHelper.SetDropDownValue(select_leadsource_locator, leadSource);
            actionHelper.SetCheckboxValue(checkbox_emailoptin_locator, optIn);
            actionHelper.ClickWebElement(submit_submitmyrequest_locator);
        }
    }
}

