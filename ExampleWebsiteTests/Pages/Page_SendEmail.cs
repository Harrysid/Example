using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ExampleWebsiteTests.Application
{
    public abstract class Page_SendEmail
    {
        public static string select_office_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_DropDownListMsmOfficeid";
        public static string text_name_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxName";
        public static string text_email_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxEmail";
        public static string textarea_enquiry_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxEnquiry";
        public static string checkbox_emailoptin_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_CheckBoxMailingOptIn";
        public static string select_leadsource_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_DropDownListMsmLeadSourceid";
        public static string submit_submitmyrequest_locator = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_ButtonAction";

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_DropDownListMsmOfficeid")]
        //public IWebElement select_office { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxName")]
        //public IWebElement text_name { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxEmail")]
        //public IWebElement text_email { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_TextBoxEnquiry")]
        //public IWebElement textarea_enquiry { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_CheckBoxMailingOptIn")]
        //public IWebElement checkbox_emailoptin { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_DropDownListMsmLeadSourceid")]
        //public IWebElement select_leadsource { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_ContentPlaceHolderDefault_ctl14_RequestCallToAction_7_ButtonAction")]
        //public IWebElement submit_submitmyrequest { get; set; }             
    }
}
