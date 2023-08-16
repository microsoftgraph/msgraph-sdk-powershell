### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeamInstalledApp -TeamId $teamId

```
This example shows how to use the Get-MgTeamInstalledApp Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeamInstalledApp -TeamId $teamId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 

```
This example shows how to use the Get-MgTeamInstalledApp Cmdlet.

