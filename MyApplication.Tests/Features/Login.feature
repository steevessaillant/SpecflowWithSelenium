Feature: Login
	Just login to some site
@Smoke
Scenario: Successful Login
	Given I Navigate to the Login page
	When I Login with Username 'user' and Password 'password' on the Login Page
	Then the url should contain 'index.html'