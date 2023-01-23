### Example 1: Using the Update-MgBookingBusinessService Cmdlet
```powershell
Import-Module Microsoft.Graph.Bookings
$params = @{
	"@odata.type" = "#microsoft.graph.bookingService"
	DefaultDuration = "PT30M"
}
Update-MgBookingBusinessService -BookingBusinessId $bookingBusinessId -BookingServiceId $bookingServiceId -BodyParameter $params
```
This example shows how to use the Update-MgBookingBusinessService Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
