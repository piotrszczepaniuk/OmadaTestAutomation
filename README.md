# OmadaTestAutomation

Example of test automation with C#, BDD, Gherkin, Specflow, Nunit, PageObjectModel, and Selenium.

# Implementation of an Automated test

*	Using WebDriver 3, NUnit 3, .Net Framework 4.5-4.6.1 (C#) implement the following:
1.	Open https://www.omada.net
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
*	Make sure the task is clear, feel free to raise any related questions before submitting the test.
*	Provide the hours spent on this task.
*	The scenario might be decomposed to more than 1 test in any particular way, if you find it necessary (explanation/comments required).
*	Test project code should be clean and meet coding standards
*	Use non-build in logging framework to save logs from verification process
*	Support 2 browsers of your choice ( I have chosen: Chrome and Firefox browser the most popular browers based on market share)
*	Please add the solution to your GitHub repository.

# Pre-requisites
- Download nuget packages:
  - <a href="https://github.com/piotrszczepaniuk/OmadaTestAutomation/blob/master/Omada.Tests/packages.config" target="_blank">packages.config</a> 
	
- Install Specflow extension in Visual Studio for editing feature files
  
# Setting up visual studio environment
- Install Microsoft Visual Studio 
- Clone respective repository or download zip.
	- https://github.com/piotrszczepaniuk/OmadaTestAutomation.git

# Running omada test automation
- Goto project directory.
- Select browser in <a href="https://github.com/piotrszczepaniuk/OmadaTestAutomation/blob/master/Omada.Tests/App.config" target="_blank">App.config</a>  
   - add key="Browser" value="chrome"
   - add key="Browser" value="firefox"
- Build project in Debug or Realease environment.
- Run test from Specfow runer or from test explorer in Visual Studio
- Use manual to understand feature test steps <a href="https://github.com/piotrszczepaniuk/OmadaTestAutomation/blob/master/Omada.Tests/docs/manual.md">manual for test steps</a> .