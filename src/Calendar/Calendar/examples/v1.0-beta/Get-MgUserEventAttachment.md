### Example 1: Using the Get-MgBetaUserEventAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
# A UPN can also be used as -UserId.
Get-MgBetaUserEventAttachment -UserId $userId -EventId $eventId
```
This example shows how to use the Get-MgBetaUserEventAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserEventAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
# A UPN can also be used as -UserId.
Get-MgBetaUserEventAttachment -UserId $userId -EventId $eventId -AttachmentId $attachmentId
```
This example shows how to use the Get-MgBetaUserEventAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
