### Example 1: List apps installed for the specified user

```powershellImport-Module Microsoft.Graph.Teams

Get-MgUserTeamworkInstalledApp -UserId $userId
```
This example shows how to use the New-MgUserTeamworkInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get the names and other details of apps installed for the user

```powershellImport-Module Microsoft.Graph.Teams

Get-MgUserTeamworkInstalledApp -UserId $userId -ExpandProperty "teamsAppDefinition"
```
This example shows how to use the New-MgUserTeamworkInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Get the app installation resource based on the manifest ID of the associated app

```powershellImport-Module Microsoft.Graph.Teams

Get-MgUserTeamworkInstalledApp -UserId $userId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'"
```
This example shows how to use the New-MgUserTeamworkInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

