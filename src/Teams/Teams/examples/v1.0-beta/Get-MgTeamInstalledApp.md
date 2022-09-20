### Example 1: Using the Get-MgTeamInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId -ExpandProperty "teamsAppDefinition" 
```
This example shows how to use the Get-MgTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgTeamInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId
```
This example shows how to use the Get-MgTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgTeamInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 
```
This example shows how to use the Get-MgTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgTeamInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId
```
This example shows how to use the Get-MgTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgTeamInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId -ExpandProperty "teamsAppDefinition(`$expand=bot)" 
```
This example shows how to use the Get-MgTeamInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
