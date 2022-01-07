Feature: Test
	Web UI Tests with .NET & Specflow

Background:  
Given I launch the website
And I accept the cookies
When navigate the login page
And I enter following details
	| Email                       | Password |
	| seleniumtester102@gmail.com | TEST102  |

@test1
Scenario: verify the basket is empty
	Given I verify the homepage is open
	When I search for electronics from categories
	And I click the subcategory sound systems 
	And I click first product from best seller
	And I add product the basket
	And I delete product from the basket
	Then basket should be empty

@test2
Scenario: verify the product price
	Given I verify the homepage is open
	When I open the deals of the day
	And I filter the laptops
	And I click the first product
	Then product price should be equal