### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
	attendees = @(
		@{
			phoneNumber = "+13129224122"
			timeZone = "Pacific Standard Time"
		}
		@{
			phoneNumber = "+1242421412"
			timeZone = "Eastern Standard Time"
		}
	)
	remindBeforeTimeInMinutesType = "mins15"
}

# A UPN can also be used as -UserId.
Send-MgUserOnlineMeetingVirtualAppointmentReminderSm -UserId $userId -OnlineMeetingId $onlineMeetingId -BodyParameter $params

```
This example shows how to use the Send-MgUserOnlineMeetingVirtualAppointmentReminderSm Cmdlet.

