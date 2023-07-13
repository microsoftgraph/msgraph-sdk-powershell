### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Bookings

$params = @{
	"@odata.type" = "#microsoft.graph.bookingStaffMember"
	displayName = "Dana Swope"
	emailAddress = "danas@contoso.com"
	"role@odata.type" = "#microsoft.graph.bookingStaffRole"
	role = "externalGuest"
	timeZone = "America/Chicago"
	useBusinessHours = $true
	"workingHours@odata.type" = "#Collection(microsoft.graph.bookingWorkHours)"
	workingHours = @(
		@{
			"@odata.type" = "#microsoft.graph.bookingWorkHours"
			"day@odata.type" = "#microsoft.graph.dayOfWeek"
			day = "monday"
			"timeSlots@odata.type" = "#Collection(microsoft.graph.bookingWorkTimeSlot)"
			timeSlots = @(
				@{
					"@odata.type" = "#microsoft.graph.bookingWorkTimeSlot"
					endTime = "17:00:00.0000000"
					startTime = "08:00:00.0000000"
				}
			)
		}
		@{
			"@odata.type" = "#microsoft.graph.bookingWorkHours"
			"day@odata.type" = "#microsoft.graph.dayOfWeek"
			day = "tuesday"
			"timeSlots@odata.type" = "#Collection(microsoft.graph.bookingWorkTimeSlot)"
			timeSlots = @(
				@{
					"@odata.type" = "#microsoft.graph.bookingWorkTimeSlot"
					endTime = "17:00:00.0000000"
					startTime = "08:00:00.0000000"
				}
			)
		}
		@{
			"@odata.type" = "#microsoft.graph.bookingWorkHours"
			"day@odata.type" = "#microsoft.graph.dayOfWeek"
			day = "wednesday"
			"timeSlots@odata.type" = "#Collection(microsoft.graph.bookingWorkTimeSlot)"
			timeSlots = @(
				@{
					"@odata.type" = "#microsoft.graph.bookingWorkTimeSlot"
					endTime = "17:00:00.0000000"
					startTime = "08:00:00.0000000"
				}
			)
		}
		@{
			"@odata.type" = "#microsoft.graph.bookingWorkHours"
			"day@odata.type" = "#microsoft.graph.dayOfWeek"
			day = "thursday"
			"timeSlots@odata.type" = "#Collection(microsoft.graph.bookingWorkTimeSlot)"
			timeSlots = @(
				@{
					"@odata.type" = "#microsoft.graph.bookingWorkTimeSlot"
					endTime = "17:00:00.0000000"
					startTime = "08:00:00.0000000"
				}
			)
		}
		@{
			"@odata.type" = "#microsoft.graph.bookingWorkHours"
			"day@odata.type" = "#microsoft.graph.dayOfWeek"
			day = "friday"
			"timeSlots@odata.type" = "#Collection(microsoft.graph.bookingWorkTimeSlot)"
			timeSlots = @(
				@{
					"@odata.type" = "#microsoft.graph.bookingWorkTimeSlot"
					endTime = "17:00:00.0000000"
					startTime = "08:00:00.0000000"
				}
			)
		}
	)
	isEmailNotificationEnabled = $false
}

New-MgBookingBusinessStaffMember -BookingBusinessId $bookingBusinessId -BodyParameter $params
```
This example shows how to use the New-MgBookingBusinessStaffMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

