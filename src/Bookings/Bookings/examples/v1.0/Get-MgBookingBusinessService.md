### Example 1
```powershell
Import-Module Microsoft.Graph.Bookings
Get-MgBookingBusinessService -BookingBusinessId $bookingBusinessId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Bookings
Get-MgBookingBusinessService -BookingBusinessId $bookingBusinessId -BookingServiceId $bookingServiceId
```
