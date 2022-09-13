###Example 1
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId -ExpandProperty "teamsAppDefinition" 
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId
```
###Example 3
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 
```
###Example 4
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId
```
###Example 5
```
Import-Module Microsoft.Graph.Teams
Get-MgTeamInstalledApp -TeamId $teamId -ExpandProperty "teamsAppDefinition" 
```
