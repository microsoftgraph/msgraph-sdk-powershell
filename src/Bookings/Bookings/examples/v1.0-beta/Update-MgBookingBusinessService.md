### Example 1: Using the Update-MgBetaBookingBusinessService Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Bookings
$params = @{
	"@odata.type" = "#microsoft.graph.bookingService"
	DefaultDuration = "PT30M"
}
Update-MgBetaBookingBusinessService -BookingBusinessId $bookingBusinessId -BookingServiceId $bookingServiceId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBookingBusinessService Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
