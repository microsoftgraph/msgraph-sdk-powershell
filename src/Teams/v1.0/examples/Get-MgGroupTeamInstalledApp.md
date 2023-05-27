### Example 1: Get the installed app

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId
```
This example shows how to use the Get-MgGroupTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get the names and other details of the installed app

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId -ExpandProperty "teamsAppDefinition"
```
This example shows how to use the Get-MgGroupTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

