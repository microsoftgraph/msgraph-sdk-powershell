### Example 1: Using the Get-MgBetaUserTeamworkInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaUserTeamworkInstalledApp -UserId $userId -UserScopeTeamsAppInstallationId $userScopeTeamsAppInstallationId
```
This example shows how to use the Get-MgBetaUserTeamworkInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserTeamworkInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaUserTeamworkInstalledApp -UserId $userId
```
This example shows how to use the Get-MgBetaUserTeamworkInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaUserTeamworkInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaUserTeamworkInstalledApp -UserId $userId -UserScopeTeamsAppInstallationId $userScopeTeamsAppInstallationId -ExpandProperty "teamsAppDefinition" 
```
This example shows how to use the Get-MgBetaUserTeamworkInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaUserTeamworkInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaUserTeamworkInstalledApp -UserId $userId -ExpandProperty "teamsAppDefinition(`$expand=bot)" 
```
This example shows how to use the Get-MgBetaUserTeamworkInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgBetaUserTeamworkInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaUserTeamworkInstalledApp -UserId $userId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 
```
This example shows how to use the Get-MgBetaUserTeamworkInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
