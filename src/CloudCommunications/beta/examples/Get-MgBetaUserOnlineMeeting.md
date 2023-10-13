### Example 1: Retrieve an online meeting by meeting ID

```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgBetaUserOnlineMeeting -UserId $userId -OnlineMeetingId $onlineMeetingId
```
This example shows how to use the Get-MgBetaUserOnlineMeeting Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Retrieve an online meeting by joinWebUrl

```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgBetaUserOnlineMeeting -UserId $userId -Filter "JoinWebUrl eq 'https://teams.microsoft.com/l/meetup-join/19:meeting_MGQ4MDQyNTEtNTQ2NS00YjQxLTlkM2EtZWVkODYxODYzMmY2@thread.v2/0?context"
```
This example shows how to use the Get-MgBetaUserOnlineMeeting Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Retrieve an online meeting by joinMeetingId

```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgBetaUserOnlineMeeting -UserId $userId -Filter "joinMeetingIdSettings/joinMeetingId eq '1234567890'"
```
This example shows how to use the Get-MgBetaUserOnlineMeeting Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Fetch attendee report of a Teams live event (deprecated)

```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications

# A UPN can also be used as -UserId.
Get-MgBetaUserOnlineMeetingAttendeeReport -UserId $userId -OnlineMeetingId $onlineMeetingId
```
This example shows how to use the Get-MgBetaUserOnlineMeeting Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

