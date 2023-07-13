### Example 1: Using the New-MgBetaBookingBusinessCustomer Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Bookings
$params = @{
	DisplayName = "Joni Sherman"
	EmailAddress = "jonis@relecloud.com"
	Addresses = @(
		@{
			PostOfficeBox = ""
			Street = "4567 Main Street"
			City = "Buffalo"
			State = "NY"
			CountryOrRegion = "USA"
			PostalCode = "98052"
			Type = "home"
		}
		@{
			PostOfficeBox = ""
			Street = "4570 Main Street"
			City = "Buffalo"
			State = "NY"
			CountryOrRegion = "USA"
			PostalCode = "98054"
			Type = "business"
		}
	)
	Phones = @(
		@{
			Number = "206-555-0100"
			Type = "home"
		}
		@{
			Number = "206-555-0200"
			Type = "business"
		}
	)
}
New-MgBetaBookingBusinessCustomer -BookingBusinessId $bookingBusinessId -BodyParameter $params
```
This example shows how to use the New-MgBetaBookingBusinessCustomer Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
