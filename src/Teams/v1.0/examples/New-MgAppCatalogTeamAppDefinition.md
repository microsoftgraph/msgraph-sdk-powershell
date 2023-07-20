### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

$params = [Zip file containing a Teams app package]


New-MgAppCatalogTeamAppDefinition -TeamsAppId $teamsAppId -Requiresreview true  -BodyParameter $params
```
This example shows how to use the New-MgAppCatalogTeamAppDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

