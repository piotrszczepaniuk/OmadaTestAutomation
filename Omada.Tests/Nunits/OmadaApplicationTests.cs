using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace Omada.Tests
{
    [TestFixture]
    public class OmadaApplicationTests : SeleniumWebDriver
    {
        private OmadaApplicationPage _omadaApplicationPage;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            InitWebDriver();
        }


        [Test]
        public void Open_Page_Nunit()
        {
            _driver.Navigate().GoToUrl("http://omada.net");
            Assert.AreEqual("Identity Management | Omada Identity",_driver.Title);
            Assert.IsTrue(_driver.FindElement(getelementbytype("id", "content")).Displayed);
        }


        [Test]
        public void Open_Page_Pom()
        {
            _omadaApplicationPage = OmadaApplicationPage.NavigateTo(_driver);
            Assert.AreEqual("Identity Management | Omada Identity", _omadaApplicationPage.Title);
            Assert.IsTrue(_omadaApplicationPage.Content);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            DisposeWebDriver();
        }


    }


}
