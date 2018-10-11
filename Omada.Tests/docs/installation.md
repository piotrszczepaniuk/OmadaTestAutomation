# Pre-requisites
- Download nuget packages:
  - <a href="https://github.com/piotrszczepaniuk/OmadaTestAutomation.git/OmadaTestAutomation/Omada.Tests/packages.config" target="_blank">packages.config</a> 
	<packages>
	  <package id="Newtonsoft.Json" version="10.0.3" targetFramework="net452" />
	  <package id="NUnit" version="3.10.1" targetFramework="net452" />
	  <package id="Selenium.Chrome.WebDriver" version="2.42" targetFramework="net452" />
	  <package id="Selenium.Firefox.WebDriver" version="0.22.0" targetFramework="net452" />
	  <package id="Selenium.Support" version="3.14.0" targetFramework="net452" />
	  <package id="Selenium.WebDriver" version="3.14.0" targetFramework="net452" />
	  <package id="Selenium.WebDriver.ChromeDriver" version="2.42.0.1" targetFramework="net452" />
	  <package id="SpecFlow" version="2.4.0.0" targetFramework="net452" />
	  <package id="SpecRun.Runner" version="1.8.4" targetFramework="net452" />
	  <package id="SpecRun.SpecFlow" version="1.8.3" targetFramework="net452" />
	  <package id="System.ValueTuple" version="4.3.0" targetFramework="net452" />
	</packages>
- Specflow extension in Visual Studio for editing feature files
  
# Setting up visual studio environment
- Install Microsoft Visual Studio 
- Clone respective repository or download zip.
	- https://github.com/piotrszczepaniuk/OmadaTestAutomation.git

# Running omada test automation
- Goto project directory.
- Select browser in App.config 
   - <add key="Browser" value="chrome" />
   - <add key="Browser" value="firefox" />
- Build project in Debug or Realease environment.
- Run test from Specfow runer or from test explorer in Visual Studio
- Use manual to understand feature test steps <a href="https://github.com/piotrszczepaniuk/OmadaTestAutomation.git/OmadaTestAutomation/Omada.Tests/docs/manual.md">manual for test steps</a> .