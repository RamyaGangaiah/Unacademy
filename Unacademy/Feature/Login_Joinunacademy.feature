Feature: Login_Joinunacademy

A short summary of the feature

@tag1
Scenario:Verify that unacademy page should be display
	Given Chrome browser is launched and unacademy app is launched
	When User click on 'Login' Button
	Then User navigate to 'Login' page
	When User click on 'create your account' Link
	Then It shows 'Join Unacademy' Page
	When User enters Mobile Number 8197919440 
	And User enter Continue button
	Then It shows Verify your mobile number page
