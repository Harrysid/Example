using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumHelper;

namespace ExampleWebsiteTests.Application
{
    public class PageObject_ArrangeAmeeting : Page_ArrangeAmeeting
    {
        ActionHelper actionHelper;

        public PageObject_ArrangeAmeeting(IWebDriver theDriver, ActionHelper theActionHelper)
        {
            //PageFactory.InitElements(theDriver, this);
            actionHelper = theActionHelper;
        }
        
        public void fillForm(String date, String myOffice, String office, String name, String position, String organisation, String areaCode, String phoneNo, String emailAddress, String additionalInfo, bool optIn, String leadSource)
        {
            actionHelper.SetTextFieldValue(text_date_locator, date);
            if (myOffice.ToLower().Equals("true"))
            {
                //select client office
                actionHelper.ClickWebElement(radio_myOffice_locator);
                actionHelper.SetTextFieldValue(text_myOffice_locator, office);
            }
            else if (myOffice.ToLower().Equals("false"))
            {
                //select something else
                actionHelper.ClickWebElement(radio_msmOffice_locator);
                actionHelper.SetDropDownValue(select_office_locator, office);
            }
            else
            {
               // select neither location option
            }
            actionHelper.SetTextFieldValue(text_name_locator, name);
            actionHelper.SetTextFieldValue(text_position_locator, position);
            actionHelper.SetTextFieldValue(text_organisation_locator, organisation);
            actionHelper.SetTextFieldValue(text_areacode_locator, areaCode);
            actionHelper.SetTextFieldValue(text_telephonenumber_locator, phoneNo);
            actionHelper.SetTextFieldValue(text_email_locator, emailAddress);
            actionHelper.SetTextFieldValue(textarea_additionalinformation_locator, additionalInfo);
            actionHelper.SetDropDownValue(select_leadsource_locator, leadSource);
            actionHelper.SetCheckboxValue(checkbox_emailoptin_locator, optIn);
            actionHelper.ClickWebElement(submit_submitmyrequest_locator);
        }
    }
}

