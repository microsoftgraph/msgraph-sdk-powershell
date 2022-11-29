### Example 1: Using the Get-MgTeamMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamMember -TeamId $teamId -Filter "roles/any(r:r eq 'owner')" 
```
This example shows how to use the Get-MgTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgTeamMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamMember -TeamId $teamId -Filter "(microsoft.graph.aadUserConversationMember/userId eq '73761f06-2ac9-469c-9f10-279a8cc267f9')" 
```
This example shows how to use the Get-MgTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgTeamMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamMember -TeamId $teamId -Filter "(microsoft.graph.aadUserConversationMember/displayName eq 'Harry Johnson' or microsoft.graph.aadUserConversationMember/email eq 'admin@M365x987948.OnMicrosoft.com')" 
```
This example shows how to use the Get-MgTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgTeamMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamMember -TeamId $teamId
```
This example shows how to use the Get-MgTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgTeamMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamMember -TeamId $teamId -ConversationMemberId $conversationMemberId
```
This example shows how to use the Get-MgTeamMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
