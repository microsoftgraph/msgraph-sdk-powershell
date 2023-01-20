### Example 1: List installed apps

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamInstalledApp -TeamId $teamId
```
This example shows how to use the Get-MgGroupTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get the names and other details of installed apps

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamInstalledApp -TeamId $teamId -ExpandProperty "teamsAppDefinition"
```
This example shows how to use the Get-MgGroupTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Get the app installation resource based on the manifest ID of the associated app

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamInstalledApp -TeamId $teamId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'"
```
This example shows how to use the Get-MgGroupTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

