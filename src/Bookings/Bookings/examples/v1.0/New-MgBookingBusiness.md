### Example 1
```powershell
Import-Module Microsoft.Graph.Bookings
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
New-MgBookingBusiness -BodyParameter $params
```
