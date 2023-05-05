# Dummy-Project
This Project covers the scenario of adding 4 items in the cart and find them to be added

Basic Features : 

# Dependencies
Packages are installed to support test run
1. Nunit 
2. Specflow
3. Selenium

# Feature File
It contains feature description i.e. Adding items to Cart and steps for testing a feature written in Gherkin language.We can mark it as an entry point for writing test.

# Step Definitons 
It maps the testing steps mentioned in feature file to code 
Step definitions are containers for the testing code that must be executed in order to run the steps in the automation layer.

# Page Objects 
web pages are represented as classes, and the various elements on the page are defined as variables on the class. All possible user interactions can then be implemented as methods on the class.
We have created 2 pages objects, Home page and Cart page

# Wrapper
This is to add functionality to webdriver and enhance Web driver implementation

# Hooks 
It is a global setup that is running with every test.Class that runs with every test scenarios that are running. It is binding before and after scenario.

# Improvements : 
1. There is only one main test scenario is automated , we need to automate all types of scenarios
2. I would have create single method to add all items in a cart rather than calling methods separately for individual items,
3. I would like to add functionality to the wrapper such that we don’t have dependencies on the raw IWebDriver instance.be called by different pages.
4. GoToPage method was written twice in different page objects . It should be written in a generic way to 


# Execution Report: 

![image](https://user-images.githubusercontent.com/47860484/236511862-91fa4ff5-f1ef-48f6-adb0-e4fb05a2ddb9.png)

