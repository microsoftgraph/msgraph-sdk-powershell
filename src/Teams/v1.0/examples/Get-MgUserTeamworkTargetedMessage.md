### Example 1: Get all targeted messages for a user

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgUserTeamworkTargetedMessage -UserId $userId

```
This example will get all targeted messages for a user

### Example 2: Filter targeted messages by date range

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgUserTeamworkTargetedMessage -UserId $userId -Filter "lastModifiedDateTime gt 2024-01-01T00:00:00Z and lastModifiedDateTime lt 2024-12-31T23:59:59Z" 

```
This example will filter targeted messages by date range

### Example 3: Get targeted messages by application sender

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgUserTeamworkTargetedMessage -UserId $userId -Filter "from/application/id eq '6d23e712-527b-406f-8d59-d02927885918'" 

```
This example will get targeted messages by application sender

