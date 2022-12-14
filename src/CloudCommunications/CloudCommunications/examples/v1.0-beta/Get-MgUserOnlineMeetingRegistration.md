### Example 1: Using the Get-MgBetaUserOnlineMeetingRegistration Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgBetaUserOnlineMeetingRegistration -UserId $userId -OnlineMeetingId $onlineMeetingId
```
This example shows how to use the Get-MgBetaUserOnlineMeetingRegistration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserOnlineMeetingRegistration Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgBetaUserOnlineMeetingRegistration -UserId $userId -OnlineMeetingId $onlineMeetingId -ExpandProperty "microsoft.graph.meetingRegistration/customQuestions" 
```
This example shows how to use the Get-MgBetaUserOnlineMeetingRegistration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
