@Omada
Feature: OmadaApplication
  In order to find information about Omada business
  As a business client
  I want to make sure that basic website functionality works

  Scenario: SmokeTest_001_Open_Page
    When I navigate to "https://www.omada.net/"
	When I click on element having "xpath" "//span[@class='cookiebar__button button--variant1']" 
    Then I should see page title as "Identity Management | Omada Identity"
    Then element having "id" "content" should be present
	
  Scenario: SmokeTest_002_Search
    When I navigate to "https://www.omada.net/"
	#When I click on element having "xpath" "//span[@class='cookiebar__button button--variant1']" 
    When I enter "gartner" into input field having "css" "form.header__search input"
	When I submit element having "css" "form.header__search input"
    Then Count of elements having "xpath" "//section[@class='search-results__item']" should be > 1
    Then Count of elements having "xpath" "//section[@class='search-results__item']" should be <= 100

  Scenario: SmokeTest_003_Redirect
    When I navigate to "https://www.omada.net/en-us/search?q=gartner"
	#When I click on element having "xpath" "//span[@class='cookiebar__button button--variant1']" 
    When I click on link having partial text "Gartner IAM Summit 2016 - London"
    Then I should see page title as "Omada is a sponser at the Gartner IAM Summit 2016 in London, UK."
    Then element having "xpath" "//section/div/p" should have partial text as "Gartner IAM Summit 2016 in London"

    
  Scenario: SmokeTest_004_Navigation_To_News
    When I navigate to "https://www.omada.net/"
	#Given I click on element having "xpath" "//span[@class='cookiebar__button button--variant1']" 
    When I click on link having text "More..."
    When I click on link having text "News & Events"
    When I click on link having text "News"
    Then I should see page title as "News | Omada Identity Suite"

  
  Scenario: SmokeTest_005_Go_To_Home_Page
    When I navigate to "https://www.omada.net/"
	#When I click on element having "xpath" "//span[@class='cookiebar__button button--variant1']" 
    When I scroll to "end" of page
    When I click on link having text "Contact"
	When I click on element having "xpath" "//span[@class='tabmenu__menu-item ' and contains(text(),'U.S. West')]"
    Then element having "css" "span.tabmenu__menu-item.selected" should be enabled
    Then I take screenshot
    When I hover over element having "xpath" "//span[@class='tabmenu__menu-item' and contains(text(),'Denmark')]"
    Then I take screenshot
    When I hover over element having "xpath" "//span[@class='tabmenu__menu-item' and contains(text(),'U.S. East')]"
    Then I take screenshot
    When I hover over element having "xpath" "//span[@class='tabmenu__menu-item selected' and contains(text(),'U.S. West')]"
    Then I take screenshot
	Then I take screenshot
    When I hover over element having "xpath" "//span[@class='tabmenu__menu-item' and contains(text(),'Germany')]"
    Then I take screenshot
    When I hover over element having "xpath" "//span[@class='tabmenu__menu-item' and contains(text(),'UK')]"
    Then I take screenshot

  Scenario: SmokeTest_006_007_Open_Read_Privacy_Policy_Close_Cookies_And_Private_Policy
    When I clear all cookies
    When I navigate to "https://www.omada.net/"
    When I scroll to "end" of page
	When I open link having text "Read Privacy Policy" in new tab
    Then I should see page title as "Omada | Processing of Personal Data"
    Then element having "xpath" "//section/h1" should have text as "WEBSITE PRIVACY POLICY"
    When I scroll to "end" of page
    When I click on element having "xpath" "//span[@class='cookiebar__button button--variant1']"
	When I switch to previous tab
	When I close new tab
	#When I refresh page
    Then link having text "Read Privacy Policy" should not be present

  Scenario: SmokeTest_008_Download_Pdf
    When I navigate to "https://www.omada.net/"
    When I scroll to "end" of page
	When I click on element having "xpath" "//span[@class='cookiebar__button button--variant1']" 
    When I click on link having text "Cases"
    When I click on link having text "Download PDF"
	When I scroll to "end" of page
	When I switch to frame having "css" "iframe"
	When I enter "John" into input field having "xpath" "//input[@id=(//label[contains(text(),'First Name')]/@for)]"
	When I enter "Smith" into input field having "xpath" "//input[@id=(//label[contains(text(),'Last Name')]/@for)]"
	When I enter "Engineer" into input field having "xpath" "//input[@id=(//label[contains(text(),'Title')]/@for)]"
	When I enter "Google" into input field having "xpath" "//input[@id=(//label[contains(text(),'Company')]/@for)]"
	When I select "Poland" option by "text" from dropdown having "xpath" "//select[@id=(//label[contains(text(),'Country')]/@for)]"
	When I enter "johnsmith@google.com" into input field having "xpath" "//input[@id=(//label[contains(text(),'Email')]/@for)]"
	When I enter "511111111" into input field having "xpath" "//input[@id=(//label[contains(text(),'Phone')]/@for)]"
    When I select "+10000" option by "text" from dropdown having "xpath" "//select[@id=(//label[contains(text(),'Number of employees')]/@for)]"
	When I select "Manager" option by "text" from dropdown having "xpath" "//select[@id=(//label[contains(text(),'Level')]/@for)]"
	When I select radio button having "xpath" "//input[@id=(//label[text()='Yes']/@for)]"
	When I switch to frame having "css" "iframe"
	When I click on element having "css" "div.recaptcha-checkbox-checkmark"
	#Please select reCAPTCHA pictures. 
	Given I wait 30 secs
	When I switch to main content
	When I switch to frame having "css" "iframe"
	When I click on element having "css" "p.submit input"
	


