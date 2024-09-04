### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	driveId = "b!HEq8Q8ZfAkuMECqSaQFnJVwNMbAGLHhHnXMz1C32pozpolsoEg-MT47fBTiYcbnd"
}

Remove-MgBetaSiteContentModelFromDrive -SiteId $siteId -ContentModelId $contentModelId -BodyParameter $params

```
This example shows how to use the Remove-MgBetaSiteContentModelFromDrive Cmdlet.

