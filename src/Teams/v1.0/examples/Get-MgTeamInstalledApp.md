### Example 1: Get the installed app

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId

```
This example will get the installed app

### Example 2: Get the names and other details of the installed app

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId -ExpandProperty "teamsAppDefinition" 

```
This example will get the names and other details of the installed app

### Example 3: Get the resource specific permissions consented for the app installed in the specified team

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgTeamInstalledApp -TeamId $teamId -TeamsAppInstallationId $teamsAppInstallationId -Property "consentedPermissionSet,id" 

```
This example will get the resource specific permissions consented for the app installed in the specified team

