### Example 1: Get a list of teams

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeam

```
This example will get a list of teams

### Example 2: Use $filter and $top to get two teams with a display name that starts with 'A'

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeam -Filter "startswith(displayName, 'A')" -Top 2 

```
This example will use $filter and $top to get two teams with a display name that starts with 'a'

### Example 3: Use $filter and $select to get id and description for team with displayName equals "A Contoso Team"

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeam -Filter "displayName eq 'A Contoso Team'" -Property "id,description" 

```
This example will use $filter and $select to get id and description for team with displayname equals "a contoso team"

