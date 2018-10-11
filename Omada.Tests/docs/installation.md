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