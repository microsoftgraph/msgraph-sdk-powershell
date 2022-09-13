###Example 1
```
Import-Module Microsoft.Graph.Bookings
Get-MgBookingBusinessStaffMember -BookingBusinessId $bookingBusinessId
```
###Example 2
```
Import-Module Microsoft.Graph.Bookings
Get-MgBookingBusinessStaffMember -BookingBusinessId $bookingBusinessId -BookingStaffMemberBaseId $bookingStaffMemberBaseId
```
