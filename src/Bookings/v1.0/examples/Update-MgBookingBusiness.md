### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Bookings

$params = @{
	email = "admin@fabrikam.com"
	schedulingPolicy = @{
		timeSlotInterval = "PT60M"
		minimumLeadTime = "P1D"
		maximumAdvance = "P30D"
		sendConfirmationsToOwner = $true
		allowStaffSelection = $true
	}
}

Update-MgBookingBusiness -BookingBusinessId $bookingBusinessId -BodyParameter $params

```
This example shows how to use the Update-MgBookingBusiness Cmdlet.

