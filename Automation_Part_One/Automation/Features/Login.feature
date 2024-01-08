Feature: Login Functionality

Login in demoshop24.com

@Testers
Scenario: Login with valid username and password data
    Given Enter the URL
    When Click on the My Account Button
    And Click on the Login Option
    When User enter valid username and password in login form
    And Clicks on Log in button

@Testers
Scenario: Login with Valid username and invalid password data
    Given Enter the URL
    When Click on the My Account Button
    And Click on the Login Option
    When User enter valid username and invalid password in login form
    And Clicks on Log in button
    Then Verify that the username or password is invalid

@Testers
Scenario: Login with invalid username and valid password data
Given Enter the URL
    When Click on the My Account Button
    And Click on the Login Option
    When User enter invalid username and valid password in login form
    And Clicks on Log in button
    Then Verify that the username or password is invalid
