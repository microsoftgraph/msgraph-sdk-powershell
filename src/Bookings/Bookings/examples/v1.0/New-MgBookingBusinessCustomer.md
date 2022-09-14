### Example 1: Using the New-MgBookingBusinessCustomer Cmdlet
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
This example shows how to use the New-MgBookingBusinessCustomer Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
