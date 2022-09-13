###Example 1
```
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserEvent -UserId $userId -EventId $eventId -Property "subject,body,bodyPreview,organizer,attendees,start,end,location,locations" 
```
###Example 2
```
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserEvent -UserId $userId -EventId $eventId -Property "subject,body,bodyPreview,organizer,attendees,start,end,location,hideAttendees" 
```
###Example 3
```
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserEvent -UserId $userId -Property "subject,body,bodyPreview,organizer,attendees,start,end,location" 
```
