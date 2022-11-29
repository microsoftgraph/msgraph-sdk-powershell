### Example 1: Using the Get-MgUserEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserEvent -UserId $userId -EventId $eventId -Property "subject,body,bodyPreview" 
```
This example shows how to use the Get-MgUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserEvent -UserId $userId -EventId $eventId -Property "subject,body,bodyPreview,organizer,attendees,start,end,location,locations" 
```
This example shows how to use the Get-MgUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgUserEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserEvent -UserId $userId -EventId $eventId -Property "subject,body,bodyPreview,organizer,attendees,start,end,location,hideAttendees" 
```
This example shows how to use the Get-MgUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgUserEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserEvent -UserId $userId -EventId $eventId -Property "subject,start,end,occurrenceId,exceptionOccurrences,cancelledOccurrences" -ExpandProperty "exceptionOccurrences" 
```
This example shows how to use the Get-MgUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgUserEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserEvent -UserId $userId -Property "subject,body,bodyPreview" 
```
This example shows how to use the Get-MgUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the Get-MgUserEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserEvent -UserId $userId -Property "subject,body,bodyPreview,organizer,attendees,start,end,location" 
```
This example shows how to use the Get-MgUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
