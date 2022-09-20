### Example 1: Using the Update-MgBookingBusinessCustomer Cmdlet
```powershell
Import-Module Microsoft.Graph.Bookings
$params = @{
	DisplayName = "Adele"
	EmailAddress = "adele@relecloud.com"
}
Update-MgBookingBusinessCustomer -BookingBusinessId $bookingBusinessId -BookingCustomerId $bookingCustomerId -BodyParameter $params
```
This example shows how to use the Update-MgBookingBusinessCustomer Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
