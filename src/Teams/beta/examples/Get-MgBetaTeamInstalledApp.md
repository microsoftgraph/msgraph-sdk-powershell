### Example 1: List installed apps

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamInstalledApp -TeamId $teamId

```
This example will list installed apps

### Example 2: Get the names and other details of installed apps

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamInstalledApp -TeamId $teamId -ExpandProperty "teamsAppDefinition(`$expand=bot)" 

```
This example will get the names and other details of installed apps

### Example 3: Get the app installation resource based on the manifest ID of the associated app

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamInstalledApp -TeamId $teamId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 

```
This example will get the app installation resource based on the manifest id of the associated app

### Example 4: Get the set of resource specific permissions consented for the apps installed in the specified team

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaTeamInstalledApp -TeamId $teamId -Property "consentedPermissionSet,id" 

```
This example will get the set of resource specific permissions consented for the apps installed in the specified team

