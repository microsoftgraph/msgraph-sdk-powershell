###Example 1
```
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Remove-MgUserEventAttachment -UserId $userId -EventId $eventId -AttachmentId $attachmentId
```
