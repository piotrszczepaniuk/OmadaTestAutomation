using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Omada.Tests
{

    public class OmadaApplicationPage
    {
        private readonly IWebDriver _driver;
        private const string PageUri = @"https://omada.net";
       

        [FindsBy(How = How.Id, Using = "content")]
        private IWebElement _content;

        [FindsBy(How = How.CssSelector, Using = "form.header__search input")]
        private IWebElement _search;


        public OmadaApplicationPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public static OmadaApplicationPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PageUri);

            return new OmadaApplicationPage(driver);
        }



        public string Search
        {
            set
            {
                _search.SendKeys(value);
            }
        }

        public bool Content => _content.Displayed;

        public string Title => _driver.Title;

    }
}
