### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Bookings

$params = @{
	displayName = "Fourth Coffee"
	address = @{
		postOfficeBox = "P.O. Box 123"
		street = "4567 Main Street"
		city = "Buffalo"
		state = "NY"
		countryOrRegion = "USA"
		postalCode = "98052"
	}
	phone = "206-555-0100"
	email = "manager@fourthcoffee.com"
	webSiteUrl = "https://www.fourthcoffee.com"
	defaultCurrencyIso = "USD"
}

New-MgBookingBusiness -BodyParameter $params

```
This example shows how to use the New-MgBookingBusiness Cmdlet.

