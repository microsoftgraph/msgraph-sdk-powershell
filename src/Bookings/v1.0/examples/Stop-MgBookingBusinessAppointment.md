### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Bookings

$params = @{
	cancellationMessage = "Your appointment has been successfully cancelled. Please call us again."
}

Stop-MgBookingBusinessAppointment -BookingBusinessId $bookingBusinessId -BookingAppointmentId $bookingAppointmentId -BodyParameter $params

```
This example shows how to use the Stop-MgBookingBusinessAppointment Cmdlet.

