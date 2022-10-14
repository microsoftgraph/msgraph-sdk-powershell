### Example 1: Using the Get-MgUserEventAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserEventAttachment -UserId $userId -EventId $eventId
```
This example shows how to use the Get-MgUserEventAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserEventAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserEventAttachment -UserId $userId -EventId $eventId -AttachmentId $attachmentId
```
This example shows how to use the Get-MgUserEventAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
