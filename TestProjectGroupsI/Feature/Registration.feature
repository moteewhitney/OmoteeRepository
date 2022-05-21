Feature: Registration
	In order to use all the benefits on a website
	A customer will need to Sign up

@mytag
Scenario: Valid Registration
	Given I navigate to the website
	And I click on sign up 
	And I enter my username
	And I enter my email address
	And I enter my password
	When I click on the sign up button
	Then I should be able to sign up successfully