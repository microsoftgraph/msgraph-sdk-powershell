### Example 1: Using the Get-MgUserOnlineMeetingRegistrationCustomQuestion Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgUserOnlineMeetingRegistrationCustomQuestion -UserId $userId -OnlineMeetingId $onlineMeetingId -MeetingRegistrationQuestionId $meetingRegistrationQuestionId
```
This example shows how to use the Get-MgUserOnlineMeetingRegistrationCustomQuestion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
