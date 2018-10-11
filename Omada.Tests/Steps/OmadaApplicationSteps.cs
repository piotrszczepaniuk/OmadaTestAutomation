using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Omada.Tests
{


    [Binding]
    public class OmadaApplicationSteps : SeleniumWebDriver
    {

        

        [BeforeFeature]
        public static void BeforeTestRun()
        {
            InitWebDriver();
    
        }
		
		[When(@"I navigate to ""(.*)""")]
        public void WhenINavigateTo(string link)
        {
            _driver.Navigate().GoToUrl(link);
        }

        [When(@"I refresh page")]
        public void WhenIRefreshPage()
        {
            _driver.Navigate().Refresh();
        }
		
		
	    [When(@"I clear all cookies")]
        public void WhenIClearAllCookies()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
        }

		[Given(@"I wait (.*) secs")]
        public void GivenIWaitSecs(int delay)
        {
            System.Threading.Thread.Sleep(delay*1000);
        }


        [When(@"I switch to new tab")]
        public void WhenISwitchToNewTab()
        {
            switchToNewTab();

        }

        [When(@"I switch to previous tab")]
        public void WhenISwitchToPreviousTab()
        {
            switchToPreviousTab();
        }

        [When(@"I switch to tab having title ""(.*)""")]
        public void WhenISwitchToTabHavingTitle(string tabTitle)
        {
            switchToTabByTitle(tabTitle);
        }
		
		[When(@"I open link having text ""(.*)"" in new tab")]
        public void WhenIOpenLinkHavingTextInNewTab(string accessName)
        {
            
            string link = _driver.FindElement(getelementbytype("linkText", accessName)).GetAttribute("href");
            switchToNewTab();
            _driver.Navigate().GoToUrl(link);
        }


        [When(@"I close new tab")]
        public void WhenICloseNewTab()
        {
            closeNewTab();
        }
	
		
		
		[When(@"I switch to frame having ""(.*)"" ""(.*)""")]
        public void WhenISwitchToFrameHavingIndex(string type, string accessName)
        {
            _driver.SwitchTo().Frame(_driver.FindElement(getelementbytype(type, accessName)));
        }

		
	    [When(@"I switch to main content")]
        public void WhenISwitchToMainContent()
        {
            _driver.SwitchTo().DefaultContent();
        }

		
        [When(@"I scroll to ""(.+)"" of page")]
        public void WhenIScrollToOfPage(string to)
        {
            if (to.Equals("end"))
                ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0,Math.max(document.documentElement.scrollHeight,document.body.scrollHeight,document.documentElement.clientHeight));");
            else if (to.Equals("top"))
                ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(Math.max(document.documentElement.scrollHeight,document.body.scrollHeight,document.documentElement.clientHeight),0);");
            else
                throw new Exception("Exception : Invalid Direction (only scroll \"top\" or \"end\")");

        }
		
		
		[When(@"I hover over element having ""(.*)"" ""(.*)""")]
        public void WhenIHoverOverElementHaving(string type, string accessName)
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(_driver.FindElement(getelementbytype(type, accessName))).Perform();

        }
        

        [When(@"I enter ""(.*)"" into input field having ""(.+)"" ""(.*)""")]
        public void WhenIEnterIntoInputFieldHaving(string text, String type, string accessName)
        {
        
            _driver.FindElement(getelementbytype(type,accessName)).SendKeys(text);
            

        }
		

        [When(@"I submit element having ""(.*)"" ""(.*)""")]
        public void WhenIPressKeyForElementHaving( string type, string accessName)
        {
            _driver.FindElement(getelementbytype(type, accessName)).Submit();
        }


        [When(@"I click on element having ""(.+)"" ""(.*)""")]
        public void WhenIClickOnElementHaving(string type, string accessName)
        {
            _driver.FindElement(getelementbytype(type, accessName)).Click();
        }

		
		[When(@"I select ""(.*)"" option by ""(.*)"" from dropdown having ""(.*)"" ""(.*)""")]
        public void WhenISelectOptionByFromDropdownHaving(string option, string optionBy, string type, string accessName)
        {
           // dropdown = wait.until(ExpectedConditions.presenceOfElementLocated(getelementbytype(accessType, accessName)));
            SelectElement selectList = new SelectElement(_driver.FindElement(getelementbytype(type, accessName)));

            if (optionBy.Equals("selectByIndex"))
                selectList.SelectByIndex(Int32.Parse(option) - 1);
            else if (optionBy.Equals("value"))
                selectList.SelectByValue(option);
            else if (optionBy.Equals("text"))
                selectList.SelectByText(option);
        }

		
        [When(@"I select radio button having ""(.*)"" ""(.*)""")]
        public void WhenISelectRadioButtonHaving(string type, string accessName)
        {
            var radioButton = _driver.FindElement(getelementbytype(type, accessName));
            if (!radioButton.Selected)
                radioButton.Click();
        }

		
        [When(@"I click on link having text ""(.*)""")]
        public void WhenIClickOnLinkHavingText( string accessName)
        {
            _driver.FindElement(getelementbytype("linkText", accessName)).Click();
        }

        [When(@"I click on link having partial text ""(.*)""")]
        public void WhenIClickOnLinkHavingPartialText(string accessName)
        {
            _driver.FindElement(getelementbytype("partialLinkText", accessName)).Click();
        }

        
        [Then(@"I should see page title as ""(.*)""")]
        public void ThenIShouldSeePageTitleAs(string title)
        {
            Assert.AreEqual(title, _driver.Title);
        }
		
		
        [Then(@"element having ""(.*)"" ""(.*)"" should have text as ""(.*)""")]
        public void ThenElementHavingShouldHaveTextAs(string type, string accessName, string text)
        {
            Assert.AreEqual(text,_driver.FindElement(getelementbytype(type, accessName)).Text);
        }
        
        [Then(@"element having ""(.*)"" ""(.*)"" should have partial text as ""(.*)""")]
        public void ThenElementHavingShouldHavePartialTextAs(string type, string accessName, string text)
        {
          
            Assert.IsTrue( _driver.FindElement(getelementbytype(type, accessName)).Text.Contains(text));
        }
		
		[Then(@"element having ""(.*)"" ""(.*)"" should be enabled")]
        public void ThenElementHavingShouldBeEnabled(string type, string accessName)
        {
            Assert.IsTrue(_driver.FindElement(getelementbytype(type, accessName)).Enabled);
        }
        
        [Then(@"element having ""(.*)"" ""(.*)"" should be present")]
        public void ThenElementHavingShouldBePresent(string type, string accessName)
        {
            Assert.IsTrue(_driver.FindElement(getelementbytype(type, accessName)).Displayed);
        }
		
		[Then(@"link having text ""(.*)"" should not be present")]
        public void ThenLinkHavingTextShouldNotBePresent(string text)
        {
            
            try
            {
                _driver.FindElement(getelementbytype("linkText", text));
                throw new Exception("link text exists");
            }
            catch (NoSuchElementException)
            {
                return;
            }
        
        }
		
		[Then(@"Count of elements having ""(.*)"" ""(.*)"" should be (>|>=|==|<|<=) (.*)")]
        public void ThenCountOfElementsHavingShouldBe(string type, string  accessName, String comp, int limit)
        {

           
            switch (comp) {
                case ">":
                    Assert.IsTrue(_driver.FindElements(getelementbytype(type, accessName)).Count > limit);
                    break;
                case ">=":
                    Assert.IsTrue(_driver.FindElements(getelementbytype(type, accessName)).Count >= limit);
                    break;
                case "==":
                    Assert.IsTrue(_driver.FindElements(getelementbytype(type, accessName)).Count == limit);
                    break;
                case "<":
                    Assert.IsTrue(_driver.FindElements(getelementbytype(type, accessName)).Count < limit);
                    break;
                case "<=":
                    Assert.IsTrue(_driver.FindElements(getelementbytype(type, accessName)).Count <= limit);
                    break;
                default:
                    throw new Exception("Wrong comparison value: " + comp);
            }
         
        }

  
        
        [Then(@"I take screenshot")]
        public void ThenITakeScreenshot()
        {
            takeScreenShot(ScenarioContext.Current.ScenarioInfo.Title);
        }
        
       
       
        [AfterScenario]
        public void AfterScenario()
        {

            if (ScenarioContext.Current.TestError != null)
            {
                takeScreenShot(ScenarioContext.Current.ScenarioInfo.Title);
            }
            
            
        }

        [AfterFeature]
        public static void AfterTestRun() {
            DisposeWebDriver();
        } 
       
    }
}
