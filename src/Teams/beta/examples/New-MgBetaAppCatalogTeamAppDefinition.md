### Example 1: Update an application previously published to the Microsoft Teams app catalog

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = app.zip


New-MgBetaAppCatalogTeamAppDefinition -TeamsAppId $teamsAppId -BodyParameter $params

```
This example will update an application previously published to the microsoft teams app catalog

### Example 2: Update a new version of an existing app for admin review before publication in the current tenant catalog

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = app.zip


New-MgBetaAppCatalogTeamAppDefinition -TeamsAppId $teamsAppId -Requiresreview true  -BodyParameter $params

```
This example will update a new version of an existing app for admin review before publication in the current tenant catalog

