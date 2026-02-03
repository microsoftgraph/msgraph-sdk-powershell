### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Bookings

$params = @{
	"@odata.type" = "#microsoft.graph.bookingCustomQuestion"
	displayName = "What is your age?"
	answerInputType = "text"
	answerOptions = @(
	)
}

New-MgBookingBusinessCustomQuestion -BookingBusinessId $bookingBusinessId -BodyParameter $params

```
This example shows how to use the New-MgBookingBusinessCustomQuestion Cmdlet.

