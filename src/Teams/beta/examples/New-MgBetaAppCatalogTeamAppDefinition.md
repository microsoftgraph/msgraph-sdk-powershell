### Example 1: Update an application previously published to the Microsoft Teams app catalog

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = app.zip


New-MgBetaAppCatalogTeamAppDefinition -TeamsAppId $teamsAppId -BodyParameter $params
```
This example shows how to use the New-MgBetaAppCatalogTeamAppDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Update a new version of an existing app for admin review prior to publication in the current tenant catalog

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = app.zip


New-MgBetaAppCatalogTeamAppDefinition -TeamsAppId $teamsAppId -Requiresreview true  -BodyParameter $params
```
This example shows how to use the New-MgBetaAppCatalogTeamAppDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

