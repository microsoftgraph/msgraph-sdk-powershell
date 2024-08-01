### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Functions

# A UPN can also be used as -UserId.
Get-MgUserOnlineMeetingVirtualAppointmentJoinWebUrl -UserId $userId -OnlineMeetingId $onlineMeetingId

```
This example shows how to use the Get-MgUserOnlineMeetingVirtualAppointmentJoinWebUrl Cmdlet.

