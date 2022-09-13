###Example 1
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannel -TeamId $teamId -ChannelId $channelId
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannel -TeamId $teamId
```
###Example 3
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannel -TeamId $teamId -Filter "membershipType eq 'shared'" 
```
###Example 4
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannel -TeamId $teamId
```
###Example 5
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamChannel -TeamId $teamId -Filter "membershipType eq 'private'" 
```
