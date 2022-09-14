### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgUserTeamworkInstalledApp -UserId $userId -UserScopeTeamsAppInstallationId $userScopeTeamsAppInstallationId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgUserTeamworkInstalledApp -UserId $userId
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgUserTeamworkInstalledApp -UserId $userId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 
```
### Example 4
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgUserTeamworkInstalledApp -UserId $userId -ExpandProperty "teamsAppDefinition" 
```
