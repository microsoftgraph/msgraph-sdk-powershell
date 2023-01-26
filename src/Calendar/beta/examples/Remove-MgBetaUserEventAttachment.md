### Example 1: Using the Remove-MgBetaUserEventAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
# A UPN can also be used as -UserId.
Remove-MgBetaUserEventAttachment -UserId $userId -EventId $eventId -AttachmentId $attachmentId
```
This example shows how to use the Remove-MgBetaUserEventAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
