###Example 1
```
Import-Module Microsoft.Graph.Bookings
$params = @{
	"@odata.type" = "#microsoft.graph.bookingService"
	DefaultDuration = "PT30M"
}
Update-MgBookingBusinessService -BookingBusinessId $bookingBusinessId -BookingServiceId $bookingServiceId -BodyParameter $params
```
