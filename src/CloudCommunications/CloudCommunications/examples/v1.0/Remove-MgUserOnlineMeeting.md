###Example 1
```
Import-Module Microsoft.Graph.CloudCommunications
# A UPN can also be used as -UserId.
Remove-MgUserOnlineMeeting -UserId $userId -OnlineMeetingId $onlineMeetingId
```
