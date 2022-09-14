### Example 1
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId -ExpandProperty "teamsAppDefinition" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 
```
### Example 4
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId
```
### Example 5
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId -ExpandProperty "teamsAppDefinition" 
```
