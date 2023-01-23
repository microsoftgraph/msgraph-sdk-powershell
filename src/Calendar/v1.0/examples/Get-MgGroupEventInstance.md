### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Calendar

# A UPN can also be used as -UserId.
Get-MgUserEventInstance -UserId $userId -EventId $eventId -Startdatetime "2019-04-08T09:00:00.0000000" -Enddatetime "2019-04-30T09:00:00.0000000" -Property "subject,bodyPreview,seriesMasterId,type,recurrence,start,end"
```
This example shows how to use the Get-MgGroupEventInstance Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

