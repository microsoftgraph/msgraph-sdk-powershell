### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Bookings

$params = @{
	staffIds = @(
	"311a5454-08b2-4560-ba1c-f715e938cb79"
)
startDateTime = @{
	dateTime = "2022-01-25T00:00:00"
	timeZone = "India Standard Time"
}
endDateTime = @{
	dateTime = "2022-01-26T17:00:00"
	timeZone = "Pacific Standard Time"
}
}

Get-MgBookingBusinessStaffAvailability -BookingBusinessId $bookingBusinessId -BodyParameter $params

```
This example shows how to use the Get-MgBookingBusinessStaffAvailability Cmdlet.

