Feature: AfpAssertion

Create new AFP record and verify it

Scenario: Create new AFP with Assertion
	Given I Login with admin user
		| email | password |
		| soydavidprieto@gmail.com | 123456   |
		And I go to "lnkSocialSecurity" link
		When I click on apf "lnkAfp" link
		Then I create the Afp with the following details
	  	| afpName | afpNit |
		| This is a Testq | 1Th3is is a test |
	
