### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId -ExpandProperty "teamsAppDefinition"
```
This example shows how to use the Get-MgTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

Get-MgTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId -Property "consentedPermissionSet,id"
```
This example shows how to use the Get-MgTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

