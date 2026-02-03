### Example 1: Get list of members in team

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeamMember -TeamId $teamId

```
This example will get list of members in team

### Example 2: Find members of a team by their Azure AD user object ID

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeamMember -TeamId $teamId -Filter "(microsoft.graph.aadUserConversationMember/userId eq '73761f06-2ac9-469c-9f10-279a8cc267f9')" 

```
This example will find members of a team by their azure ad user object id

### Example 3: Find members of a team by their names or email

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeamMember -TeamId $teamId -Filter "(microsoft.graph.aadUserConversationMember/displayName eq 'Harry Johnson' or microsoft.graph.aadUserConversationMember/email eq 'admin@M365x987948.OnMicrosoft.com')" 

```
This example will find members of a team by their names or email

