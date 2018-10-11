# Manual for https://www.omada.net tests

# Implementation of an Automated test

*	Using WebDriver 3, NUnit 3, .Net Framework 4.5-4.6.1 (C#) implement the following:
1.	Open “omada.net”	
	Make sure the page is loaded properly (1-2 checks of your choice)
2.	Execute search for “gartner” (using search box in the top right corner of the front page)
	Verify that the search gives more than 1 result and that there is “There is Safety in Numbers” among those
3.	Click on the link “Gartner IAM Summit 2016 - London” 
	And check you’re redirected to the particular article and that the page is loaded properly (1-2 checks of your choice)
4.	Navigate to News
	More… > News & Events > News
	Verify that the same article is present there.
5.	Go to the home page
	Click on Contact. On opened page click U.S West and check if there is "class" change on this element (take a screenshot of that)
	On this same page do a mouse hover on different location (take a screenshot before and after performing the action)
6.	Open Read Privacy Policy in another tab. Check if it is opened and loaded properly (1-2 checks of your choice)
7.	Click on Close button for Cookie and Privacy Policy (“cookiebar”) on previous tab and close tab with displayed Privacy Policy. Check if Privacy Policy will be not shown anymore on the site.
8.	From the bottom of the Home page choose Cases link. On new open click Download PDF button. Fill necessary data to download PDF file (reCAPTCHA blocks automation). After downloading file, check if it is downloaded to your local machine.
•	Make sure the task is clear, feel free to raise any related questions before submitting the test.
•	Provide the hours spent on this task.
•	The scenario might be decomposed to more than 1 test in any particular way, if you find it necessary (explanation/comments required).
•	Test project code should be clean and meet coding standards
•	Use non-build in logging framework to save logs from verification process
•	Support 2 browsers of your choice ( I have chosen: Chrome and Firefox browser the most popular browers based on market share)
•	Please add the solution to your GitHub repository.


* [Navigation Steps](https://github.com/piotrszczepaniuk/OmadaTestAutomation.git/manual.md#navigation-steps)
* [Input Steps](https://github.com/piotrszczepaniuk/OmadaTestAutomation.git/manual.md#input-steps)
* [Click Steps](https://github.com/piotrszczepaniuk/OmadaTestAutomation.git/manual.md#click-steps)
* [Assertion Steps](https://github.com/piotrszczepaniuk/OmadaTestAutomation.git/manual.md#assertion-steps)
* [Screenshot Steps](https://github.com/piotrszczepaniuk/OmadaTestAutomation.git/manual.md#screenshot-steps)


## Navigation Steps

To navigate to URL and change browser state use following steps :

	When I navigate to "([^\"]*)"
	When I refresh page
	When I clear all cookies
	Given I wait (.*) secs

To switch between tabs use following steps :

	When I switch to new tab
	When I switch to previous tab
	When I switch to tab having title "(.*?)"
	When I open link having text "(.*)" in new tab
	When I close new tab

To switch between frames use following steps :	

	When I switch to frame having index \"(.*?)
	When I switch to frame having "id" \"(.*?)
	When I switch to frame having "name" \"(.*?)
	When I switch to frame having "xpath" \"(.*?)
	When I switch to frame having "css" \"(.*?)
	When I switch to main content
	

To scroll webpage use following steps :
	
	When I scroll to top of page
	When I scroll to end of page


To hover over a element use following steps :

	When I hover over element having "id" "(.*?)"
	When I hover over element having "name" "(.*?)"
	When I hover over element having "class" "(.*?)"
	When I hover over element having "xpath" "(.*?)"
	When I hover over element having "css" "(.*?)"



Input Steps
-----------

#### Steps For TextFields

To enter text into input field use following steps :

	When I enter "([^\"]*)" into input field having "id" "([^\"]*)"
	When I enter "([^\"]*)" into input field having "name" "([^\"]*)"
	When I enter "([^\"]*)" into input field having "class" "([^\"]*)"
	When I enter "([^\"]*)" into input field having "xpath" "([^\"]*)"
	When I enter "([^\"]*)" into input field having "css" "([^\"]*)"

To submit element into input fiels use the following steps:

	When I submit element having "id" "([^\"]*)"
	When I submit element having "name" "([^\"]*)"
	When I submit element having "class" "([^\"]*)"
	When I submit element "xpath" "([^\"]*)"
	When I submit element having "css" "([^\"]*)"

#### Steps For Dropdown List :

To select option by text from dropdown use following steps :

	When I select "(.*?)" option by text from dropdown having "id" "(.*?)"
	When I select "(.*?)" option by text from dropdown having "name" "(.*?)"
	When I select "(.*?)" option by text from dropdown having "class" "(.*?)"
	When I select "(.*?)" option by text from dropdown having "xpath" "(.*?)"
	When I select "(.*?)" option by text from dropdown having "css" "(.*?)"

To select option by index from dropdown use following steps :

	When I select (\d+) option by index from dropdown having "id" "(.*?)"
	When I select (\d+) option by index from dropdown having "name" "(.*?)"
	When I select (\d+) option by index from dropdown having "class" "(.*?)"
	When I select (\d+) option by index from dropdown having "xpath" "(.*?)"
	When I select (\d+) option by index from dropdown having "css" "(.*?)"

To select option by value from dropdown use following steps :

	When I select "(.*?)" option by value from dropdown having "id" "(.*?)"
	When I select "(.*?)" option by value from dropdown having "name" "(.*?)"
	When I select "(.*?)" option by value from dropdown having "class" "(.*?)"
	When I select "(.*?)" option by value from dropdown having "xpath" "(.*?)"
	When I select "(.*?)" option by value from dropdown having "css" "(.*?)"


#### Steps For Radio Buttons

To select radio button use following steps :

	When I select radio button having "id" "(.*?)"
	When I select radio button having "name" "(.*?)"
	When I select radio button having "class" "(.*?)"
	When I select radio button having "xpath" "(.*?)"
	When I select radio button having "css" "(.*?)"


Click Steps
-----------
To click on web element use following steps :

	When I click on element having "id" "(.*?)"
	When I click on element having "name" "(.*?)"
	When I click on element having "class" "(.*?)"
	When I click on element having "xpath" "(.*?)"
	When I click on element having "css" "(.*?)"

To click on links use following steps :

	When I click on link having text "(.*?)"
	When I click on link having partial text "(.*?)"


Assertion Steps
---------------
To assert that page title can be found use following step :

	Then I should see page title as "(.*?)"
    
#### Steps For Asserting Element Text

To assert element text use any of the following steps :

	Then element having "id" "([^\"]*)" should have text as "(.*?)"
	Then element having "name" "([^\"]*)" should have text as "(.*?)"
	Then element having "class" "([^\"]*)" should have text as "(.*?)"
	Then element having "xpath" "([^\"]*)" should have text as "(.*?)"
	Then element having "css" "([^\"]*)" should have text as "(.*?)"

	Then element having "id" "([^\"]*)" should have partial text as "(.*?)"
	Then element having "name" "([^\"]*)" should have partial text as "(.*?)"
	Then element having "class" "([^\"]*)" should have partial text as "(.*?)"
	Then element having "xpath" "([^\"]*)" should have partial text as "(.*?)"
	Then element having "css" "([^\"]*)" should have partial text as "(.*?)"
	

#### Steps For Asserting Element Accesibility

To assert that element is enabled use any of the following steps :

	Then element having "id" "([^\"]*)" should be enabled
	Then element having "name" "([^\"]*)" should be enabled
	Then element having "class" "([^\"]*)" should be enabled
	Then element having "xpath" "([^\"]*)" should be enabled
	Then element having "css" "([^\"]*)" should be enabled

#### Steps For Asserting Element Visibility

To assert that element is present use any of the following steps :

	Then element having "id" "([^\"]*)" should be present
	Then element having "name" "([^\"]*)" should be present
	Then element having ""class"" "([^\"]*)" should be present
	Then element having "xpath" "([^\"]*)" should be present
	Then element having "css" "([^\"]*)" should be present

	
#### Steps For Asserting Links

To assert that link is not present use following steps :

	Then link having partial text "(.*?)" should not be present

#### Steps For Asserting count of elements

To assert that count of elements is >|>=|==|<|<=
	Then Count of elements having "id" "([^\"]*)"  should be (>|>=|==|<|<=) (.*)
	Then Count of elements having "name" "([^\"]*)"  should be (>|>=|==|<|<=) (.*)
	Then Count of elements having ""class"" "([^\"]*)"  should be (>|>=|==|<|<=) (.*)
	Then Count of elements having "xpath" "([^\"]*)"  should be (>|>=|==|<|<=) (.*)
	Then Count of elements having "css" "([^\"]*)"  should be (>|>=|==|<|<=) (.*)


Screenshot Steps 
----------------
To take screenshot use following step :

	When I take screenshot (Screenshot is taken into Omada.Tests/TestResults folder )



