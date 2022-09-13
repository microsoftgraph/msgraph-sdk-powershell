###Example 1
```
Import-Module Microsoft.Graph.Teams
Get-MgUserTeamworkInstalledApp -UserId $userId -UserScopeTeamsAppInstallationId $userScopeTeamsAppInstallationId
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
Get-MgUserTeamworkInstalledApp -UserId $userId
```
###Example 3
```
Import-Module Microsoft.Graph.Teams
Get-MgUserTeamworkInstalledApp -UserId $userId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 
```
###Example 4
```
Import-Module Microsoft.Graph.Teams
Get-MgUserTeamworkInstalledApp -UserId $userId -ExpandProperty "teamsAppDefinition" 
```
