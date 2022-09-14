### Example 1
```powershell
Import-Module Microsoft.Graph.Bookings
Get-MgBookingBusinessCustomer -BookingBusinessId $bookingBusinessId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Bookings
Get-MgBookingBusinessCustomer -BookingBusinessId $bookingBusinessId -BookingCustomerBaseId $bookingCustomerBaseId
```
