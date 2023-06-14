Feature: AfpCreate

Create a new AFP record

@tag
Scenario: Create new AFP
	Given I Login with the following details
		| email | password |
		| soydavidprieto@gmail.com | 123456   |
		And I click on "lnkSocialSecurity" link
		When I click on apf "lnkAfp" link
		Then I create the Afp with the following details
	  	| afpName | afpNit |
		| dos | unoiy876 |
	