### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Calendar

# A UPN can also be used as -UserId.
Remove-MgBetaUserEventAttachment -UserId $userId -EventId $eventId -AttachmentId $attachmentId
```
This example shows how to use the Get-MgBetaBetaGroupEventAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

