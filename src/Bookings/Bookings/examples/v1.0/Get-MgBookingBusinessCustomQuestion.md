### Example 1
```powershell
Import-Module Microsoft.Graph.Bookings
Get-MgBookingBusinessCustomQuestion -BookingBusinessId $bookingBusinessId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Bookings
Get-MgBookingBusinessCustomQuestion -BookingBusinessId $bookingBusinessId -BookingCustomQuestionId $bookingCustomQuestionId
```
