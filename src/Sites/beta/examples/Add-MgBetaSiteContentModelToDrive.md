### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	driveId = "b!HEq8Q8ZfAkuMECqSaQFnJVwNMbAGLHhHnXMz1C32pozpolsoEg-MT47fBTiYcbnd"
}

Add-MgBetaSiteContentModelToDrive -SiteId $siteId -ContentModelId $contentModelId -BodyParameter $params

```
This example shows how to use the Add-MgBetaSiteContentModelToDrive Cmdlet.

