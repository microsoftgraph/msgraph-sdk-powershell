### Example 1: Get the installed app

```powershellImport-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId
```
This example shows how to use the Get-MgBetaTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get the names and other details of the installed app

```powershellImport-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId -ExpandProperty "teamsAppDefinition"
```
This example shows how to use the Get-MgBetaTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Get the resource specific permissions consented for the app installed in the specified team

```powershellImport-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId -Property "consentedPermissionSet,id"
```
This example shows how to use the Get-MgBetaTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

