### Example 1: Using the New-MgBetaBookingBusiness Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Bookings
$params = @{
	DisplayName = "Fourth Coffee"
	Address = @{
		PostOfficeBox = "P.O. Box 123"
		Street = "4567 Main Street"
		City = "Buffalo"
		State = "NY"
		CountryOrRegion = "USA"
		PostalCode = "98052"
	}
	Phone = "206-555-0100"
	Email = "manager@fourthcoffee.com"
	WebSiteUrl = "https://www.fourthcoffee.com"
	DefaultCurrencyIso = "USD"
}
New-MgBetaBookingBusiness -BodyParameter $params
```
This example shows how to use the New-MgBetaBookingBusiness Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
