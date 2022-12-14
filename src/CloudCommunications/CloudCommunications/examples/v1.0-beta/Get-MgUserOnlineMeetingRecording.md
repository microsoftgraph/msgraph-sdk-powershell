### Example 1: Using the Get-MgBetaUserOnlineMeetingRecording Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgBetaUserOnlineMeetingRecording -UserId $userId -OnlineMeetingId $onlineMeetingId
```
This example shows how to use the Get-MgBetaUserOnlineMeetingRecording Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
