### Example 1
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannel -TeamId $teamId -ChannelId $channelId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannel -TeamId $teamId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannel -TeamId $teamId -Filter "membershipType eq 'shared'" 
```
### Example 4
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannel -TeamId $teamId
```
### Example 5
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannel -TeamId $teamId -Filter "membershipType eq 'private'" 
```
