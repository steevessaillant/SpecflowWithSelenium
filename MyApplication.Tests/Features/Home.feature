Feature: Create an Home Page and its structure as my sample react-redux application
	
Background: 
	Given I have a browser
	When I enter 'http://localhost:3000/'
	Then I should see the Home Page

@Smoke
Scenario: I have not used the application yet
	Given I am at the root of the site
	Then the page title should be 'Home'

@Regression
@Smoke
Scenario: From the Home Page, I press the Login button
	Given I am at the Home Page
	When I press the Login button
	Then the page title should be 'Login'

@Regression
Scenario: I go to a non-existing page
	Given I am at the Home Page
	When I type 'Non-Existing' after the url displayed in the url field in my browser
	Then the page title should be 'Page Not Found'
