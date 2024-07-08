### Example 1: Create an anonymous sharing link

```powershell

Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	type = "view"
	scope = "anonymous"
	password = "String"
	recipients = @(
		@{
			"@odata.type" = "microsoft.graph.driveRecipient"
		}
	)
	sendNotification = $true
	retainInheritedPermissions = $false
}

New-MgBetaSiteListItemLink -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params

```
This example will create an anonymous sharing link

### Example 2: Creating company sharable links

```powershell

Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	type = "edit"
	scope = "organization"
}

New-MgBetaSiteListItemLink -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params

```
This example shows creating company sharable links

### Example 3: Creating embeddable links

```powershell

Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	type = "embed"
}

New-MgBetaSiteListItemLink -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params

```
This example shows creating embeddable links

