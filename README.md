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


