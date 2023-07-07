### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = [Zip file containing a Teams app package]


New-MgBetaAppCatalogTeamAppDefinition -TeamsAppId $teamsAppId -Requiresreview true  -BodyParameter $params
```
This example shows how to use the New-MgBetaAppCatalogTeamAppDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

