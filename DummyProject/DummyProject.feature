Feature: DummyProject

To add items to the cart , verify total items, search for lowest price and remove from cart

Scenario: User can add items to cart
	Given I am on HomePage
	And I add four random items to my cart
	When I view my cart
	Then I find total four items listed in my cart
