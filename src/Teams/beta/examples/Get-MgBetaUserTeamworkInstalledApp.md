### Example 1: Get an app installed for the specified user

```powershellImport-Module Microsoft.Graph.Beta.Teams

Get-MgBetaUserTeamworkInstalledApp -UserId $userId -UserScopeTeamsAppInstallationId $userScopeTeamsAppInstallationId
```
This example shows how to use the Get-MgBetaUserTeamworkInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get the names and other details of the app installed for the user

```powershellImport-Module Microsoft.Graph.Beta.Teams

Get-MgBetaUserTeamworkInstalledApp -UserId $userId -UserScopeTeamsAppInstallationId $userScopeTeamsAppInstallationId -ExpandProperty "teamsAppDefinition"
```
This example shows how to use the Get-MgBetaUserTeamworkInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

