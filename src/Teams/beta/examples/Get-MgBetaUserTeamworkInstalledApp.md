### Example 1: List apps installed for the specified user

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaUserTeamworkInstalledApp -UserId $userId

```
This example will list apps installed for the specified user

### Example 2: Get the names and other details of apps installed for the user

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaUserTeamworkInstalledApp -UserId $userId -ExpandProperty "teamsAppDefinition(`$expand=bot)" 

```
This example will get the names and other details of apps installed for the user

### Example 3: Get the app installation resource based on the manifest ID of the associated app

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaUserTeamworkInstalledApp -UserId $userId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 

```
This example will get the app installation resource based on the manifest id of the associated app

