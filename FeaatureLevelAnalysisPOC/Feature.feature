Feature: Feature



  Scenario: Successful Login
    Given I am on the login page
    When I enter valid credentials
    And I click the login button
    Then I should be redirected to the dashboard

  Scenario: Unsuccessful Login with Invalid Password
    Given I am on the login page
    When I enter a valid username and an invalid password
    And I click the login button
    Then I should see an error message "Invalid credentials"

  Scenario: Unsuccessful Login with Empty Fields
    Given I am on the login page
    When I leave the username and password fields empty
    And I click the login button
    Then I should see an error message "Fields cannot be empty"
