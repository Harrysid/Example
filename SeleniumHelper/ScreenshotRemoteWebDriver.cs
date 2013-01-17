using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SeleniumHelper {
    public class ScreenShotRemoteWebDriver : RemoteWebDriver, 
ITakesScreenshot 
    { 
        public ScreenShotRemoteWebDriver(Uri RemoteAdress, ICapabilities 
capabilities) 
            : base(RemoteAdress, capabilities) 
        { 
        }

        public ScreenShotRemoteWebDriver(Uri RemoteAdress, ICapabilities
capabilities, TimeSpan timeSpan)
            : base(RemoteAdress, capabilities, timeSpan)
        {
        } 

        public Screenshot GetScreenshot() 
        { 
            // Get the screenshot as base64. 
            Response screenshotResponse = 
this.Execute(DriverCommand.Screenshot, null); 
            string base64 = screenshotResponse.Value.ToString(); 
            // ... and convert it. 
            return new Screenshot(base64); 
        } 
    } 
  

}