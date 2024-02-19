### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	fields = @{
		Title = "Widget"
		Color = "Purple"
		Weight = 
	}
}

New-MgBetaSiteListItem -SiteId $siteId -ListId $listId -BodyParameter $params

```
This example shows how to use the New-MgBetaSiteListItem Cmdlet.

