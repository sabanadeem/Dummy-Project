Feature: DummyProject

To add items to the cart , verify total items, search for lowest price and remove from cart

Background: User can add items to cart
	Given I am on HomePage
	And I add four random items to my cart
	When I view my cart
	Then I find total four items listed in my cart

	Scenario: : User can remove first item from Cart
	Given I get Item rows in a cart
	When I remove an item
	Then I can see remaining items in cart
