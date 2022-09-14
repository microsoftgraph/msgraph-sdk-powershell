### Example 1
```powershell
Import-Module Microsoft.Graph.Bookings
$params = @{
	"@odata.type" = "#microsoft.graph.bookingAppointment"
	EndDateTime = @{
		"@odata.type" = "#microsoft.graph.dateTimeTimeZone"
		DateTime = "2018-05-06T12:30:00.0000000+00:00"
		TimeZone = "UTC"
	}
	StartDateTime = @{
		"@odata.type" = "#microsoft.graph.dateTimeTimeZone"
		DateTime = "2018-05-06T12:00:00.0000000+00:00"
		TimeZone = "UTC"
	}
}
Update-MgBookingBusinessAppointment -BookingBusinessId $bookingBusinessId -BookingAppointmentId $bookingAppointmentId -BodyParameter $params
```
