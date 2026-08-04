Feature: TM_04_VerifyLoginForExistingViewUser

@regression
@transfermatching
Scenario: TM_04 Verify login for existing view user
	Given the levy employer logins using existing transfer matching account
	Then the levy employer can verify login for existing view user
