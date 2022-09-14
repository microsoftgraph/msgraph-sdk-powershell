### Example 1
```powershell
Import-Module Microsoft.Graph.Bookings
$params = @{
	"@odata.type" = "#microsoft.graph.bookingCustomer"
	DisplayName = "Joni Sherman"
	EmailAddress = "jonis@relecloud.com"
	Addresses = @(
	)
	Phones = @(
	)
}
New-MgBookingBusinessCustomer -BookingBusinessId $bookingBusinessId -BodyParameter $params
```
