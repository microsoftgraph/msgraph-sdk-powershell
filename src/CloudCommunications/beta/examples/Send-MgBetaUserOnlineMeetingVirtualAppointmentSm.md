### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

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
	messageType = "confirmation"
}

# A UPN can also be used as -UserId.
Send-MgBetaUserOnlineMeetingVirtualAppointmentSm -UserId $userId -OnlineMeetingId $onlineMeetingId -BodyParameter $params

```
This example shows how to use the Send-MgBetaUserOnlineMeetingVirtualAppointmentSm Cmdlet.

