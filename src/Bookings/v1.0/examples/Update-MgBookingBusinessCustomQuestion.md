### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Bookings

$params = @{
	"@odata.type" = "#microsoft.graph.bookingCustomQuestion"
	displayName = "What is your age?"
	answerInputType = "text"
	answerOptions = @(
	)
}

Update-MgBookingBusinessCustomQuestion -BookingBusinessId $bookingBusinessId -BookingCustomQuestionId $bookingCustomQuestionId -BodyParameter $params
```
This example shows how to use the Update-MgBookingBusinessCustomQuestion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

