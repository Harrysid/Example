using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumHelper;

namespace ExampleWebsiteTests.Application
{
    public class PageObject_ArrangeAcall : Page_ArrangeAcall
    {
        ActionHelper actionHelper;

        public PageObject_ArrangeAcall(IWebDriver theDriver, ActionHelper theActionHelper)
        {
           // PageFactory.InitElements(theDriver, this);
            actionHelper = theActionHelper; 
        }

        public void fillForm(String office, String name, String position, String organisation, String areaCode, String phoneNo, String emailAddress, String dateToCall, String timeToCall, String additionalInfo, bool optIn, String leadSource)
        {              
            actionHelper.SetDropDownValue(select_office_locator, office);
            actionHelper.SetTextFieldValue(text_name_locator, name);
            actionHelper.SetTextFieldValue(text_position_locator, position);
            actionHelper.SetTextFieldValue(text_organisation_locator, organisation);
            actionHelper.SetTextFieldValue(text_areacode_locator, areaCode);
            actionHelper.SetTextFieldValue(text_telephonenumber_locator, phoneNo);
            actionHelper.SetTextFieldValue(text_email_locator, emailAddress);
            actionHelper.SetDropDownValue(select_datetocall_locator, dateToCall);
           
            if (dateToCall.Length > 0 & timeToCall.Length > 0)
            {
               actionHelper.SetDropDownValue(select_timetocall_locator, timeToCall);
            }

           actionHelper.SetTextFieldValue(textarea_additionalinformation_locator, additionalInfo);
           actionHelper.SetDropDownValue(select_leadsource_locator, leadSource);
           actionHelper.SetCheckboxValue(checkbox_emailoptin_locator, optIn);
           actionHelper.ClickWebElement(submit_submitmyrequest_locator);
        }
    }
}

