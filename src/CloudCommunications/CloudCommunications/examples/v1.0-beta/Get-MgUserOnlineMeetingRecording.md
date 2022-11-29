### Example 1: Using the Get-MgUserOnlineMeetingRecording Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgUserOnlineMeetingRecording -UserId $userId -OnlineMeetingId $onlineMeetingId
```
This example shows how to use the Get-MgUserOnlineMeetingRecording Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
