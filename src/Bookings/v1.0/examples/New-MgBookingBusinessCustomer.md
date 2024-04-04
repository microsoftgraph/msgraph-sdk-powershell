### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Bookings

$params = @{
	"@odata.type" = "#microsoft.graph.bookingCustomer"
	displayName = "Joni Sherman"
	emailAddress = "jonis@relecloud.com"
	addresses = @(
		@{
			postOfficeBox = ""
			street = "4567 Main Street"
			city = "Buffalo"
			state = "NY"
			countryOrRegion = "USA"
			postalCode = "98052"
			type = "home"
		}
		@{
			postOfficeBox = ""
			street = "4570 Main Street"
			city = "Buffalo"
			state = "NY"
			countryOrRegion = "USA"
			postalCode = "98054"
			type = "business"
		}
	)
	phones = @(
		@{
			number = "206-555-0100"
			type = "home"
		}
		@{
			number = "206-555-0200"
			type = "business"
		}
	)
}

New-MgBookingBusinessCustomer -BookingBusinessId $bookingBusinessId -BodyParameter $params

```
This example shows how to use the New-MgBookingBusinessCustomer Cmdlet.

