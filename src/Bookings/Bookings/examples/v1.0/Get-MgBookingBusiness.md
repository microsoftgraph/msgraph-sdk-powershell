### Example 1
```powershell
Import-Module Microsoft.Graph.Bookings
Get-MgBookingBusiness -BookingBusinessId $bookingBusinessId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Bookings
Get-MgBookingBusiness
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Bookings
Get-MgBookingBusiness -Query "Adventure" 
```
