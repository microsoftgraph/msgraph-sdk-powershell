### Example 1: Using the Update-MgBookingBusinessCustomQuestion Cmdlet
```powershell
Import-Module Microsoft.Graph.Bookings
$params = @{
	"@odata.type" = "#microsoft.graph.bookingCustomQuestion"
	DisplayName = "What is your age?"
	AnswerInputType = "text"
	AnswerOptions = @(
	)
}
Update-MgBookingBusinessCustomQuestion -BookingBusinessId $bookingBusinessId -BookingCustomQuestionId $bookingCustomQuestionId -BodyParameter $params
```
This example shows how to use the Update-MgBookingBusinessCustomQuestion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
