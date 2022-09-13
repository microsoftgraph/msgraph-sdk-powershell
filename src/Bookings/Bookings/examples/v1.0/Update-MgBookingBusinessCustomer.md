###Example 1
```
Import-Module Microsoft.Graph.Bookings
$params = @{
	"@odata.type" = "#microsoft.graph.bookingCustomer"
	DisplayName = "Adele"
	EmailAddress = "adele@relecloud.com"
}
Update-MgBookingBusinessCustomer -BookingBusinessId $bookingBusinessId -BookingCustomerBaseId $bookingCustomerBaseId -BodyParameter $params
```
