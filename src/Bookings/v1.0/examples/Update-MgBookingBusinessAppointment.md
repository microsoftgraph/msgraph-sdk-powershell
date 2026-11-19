### Example 1: Change the date of service

```powershell

Import-Module Microsoft.Graph.Bookings

$params = @{
	"@odata.type" = "#microsoft.graph.bookingAppointment"
	end = @{
		"@odata.type" = "#microsoft.graph.dateTimeTimeZone"
		dateTime = "2018-05-06T12:30:00.0000000+00:00"
		timeZone = "UTC"
	}
	start = @{
		"@odata.type" = "#microsoft.graph.dateTimeTimeZone"
		dateTime = "2018-05-06T12:00:00.0000000+00:00"
		timeZone = "UTC"
	}
}

Update-MgBookingBusinessAppointment -BookingBusinessId $bookingBusinessId -BookingAppointmentId $bookingAppointmentId -BodyParameter $params

```
This example will change the date of service

### Example 2: Update the customers for an appointment

```powershell

Import-Module Microsoft.Graph.Bookings

$params = @{
	"@odata.type" = "#microsoft.graph.bookingAppointment"
	customers = @(
		@{
			"@odata.type" = "#microsoft.graph.bookingCustomerInformation"
			customerId = "cd56bb19-c348-42c6-af5c-09818c87fb8c"
			name = "John Doe"
			emailAddress = "john.doe@example.com"
			phone = "313-555-5555"
		}
		@{
			"@odata.type" = "#microsoft.graph.bookingCustomerInformation"
			customerId = "72f148fa-9a86-4c59-b277-f5089d9ea0e7"
			name = "Jane Smith"
			emailAddress = "jane.smith@example.com"
			phone = "248-555-5678"
		}
	)
}

Update-MgBookingBusinessAppointment -BookingBusinessId $bookingBusinessId -BookingAppointmentId $bookingAppointmentId -BodyParameter $params

```
This example will update the customers for an appointment

