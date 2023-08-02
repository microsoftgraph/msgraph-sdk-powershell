### Example 1: List attendance reports for an online meeting

```powershell

Import-Module Microsoft.Graph.Beta.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgBetaUserOnlineMeetingAttendanceReport -UserId $userId -OnlineMeetingId $onlineMeetingId

```
This example will list attendance reports for an online meeting

