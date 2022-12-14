### Example 1: Using the Remove-MgBetaUserOnlineMeetingRegistrationCustomQuestion Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
# A UPN can also be used as -UserId.
Remove-MgBetaUserOnlineMeetingRegistrationCustomQuestion -UserId $userId -OnlineMeetingId $onlineMeetingId -MeetingRegistrationQuestionId $meetingRegistrationQuestionId
```
This example shows how to use the Remove-MgBetaUserOnlineMeetingRegistrationCustomQuestion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
