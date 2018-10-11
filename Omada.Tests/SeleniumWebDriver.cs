using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System.IO;
using OpenQA.Selenium.Interactions;

namespace Omada.Tests
{
    public class SeleniumWebDriver
    {
        protected static IWebDriver _driver;
        private string oldTab = null;
        private string currentTab = null;

        protected static void InitWebDriver()
        {

            Console.WriteLine("InitWebDriver");

            string browser = ConfigurationSettings.AppSettings["Browser"];
            string browserOption1 = ConfigurationSettings.AppSettings["BrowserOption1"];

            browser = browser.ToLower();
            switch (browser)
            {
                case "chrome":
                    var chromeOptions = new ChromeOptions();
                    if (!browserOption1.Equals(""))
                        chromeOptions.AddArguments(browserOption1);
                    _driver = new ChromeDriver(chromeOptions);
                    break;
                case "firefox":
                    var firefoxOptions = new FirefoxOptions();
                    if (!browserOption1.Equals(""))
                        firefoxOptions.AddArguments(browserOption1);
                    _driver = new FirefoxDriver(firefoxOptions);
                    break;
                default:
                    firefoxOptions = new FirefoxOptions();
                    //firefoxOptions.AddArguments("--headless");
                    _driver = new FirefoxDriver(firefoxOptions);
                    break;

            }


            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            _driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(30);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        protected void takeScreenShot(string scrName) {

            string PrjFolder = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).
                                Parent.Parent.FullName;
            DateTime time = DateTime.Now;
            string dateToday = "_date_" + time.ToString("yyyy-MM-dd") + "_time_" + time.ToString("HH-mm-ss");
            var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
            screenshot.SaveAsFile(PrjFolder+"\\TestResults\\" +scrName+"" + dateToday + ".jpg", ScreenshotImageFormat.Jpeg);
        }

        protected void switchToNewTab()
        {  
            oldTab = _driver.CurrentWindowHandle;
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.open();");
            _driver.SwitchTo().Window(_driver.WindowHandles.Last());
            currentTab = _driver.CurrentWindowHandle;

        }

        protected void switchToPreviousTab()
        {
            string lastTab = currentTab;
            _driver.SwitchTo().Window(oldTab);
            currentTab = lastTab;

        }

        protected void switchToTabByTitle(string tabTitle)
        {

            oldTab = _driver.CurrentWindowHandle;
            bool winFound = false;
    	    foreach (string winHandle in _driver.WindowHandles)
            {
                string str = _driver.SwitchTo().Window(winHandle).Title;
                   if (str.Equals(tabTitle))
                    {
                        winFound = true;
                        currentTab = winHandle;
                        break;
                    }
                }
    	    if (!winFound)
    		    throw new Exception("Tab having title "+tabTitle+" not found");
        }



        protected void closeNewTab()
        {
            
            if (_driver.CurrentWindowHandle != null)
            {
                _driver.SwitchTo().Window(_driver.WindowHandles.Last());
                ((IJavaScriptExecutor)_driver).ExecuteScript("window.close();");
                oldTab = "";
                if (_driver.WindowHandles.Last() != null)
                    _driver.SwitchTo().Window(_driver.WindowHandles.Last());
                currentTab = _driver.CurrentWindowHandle;
            }
            else
                currentTab = null;

        }


        protected By getelementbytype(String type, String accessName)
        {
            switch (type)
            {
                case "id": return By.Id(accessName);
                case "name": return By.Name(accessName);
                case "class": return By.ClassName(accessName);
                case "xpath": return By.XPath(accessName);
                case "css": return By.CssSelector(accessName);
                case "linkText": return By.LinkText(accessName);
                case "partialLinkText": return By.PartialLinkText(accessName);
                case "tagName": return By.TagName(accessName);
                default: return null;

            }
        }

        protected static void DisposeWebDriver()
        {
            Console.WriteLine("DisposeWebDriver");
            //_driver.Close();
            _driver.Dispose();
        }
    }

}
