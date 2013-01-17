using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ExampleWebsiteTests.Application
{
    public abstract class Page_ArrangeAmeeting
    {

        public static string text_date_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_Meetingdate";
        public static string radio_myOffice_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_RadioButtonListMeeting_0";
        public static string text_myOffice_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxMeetingTown";
        public static string radio_msmOffice_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_RadioButtonListMeeting_1";
        public static string select_office_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_DropDownListMeetingOffice";
        public static string text_name_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxName";
        public static string text_position_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxPosition";
        public static string text_organisation_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxOrganisation";
        public static string text_areacode_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxTelIntCode";
        public static string text_telephonenumber_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxTelephone";
        public static string text_email_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxEmail";
        public static string textarea_additionalinformation_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxAdditionalInformation";
        public static string checkbox_emailoptin_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_CheckBoxMailingOptIn";
        public static string select_leadsource_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_DropDownListMsmLeadSourceid";
        public static string submit_submitmyrequest_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_ButtonAction";
    
        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_Meetingdate")]
        //public IWebElement text_date { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_RadioButtonListMeeting_0")]
        //public IWebElement radio_myOffice { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxMeetingTown")]
        //public IWebElement text_myOffice { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_RadioButtonListMeeting_1")]
        //public IWebElement radio_msmOffice { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_DropDownListMeetingOffice")]
        //public IWebElement select_office { get; set; }
        
        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxName")]
        //public IWebElement text_name { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxPosition")]
        //public IWebElement text_position { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxOrganisation")]
        //public IWebElement text_organisation { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxTelIntCode")]
        //public IWebElement text_areacode { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxTelephone")]
        //public IWebElement text_telephonenumber { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxEmail")]
        //public IWebElement text_email { get; set; }
               
        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxAdditionalInformation")]
        //public IWebElement textarea_additionalinformation { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_CheckBoxMailingOptIn")]
        //public IWebElement checkbox_emailoptin { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_DropDownListMsmLeadSourceid")]
        //public IWebElement select_leadsource { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_ButtonAction")]
        //public IWebElement submit_submitmyrequest { get; set; }     

    }
}
