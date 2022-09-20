### Example 1: Using the Update-MgBookingBusinessAppointment Cmdlet
```powershell
Import-Module Microsoft.Graph.Bookings
$params = @{
	"@odata.type" = "#microsoft.graph.bookingAppointment"
	End = @{
		"@odata.type" = "#microsoft.graph.dateTimeTimeZone"
		DateTime = "2018-05-06T12:30:00.0000000+00:00"
		TimeZone = "UTC"
	}
	InvoiceDate = @{
		"@odata.type" = "#microsoft.graph.dateTimeTimeZone"
		DateTime = "2018-05-06T12:30:00.0000000+00:00"
		TimeZone = "UTC"
	}
	Start = @{
		"@odata.type" = "#microsoft.graph.dateTimeTimeZone"
		DateTime = "2018-05-06T12:00:00.0000000+00:00"
		TimeZone = "UTC"
	}
}
Update-MgBookingBusinessAppointment -BookingBusinessId $bookingBusinessId -BookingAppointmentId $bookingAppointmentId -BodyParameter $params
```
This example shows how to use the Update-MgBookingBusinessAppointment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
