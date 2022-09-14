### Example 1
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamMember -TeamId $teamId -Filter "(microsoft.graph.aadUserConversationMember/userId eq '73761f06-2ac9-469c-9f10-279a8cc267f9')" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamMember -TeamId $teamId -Filter "(microsoft.graph.aadUserConversationMember/displayName eq 'Harry Johnson' or microsoft.graph.aadUserConversationMember/email eq 'admin@M365x987948.OnMicrosoft.com')" 
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamMember -TeamId $teamId
```
### Example 4
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamMember -TeamId $teamId -ConversationMemberId $conversationMemberId
```
