###Example 1
```
Import-Module Microsoft.Graph.Bookings
$params = @{
	"@odata.type" = "#microsoft.graph.bookingCustomQuestion"
	DisplayName = "What is your age?"
	AnswerInputType = "text"
	AnswerOptions = @(
	)
}
New-MgBookingBusinessCustomQuestion -BookingBusinessId $bookingBusinessId -BodyParameter $params
```
