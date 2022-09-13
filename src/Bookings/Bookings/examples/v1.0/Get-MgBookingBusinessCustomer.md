###Example 1
```
Import-Module Microsoft.Graph.Bookings
Get-MgBookingBusinessCustomer -BookingBusinessId $bookingBusinessId
```
###Example 2
```
Import-Module Microsoft.Graph.Bookings
Get-MgBookingBusinessCustomer -BookingBusinessId $bookingBusinessId -BookingCustomerBaseId $bookingCustomerBaseId
```
