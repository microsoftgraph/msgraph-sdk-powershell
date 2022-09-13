###Example 1
```
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserEventAttachment -UserId $userId -EventId $eventId
```
