### Example 1: Using the Get-MgBetaUserOnlineMeetingRegistrationCustomQuestion Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgBetaUserOnlineMeetingRegistrationCustomQuestion -UserId $userId -OnlineMeetingId $onlineMeetingId -MeetingRegistrationQuestionId $meetingRegistrationQuestionId
```
This example shows how to use the Get-MgBetaUserOnlineMeetingRegistrationCustomQuestion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
