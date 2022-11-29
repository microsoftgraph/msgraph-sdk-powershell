### Example 1: Using the Update-MgBookingBusiness Cmdlet
```powershell
Import-Module Microsoft.Graph.Bookings
$params = @{
	Email = "admin@fabrikam.com"
	SchedulingPolicy = @{
		TimeSlotInterval = "PT60M"
		MinimumLeadTime = "P1D"
		MaximumAdvance = "P30D"
		SendConfirmationsToOwner = $true
		AllowStaffSelection = $true
	}
}
Update-MgBookingBusiness -BookingBusinessId $bookingBusinessId -BodyParameter $params
```
This example shows how to use the Update-MgBookingBusiness Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
